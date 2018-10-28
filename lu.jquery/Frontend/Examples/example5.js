$(function(){
    $.ajax({
        url: 'http://localhost:5000/api/players',
        method: "GET"
    })
    .done(function(data){
        addPlayerToList(data);
    });

    $.ajax({
        url: 'https://restcountries.eu/rest/v2/region/americas',
        method: "GET"
    })
    .done(function(data){
        addCountries(data);
    })

    $('#player-list').on('click', 'li', function(){
        alert('PlayerId:' + $(this).data('playerId'));
    });

    $('#player-list').on('click', 'button', removePlayer);

    $('#myNewPlayer').on('click', function(){
        var player = {
            name: $('#playerName').val(),
            country: $('#playerCountry').val()
        }
        $.ajax({
            url: 'http://localhost:5000/api/players',
            method: "POST",
            dataType: 'json', //optional
            contentType : 'application/json',
            data: JSON.stringify(player)
        })
        .done(function(data){
            addPlayerToList([data]);
        })
        .fail(function(error){
            console.log('Status Code:'+ error.status);
        })
    });

    function addPlayerToList(data){
        $('#playerName').val('');
        $.each(data, function(index, item){
            var newElement = $('<div>').data('playerId', item.id).text('Id: ' + item.id + ' - Name: ' + item.name + ' - Country: ' + item.country);
            var removeElement = $('<button></button>').text('Remove');
            newElement.append(removeElement);
            $('#player-list').append(newElement);
        })        
    }

    function addCountries(data){
        $.each(data, function(index, item){
            var country = $('<option>').val(item.alpha3Code).text(item.name);
            $('#playerCountry').append(country);
        });
        
    }

    function removePlayer(){
        var parentElement = $(this).parent('div');
        var playerId = parentElement.data('playerId');
        $.ajax({
            url: 'http://localhost:5000/api/players/'+playerId,
            method: 'DELETE'
        })
        .done(function(){
            parentElement.remove();
        })
    }
})