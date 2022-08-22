# TP.Aula07.Parallel

Este repositório contém minha solução para os exercícios propostos na aula 07 do Módulo Técnicas de Programação. Estes exercícios foram propostos para a fixação do conteúdo de Paralelismo. <br/>

### Enunciados <br/>
Questão 1 <br/>
Criar um aplicativo que simule uma chamada à uma API. Utilize Sleep para definir o tempo de 2 segundos para uma chamada. Utilizando paralelismo (for ou foreach), execute essa chamada 100 vezes utilizando no máximo 7 threads. Exiba uma mensagem de finalização ao terminar cada chamada. Exiba o tempo gasto para toda a operação em segundos.
<br/>

Questão 2 <br/>
Criar um aplicativo que possua 3 métodos:
- AcertarBaseDeDados
- EnviarEmail
- LimparArquivosTemporarios <br/>

Cada método terá seu tempo de execução definido por Sleep (no máximo 4 segundos). Faça com que os 3 métodos sejam executados em paralelo. Utilize um quarto método que fará a execução dos demais e faça com que ele espere um parâmetro onde será informada a quantidade de threads a serem utilizadas na execução. Exiba do tempo gasto em milissegundos.

## :hammer: Como executar o programa
Clone o repositório em uma pasta local: git clone `https://github.com/sathyagimenes/TP.Aula07.Parallel.git` <br/>
Abra a solução do projeto com o Visual Studio: arquivo `TP.Aula07.Parallel.sln` <br/>
Execute o projeto com `CTRL + F5`
