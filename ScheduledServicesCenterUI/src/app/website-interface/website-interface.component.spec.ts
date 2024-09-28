import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WebsiteInterfaceComponent } from './website-interface.component';

describe('WebsiteInterfaceComponent', () => {
  let component: WebsiteInterfaceComponent;
  let fixture: ComponentFixture<WebsiteInterfaceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WebsiteInterfaceComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WebsiteInterfaceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
