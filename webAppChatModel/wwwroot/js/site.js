let divMensagem = document.querySelector(".chat-body")
let buttonEnviar = document.querySelector("#send-message");
let buttonUpload = document.getElementById('file-input');
let arquivoSelecionado;


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

function handleFileUpload(event) {


    const file = event.target.files[0]; 
    let resposta = "";

    arquivoSelecionado = `Arquivo selecionado: ${file.name}`    
   
    divMensagem.appendChild(criarMensagem(arquivoSelecionado));

    if (arquivoSelecionado.startsWith('Arquivo selecionado:')) {
        resposta = `Obrigado por enviar o arquivo ${file.name}! `
    } else {
        resposta = 'Não recebemos o arquivo enviado!'
    }

    setTimeout(() => {
        divMensagem.appendChild(ResponderMensagem(resposta));
        divMensagem.scrollTop = divMensagem.scrollHeight;
    }, 2000);

    event.target.value = '';
   
}

buttonUpload.addEventListener('click', function (e) {
    const input = document.createElement('input');
    input.type = 'file'; 
    input.click();
    input.addEventListener("change", handleFileUpload);    
});

buttonEnviar.addEventListener("click", async (e) => {
    e.preventDefault();
    let pergunta = document.querySelector("input#mensagem").value;
    
    divMensagem.appendChild(criarMensagem(pergunta))
    document.querySelector("input#mensagem").value = "";    

    let url = `https://localhost:7173/api/Chat/buscarPorPergunta/${encodeURIComponent(pergunta)}`   
    fetch(url)
        .then(response => response.json())
        .then(data => {           
            let resposta = data.resposta;
            divMensagem.appendChild(ResponderMensagem(resposta));
            divMensagem.scrollTop = divMensagem.scrollHeight;
        })
        .catch(error => {
            divMensagem.appendChild(ResponderMensagem("Não temos resposta para a sua pergunta."));
            divMensagem.scrollTop = divMensagem.scrollHeight;
        });

    
});

