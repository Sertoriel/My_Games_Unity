using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerOsg : MonoBehaviour
{
    public List<dadosRespostasasOsg[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesOsg[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasOsg[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. O que é o OSGA?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Uma plataforma de streaming."},
            new dadosRespostasasOsg() {Resp = "b) Um curso de produção audiovisual."},
            new dadosRespostasasOsg() {Resp = "c) Uma universidade especializada."},
            new dadosRespostasasOsg() {Resp = "d) Festival de vídeos universitários."},
            new dadosRespostasasOsg() {Resp = "e) Uma rede social para alunos."},
            new dadosRespostasasOsg() {Resp = "f) Uma revista acadêmica."}
        });

        //2. Qual é o objetivo principal do OSGA neste ano?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Reduzir o número de inscrições."},
            new dadosRespostasasOsg() {Resp = "b) Expandir produção audiovisual."},
            new dadosRespostasasOsg() {Resp = "c) Priorizar filmes internacionais."},
            new dadosRespostasasOsg() {Resp = "d) Organizar feiras de cinema."},
            new dadosRespostasasOsg() {Resp = "e) Focar em publicidade."},
            new dadosRespostasasOsg() {Resp = "f) Desenvolver roteiros."}
        });

        //3. Onde os vídeos do OSGA são exibidos?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Apenas online."},
            new dadosRespostasasOsg() {Resp = "b) Em auditórios universitários."},
            new dadosRespostasasOsg() {Resp = "c) Salas de cinema tradicionais."},
            new dadosRespostasasOsg() {Resp = "d) Em feiras ao ar livre."},
            new dadosRespostasasOsg() {Resp = "e) Plataformas de vídeo por demanda."},
            new dadosRespostasasOsg() {Resp = "f) Em museus."}
        });

        //4. Qual grupo de estudantes o OSGA visa atender?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Grupo Aprendizado Global."},
            new dadosRespostasasOsg() {Resp = "b) Grupo Visualize."},
            new dadosRespostasasOsg() {Resp = "c) Grupo Ser Educacional."},
            new dadosRespostasasOsg() {Resp = "d) Grupo Cinefilia."},
            new dadosRespostasasOsg() {Resp = "e) Grupo Luz & Ação."},
            new dadosRespostasasOsg() {Resp = "f) Grupo Cinema Pioneiro."}
        });

        //5. O que o OSGA promove além da exibição de vídeos?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Festas de gala."},
            new dadosRespostasasOsg() {Resp = "b) Passeios turísticos."},
            new dadosRespostasasOsg() {Resp = "c) Cursos de idioma."},
            new dadosRespostasasOsg() {Resp = "d) Capacitações e premiações."},
            new dadosRespostasasOsg() {Resp = "e) Acampamentos estudantis."},
            new dadosRespostasasOsg() {Resp = "f) Aulas de teatro."}
        });
        
        //6. Qual é uma característica valorizada pelo festival OSGA?
        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "a) Utilização de equipamento caro."},
            new dadosRespostasasOsg() {Resp = "b) Duração mínima de 2 horas."},
            new dadosRespostasasOsg() {Resp = "c) Diversidades regionais."},
            new dadosRespostasasOsg() {Resp = "d) Filmes apenas em preto e branco."},
            new dadosRespostasasOsg() {Resp = "e) Narrativas ficcionais."},
            new dadosRespostasasOsg() {Resp = "f) Uso extensivo de efeitos especiais."}
        });

        RespostasList.Add(new dadosRespostasasOsg[]
        {
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasOsg() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesOsg[6];

        Questões[0] = new dadosQuestõesOsg() {RespQ = "d) Festival de vídeos universitários."};
        Questões[1] = new dadosQuestõesOsg() {RespQ = "b) Expandir produção audiovisual."};
        Questões[2] = new dadosQuestõesOsg() {RespQ = "c) Salas de cinema tradicionais."};
        Questões[3] = new dadosQuestõesOsg() {RespQ = "c) Grupo Ser Educacional."};
        Questões[4] = new dadosQuestõesOsg() {RespQ = "d) Capacitações e premiações."};
        Questões[5] = new dadosQuestõesOsg() {RespQ = "c) Diversidades regionais."};
    }
}

public class dadosRespostasasOsg
{
    public string Resp {get; set; }
}
public class dadosQuestõesOsg
{
    public string RespQ {get; set; }
}