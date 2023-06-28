let divMensagem = document.querySelector(".chat-messages")
let buttonEnviar = document.querySelector("#send-message");

function criarMensagem(mensagem) {
    // Cria um elemento div
    var divElement = document.createElement('div');
    divElement.classList.add('message');
    divElement.classList.add('incoming');

    // Cria um elemento div para o conteúdo da mensagem
    var contentElement = document.createElement('div');
    contentElement.classList.add('message-content');

    // Cria um elemento p para o texto da mensagem
    var pElement = document.createElement('p');
    pElement.textContent = mensagem;

    // Adiciona o elemento p ao elemento div do conteúdo da mensagem
    contentElement.appendChild(pElement);

    // Cria um elemento span para o carimbo de data/hora
    var spanElement = document.createElement('span');
    spanElement.classList.add('message-timestamp');
    spanElement.textContent = criarHoraAtual();

    // Adiciona o elemento div do conteúdo da mensagem ao elemento div principal
    divElement.appendChild(contentElement);

    // Adiciona o elemento span do carimbo de data/hora ao elemento div principal
    divElement.appendChild(spanElement);

    return divElement;



}

function criarHoraAtual() {
    // Cria um objeto Date para a data/hora atual
    var date = new Date();

    // Obtém as horas e minutos
    var hours = date.getHours();
    var minutes = date.getMinutes();

    // Determina se é AM ou PM
    var amOrPm = hours >= 12 ? 'PM' : 'AM';

    // Converte para o formato 12 horas
    hours = hours % 12;
    hours = hours ? hours : 12; // Define 12 horas para meia-noite (0 horas)

    // Formata os minutos com dois dígitos
    minutes = minutes < 10 ? '0' + minutes : minutes;

    // Cria a string no formato "hh:mm AM/PM"
    return currentTime = hours + ':' + minutes + ' ' + amOrPm;

}

function EnviarMensagem() {

    let mensagem = document.querySelector("input#mensagem").value;
    divMensagem.appendChild(criarMensagem(mensagem))
}

buttonEnviar.addEventListener("click",EnviarMensagem);

