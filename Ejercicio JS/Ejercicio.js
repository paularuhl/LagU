function start() {
    const btnInsert = document.querySelector('#insertar');

    btnInsert.onclick = function (e) {
        const name = document.getElementById('name');
        const lastname = document.getElementById('lastname');
        const age = document.getElementById('age');

        insertarPersona(name.value, lastname.value, age.value);
    };

}

function insertarPersona(name, lastname, age) {
    let ul = document.getElementsByName('Listado')[0];
    let li = document.createElement('li');
    let btnDelete = document.createElement('button');

    btnDelete.innerText = 'Borrar';
    btnDelete.onclick = function () {
        li.remove();
    }

    li.innerText = `${name} ${lastname} (${age})`;
    li.append(btnDelete);

    ul.append(li);
}


window.addEventListener('load', start);

//marcost@lagash.com