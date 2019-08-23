# Sistema para gerenciar empréstimos de livros

[![Build status](https://ci.appveyor.com/api/projects/status/c05avthupjm0am8r?svg=true)](https://ci.appveyor.com/project/jeh-dias/lendingbooksystem)

## Funcionamento do Sistema

1. O sistema contêm funcionalidades de cadastro completo do livro.
2. O sistema vai contabilizar o número de dias ou horas para a devolução do livro.
3. O sistema contêm o cadastro com os dados da pessoa que efetuou o empréstimo para fins de controle.
4. A cada empréstimo efetuado, antes da entrega do item, deverá ser apontado no sistema as condições (qualidade e/ou estado) atuais do 5. item. Por exemplo, no caso do livro: em bom estado, capa riscada a caneta, página de prefácio rasgada, etc.
5. O sistema deverá possibilitar consulta á lista de empréstimos e detalhes das condições de empréstimo como data de entrega e detalhes do item.
6. No momento da entrega, o cliente poderá incluir no sistema feedbacks sobre o item que pegou emprestado.
7. O sistema deverá dar suporte á bloqueio de empréstimo para um item.

## Api disponível no azure
https://lending.azurewebsites.net

## Api com Swagger disponível no azure
https://lending.azurewebsites.net/docs

## Banco de dados postgres disponível no Google Cloud Plataform 
1. Endereço público 35.199.92.78
2. Nome da conexão de instância: projeto-final-arquitetura-net:southamerica-east1:instance-arquitetura

## Projeto Front
https://github.com/jeh-dias/LendingBookSystemFront
