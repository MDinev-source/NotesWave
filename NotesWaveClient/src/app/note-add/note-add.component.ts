import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Note } from '../models/Note';
import { NoteService } from '../services/note.service';

@Component({
  selector: 'app-note-add',
  imports: [],
  templateUrl: './note-add.component.html',
  styleUrl: './note-add.component.css'
})
export class NoteAddComponent implements OnInit{
  noteForm!: FormGroup;
  isLoading = false;

  constructor(
    private fb: FormBuilder,
    private noteService: NoteService // Your Note Service to handle HTTP requests
  ) {}

  ngOnInit(): void {
    // Initialize form with basic fields
    this.noteForm = this.fb.group({
      title: ['', [Validators.required, Validators.maxLength(255)]],
      state: ['', Validators.required], // Add a proper list or enum values here
      noteRels: this.fb.array([]), // Initialize the array for related notes
      noteSketches: this.fb.array([]), // Initialize the array for sketches
      noteDescriptions: this.fb.array([]) // Initialize the array for descriptions
    });
  }

  // Handle form submission
  onSubmit(): void {
    if (this.noteForm.invalid) {
      return; // Do not submit if form is invalid
    }
    this.isLoading = true;
    const note: Note = this.noteForm.value;
    
    this.noteService.createNote(note).subscribe(
      (response) => {
        console.log('Note created successfully!', response);
        this.isLoading = false;
      },
      (error) => {
        console.error('Error creating note!', error);
        this.isLoading = false;
      }
    );
  }

  // Add a new related note (example)
  addNoteRel(): void {
    const noteRelGroup = this.fb.group({
      // Add fields specific to NoteRel here
      relatedNoteId: ['', Validators.required]
    });
    this.noteRels.push(noteRelGroup);
  }

  // Getter for accessing noteRels form array
  get noteRels() {
    return (this.noteForm.get('noteRels') as FormArray);
  }

  // Add a new sketch (example)
  addNoteSketch(): void {
    const noteSketchGroup = this.fb.group({
      // Add fields specific to NoteSketch here
      sketchImage: ['', Validators.required] // Assuming image URL or base64 string
    });
    this.noteSketches.push(noteSketchGroup);
  }

  // Getter for accessing noteSketches form array
  get noteSketches() {
    return (this.noteForm.get('noteSketches') as FormArray);
  }

  // Add a new description (example)
  addNoteDescription(): void {
    const noteDescriptionGroup = this.fb.group({
      descriptionText: ['', Validators.required]
    });
    this.noteDescriptions.push(noteDescriptionGroup);
  }

  // Getter for accessing noteDescriptions form array
  get noteDescriptions() {
    return (this.noteForm.get('noteDescriptions') as FormArray);
  }
}