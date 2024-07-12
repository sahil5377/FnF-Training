class Employee { //class represents records
    constructor(id, name, address, salary) {
        this.empId = id;
        this.empName = name;
        this.empAddress = address;
        this.empSalary = salary
    }
}
 
class EmployeeRepo{ //Class represents collection of records
    data = [];//Represents the data of the Class.
    constructor(){
        this.loadData();
    }
 
    loadData = () => {
        if (localStorage.getItem("empList") != null) {
            const json = localStorage.getItem("empList");
            this.data = JSON.parse(json);
        }
       
    }
    saveData =() =>{
        const json = JSON.stringify(this.data);
        localStorage.setItem("empList", json);
 
    }
 
    addNewEmployee = (emp) =>{
        this.loadData();
        this.data =[...this.data, emp];
        this.saveData();
 
    }
 
    deleteEmployee = (id) => {
        this.loadData();
        let index = this.data.findIndex((e)=>e.empId==id);
        this.data.splice(index,1);
        this.saveData(); //removing an element in JS's array.
    }
 
    getAllEmployees = () => {
        this.loadData();
        return this.data;
    }
 
    updateEmployee = (id, emp) =>{
        this.loadData();
        let index = this.data.findIndex((e)=>e.empId == id);
        this.data.splice(index,1,emp);//Removes the number of elements(2nd arg) from the specific index(1st arg) and replaces it with the emp object(3rd arg).
        this.saveData();
    }
}
 
/*********************Global Functions*************/
const hideElements = (...element) => [...element].forEach(e=> e.style.display = 'none')//The three dots is a spread operator which implies that it is an array. THIS IS THE NEW WAY!!!
 
//OLD WAY:
const hide=function(elements){
    elements.forEach(element=>{
        element.style.display="none";
 
    });
 
}
const show = (id) => document.getElementById(id).style.display='block';