import { DescriptionType } from "./Enums/DescriptonType";

export interface Description {
    id : string;
    text : string;
    type : DescriptionType;
    selected?: boolean;
}