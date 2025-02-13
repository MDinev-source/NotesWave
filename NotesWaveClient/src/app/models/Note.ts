import { NoteRel } from "./NoteRel";
import { NoteSketch } from "./NoteSketch";
import { Description } from "./Description";

export interface Note{
    id: string;
    title: string;
    state : string;
    noteRels : Array<NoteRel>;
    noteSketches : Array<NoteSketch>;
    noteDescriptions : Array<Description>;
}