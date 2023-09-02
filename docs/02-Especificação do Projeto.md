# Especificações do Projeto

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nas figuras abaixo:

### Lucas Mendes
[FOTO]
<br /><strong>Idade:</strong> 51 anos<br />
<br /><strong>Ocupação:</strong> Engenheiro Civil<br />
<br /><strong>Descrição:</strong> Lucas Mendes é um engenheiro civil bem-sucedido, conhecido por sua dedicação ao trabalho e sua abordagem meticulosa em tudo o que faz. Ele é uma pessoa ativa, sempre em movimento, e mantém um estilo de vida ocupado devido às suas responsabilidades profissionais e pessoais. Lucas também é pai de dois filhos e tenta equilibrar suas obrigações familiares com sua carreira.<br />
<br /><strong>Aplicativos:</strong>
<li>WhatsApp</li>
<li>Facebook</li>
<li>Waze</li>
<li>Excel</li>
<br /><strong>Motivações:</strong>
<li>Lucas reconhece a importância de cuidar de sua saúde bucal, mas suas obrigações profissionais e familiares muitas vezes consomem seu tempo. Ele vê o aplicativo como uma solução que permitirá que ele agende consultas de maneira conveniente, economizando tempo valioso.</li>
<li>Como alguém que valoriza informações claras e detalhadas, Lucas vê o aplicativo como uma maneira de acessar rapidamente seu histórico de tratamentos e obter informações sobre procedimentos planejados, permitindo que ele tome decisões informadas.</li>
<br /><strong>Frustrações:</strong>
<li>Lucas muitas vezes adia ou negligência consultas dentárias devido à sua agenda agitada como engenheiro civil.</li>
<li>A falta de tempo para cuidar de sua saúde bucal pode ser frustrante, especialmente quando se confronta com uma lista de obrigações profissionais e familiares.</li>
<br /><strong>Hobbies:</strong>
<li>Lucas gosta de passar tempo ao ar livre com sua família, seja em parques, praias ou trilhas.</li>
<li>Eles gostam de assistir a filmes juntos em casa, criando uma atmosfera acolhedora e relaxante.</li>
<li>Lucas acredita na importância de apresentar sua família a diferentes culturas, levando-os a museus, exposições e eventos culturais. projetos pessoais.</li>

### Ana Silva
[FOTO]
<br /><strong>Idade:</strong> 32 anos<br />
<br /><strong>Ocupação:</strong> Educadora Infantil<br />
<br /><strong>Descrição:</strong><br />
<br /><strong>Aplicativos:</strong>
<li>WhatsApp</li>
<li>Instagram</li>
<li>Spotify</li>
<li>Pinterest</li>
<br /><strong>Motivações:</strong>
<li></li>
<br /><strong>Frustrações:</strong>
<li></li>
<br /><strong>Hobbies:</strong>
<li></li>

### Dr. Rodrigo Ferreira
[FOTO]
<br /><strong>Idade:</strong> 47 anos<br />
<br /><strong>Ocupação:</strong> Dentista Ortodontista<br />
<br /><strong>Descrição:</strong><br />
<br /><strong>Aplicativos:</strong>
<li>WhatsApp</li>
<li>Facebook</li>
<li>Google Calendar</li>
<li>Audible</li>
<br /><strong>Motivações:</strong>
<li></li>
<br /><strong>Frustrações:</strong>
<li></li>
<br /><strong>Hobbies:</strong>
<li></li>

### Dra. Maria Oliveira
[FOTO]
<br /><strong>Idade:</strong> 25 anos<br />
<br /><strong>Ocupação:</strong> Dentista<br />
<br /><strong>Descrição:</strong><br />
<br /><strong>Aplicativos:</strong>
<li>WhatsApp</li>
<li>TikTok</li>
<li>Spotify</li>
<li>MyFitnessPal</li>
<br /><strong>Motivações:</strong>
<li></li>
<br /><strong>Frustrações:</strong>
<li></li>
<br /><strong>Hobbies:</strong>
<li></li>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Lucas Mendes|Agendar consulta|Poupar tempo e garantir que o agendamento seja feito de maneira rápida e conveniente|
|Ana Silva|Filtrar pelos Dentistas próximos da minha região|Encontrar um profissional de confiança nas proximidades de casa|
|Dr. Rodrigo Ferreira|Visualizar horários marcados pelos clientes|Gerenciar meu cronograma de consultas de forma eficiente|
|Dra. Maria Oliveira|Me cadastrar|Aumentar sua visibilidade profissional|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID|Descrição do Requisito|Prioridade|
|------|------|------|
|RF-01|O cliente deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail, senha e idade.|ALTA| 
|RF-02|O dentista deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail, senha, idade, especialidade e, opcionalmente, horário de atendimento, local do consultório e descrição.|ALTA|
|RF-03|O cliente deve ser capaz de fazer login usando seu e-mail e senha correspondentes.|ALTA|
|RF-04|O dentista deve ser capaz de fazer login usando seu e-mail e senha correspondentes.|ALTA|
|RF-05|O usuário (cliente ou dentista) deve ser capaz de visualizar a lista de dentistas disponíveis.|ALTA|
|RF-06|O usuário (cliente ou dentista) deve ser capaz de filtrar a lista de dentistas por nome ou especialidade ou localidade.|ALTA|
|RF-07|O usuário (cliente ou dentista) deve ser capaz de visualizar os detalhes de um dentista selecionado.|ALTA|
|RF-08|O cliente, quando logado, deve poder agendar um horário com um dentista.|ALTA|
|RF-09|O cliente, quando logado, não deve poder agendar o mesmo horário que já foi agendado previamente.|ALTA|
|RF-10|O cliente, quando logado, não deve poder agendar o mesmo horário com mais de um dentista.|ALTA|
|RF-11|O cliente, quando logado, deve poder visualizar os horários marcados por ele.|ALTA|
|RF-12|O dentista, quando logado, deve poder visualizar os horários marcados pelos clientes.|ALTA|
|RF-13|O cliente, quando logado, deve poder fazer alterações em seu próprio cadastro.|MÉDIA|
|RF-14|O dentista, quando logado, deve poder fazer alterações em seu próprio cadastro.|MÉDIA|
|RF-15|O cliente, quando logado, deve poder cancelar uma consulta com pelo menos um dia de antecedência.|MÉDIA|
|RF-16|O dentista, quando logado, deve poder cancelar uma consulta com pelo menos um dia de antecedência.|MÉDIA|
|RF-17|O cliente deve poder excluir sua própria conta.|BAIXA|
|RF-18|O dentista deve poder excluir sua própria conta.|BAIXA|
|RF-19|O sistema deve ter um mecanismo de recuperação de senha para os usuários (cliente ou dentista)|BAIXA|
|RF-20|O sistema deve notificar o dentista quando uma consulta é marcada.|BAIXA|

### Requisitos não Funcionais

|ID|Descrição do Requisito|Prioridade|
|------|------|------|
|RNF-01|O site deverá ser responsivo se adaptando para telas de smartphones e desktops|ALTA|
|RNF-02|O site deverá seguir um padrão de design para cores dos componentes integrantes das páginas, tamanho e tipo de fonte de escrita|MÉDIA|
|RNF-03|O site deverá apresentar um desempenho estável, com um tempo de resposta adequado para as ações que envolvam o processamento|BAIXA|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID|Restrição|
|------|------|
|RE-01|O sistema deve ser desenvolvido em uma plataforma que suporte a linguagem C#.|
|RE-02|O sistema deve armazenar os dados dos clientes e dentistas de forma segura.|
|RE-03|O sistema deve garantir a privacidade dos dados pessoais dos clientes e dentistas.|

## Diagrama de Casos de Uso

![Diagrama de Casos de Uso](<./img/Diagrama de Casos de Uso.png>)
