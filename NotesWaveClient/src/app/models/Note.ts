import { NoteRel } from "./NoteRel";
import { NoteSketch } from "./NoteSketch";
import { Description } from "./Description";
import { NoteState } from "./Enums/NoteState";

export interface Note{
    id?: string;
    title: string;
    state? : NoteState
    noteRels : Array<NoteRel>;
    noteSketches : Array<NoteSketch>;
    noteDescriptions : Array<Description>;
}