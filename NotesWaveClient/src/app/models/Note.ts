import { NoteRel } from "./NoteRel";
import { NoteSketch } from "./NoteSketch";
import { NoteDescription } from "./NoteDescription";

export interface Note{
    id: string;
    title: string;
    state : string;
    noteRels : Array<NoteRel>;
    noteSketches : Array<NoteSketch>;
    noteDescriptions : Array<NoteDescription>;
}