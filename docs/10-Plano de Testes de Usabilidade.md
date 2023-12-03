# Plano de Testes de Usabilidade

**Introdução**: Este plano de teste de usabilidade tem como objetivo avaliar a facilidade de uso e a experiência do usuário no site EASYDENTAL. Será conduzido um conjunto de testes com usuários para identificar possíveis problemas de usabilidade e fornece recomendações para melhorias. 
 
**Objetivos**: Avaliar a usabilidade geral do sistema. Identificar possíveis obstáculos ou dificuldades na navegação e interação. Coletar feedback dos usuários para aprimorar a interface e a experiência. 

**Metodologia**: Os testes de usabilidade serão realizados com um grupo de participantes representativos dos usuários reais do sistema, incluindo membros do grupo de desenvolvimento. Os testes serão conduzidos em um ambiente controlado, e os participantes serão solicitados a realizar tarefas específicas no sistema. Um facilitador observará e registrará as ações e comentários dos participantes. 

|    CT-01   | Cadastro de Cliente |
|------------|-------------------------------------------------------------------------------------------------------|
|  Requisito | RF-01 - O cliente deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail e senha |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de cadastro, este que pode ser realizado ao clicar em "Cadastrar". Após o preenchimento de informações cadastrais (Nome, Telefone, E-mail, Senha e Confirme a senha) e clique em “Cadastrar”, o usuário será redirecionado a página de Login Cliente. Assim, a aplicação atende ao requisito: RF-01. |

|    CT-02   | Cadastro de Dentista |
|------------|-------------------------------------------------------------------------------------------------------|
|  Requisito | RF-02 - O dentista deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail, senha, idade, especialidade e, opcionalmente, horário de atendimento, local do consultório e descrição. |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de cadastro, este que pode ser realizado ao clicar em "Cadastrar" e logo após clicar em “Cadastro Dentista”. Após o preenchimento de informações cadastrais (Nome, Telefone, E-mail, Senha, Confirme a senha, CRO, Especialidades, Nome da Clínica, Endereço, Horário de abertura, Horário de encerramento e descrição) e clique em “Cadastrar”, o usuário será redirecionado a página de Login Dentista. Assim, a aplicação atende ao requisito: RF-02. |

|    CT-03   | Login de Usuário |
|------------|-------------------------------------------------------------------------------------------------------|
|  Requisito | RF-03 - O cliente deve ser capaz de fazer login usando seu e-mail e senha correspondentes. RF-04 - O dentista deve ser capaz de fazer login usando seu e-mail e senha correspondentes. |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de login, este que pode ser realizado ao clicar em "login", caso queira realizar login como paciente só preencher os dados previamente cadastrados (E-mail e Senha) e logo após clicar no botão login. Mas caso queira realizar login como dentista basta clicar o botão “login dentista” localizado na parte inferior da página, aonde será direcionado a “login dentista”, aonde preencherá os dados previamente cadastrados (E-mail e senha) e clicar no botão login. Após ambos processos o usuário será direcionado a página lista de dentistas encerrando o processo de login. Assim, a aplicação atende aos requisitos: RF-03 e RF-04. |

|    CT-04   | Agendamento de Consultas |
|------------|-------------------------------------------------------------------------------------------------------|
|  Requisito | RF-08 - O cliente, quando logado, deve poder agendar um horário com um dentista. RF-11 - O cliente, quando logado, deve poder visualizar os horários marcados por ele. |
| Observação | Após o usuário realizar o login como paciente, e ser direcionado a página de lista de dentistas, selecionar um dentista previamente cadastrado, clica em “Detalhes”, assim será direcionado a página de detalhes do dentista, aonde além dos detalhes do dentista haverá um campo “Agendamento”. Onde o usuário realizará o agendamento da data e do horário, após o agendamento o usuário será direcionado a página de “Suas consultas” aonde o mesmo pode verificar o seu horário marcado com o seu dentista selecionado previamente na lista de dentistas. Assim, a aplicação atende aos requisitos: RF-08 e RF-11. |

## Cenários de Teste de Usabilidade
Aqui está um exemplo simplificado de uma tabela de plano de teste de usabilidade para a aplicação mencionada. Essa tabela fornece uma estrutura básica para avaliar a usabilidade em diferentes tarefas da aplicação, definindo objetivos, critérios de avaliação, métodos de coleta de dados e análise dos resultados.

|          Tarefa          |                                Objetivos                               | Critérios de Avaliação de Usabilidade |                 Coleta de Dados                 |            Análise dos Resultados            |
|--------------------------|------------------------------------------------------------------------|---------------------------------------|-------------------------------------------------|----------------------------------------------|
|    Cadastro de Cliente   |       Verificar a facilidade de conclusão do processo de cadastro      |    Taxa de erro durante o cadastro    | Observação direta do usuário durante o cadastro | Identificar áreas de confusão ou dificuldade |
|   Cadastro de Dentista   |       Verificar a facilidade de conclusão do processo de cadastro      |    Taxa de erro durante o cadastro    | Observação direta do usuário durante o cadastro | Identificar áreas de confusão ou dificuldade |
|     Login de Usuario     | Avaliar a facilidade de login e a precisão do feedback de autenticação |     Número de cliques necessários     |        Tempo médio de conclusão do login        |  Identificar possíveis erros de performance  |
| Agendamento de Consultas |     Verificar quanto tempo o usuário gasta para marcar uma consulta    | Tempo médio para agendar uma consulta |      Tempo médio para agendar uma consulta      |    Identificar a intuitividade do usuário    |