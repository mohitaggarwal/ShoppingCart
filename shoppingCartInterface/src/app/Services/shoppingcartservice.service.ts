import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { from, Observable } from 'rxjs';
import {ShopingCartItem} from "../Model/ShoppingCartItem"
import {ShoppingCartReceipt} from "../Model/ShoppingCartReceipt"

@Injectable({
  providedIn: 'root'
})
export class ShoppingcartserviceService {
  baseUrl: string ='https://localhost:44385/';
  headers= new HttpHeaders()
  .append('content-type', 'application/json')
  .append('Access-Control-Allow-Origin', '*');

  constructor(private http: HttpClient) { }

  getCartItems(cartId: number): Observable<ShopingCartItem[]>
  {
    return this.http.get(this.baseUrl + 'api/ShoppingCart/' + cartId, { 'headers': this.headers }).pipe(map((response:any) => 
    { return response;}));
  }

  getCartReceipt(cartId: number): Observable<ShoppingCartReceipt>
  {
    return this.http.get(this.baseUrl + 'api/ShoppingCart/' + cartId + '/receipt', { 'headers': this.headers }).pipe(map((response:any) => 
    { return response;}));
  }
}
