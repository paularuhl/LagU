
function iniciar() {
    const botonesVerdes = document.getElementsByName('verde');
    const botonesRojos = document.getElementsByName('rojo');
    const botonesNaranjas = document.getElementsByName('naranja');

    botonesVerdes.forEach((boton) => {
        const p = boton.parentElement.firstElementChild;

        boton.onclick = function () {
            p.className = 'verde';
        };
    });

    botonesRojos.forEach((boton) => {
        const p = boton.parentElement.firstElementChild;

        boton.onclick = function () {
            p.className = 'rojo';
        };
    });

    botonesNaranjas.forEach((boton) => {
        const p = boton.parentElement.firstElementChild;

        boton.onclick = function () {
            p.classList.toggle('naranja');
        };
    });
}

window.addEventListener('load', iniciar);

