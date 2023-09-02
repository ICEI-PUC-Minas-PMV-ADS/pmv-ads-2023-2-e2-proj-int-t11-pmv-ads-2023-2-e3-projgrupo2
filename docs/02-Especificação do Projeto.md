# Especificações do Projeto

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Lucas Mendes|Agendar consulta| Não esquecer de fazê-las|Poupar tempo e garantir que o agendamento seja feito de maneira rápida e conveniente|
|Ana Silva|Filtrar pelos Dentistas próximos da minha região|Encontrar um profissional de confiança em minha nova localidade|
|Dr. Rodrigo Ferreira| Alterar permissões                 | Permitir que possam administrar contas |
|Dra. Maria Oliveira| Alterar permissões                 | Permitir que possam administrar contas |

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
