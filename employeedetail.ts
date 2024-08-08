import { Component, Input, input } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-emp-detail',
  templateUrl: './emp-detail.component.html',
})
export class EmpDetailComponent {
  @Input() empObj = {} as Employee
}
