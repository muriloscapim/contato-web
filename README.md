# contato-web

#### Requisitos
- SGBD PostgreSQL
- Visual Studio

#### Criar o banco de dados no PostgeSQL utilizando os seguintes comandos SQL:
```sql
CREATE DATABASE contato
TEMPLATE = TEMPLATE0
ENCODING 'UTF-8'
CONNECTION LIMIT -1;

CREATE TABLE tb_contato(
id SERIAL,
nome VARCHAR(60) CONSTRAINT nn_tb_contato_nome NOT NULL,
email VARCHAR(60) CONSTRAINT nn_tb_contato_email NOT NULL,
telefone VARCHAR(15) CONSTRAINT nn_tb_contato_telefone NOT NULL,
CONSTRAINT pk_tb_contato_idContato PRIMARY KEY(id)
);
```

#### Framework ASP.NET MVC
- Framework para desenvolvimento de aplicações web.
- Faz uso do padrão de arquitetura de desenvolvimento de software MVC.
- Funciona sobre o .NET Framework.

- Para melhor entendimento sugiro assistir esse vídeo: 
https://www.youtube.com/watch?v=7xRQ5Jw-nxo

#### No padrão MVC há três elementos principais:
- O **model**, responsável por representar as entidades da lógica de negócios da aplicação;
- A **view**, responsável por apresentar uma interface para o usuário;
- E o **controller**, que realiza o controle dos outros elementos, fornece uma ligação entre eles.


O Model realiza o acesso ao banco de dados e o Controller atua como intermediário entre a View (páginas HTML) e o model.
Nas classes Controller desenvolvemos grande parte das validações e regras de negócio do sistema.


#### Biblioteca ADO.NET
- ADO.NET é a biblioteca (conjunto de classes) utilizada pela Microsoft para acesso a bases de dados na plataforma .NET
- Facilita o acesso das aplicações à bases de dados de diversos tipos.

#### Npgsql
- https://www.npgsql.org/
- **Provedor de dados do ADO.NET** para acesso ao banco de dados PostgreSQL em uma aplicação .NET
- Contém classes para conexão, consulta e retorno dos dados do banco de dados PostgreSQL.
- A melhor maneira de usar o Npgsql em nosso projeto é instalar o seu pacote nuget.

#### NuGet
- https://www.nuget.org/
- Gerenciador de pacotes para a plataforma .NET
- Possui integração ao Visual Studio.

#### String de conexão
- https://www.connectionstrings.com/npgsql/
