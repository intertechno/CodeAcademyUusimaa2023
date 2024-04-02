function compareValues(a, b)
{
    console.log(`Verrataan: ${a} / ${b}`)
    return {
        looseEquality: a == b, /* == vertailun tulos */
        strictEquality: a === b /* === vertailun tulos */
      }
}

console.log(compareValues(5, "5"));
console.log(compareValues(0, false));
console.log(compareValues(null, undefined));
console.log(compareValues(NaN, NaN));
console.log(compareValues(1, true));
console.log(compareValues(234, true));


let x;
console.log(x);