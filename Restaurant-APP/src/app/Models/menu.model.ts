export interface Menu{
    id: number,
    name: string,
    description: string,
    type:string,
    imageUrl: string,
    availability: boolean,
    validityPeriod: boolean | null,
    priceRange: string
}