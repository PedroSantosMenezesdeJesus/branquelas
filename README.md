# As Branquelas Cena do Carro

<h3>Integrantes: Kevin Novais Bezerra, Pedro Santos Menezes de Jesus<h3>

<h3>Série: 2º Programação de Jogos Digitais</h3>
<br>
<h3>- Tema:</h3>
"As Branquelas" é um filme de comédia e crime que conta a história dois policiais negros irmãos muito  atrapalhados chamados Kevin e Marcus Coperland que devem proteger duas patricinhas e investigar um suspeito de sequestro de garotas,os dois após um acidente leve de carro,por conta disso eles se disfarçam das irmãs wilons vulgo as patricinhas, eles fazem amizade com as amigas delas e aprendem como é estar no lugar de uma mulher, isso os ajuda a encontrar o verdadeiro culpado, contando com o personagem mais cômico do filme o Latrell

- Cena:<br>
Possui uma tonalidade mais escura por acontecer a noite, cores com maior destaque são o rosa para representar a feminilidade, o preto do terno e do carro para demonstrar confiança, e o amarelo por conta do cachorro, os personagens presentes são Latrell e Marcus disfarçado e ambos escutam "A Thousand Miles"

- Teoria das Cores:<br>
Possui muitas cores vividas para simbolizar a vida de patricinha, outra cor presente é o branco simbolizando status e poder

- Protagonistas:<Br>
Kevin e Marcus Coperland: ambos são atrapalhados, mas são dedicados ao seu trabalho, Kevin cria os planos malucos enquanto Marcus é mais pe no chão.
Latrell: Possui uma personalidade forte, muito determinado para conseguir seu amor, tenta seduzir seu amor muitas vezes, é romântico, personagem mais humorístico do filme.

- Proposta da cena:<br>
A proposta da nossa cena é fazer o player controlando o carro chegar ao restaurante, tendo que descobrir o caminho correto e desviando de carros pelo caminho, com ao fundo tocando a música "A Thousand Miles", os personagens envolvidos são Latrell e Marcus disfarçado, o player movimenta o carro com as teclas W,A,S,D que movimentam o carro para frente, para trás, direita e esquerda


- História:<Br>
Você como Latrell fez uma reserva em um restaurante e está levando uma companhia e não quer deixá-la esperando assim entrando no carro e dirijindo ao som de "A Thousand a Miles" até o restaurante, tendo que fazer desvios pois o caminho original está interditado.

- Cenário:<Br>
A cena se passa em uma cidade grande cheia de lojas, prédios, com várias árvores, tendo diferentes caminhos para seguir só que por conta de acidentes eles estão interditados.

- Música:<Br>
A Thousand Miles - Vanessa Carlton

<h3>Proposta da Cena</h3>

esboço dos personagens

![image](https://github.com/user-attachments/assets/a76bf2df-8206-4e4b-8ddc-bc5daeb05092)

![image](https://github.com/user-attachments/assets/64d0924b-9967-4954-adf9-2ef08d2072de)

esboço da cena

![image](https://github.com/user-attachments/assets/28cbffb5-0f8b-40ec-8c21-aed0ab383083)

<h3>Explicação do Código</h3>

<br> Criamos a classe player, com os atributos de Vector3 Mover, Vector3 Girar, GameObject Objeto e Sting Nome, depois atribuimos a um constructor e criamos os metodos de movimento e rotação
![image](https://github.com/user-attachments/assets/9ad7b4f8-c4e0-4362-85af-a55583916652)

![image](https://github.com/user-attachments/assets/06f02246-6789-4480-862c-328699bb38f3)

<br> Criamos a classe jogo atrelada a um MonoBehaviour para interagir com o carro, criamos variaveis que conrespondiam a os atributos da classe Player, e uma variavel que herdava do Player, chamamos as variaveis para colocarmos valores nelas e atribuimos cada varialvel para seu atributo conrespondente, no Uptade chamamos os metodos e os atribuimos as variaveis. Criamos uma metodo para atribuir a tag a string nome e Objeto 3d para atribuir para a variavel objeto. chamando assim o objeto. 
![image](https://github.com/user-attachments/assets/906e37ad-f947-4f0d-b053-8eda3a9a0d88)

![image](https://github.com/user-attachments/assets/a0397699-17d9-4bca-b7c9-b5412cbace4e)

<br> na classe Obstaculo os atributos são Vector3 Mover, GameObject Objeto e String Nome,  depois atribuimos a um constructor e criamos os metodos de movimentação para os varios obstaculos
![image](https://github.com/user-attachments/assets/19a1e172-2e82-49dd-b733-9b8a8deb9574)

![image](https://github.com/user-attachments/assets/8c86aeaf-7a3f-4627-99e0-bf7fe5a7e643)

<br> na classe JogoObstaculo criamos variaveis que atribuimos a os atributos da classe Obstaculo, e variaveis que herdavem da classe Obstaculo, depois atribuimos os valores para cada variavel e como ela funcionariam para as variaveis que herdavam da classe Obstaculo, no Uptade chamamos os metodos e os atribuimos as variaveis, e criamos uma metodo para atribuir a tag a string nome e Objeto 3d para atribuir para a variavel objeto. chamando assim o objeto. 
![image](https://github.com/user-attachments/assets/ca343c8b-f337-4d2c-8173-b6fc90b6069a)

![image](https://github.com/user-attachments/assets/357473bc-5bb9-48b8-b044-47a683f7ca68)

![image](https://github.com/user-attachments/assets/b5a65cf2-f60b-4fdd-936e-71dc7ebe01fa)

<br> criamos a classe colisão e colisãoVitoria para caso os obstaculos tocarem no jogador, verem se ele tem a tag jogador, caso sim, o jogo reinicia, e no colisãoVitoria caso seja verdade ele muda a cena para a cena de vitoria 
![image](https://github.com/user-attachments/assets/25cc4377-b62d-410d-b694-4673d099a493)

![image](https://github.com/user-attachments/assets/ebee707f-8aee-42b7-ab48-7eb44619ef7a)

<br> cria uma classe feita para tocar a musics em loop durante o jogo
![image](https://github.com/user-attachments/assets/3135dbf0-1508-43d8-a1f6-45df7304250b)


<h3>Diagrama velho </h3>

![image](https://github.com/user-attachments/assets/f567b11d-7e8f-4afe-9650-a09beb699c5a)

<h3>Diagrama novo </h3>

![image](https://github.com/user-attachments/assets/863f6c1b-b6a5-4ec2-99a1-6baac50262d0)

<h3>Assets usados</h3>

Adventure Female (Free)
[link](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/adventure-female-free-272945)

FREE - Modular Character - Fantasy RPG Human Male
[link](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/free-modular-character-fantasy-rpg-human-male-228952)

Race game car, BMW Shark
[link](https://assetstore.unity.com/packages/3d/vehicles/land/race-game-car-bmw-shark-137732)

SimplePoly City - Low Poly Assets
[link](https://assetstore.unity.com/packages/3d/environments/simplepoly-city-low-poly-assets-58899)

Lowpoly Dinner Table
[link](https://assetstore.unity.com/packages/3d/environments/fantasy/lowpoly-dinner-table-55180)

esboço dos personagens

![image](https://github.com/user-attachments/assets/a76bf2df-8206-4e4b-8ddc-bc5daeb05092)

![image](https://github.com/user-attachments/assets/64d0924b-9967-4954-adf9-2ef08d2072de)

esboço da cena

![image](https://github.com/user-attachments/assets/28cbffb5-0f8b-40ec-8c21-aed0ab383083)

video do jogo
[link](https://drive.google.com/file/d/1glqpTzwGarvE6oZruqga1ppyKNdGWTkr/view?usp=sharing)

Nosso Jogo
[link](https://drive.google.com/file/d/1J1WHvFNGHTvmPVexPrZ8eObi6xjUDIkN/view?usp=drivesdk)

<h3> o que cada um fez</h3>

Pedro: fez a parte de programação, o video, os diagramas, o cenario com auxílio  e fez a analise do filme com auxílio.

kevin: fez a parte artistica, buscou os assets, ajudou na criação do cenário e o repositorio, fez os esboços ajudou na análise do filme.
