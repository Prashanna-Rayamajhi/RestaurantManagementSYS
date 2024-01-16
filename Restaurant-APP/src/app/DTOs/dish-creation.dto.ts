import { Menu } from "../Models/menu.model"

export interface DishCreationDTO{
    name: string,
    description: string,
    image: File,
    price: number,
    availability: boolean,
    category: number,
    ingredients: string
    menus: Menu[]
}