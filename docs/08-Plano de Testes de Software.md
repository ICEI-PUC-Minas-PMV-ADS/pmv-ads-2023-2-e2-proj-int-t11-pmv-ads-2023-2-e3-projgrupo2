# Plano de Testes de Software
Os requisitos para realização dos testes de software são: 

* Site publicado na Internet 

* Navegador da Internet - Chrome, Firefox ou Edge 

* Conectividade de Internet para acesso às plataformas (APISs) 

 

Os testes funcionais a serem realizados no aplicativo são descritos a seguir: 

 

# Casos de Testes 



# CT-01 – Cadastrar Cliente 

* Requisitos Associados:

RF-01 - O cliente deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail, senha e idade. 

* Objetivo do Teste: 

Verificar se está sendo possível o cadastro de cliente.

* Passos: 

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Preencher campos de cadastro do cliente 

4 Clicar em confirmar cadastro 

* Critérios de Êxito: 

Site deve confirmar cadastro e redirecionar para a página com a lista de dentistas. 

 

# CT-02 – Cadastrar Dentista 

* Requisitos Associados: 

RF-02 - O dentista deve ser capaz de se cadastrar informando obrigatoriamente seu nome, e-mail, senha, idade, especialidade e, opcionalmente, horário de atendimento, local do consultório e descrição. 

* Objetivo do Teste: 

Verificar se está sendo possível o cadastro de dentista 

* Passos: 

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Preencher campos de cadastro do dentista 

4 Clicar em confirmar cadastro 

* Critérios de Êxito: 

Site deve confirmar cadastro e redirecionar para a página com a lista de dentistas 

 


# CT-03 – Fazer login 

* Requisitos Associados: 

RF-03 - O cliente deve ser capaz de fazer login usando seu e-mail e senha correspondentes. 

RF-04 - O dentista deve ser capaz de fazer login usando seu e-mail e senha correspondentes. 

* Objetivo do Teste:  

Verificar se está sendo possível fazer o login no site 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Preencher e-mail e senha corretos 

4 Clicar em fazer login 

* Critérios de Êxito:  

Site deve confirmar login e redirecionar para a página com a lista de dentistas 

 

# CT-04 – Visualizar lista de dentistas 

* Requisitos Associados:  

RF-05 - O usuário (cliente ou dentista) deve ser capaz de visualizar a lista de dentistas disponíveis. 

* Objetivo do Teste:  

Verificar se está sendo possível visualizar lista de dentistas 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Acessar página com a lista de dentistas 

* Critérios de Êxito 

Site deve exibir todos os dentistas disponíveis


# CT-05 – Visualizar detalhes de um dentista 

* Requisitos Associados:  

RF-07 - O usuário (cliente ou dentista) deve ser capaz de visualizar os detalhes de um dentista selecionado. 

* Objetivo do Teste:  

Verificar se está sendo possível visualizar os detalhes de um dentista 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Acessar página com a lista de dentistas 

4 Selecione um dentista 

* Critérios de Êxito:  

Site deve exibir os detalhes de um dentista 



# CT-06 – Agendar horário com um dentista 

* Requisitos Associados:  

RF-08 - O cliente, quando logado, deve poder agendar um horário com um dentista. 

* Objetivo do Teste:  

Verificar se está sendo possível agendar um horário com um dentista 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Acessar página com a lista de dentistas 

4 Selecione um dentista 

5 Agende um horário  

* Critérios de Êxito:  

Site deve confirmar o agendamento

 

# CT-07 – Visualizar horários marcados como cliente 

* Requisitos Associados:  

RF-11 - O cliente, quando logado, deve poder visualizar os horários marcados por ele. 

* Objetivo do Teste:  

Verificar se está sendo possível visualizar os horários marcados como cliente 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Acessar página com os agendamentos do cliente 

* Critérios de Êxito:  

Site deve exibir os horários marcados pelo cliente 



# CT-08 – Visualizar horários marcados pelos clientes 

* Requisitos Associados:  

RF-12 - O dentista, quando logado, deve poder visualizar os horários marcados pelos clientes. 

* Objetivo do Teste:  

Verificar se está sendo possível visualizar os horários marcados pelos clientes 

* Passos:  

1 Acessar o Navegador 

2 Informar o endereço do Site 

3 Acessar página com os agendamentos feito por clientes 

* Critérios de Êxito:  

Site deve exibir todos os horários marcados pelos clientes 