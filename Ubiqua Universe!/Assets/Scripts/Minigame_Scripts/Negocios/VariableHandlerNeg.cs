using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerNeg : MonoBehaviour
{
    public List<dadosRespostasasNeg[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesNeg[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasNeg[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é a principal proposta da Escola de Negócios?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Oferecer cursos de idiomas."},
            new dadosRespostasasNeg() {Resp = "b) Realizar feiras de carreira."},
            new dadosRespostasasNeg() {Resp = "c) Formar empreendedores remotamente."},
            new dadosRespostasasNeg() {Resp = "d) Promover aulas presenciais."},
            new dadosRespostasasNeg() {Resp = "e) Organizar eventos esportivos."},
            new dadosRespostasasNeg() {Resp = "f) Certificar em tecnologia."}
        });

        //2. Qual é o objetivo da Escola de Negócios em relação à formação acadêmica?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Substituir o currículo tradicional."},
            new dadosRespostasasNeg() {Resp = "b) Integrar com a vivência de mercado."},
            new dadosRespostasasNeg() {Resp = "c) Oferecer apenas cursos gratuitos."},
            new dadosRespostasasNeg() {Resp = "d) Priorizar áreas de humanas."},
            new dadosRespostasasNeg() {Resp = "e) Enfatizar práticas esportivas."},
            new dadosRespostasasNeg() {Resp = "f) Desenvolver habilidades artísticas."}
        });

        //3. A Escola de Negócios tem foco em qual tipo de aprendizado?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Aprendizado prático."},
            new dadosRespostasasNeg() {Resp = "b) Aprendizado teórico."},
            new dadosRespostasasNeg() {Resp = "c) Aprendizado disruptivo."},
            new dadosRespostasasNeg() {Resp = "d) Aprendizado histórico."},
            new dadosRespostasasNeg() {Resp = "e) Aprendizado linguístico."},
            new dadosRespostasasNeg() {Resp = "f) Aprendizado artístico."}
        });

        //4. A quem a Escola de Negócios atende primariamente?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Alunos do ensino médio."},
            new dadosRespostasasNeg() {Resp = "b) Profissionais aposentados."},
            new dadosRespostasasNeg() {Resp = "c) Alunos de graduação e pós-graduação."},
            new dadosRespostasasNeg() {Resp = "d) Alunos do ensino fundamental."},
            new dadosRespostasasNeg() {Resp = "e) Turistas e visitantes."},
            new dadosRespostasasNeg() {Resp = "f) Professores e educadores."}
        });

        //5. A Escola de Negócios está associada a qual grupo educacional?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Grupo de Estudos Avançados."},
            new dadosRespostasasNeg() {Resp = "b) Grupo de Educação Internacional."},
            new dadosRespostasasNeg() {Resp = "c) Grupo Estrela do Saber."},
            new dadosRespostasasNeg() {Resp = "d) Grupo Mundo Educativo."},
            new dadosRespostasasNeg() {Resp = "e) Grupo Ser Educacional."},
            new dadosRespostasasNeg() {Resp = "f) Grupo Conhecimento Sem Fronteiras."}
        });
        
        //6. Qual é o modo principal de oferta dos cursos da Escola de Negócios?
        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "a) Aulas presenciais."},
            new dadosRespostasasNeg() {Resp = "b) Aulas ao ar livre."},
            new dadosRespostasasNeg() {Resp = "c) Formação remota e digital."},
            new dadosRespostasasNeg() {Resp = "d) Seminários mensais."},
            new dadosRespostasasNeg() {Resp = "e) Aulas em estúdios de TV."},
            new dadosRespostasasNeg() {Resp = "f) Webinars semanais."}
        });

        RespostasList.Add(new dadosRespostasasNeg[]
        {
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasNeg() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesNeg[6];

        Questões[0] = new dadosQuestõesNeg() {RespQ = "c) Formar empreendedores remotamente."};
        Questões[1] = new dadosQuestõesNeg() {RespQ = "b) Integrar com a vivência de mercado."};
        Questões[2] = new dadosQuestõesNeg() {RespQ = "c) Aprendizado disruptivo."};
        Questões[3] = new dadosQuestõesNeg() {RespQ = "c) Alunos de graduação e pós-graduação."};
        Questões[4] = new dadosQuestõesNeg() {RespQ = "e) Grupo Ser Educacional."};
        Questões[5] = new dadosQuestõesNeg() {RespQ = "c) Formação remota e digital."};
    }
}

public class dadosRespostasasNeg
{
    public string Resp {get; set; }
}
public class dadosQuestõesNeg
{
    public string RespQ {get; set; }
}