import { Component, OnInit } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
})
export class MasterComponent implements OnInit {
  empList: Employee[] = [];

  ngOnInit(): void {
    this.empList.push(
      { empId: 123, empName: "Sahil", empAddress: "Bangalore", empSalary: 45000, empPic: "img1.jpg" },
      { empId: 124, empName: "Sakshi", empAddress: "Hubali", empSalary: 40000, empPic: "img2.jpg" },
      { empId: 125, empName: "Arpita", empAddress: "Belagavi", empSalary: 55000, empPic: "img3.jpg" },
      { empId: 126, empName: "Chaita", empAddress: "Gokarna", empSalary: 50000, empPic: "img4.jpg" }
    );
  }

  onEdit = (rec: number) => {
    // Implement edit functionality here
  };

  onDelete = (emp: Employee) => {
    const index = this.empList.indexOf(emp);
    if (index > -1) {
      this.empList.splice(index, 1);
    }
  };
}
