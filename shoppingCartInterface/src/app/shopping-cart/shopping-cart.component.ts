import { Component, OnInit } from '@angular/core';
import {ShopingCartItem} from "../Model/ShoppingCartItem"
import {ActivatedRoute} from "@angular/router";
import {ShoppingcartserviceService} from "../Services/shoppingcartservice.service"

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.css']
})
export class ShoppingCartComponent implements OnInit {
  cartId:number;
  shopingCartItems: ShopingCartItem[];

  constructor(private route: ActivatedRoute, private cartService: ShoppingcartserviceService) { 
    this.route.params.subscribe( params => {this.cartId =  params.id;});
  }

  ngOnInit(): void {
    this.cartService.getCartItems(this.cartId).subscribe(cartItems => this.shopingCartItems = cartItems);
    console.log(this.cartId);
    console.log(this.shopingCartItems);
  }

}
