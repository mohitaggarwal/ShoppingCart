export class ShoppingCartItemWithTax{
    ProductId:number;
    Name: string;
    Description:string;
    Cost: number;
    Quantity:number;
    TotalCostPrice: number;
    BasicSalesTax: number;
    ImportDutyTax: number;
    TotalSalesTax: number;
}

export class ShoppingCartReceipt{
    TotalCostPrice: number;
    BasicSalesTax: number;
    ImportDutyTax: number;
    GrandTotal: number;
    CartItems: ShoppingCartItemWithTax[]
}