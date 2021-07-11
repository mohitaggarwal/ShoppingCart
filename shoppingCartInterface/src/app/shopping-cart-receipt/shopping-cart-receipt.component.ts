import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {ShoppingCartReceipt} from "../Model/ShoppingCartReceipt"
import {ShoppingcartserviceService} from "../Services/shoppingcartservice.service"

@Component({
  selector: 'app-shopping-cart-receipt',
  templateUrl: './shopping-cart-receipt.component.html',
  styleUrls: ['./shopping-cart-receipt.component.css']
})
export class ShoppingCartReceiptComponent implements OnInit {

  cartId:number;
  shopingCartReceipt: ShoppingCartReceipt;

  constructor(private route: ActivatedRoute, private cartService: ShoppingcartserviceService) { 
    this.route.params.subscribe( params => { this.cartId =  params.id;});
  }

  ngOnInit(): void {
    this.cartService.getCartReceipt(this.cartId).subscribe(cartItemReceipt => this.shopingCartReceipt = cartItemReceipt);
    console.log(this.cartId);
    console.log(this.shopingCartReceipt);
  }

}
