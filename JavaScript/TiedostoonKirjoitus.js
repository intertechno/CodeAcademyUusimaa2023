const fs = require("fs");

function kirjoitaTiedostoon(teksti) {
    fs.writeFileSync("Testi.txt", teksti);
}

function kirjoitaTiedostoon2(teksti) {
    fs.writeFile("Testi.txt", teksti, (err) => {
        if (err) {
            console.log("Virhetilanne!");
            return;
        }
        console.log("Kirjoitus tehty!");
    });
}

kirjoitaTiedostoon("Moi!");
kirjoitaTiedostoon2("Moi!");
console.log("Valmis.");
