# Geo_Shared API

<div align="center">
  
![GeoShared](https://i.imgur.com/hQthpj9.png)

</div>

Repositório da API do geoshared, inspirado no [GEO_DB](http://geodb-cities-api.wirefreethought.com)

Link da API Hospedada: https://geoshared-api.onrender.com/shared/endpoint

Guilherme Ribeiro &&
Nicolas Moresco Viana 3 A DS

# Endpoints

Os seus princpiais endpoints são:

- Bioma;
- Continente;
- Governadore;
- Imagem;
- Presidente;
- Provincia;
- Quiz;

# Diagramas

### Diagrama de classes
![Diagrama de Classes](https://i.imgur.com/0TXcFMS.png)



### MER (Modelo Entidade e Relacionamento)
![MER](https://i.imgur.com/OaAZ63J.png)



### DER Conceitual (Diagrama de Entidade e Relarionamento)
![DER](https://i.imgur.com/fsAQhWF.png)


# Funcionamento


> Terás de ter o MySQL instalado em sua máquina

Para executá-lo siga as instruções abaixo:

- Clone o repositório com ```git clone https://github.com/Gui-Ribs/Geo_Shared-API.git ```
- Baixe as dependências ```dotnet restore ```
- Migations: ```dotnet ef database update ```
- Execute ```dotnet run```

- Obs: Tenha instalado o donet ef;

Para se conectar com o banco no localhost, altere a propriedade "LocalhostConnection", em appsettings.json

> Caso tenha o Docker instalado, rode o comando ```docker compose up -d```

# Funcionamento - Demonstração

- Link do funcionamento: https://abrir.link/vui9I
