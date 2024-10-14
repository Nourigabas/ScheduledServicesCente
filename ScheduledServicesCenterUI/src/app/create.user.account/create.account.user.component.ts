import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { User } from '../../models/user';

@Component({
  selector: 'app-createaccountuser',
  standalone: true,
  imports: [TabsModule, CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './create.account.user.component.html',
  styleUrl: './create.account.user.component.css'
})
export class CreateAccountUserComponent implements OnInit {
  constructor(private fb: FormBuilder) { }
  ngOnInit(): void {
    this.UserForm = this.fb.group({
      FullName: ['', Validators.required],
      DateOfBirth: [Date, Validators.required],
      Phone: ['', Validators.required],
      Gmail: ['', Validators.required],
      UserName: ['', Validators.required],
      Password: ['', Validators.required]
    })
  }
  UserForm!: FormGroup
  UserForCreate!: User
  disabled: boolean = false
  AddUser() {
    this.UserForCreate = new User(this.UserForm.value);
  }
  checkDisabled(event: Event) {
    const input = event.target as HTMLInputElement;
    const confPass = input.value
    if (confPass === this.UserForm.get('Password')?.value) {
      this.disabled = true
    }
    else {
      this.disabled = false;
    }
    console.log(this.disabled)
  }
}
