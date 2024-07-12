const emp ={
    empName: 'Sahil',
    empAddress:"Bangalore",
    empSalary:56000
}

console.log(emp);
const emp2 = emp;

emp.empSalary= 76000;

console.log(emp.empSalary);
console.log(emp2.empSalary);

for (const key in emp){
    console.log(`Property: ${key},Value:${emp[key]}`);
}

//using spread Operator to append the object
const emp3 ={...emp,empDesignation:"Intern"};
console.log(emp3)

const employee = function(id,name,address){
    this.empId=id;
    this.empName=name;
    this.empAddress=address
    this.display = function(){
        return `${this.empName} is from ${this.empAddress}`
    }
}
console.log(employee);

const employee1 = new employee(123, "sahil","Banagalore");
const employee2 = new employee(124, "Arpita","Banagalore");

employee2.empAddress="Bidari";
console.log(employee1.empAddress);
console.log(employee2.empAddress);

//Newer Syntax From ES6

class Customer{
    constructor(id,name,address,bill){
        this.id=id;
        this.name=name;
        this.address=address;
        this.billamount=bill;
    }
    display = () => `${this.name} is from ${this.address} and has raised the bill amount of Rs. ${this.billamount}`;
}

const cst = new Customer(123,"Aruna","Bangalore",5000);
alert(cst.display());