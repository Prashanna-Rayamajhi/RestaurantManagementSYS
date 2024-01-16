import { Dish } from "../Models/dish.model";

export interface MenuCreationDTO{
    name: string,
    description: string,
    type:string,
    image: File,
    availability: boolean,
    validityPeriod: Date | null,
    priceRange: string,
    dishes: Dish[];
}