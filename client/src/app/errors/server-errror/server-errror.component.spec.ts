import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServerErrrorComponent } from './server-errror.component';

describe('ServerErrrorComponent', () => {
  let component: ServerErrrorComponent;
  let fixture: ComponentFixture<ServerErrrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServerErrrorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServerErrrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
