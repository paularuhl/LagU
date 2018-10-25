function iniciar() {
    crearTexto();

    window.addEventListener('mousemove', function (event) {
        let el = document.getElementById('foo');

        let pos = {
            x: event.clientX,
            y: event.clientY
        };

        this.console.log(pos);

        el.style.top = pos.y + 'px';
        el.style.left = pos.x + 'px';

    })
}

function crearTexto() {
    let el = document.createElement('span');

    el.id = 'foo';
    el.innerText = 'Texto';
    el.style.position = 'absolute';

    document.body.append(el);
}

window.addEventListener('load', iniciar);