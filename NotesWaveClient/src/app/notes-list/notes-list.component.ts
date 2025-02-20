import { Note } from '../models/Note';
import { Component, OnInit } from '@angular/core';
import { NoteService } from '../services/note.service';
import { DescriptionType } from '../models/Enums/DescriptonType';
import { DescriptionService } from '../services/description.service';

@Component({
  selector: 'app-notes-list',
  imports: [],
  templateUrl: './notes-list.component.html',
  styleUrl: './notes-list.component.css'
})
export class NotesListComponent implements OnInit {
    newNote: Note = {
      title: '',
      noteRels: [],
      noteSketches: [],
      noteDescriptions: []
    };
    notes: Array<Note> = [];
    selectedNote: Note | null = null;

    constructor (private noteService: NoteService, 
      private descriptionService: DescriptionService
    ) {}

    ngOnInit() {
      this.fetchNotes();
    }

    fetchNotes(): void {
      this.noteService.getNotes().subscribe(notes => {
        this.notes = notes;
      });
    }

    addNote() {
      this.noteService.addNote(this.newNote).subscribe({
        next: (createdNote) => {
          console.log('Note created:', createdNote);
          this.newNote = createdNote;
          this.notes.push(this.newNote);
        },
        error: (error) => {
          console.error('Error creating note:', error);
        },
        complete: () => {
          console.log('Note creation complete');
        }
      });
    }

    selectNote(note: Note){
      this.selectedNote = note;
    }

    addDescriptionToNote(noteId: string, text :string){
        this.descriptionService.addDescriptionToNote(noteId, text).subscribe (() =>{
          const note = this.notes.find((n) => n.id === noteId)
          if (note){
            note.noteDescriptions.push({ id: '', text, type: DescriptionType.Title })
          }
        })
    }
    
}
