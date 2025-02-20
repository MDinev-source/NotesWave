import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Description } from '../models/Description';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DescriptionService {
  private descPath = environment.apiUrl + 'Desriptions';

  constructor(private http: HttpClient) { }

  addDescriptionToNote(noteID: string, text: string): Observable<void> {
    return this.http.post<void>(this.descPath + `/${noteID}`, text);
  }

  removeDescriptionFromNote(descriptionId: string) : Observable<void> {
    return this.http.delete<void>(this.descPath + `/${descriptionId}`);
  }

  updateDescription(description: Description) : Observable<void> {
    return this.http.put<void>(this.descPath + `/${description.id}`, description);
  }
}
