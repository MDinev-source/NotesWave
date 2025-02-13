import { BehaviorSubject, Observable } from 'rxjs';
import { Note } from '../models/Note';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NoteService {
  private notePath = environment.apiUrl + 'Notes';

  constructor(private http: HttpClient) { }

  getNotes(): Observable<Note[]> {
    return this.http.get<Note[]>(this.notePath);
  }

  addNote(note: Note): Observable<Note> {
    return this.http.post<Note>(this.notePath, note);
  }
}
