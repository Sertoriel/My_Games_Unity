using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerExp : MonoBehaviour
{
    public List<dadosRespostasasExp[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesExp[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasExp[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é o objetivo principal do Ser Experience?
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Promover feiras acadêmicas."},
            new dadosRespostasasExp() {Resp = "b) Incentivar viagens internacionais."},
            new dadosRespostasasExp() {Resp = "c) Organizar workshops técnicos."},
            new dadosRespostasasExp() {Resp = "d) Proporcionar aprendizagem imersiva conectada ao Brasil."},
            new dadosRespostasasExp() {Resp = "e) Criar competições estudantis."},
            new dadosRespostasasExp() {Resp = "f) Estabelecer parcerias com universidades estrangeiras."}
        });

        //2. O que diferencia o Ser Experience de outras iniciativas educacionais?
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Foco exclusivo em pesquisa avançada."},
            new dadosRespostasasExp() {Resp = "b) Uso intensivo de realidade virtual."},
            new dadosRespostasasExp() {Resp = "c) Visitas guiadas e desafios interativos virtuais."},
            new dadosRespostasasExp() {Resp = "d) Promoção de eventos culturais."},
            new dadosRespostasasExp() {Resp = "e) Interação apenas com especialistas locais."},
            new dadosRespostasasExp() {Resp = "f) Cursos online padrão."}
        });

        //3. Como o Ser Experience se relaciona com as regiões do Brasil?
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Concentra-se apenas na região Sudeste."},
            new dadosRespostasasExp() {Resp = "b) Propõe desafios a partir de todas as regiões."},
            new dadosRespostasasExp() {Resp = "c) Realiza eventos presenciais em capitais."},
            new dadosRespostasasExp() {Resp = "d) Oferece cursos especializados por região."},
            new dadosRespostasasExp() {Resp = "e) Promove viagens de campo."},
            new dadosRespostasasExp() {Resp = "f) Organiza feiras regionais."}
        });

        //4. O Ser Experience é caracterizado por qual tipo de rede?
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Uma rede de universidades internacionais."},
            new dadosRespostasasExp() {Resp = "b) Uma rede de startups e empreendedores."},
            new dadosRespostasasExp() {Resp = "c) Uma rede colaborativa entre alunos e professores."},
            new dadosRespostasasExp() {Resp = "d) Uma rede de patrocinadores e investidores."},
            new dadosRespostasasExp() {Resp = "e) Uma rede de serviços de tutoria."},
            new dadosRespostasasExp() {Resp = "f) Uma rede de plataformas de ensino à distância."}
        });

        //5. Que tipo de interação o Ser Experience promove?
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Apenas aulas teóricas."},
            new dadosRespostasasExp() {Resp = "b) Interações apenas com especialistas da área."},
            new dadosRespostasasExp() {Resp = "c) Atividades em universos de pesquisa e ambientes naturais."},
            new dadosRespostasasExp() {Resp = "d) Estágios em empresas parceiras."},
            new dadosRespostasasExp() {Resp = "e) Workshops sobre inovação e tecnologia."},
            new dadosRespostasasExp() {Resp = "f) Palestras motivacionais."}
        });
        
        //6. No Ser Experience, o aluno é incentivado a ser...
        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "a) Apenas um observador."},
            new dadosRespostasasExp() {Resp = "b) Um participante passivo."},
            new dadosRespostasasExp() {Resp = "c) Exclusivamente um pesquisador."},
            new dadosRespostasasExp() {Resp = "d) Integração com equipes internacionais."},
            new dadosRespostasasExp() {Resp = "e) Integral e participativo."},
            new dadosRespostasasExp() {Resp = "f) Um orador e apresentador."}
        });

        RespostasList.Add(new dadosRespostasasExp[]
        {
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasExp() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesExp[6];

        Questões[0] = new dadosQuestõesExp() {RespQ = "d) Proporcionar aprendizagem imersiva conectada ao Brasil."};
        Questões[1] = new dadosQuestõesExp() {RespQ = "c) Visitas guiadas e desafios interativos virtuais."};
        Questões[2] = new dadosQuestõesExp() {RespQ = "b) Propõe desafios a partir de todas as regiões."};
        Questões[3] = new dadosQuestõesExp() {RespQ = "c) Uma rede colaborativa entre alunos e professores."};
        Questões[4] = new dadosQuestõesExp() {RespQ = "c) Atividades em universos de pesquisa e ambientes naturais."};
        Questões[5] = new dadosQuestõesExp() {RespQ = "e) Integral e participativo."};
    }
}

public class dadosRespostasasExp
{
    public string Resp {get; set; }
}
public class dadosQuestõesExp
{
    public string RespQ {get; set; }
}