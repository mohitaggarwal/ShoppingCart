import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';
import { ShoppingCartReceiptComponent } from './shopping-cart-receipt/shopping-cart-receipt.component';


const routes: Routes = [
  { path: 'cart/:id', component: ShoppingCartComponent },
  { path: 'cart/:id/receipt', component: ShoppingCartReceiptComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
