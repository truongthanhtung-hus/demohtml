var score,gameplaying, playing,roundScore;

function newplay(){
    gameplaying = true;
    score = 0;
    roundScore = [0,0];
    document.querySelector('#cur0').textContent = '0';
    document.querySelector('#cur1').textContent = '0';
    document.querySelector('#total0').textContent = '0';
    document.querySelector('#total1').textContent = '0';
    document.querySelector('#dice').style.display = 'none';
}

newplay();
document.querySelector('.new-game').addEventListener('click',newplay);
document.querySelector('.dice-hole').addEventListener('click', function(){
    if(gameplaying) {
        var dice = Math.floor(Math.random() * 6) + 1;

        document.getElementById('dice').style.display = 'block';
        document.getElementById('dice').src = 'img/d-' + dice +'.png';

        if (dice != 1) {
            score = score + dice;
            document.querySelector('#cur' + playing).textContent = score;
        }
        else {
            score = 0;
            document.querySelector('#cur' + playing).textContent = '0';
            document.getElementById('dice').style.display = 'none';
            confirm("Quay vào số 1 rồi =)))");
            roundScore[playing] = 0;
            document.querySelector('#total' + playing).textContent = roundScore[playing];
            nextplayer();
        }
        if (score == 100){
            confirm("Win")
            newplay();
        }
    }
}); 
playing = 0;
function nextplayer() {
    score = 0;
    if(playing == 0){
        document.querySelector('#cur0').textContent = '0';
        document.querySelector('.player-0').classList.remove('playing');
        document.querySelector('.player-1').classList.add('playing');
        playing = 1;
    } else {
        document.querySelector('.player-1').classList.remove('playing');
        document.querySelector('.player-0').classList.add('playing');
        document.querySelector('#cur1').textContent = '0';
        playing = 0;
    }
}
document.querySelector('.hold').addEventListener('click',function(){
    if(gameplaying){
        roundScore[playing] += score;
        document.querySelector('#total' + playing).textContent = roundScore[playing];
        if (roundScore[playing] >= 100){
            confirm("Win");
        }
        nextplayer();
    }
});
