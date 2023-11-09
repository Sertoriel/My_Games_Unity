using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerCria : MonoBehaviour
{
    public List<dadosRespostasasCria[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesCria[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasCria[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é a principal função do CRIA?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) Promover festivais de cinema."},
            new dadosRespostasasCria() {Resp = "b) Organizar feiras de ciências."},
            new dadosRespostasasCria() {Resp = "c) Incentivar a publicação de livros."},
            new dadosRespostasasCria() {Resp = "d) Oferecer suporte ao empreendedorismo."},
            new dadosRespostasasCria() {Resp = "e) Coordenar intercâmbios acadêmicos."},
            new dadosRespostasasCria() {Resp = "f) Realizar exposições de arte."}
        });

        //2. Que tipo de apoio o CRIA oferece para o desenvolvimento de negócios?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) Aquisição de equipamentos."},
            new dadosRespostasasCria() {Resp = "b) Patrocínio para publicidade."},
            new dadosRespostasasCria() {Resp = "c) Mentoria digital e capacitação."},
            new dadosRespostasasCria() {Resp = "d) Empréstimos financeiros."},
            new dadosRespostasasCria() {Resp = "e) Parcerias com empresas internacionais."},
            new dadosRespostasasCria() {Resp = "f) Design de logos e marcas."}
        });

        //3. A que se refere o termo "embrião" no contexto do CRIA?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) Uma nova tecnologia."},
            new dadosRespostasasCria() {Resp = "b) Uma startup de biologia."},
            new dadosRespostasasCria() {Resp = "c) Primeira fase do empreendimento."},
            new dadosRespostasasCria() {Resp = "d) Uma ferramenta de software."},
            new dadosRespostasasCria() {Resp = "e) Uma sala de reunião."},
            new dadosRespostasasCria() {Resp = "f) Um evento anual do CRIA."}
        });

        //4. O que acontece com as propostas submetidas ao CRIA?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) São publicadas em uma revista."},
            new dadosRespostasasCria() {Resp = "b) Recebem um prêmio em dinheiro."},
            new dadosRespostasasCria() {Resp = "c) Passam por processo de consolidação."},
            new dadosRespostasasCria() {Resp = "d) São arquivadas para revisão futura."},
            new dadosRespostasasCria() {Resp = "e) São transformadas em apps móveis."},
            new dadosRespostasasCria() {Resp = "f) Recebem patente internacional."}
        });

        //5. Qual grupo acadêmico pode submeter propostas ao CRIA?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) Apenas alunos de pós-graduação."},
            new dadosRespostasasCria() {Resp = "b) Somente estudantes internacionais."},
            new dadosRespostasasCria() {Resp = "c) Estudantes de todas as universidades."},
            new dadosRespostasasCria() {Resp = "d) Apenas alunos do Grupo Ser Educacional."},
            new dadosRespostasasCria() {Resp = "e) Qualquer pessoa, independentemente da formação."},
            new dadosRespostasasCria() {Resp = "f) Ex-alunos com até 5 anos de formados."}
        });
        
        //6. Qual é um dos principais aspectos avaliados no embrião do projeto no CRIA?
        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "a) A originalidade do nome da empresa."},
            new dadosRespostasasCria() {Resp = "b) O design do website proposto."},
            new dadosRespostasasCria() {Resp = "c) A estratégia e plano de negócios."},
            new dadosRespostasasCria() {Resp = "d) A capacidade de produção em massa."},
            new dadosRespostasasCria() {Resp = "e) A presença nas redes sociais."},
            new dadosRespostasasCria() {Resp = "f) O histórico acadêmico do proponente."}
        });

        RespostasList.Add(new dadosRespostasasCria[]
        {
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCria() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesCria[6];

        Questões[0] = new dadosQuestõesCria() {RespQ = "d) Oferecer suporte ao empreendedorismo."};
        Questões[1] = new dadosQuestõesCria() {RespQ = "c) Mentoria digital e capacitação."};
        Questões[2] = new dadosQuestõesCria() {RespQ = "c) Primeira fase do empreendimento."};
        Questões[3] = new dadosQuestõesCria() {RespQ = "c) Passam por processo de consolidação."};
        Questões[4] = new dadosQuestõesCria() {RespQ = "d) Apenas alunos do Grupo Ser Educacional."};
        Questões[5] = new dadosQuestõesCria() {RespQ = "c) A estratégia e plano de negócios."};
    }
}

public class dadosRespostasasCria
{
    public string Resp {get; set; }
}
public class dadosQuestõesCria
{
    public string RespQ {get; set; }
}