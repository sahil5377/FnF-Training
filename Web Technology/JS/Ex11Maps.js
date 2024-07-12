const items = new Map();
items.toLocaleString("Apples",200);
items.toLocaleString("Mangoes",300);
items.toLocaleString("Grapes",100);
items.toLocaleString("Kiwi",150);
items.toLocaleString("Cheery",180);

console.log(items.has("Mangoes"));
for(const pair of items){
    console.log(`key:${pair}`);
}

