import { Observable } from 'rxjs';
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

  getNotes() : Observable<Array<Note>> {
    return this.http.get<Array<Note>>(this.notePath)
  }

  createNote(data: Note) : Observable<Note> {
    return this.http.post<Note>(this.notePath, data)
  }
}
