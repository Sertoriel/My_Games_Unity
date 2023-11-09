using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerSpon : MonoBehaviour
{
    public List<dadosRespostasasSpon[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesSpon[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasSpon[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é o principal objetivo do SER SPONSOR?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Organizar feiras acadêmicas."},
            new dadosRespostasasSpon() {Resp = "b) Promover viagens internacionais."},
            new dadosRespostasasSpon() {Resp = "c) Conectar alunos com empresas patrocinadoras."},
            new dadosRespostasasSpon() {Resp = "d) Apresentar melhores práticas de mercado."},
            new dadosRespostasasSpon() {Resp = "e) Incentivar a criação de startups."},
            new dadosRespostasasSpon() {Resp = "f) Organizar competições entre universidades."}
        });

        //2. Como o SER SPONSOR busca enriquecer o processo de aprendizado?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Por meio de desafios práticos."},
            new dadosRespostasasSpon() {Resp = "b) Através de cursos online."},
            new dadosRespostasasSpon() {Resp = "c) Promovendo palestras internacionais."},
            new dadosRespostasasSpon() {Resp = "d) Com sessões de coaching individuais."},
            new dadosRespostasasSpon() {Resp = "e) Através da distribuição de materiais de leitura."},
            new dadosRespostasasSpon() {Resp = "f) Organizando excursões a empresas."}
        });

        //3. Quem desempenha o papel de guiar o aluno no SER SPONSOR?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Outros alunos mais experientes."},
            new dadosRespostasasSpon() {Resp = "b) Representantes do governo."},
            new dadosRespostasasSpon() {Resp = "c) Profissionais do curso ou empresas parceiras."},
            new dadosRespostasasSpon() {Resp = "d) Consultores independentes."},
            new dadosRespostasasSpon() {Resp = "e) Palestrantes convidados."},
            new dadosRespostasasSpon() {Resp = "f) Coordenadores acadêmicos."}
        });

        //4. O que o SER SPONSOR possibilita ao aluno criar?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Uma startup."},
            new dadosRespostasasSpon() {Resp = "b) Um perfil em plataformas de emprego."},
            new dadosRespostasasSpon() {Resp = "c) Uma network com profissionais de destaque."},
            new dadosRespostasasSpon() {Resp = "d) Um portfólio online."},
            new dadosRespostasasSpon() {Resp = "e) Um currículo internacional."},
            new dadosRespostasasSpon() {Resp = "f) Um projeto de pesquisa."}
        });

        //5. Como o profissional do SER SPONSOR participa do percurso acadêmico do aluno?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Avaliando as notas do aluno."},
            new dadosRespostasasSpon() {Resp = "b) Sugerindo disciplinas optativas."},
            new dadosRespostasasSpon() {Resp = "c) Atuando em atividades institucionais."},
            new dadosRespostasasSpon() {Resp = "d) Coordenando grupos de estudo."},
            new dadosRespostasasSpon() {Resp = "e) Organizando workshops."},
            new dadosRespostasasSpon() {Resp = "f) Supervisionando estágios."}
        });
        
        //6. Qual tipo de experiência o SER SPONSOR visa proporcionar ao aluno?
        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "a) Técnicas de estudo."},
            new dadosRespostasasSpon() {Resp = "b) Vivências multiculturais."},
            new dadosRespostasasSpon() {Resp = "c) Experiências inspiradoras."},
            new dadosRespostasasSpon() {Resp = "d) Habilidades de gestão de projetos."},
            new dadosRespostasasSpon() {Resp = "e) Estratégias de marketing."},
            new dadosRespostasasSpon() {Resp = "f) Técnicas de negociação."}
        });

        RespostasList.Add(new dadosRespostasasSpon[]
        {
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasSpon() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesSpon[6];

        Questões[0] = new dadosQuestõesSpon() {RespQ = "d) Apresentar melhores práticas de mercado."};
        Questões[1] = new dadosQuestõesSpon() {RespQ = "a) Por meio de desafios práticos."};
        Questões[2] = new dadosQuestõesSpon() {RespQ = "c) Profissionais do curso ou empresas parceiras."};
        Questões[3] = new dadosQuestõesSpon() {RespQ = "c) Uma network com profissionais de destaque."};
        Questões[4] = new dadosQuestõesSpon() {RespQ = "c) Atuando em atividades institucionais."};
        Questões[5] = new dadosQuestõesSpon() {RespQ = "c) Experiências inspiradoras."};
    }
}

public class dadosRespostasasSpon
{
    public string Resp {get; set; }
}
public class dadosQuestõesSpon
{
    public string RespQ {get; set; }
}