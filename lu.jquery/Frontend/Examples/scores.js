$(function(){
    $.ajax({
        url: 'http://localhost:5000/api/scores',
        method: "GET"
    })
    .done(function(data){
        addScoreToList(data);
    });

/*  $('#score-list').on('click', 'li', function(){
        alert('PlayerId:' + $(this).data('playerId'));
    });
*/
    $('#player-list').on('click', 'button', removePlayer);

    $('#newScore').on('click', function(){
        var score = {
            gameId: $('#gameId').val(),
            playerId: $('#playerId').val(),
            kills: $('#kills').val(),
            deaths: $('#deaths').val(),
            assists: $('#assists').val()
        }
        $.ajax({
            url: 'http://localhost:5000/api/scores',
            method: "POST",
            dataType: 'json', //optional
            contentType : 'application/json',
            data: JSON.stringify(score)
        })
        .done(function(data){
            addPlayerToList([data]);
        })
        .fail(function(error){
            console.log('Status Code:'+ error.status);
        })
        
    });

    function addScoreToList(data){
        $('#playerId').val('');
        $.each(data, function(index, item){
            var newElement = $('<div>').data('playerId', item.id).text('PlayerId: ' + item.id + ' - Name: ' + item.name + ' - Country: ' + item.country);
            var removeElement = $('<button></button>').text('Remove');
            newElement.append(removeElement);
            $('#player-list').append(newElement);
        })        
    }


    function removePlayer(){
        var parentElement = $(this).parent('div');
        var playerId = parentElement.data('playerId');
        $.ajax({
            url: 'http://localhost:5000/api/scores/'+playerId,
            method: 'DELETE'
        })
        .done(function(){
            parentElement.remove();
        })
    }
})