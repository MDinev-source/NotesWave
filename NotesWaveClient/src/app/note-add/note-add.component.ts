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

  addNote() {
    this.noteService.addNote(this.newNote).subscribe({
      next: (value) => { console.log(value); },
      error: (error) => { console.error(error); },
      complete: () => { console.log('Complete'); }
    });
  }
}