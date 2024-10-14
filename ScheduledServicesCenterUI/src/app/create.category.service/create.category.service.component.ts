import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-createcategoryservice',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule,FormsModule],
  templateUrl: './create.category.service.component.html',
  styleUrl: './create.category.service.component.css'
})
export class CreateCategoryServiceComponent implements OnInit {
  constructor(){}
  ngOnInit(): void {
  }
  
}
