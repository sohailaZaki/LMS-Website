import { Component } from '@angular/core';
import { Router } from '@angular/router';  // استيراد Router من Angular

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private router: Router) {}  // إضافة الـ Router داخل الـ constructor

  studentName: string = 'ندى محمد شحات على';
  studentNameEnglish: string = 'Nada Mohamed Shahat';
  Email: string = 'nada@gmail.com';
  phoneNumber: string = '01146169369';

  // التنقل بين الصفحات
  navigateTo(page: string): void {
    this.router.navigate([`/${page}`]); // توجيه الصفحات الفرعية
  }
}
