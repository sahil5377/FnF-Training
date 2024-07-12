const fruits = ["Apples", "Mangoes", "Bananna"];
console.log(fruits);

// for (let index = 0; index < fruits.length; index++) {
//     const element = fruits[index];
//     console.log(element);    
// }

// for (const element of fruits) {
//     console.log(element);
// }

// for (const key in fruits) {
//     console.log(`Index: ${key}:Value:${fruits[key]}`)
// }
// console.log("ES5 syntax of foreach statement using Arrow Operator(Lambda Expression)");
// fruits.forEach((element)=>{
//     console.log(element);
// })

//////////////////////////////////////////////////////////////////
fruits.push("Pine Apple");
fruits.push("custard Apple");
fruits.push("ooty Apple");
//starts adding to the bottom

fruits.unshift("Kiwi");
// adds in the beggining

//Insert in between, or deleete or return

fruits.splice(2,0, "Gauva","Bannana", "Grapes")
//fruits.splice(insert at which position ,Delete at which psoition , "Gauva","Bannana", "Grapes")

for (const element of fruits) {
    console.log(element);
}
