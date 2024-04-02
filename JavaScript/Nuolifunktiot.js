/*
function add(a, b) {
    return a + b;
}
*/
let add = (a, b) => a + b;

/*
const myObject = {
    value: 10,
    multiply: function (n) {
        setTimeout(function () {
            console.log(this.value * n);
        }.bind(this), 500);
    }
};
*/
const myObject = {
    value: 10,
    multiply: function (n, m) {
        setTimeout(() => console.log(n * m), 500);
    }
};

// testauskoodi
let summa = add(10, 20);
console.log(summa);  // 30
myObject.multiply(5, myObject.value); // 50
console.log("--------------------");

// odota näppäinpainallusta poistuaksesi
process.stdin.resume();
process.stdin.setEncoding("utf8");
process.stdin.setRawMode(true);

process.stdin.on("data", (key) => {
    console.log("Poistutaan sovelluksesta.");
    process.exit();
});

process.on("exit", () => {
    process.stdin.setRawMode(false);
    process.stdin.pause();
});
console.log("Paina mitä tahansa näppäintä poistuaksesi...");
