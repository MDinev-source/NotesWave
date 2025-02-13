import { Note } from '../models/Note';
import { Component, OnInit } from '@angular/core';
import { NoteService } from '../services/note.service';

@Component({
  selector: 'app-notes-list',
  imports: [],
  templateUrl: './notes-list.component.html',
  styleUrl: './notes-list.component.css'
})
export class NotesListComponent implements OnInit {
    notes: Array<Note> = [];

    constructor (private noteService: NoteService) {}

    ngOnInit() {
      this.fetchNotes();
    }

    fetchNotes(): void {
      this.noteService.getNotes().subscribe(notes => {
        this.notes = notes;
      });
    }
}
