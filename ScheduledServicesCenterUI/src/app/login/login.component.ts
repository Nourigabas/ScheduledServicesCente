import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css', '../login/login.component.css']  // إضافة المزيد من ملفات الأنماط
})
export class LoginComponent {

}
