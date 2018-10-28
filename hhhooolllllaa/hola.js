function start() {
    const btn = document.querySelector('#btn');

    btn.onclick = function (e) {
        //let word = document.getElementById("word").value;
        let num = parseInt(document.getElementById("word").value);
        //borrarRepetidas(word);
        //alert(tieneRepetidas(word));
        alert(numeroToRoman(num));
    };

}

function borrarRepetidas(word) {
    var corrected = "";

    for (var i = 0; i < word.length; i++) {
        if (word[i] != word[i + 1]) {
            corrected += word[i];
        }
    }
    alert(corrected);
}

function tieneRepetidas(word) {

    for (var i = 0; i < word.length; i++) {

        for (var j = i + 1; j < word.length; j++) {

            if (word[i] == word[j]) {
                return "Tiene";
            }
        }
    }
    return "No tiene";
}

function numeroToRoman(num) {
    
    let r = "";

    let romans = {M:1000,CM:900,D:500,CD:400,C:100,XC:90,L:50,XL:40,X:10,IX:9,V:5,IV:4,I:1};


    for(var test in romans)
    {
        while(num>=romans[test])
        {
           r += test;
           num -= romans[test]; 
        }
    }
    
    return r;
}

window.addEventListener('load', start);

//marcost@lagash.com