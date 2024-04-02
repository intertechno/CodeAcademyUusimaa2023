const fruits = ["omena", "banaani", "appelsiini"];
const vegetables = ["pinaatti", "porkkana", "peruna"];

const ruoka = [...fruits, ...vegetables];
/*
for (let index = 0; index < fruits.length; index++) {
    const element = fruits[index];
    ruoka.push(element);
}
for (let index = 0; index < vegetables.length; index++) {
    const element = vegetables[index];
    ruoka.push(element);
}
*/
console.log(ruoka);