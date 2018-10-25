
function iniciar() {
    const btnInsertar = document.querySelector('#btn-insertar');
    const btnBorrarPrimero = document.querySelector('#btn-borrar-primero');
    const btnBorrarUltimo = document.querySelector('#btn-borrar-ultimo');

    btnInsertar.onclick = function (e) {
        const prefijo = document.getElementById('prefijo');

        insertarLi(prefijo.value);
    };

    btnBorrarPrimero.onclick = function (e) {
        borrarPrimero();
    };

    btnBorrarUltimo.onclick = function (e) {
        borrarUltimo();
    };
}

function insertarLi(text) {
    let ul = document.getElementsByName('actualizame')[0];
    let li = document.createElement('li');

    if (!text) {
        text = '[##]'
    }

    li.innerText = `[${ul.children.length + 1}] - ${text}`;

    ul.append(li);
}

function borrarPrimero() {
    var ul = document.getElementsByName('actualizame')[0];

    ul.firstElementChild.remove();
}

function borrarUltimo() {
    var ul = document.getElementsByName('actualizame')[0];

    ul.lastElementChild.remove();
}

window.addEventListener('load', iniciar);