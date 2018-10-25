
function iniciar() {
    ejemplo1_onchange();
    ejemplo2_keyup();
    //ejemplo3_sandbox();
    ejemplo4_hack();

    //  ejemplo5_ultimo_parametro();

    removerEvento();
}

function ejemplo1_onchange() {
    const misElementos = document
        .querySelector('div[name="ejemplo1"]')
        .querySelectorAll('input');

    misElementos.forEach(el => {
        el.addEventListener('change', function (event) {
            const resultado = document.getElementById('resultado1');

            resultado.innerText = `${event.target.name}: ${event.target.value}`;
        });
    });
}

function ejemplo2_keyup() {
    const misElementos = document
        .querySelector('div[name="ejemplo2"]')
        .querySelectorAll('input');

    misElementos.forEach(el => {
        el.addEventListener('keyup', function (event) {
            const resultado = document.getElementById('resultado2');

            resultado.innerText = `${event.target.name}: ${event.target.value}`;
        });
    });
}

function ejemplo3_sandbox() {
    const miElemento = document
        .querySelector('div[name="ejemplo3"]')
        .querySelectorAll('input')[0];

    miElemento.addEventListener('keyup', anotarEvento);
    miElemento.addEventListener('keydown', anotarEvento);
    miElemento.addEventListener('change', anotarEvento);
    miElemento.addEventListener('focus', anotarEvento);
    miElemento.addEventListener('blur', anotarEvento);
}

function ejemplo4_hack() {
    const formulario = document.querySelector('form');
    const nombre = formulario.querySelector('input[name="Nombre"]');
    const apellido = formulario.querySelector('input[name="Apellido"]');

    formulario.addEventListener('submit', function (event) {

        if (nombre.value === 'hack') {
            alert('Dang!');

            nombre.value = 'Hola';
            apellido.value = 'Mundo!';

            event.preventDefault();
        }
    })
}

function ejemplo5_ultimo_parametro() {
    let unaSolaVez = {
        once: true
    };
    const miElemento = document.querySelector('input[name="Sandbox"]');

    miElemento.addEventListener('keyup', function (event) {
        console.log(event.type + ' ejecutado');
    }, unaSolaVez);
}

function anotarEvento(event) {
    const resultado = document.getElementById('resultado3');
    const el = document.createElement('p');

    el.innerText = `#${resultado.children.length + 1} | Evento: ${event.type}`;

    resultado.append(el);
}

function removerEvento() {
    const miElemento = document.querySelector('input[name="Sandbox"]');

    miElemento.addEventListener('focus', function listener(event) {
        console.log(event.type + ' ejecutado');
        this.removeEventListener('focus', listener)
    });

    miElemento.addEventListener('blur', function listener(event) {
        console.log(event.type + ' ejecutado');
        this.removeEventListener('blur', listener)
    });

    miElemento.addEventListener('change', function listener(event) {
        console.log(event.type + ' ejecutado');
        this.removeEventListener('change', listener)
    });
}

window.addEventListener('load', iniciar);


















const foo = `
                  /88888888888888888888888888\
                  |88888888888888888888888888/
                   |~~____~~~~~~~~~"""""""""|
                  / \_________/"""""""""""""\
                 /  |              \         \
                /   |  88    88     \         \
               /    |  88    88      \         \
              /    /                  \        |
             /     |   ________        \       |
             \     |   \______/        /       |
  /"\         \     \____________     /        |
  | |__________\_        |  |        /        /
/""""\           \_------'  '-------/       --
\____/,___________\                 -------/
------*            |                    \
  ||               |                     \
  ||               |                 ^    \
  ||               |                | \    \
  ||               |                |  \    \
  ||               |                |   \    \
  \|              /                /"""\/    /
     -------------                |    |    /
     |\--_                        \____/___/
     |   |\-_                       |
     |   |   \_                     |
     |   |     \                    |
     |   |      \_                  |
     |   |        ----___           |
     |   |               \----------|
     /   |                     |     ----------""\
/"\--"--_|                     |               |  \
|_______/                      \______________/    )
                                              \___/`;