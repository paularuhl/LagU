
function iniciar() {
    const block1 = document.getElementById('block1');
    const block2 = document.getElementById('block2');
    const block3 = document.getElementById('block3');

    block1.addEventListener('click', fadeOutBlock1);
    block2.addEventListener('click', shrinkBlock2);
    block3.addEventListener('click', colorBlock3);
}

function fadeOutBlock1(event) {
    var style = event.target.style;

    style.opacity = 1;

    var interval = setInterval(function () {
        console.log('ocultando...');
        style.opacity -= 0.1;

        if (style.opacity == 0) {
            style.display = "none";
            //shrinkBlock2(event);
            clearInterval(interval);
        }
    }, 100);
}

function shrinkBlock2(event) {
    var style = event.target.style;

    style.height = '150px';

    var interval = setInterval(function () {
        console.log('encogiendo...');
        style.height = `${style.height.replace('px', '') - 1}px`;

        if (style.height == '0px') {
            style.display = "none";
            clearInterval(interval);
        }
    }, 10);
}

function colorBlock3(event) {
    var style = event.target.style;

    style.backgroundColor = 'rgb(255, 0, 0)';

    var interval = setInterval(function () {
        var color = obtenerRgb(style.backgroundColor);

        procesar(color);

        style.backgroundColor = `rgb(${color.r}, ${color.g}, ${color.b})`;

        if (color.r == 255 && color.g == 255 && color.b == 255) {
            style.display = "none";
            clearInterval(interval);
        }
    }, 10);
}

function calcularEaseOut(currentTime, begInnIng, changeInValue, duration) {
    return changeInValue * ((currentTime = currentTime / duration - 1) * currentTime * currentTime + 1) + begInnIng;
}

function obtenerRgb(str) {
    let p = str.split(',');

    return {
        r: parseInt(p[0].split('(')[1]),
        g: parseInt(p[1]),
        b: parseInt(p[2].substring(1, p[2].length - 1))
    };
}

function procesar(color) {
    if (color.r < 255) {
        color.r = color.r + 1;
    }
    if (color.g < 255) {
        color.g = color.g + 1;
    }
    if (color.b < 255) {
        color.b = color.b + 1;
    }
}

window.addEventListener('load', iniciar);