import { Component, OnInit } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
})
export class MasterComponent implements OnInit {
  ngOnInit(): void {
    this.empList.push({empId : 123,empName : "Sahil",empAddress: "Bangalore",empSalary: 45000,empPic:"img1.jpg"});
    this.empList.push({empId : 124,empName : "Sakshi",empAddress: "Hubali",empSalary: 40000,empPic:"img2.jpg"});
    this.empList.push({empId : 125,empName : "Arpita",empAddress: "Belagavi",empSalary: 55000,empPic:"img3.jpg"});
    this.empList.push({empId : 126,empName : "Chaita",empAddress: "Gokarna",empSalary: 50000,empPic:"img4.jpg"});
  }
onEdit = (rec : number)=>{

};

onDelete = (emp: Employee) => {
  const index = this.empList.indexOf(emp);
  this.empList.splice(index, 1);
};
  empList: Employee[]=[]
}
