export class ShopingCartItem{
    ProductId:number;
    Name: string;
    Description:string;
    Cost: number;
    Quantity:number;

    constructor(productId:number, name:string, description:string, cost:number, quantity: number)
    {
        this.ProductId = productId;
        this.Cost = cost;
        this.Description = description;
        this.Name = name;
        this.Quantity = quantity;
    }
}