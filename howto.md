<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/desafio_01.png" align="center">

## O desafio

Para realização do desafio, foi necessário a execução dos seguintes passos:

### Passos:

#### Criar uma conta gratuita no Azure
- [ ] Foi criada uma conta no Azure e no Azure DevOps

#### Configurar o Azure para dois ambientes: Teste e Produção
- [ ] O Azure foi configurado da seguinte forma: 
	- Teste 
		Grupo de recursos: nibodesafiogitdev-rg
		DevOps Starter: NiboDesafioGitDev
<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/NiboDesafioGitDev.png" align="center">
	
	- Produção
		Grupo de recursos: nibodesafiogitdev-rg
		DevOps Starter: NiboDesafioGitDev	

<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/NiboDesafioGit.png" align="center">

#### Configurar pipeline para integração e deploy contínuo usando o Github Actions ou Azure DevOps
- [ ] A aplicação foi desenvolvida no Visual Studio e armazenada no repositorio [github] (https://github.com/migueldumar/NiboDesafioGit)
- [ ] Para o pipeline de integração e deploy contínuo (CI/CD) foi usando o Azure DevOps com o repositorio no githeb referenciado no item anterior. 

<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/NiboDesafioGit_CI_CD.png" align="center">
<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/NiboDesafioGitDev_CI_CD.png" align="center">

#### Uma das etapas obrigatórias deve rodar os testes unitários
#### O deploy deve ser realizado automaticamente no ambiente de testes e no ambiente de produção, seguindo o Github Flow
#### O deploy deverá ser feito na sua conta Azure nos ambientes que você criou

- O teste unitário foi aplicado no pipeline NiboDesafioGitDev - CI
	- Homologação
		- pipeline de build: NiboDesafioGitDev - CI
			- o job esta sendo iniciado automaticamente quando o repositorio develop é atualizado no github 
				- utilizando o github flow para criar a release, faz o pusuh e sincronizando )
			- o teste é realizado nesse passo
				- foi criada uma função com um teste simple de validação de texto de um outro conteúdo de uma pagina interna, somente para gerar um erro de execução.
				- para realizar o teste, por exemplo, deve ser alterado o [arquivo] (https://github.com/migueldumar/NiboDesafioGit/blob/main/WebApplicationNiboDesafioGit/WebApplication.Test/TestUnitario.cs) alterando a inicial de uma das palavras para minuscula,
				assim gerando um erro e não dando continuidade no deploy da aplicação. Caso não seja identificado erro no teste, o job da implantação
				- para realização da implantação, foi configurado o job release NiboDesafioGitDev - CD, que é inicado automaticamente com o sucesso do job NiboDesafioGitDev - CI				
				
				
	- Produção
			- pipeline de build: NiboDesafioGit - CI
			- o job esta sendo iniciado automaticamente quando o repositorio main é atualizado no github 
				- utilizando o merge para sincronização
			- o teste é realizado no passo de deploy (passo anterior de homologação), tendo em vista que o merge para a produção já cracteriza que a build de homologação já foi testada.
			- para realização da implantação, foi configurado o job release NiboDesafioGit - CD, que é inicado automaticamente com o sucesso do job NiboDesafioGit - CI
			- para finalização do deploy, é necessária a aprovação por um usuário "admin".
			
<img src="https://github.com/migueldumar/NiboDesafioGit/blob/develop/NiboDesafioGit_approved_CD.png" align="center">
    
#### URLs e instruções de como verificar o resultado

##### Produção: 
NiboDesafioGit.azurewebsites.net

##### Homologação:
NiboDesafioGitDev.azurewebsites.net

##### Github
https://github.com/migueldumar/NiboDesafioGit.git

o teste foi descrito no passo de teste unitário


## Envio da solução
- você deverá criar um fork deste repositório: https://github.com/mmdumar/NiboDesafioGit.git
- incluir os scripts `.yml` : https://github.com/migueldumar/NiboDesafioGit/tree/develop/arquivos_scripts




