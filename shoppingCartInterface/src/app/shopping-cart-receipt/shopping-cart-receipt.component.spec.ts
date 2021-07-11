import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShoppingCartReceiptComponent } from './shopping-cart-receipt.component';

describe('ShoppingCartReceiptComponent', () => {
  let component: ShoppingCartReceiptComponent;
  let fixture: ComponentFixture<ShoppingCartReceiptComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShoppingCartReceiptComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShoppingCartReceiptComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
