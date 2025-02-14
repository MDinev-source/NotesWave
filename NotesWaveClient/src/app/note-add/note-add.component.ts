import { Note } from '../models/Note';
import { Component, OnInit } from '@angular/core';
import { NoteService } from '../services/note.service';

@Component({
  selector: 'app-note-add',
  imports: [],
  templateUrl: './note-add.component.html',
  styleUrl: './note-add.component.css'
})
export class NoteAddComponent{
  newNote: Note = {
    title: '',
    noteRels: [],
    noteSketches: [],
    noteDescriptions: []
  };

  constructor(private noteService: NoteService) {}

  loadNotes(): void {
    this.noteService.getNotes().subscribe(notes => {
      if (notes.length > 0) {
        this.newNote = notes[0];
      }
    });
  }

  addNote() {
    this.noteService.addNote(this.newNote).subscribe({
      next: (createdNote) => {
        console.log('Note created:', createdNote);
        this.newNote = createdNote;
        this.loadNotes();
      },
      error: (error) => {
        console.error('Error creating note:', error);
      },
      complete: () => {
        console.log('Note creation complete');
      }
    });
  }
}

