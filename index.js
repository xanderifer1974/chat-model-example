let divMensagem = document.querySelector(".chat-messages")
let buttonEnviar = document.querySelector("#send-message");


function criarMensagem(mensagem) {
    const divPrincipal = document.createElement('div');

    const divMensagem = document.createElement('div');
    divMensagem.classList.add('message', 'incoming');

    const divConteudoMensagem = document.createElement('div');
    divConteudoMensagem.classList.add('message-content');

    const paragrafo = document.createElement('p');
    paragrafo.textContent = mensagem;

    divConteudoMensagem.appendChild(paragrafo);
    divMensagem.appendChild(divConteudoMensagem);

    const divTimestamp = document.createElement('div');
    divTimestamp.style.display = 'block';
    divTimestamp.style.textAlign = 'right';

    const spanTimestamp = document.createElement('span');
    spanTimestamp.classList.add('message-timestamp');
    spanTimestamp.textContent = criarHoraAtual();

    divTimestamp.appendChild(spanTimestamp);

    divPrincipal.appendChild(divMensagem);
    divPrincipal.appendChild(divTimestamp);

    return divPrincipal;
}

function criarHoraAtual() {

    let date = new Date();

    let hours = date.getHours();
    let minutes = date.getMinutes();
    let amOrPm = hours >= 12 ? 'PM' : 'AM';
    hours = hours % 12;
    hours = hours ? hours : 12;
    minutes = minutes < 10 ? '0' + minutes : minutes;

    return currentTime = hours + ':' + minutes + ' ' + amOrPm;

}

function EnviarMensagem(mensagem) {
    // let resposta = "Olá, iremos responder em breve a sua mensagem";

    divMensagem.appendChild(criarMensagem(mensagem))

    // setTimeout(function() {
    //     let Resposta = ResponderMensagem(resposta,horario)
    //     divMensagem.appendChild(Resposta)
    //   }, 2000);


}

function ResponderMensagem(texto) {
    let horario = criarHoraAtual();
    var divMensagem = document.createElement('div');
    divMensagem.id = 'mensagem-e-horario-resposta';

    var divOutgoing = document.createElement('div');
    divOutgoing.classList.add('message', 'outgoing');

    var divContent = document.createElement('div');
    divContent.classList.add('message-content');

    var paragrafo = document.createElement('p');
    paragrafo.textContent = texto;

    divContent.appendChild(paragrafo);
    divOutgoing.appendChild(divContent);
    divMensagem.appendChild(divOutgoing);

    var divHorario = document.createElement('div');
    divHorario.style.display = 'block';
    divHorario.style.textAlign = 'left';

    var spanHorario = document.createElement('span');
    spanHorario.classList.add('message-timestamp');
    spanHorario.textContent = horario;

    divHorario.appendChild(spanHorario);
    divMensagem.appendChild(divHorario);

    return divMensagem;
}

//Crear o modelo de chat com uma api fake.
buttonEnviar.addEventListener("click", async (e) => {
    e.preventDefault();
    let pergunta = document.querySelector("input#mensagem").value;
    divMensagem.appendChild(criarMensagem(pergunta))    

    fetch(`http://localhost:3000/simulacaoChat?pergunta=${pergunta}`)
        .then(response => response.json())
        .then(data => {
                      
            let resposta = data[0].resposta;
            console.log(resposta)          

            divMensagem.appendChild(ResponderMensagem(resposta));
        })
        .catch(error => {
            // Trate o erro, se necessário
            divMensagem.appendChild(ResponderMensagem("Não temos resposta para a sua pergunta."));
            
        });  


});

