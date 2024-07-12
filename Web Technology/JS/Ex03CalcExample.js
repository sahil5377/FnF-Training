let v1 = parseFloat(prompt("Enter the first value"));
if(isNaN(v1)){
    alert("Blank values not allowed, Considerd as 0");
    v1=0;
}
let v2 = parseFloat(prompt("Enter the second value"));
if(isNaN(v2)){
    alert("Blank values not allowed, Considerd as 0");
    v2=0;
}
let op = prompt("Enter the choice as +, -, * or /");
switch (op){
    case "+": alert("The result of add is" +(v1+v2));
    break;
    case "-": alert("The result of add is " +(v1-v2));
    break;
    case "*": alert("The result of add is " +(v1*v2));
    break;
    case "/": alert("The result of add is " +(v1/v2));
    break;
    default:
        alert("Unrecognized, Choose the valid Options");
        break;
}