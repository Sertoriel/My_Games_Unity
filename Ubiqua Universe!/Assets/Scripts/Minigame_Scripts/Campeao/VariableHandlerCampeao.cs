using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandlerCampeao : MonoBehaviour
{
    public List<dadosRespostasasCamp[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestõesCamp[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasasCamp[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é o principal objetivo do projeto "Ser Campeão"?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Realizar competições esportivas para alunos."},
            new dadosRespostasasCamp() {Resp = "b) Oferecer treinamento físico para estudantes."},
            new dadosRespostasasCamp() {Resp = "c) Compartilhar histórias inspiradoras de superação."},
            new dadosRespostasasCamp() {Resp = "d) Organizar festivais de música e arte."},
            new dadosRespostasasCamp() {Resp = "e) Fornecer aulas de yoga e meditação."},
            new dadosRespostasasCamp() {Resp = "f) Incentivar o estudo de línguas estrangeiras."}
        });

        //2. Como o projeto "Ser Campeão" é apresentado aos alunos?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Através de livros didáticos."},
            new dadosRespostasasCamp() {Resp = "b) Em aulas de educação física."},
            new dadosRespostasasCamp() {Resp = "c) Em eventos temáticos realizados remotamente."},
            new dadosRespostasasCamp() {Resp = "d) Através de reuniões presenciais obrigatórias."},
            new dadosRespostasasCamp() {Resp = "e) Via podcasts e transmissões de rádio."},
            new dadosRespostasasCamp() {Resp = "f) Por meio de campeonatos esportivos locais."}
        });

        //3. Além de compartilhar histórias, o que mais o projeto "Ser Campeão" apoia?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Produção de filmes documentários."},
            new dadosRespostasasCamp() {Resp = "b) Exibições de arte e escultura."},
            new dadosRespostasasCamp() {Resp = "c) Desenvolvimento de videogames."},
            new dadosRespostasasCamp() {Resp = "d) Viagens de estudo ao exterior."},
            new dadosRespostasasCamp() {Resp = "e) Práticas esportivas para atletas de alta performance."},
            new dadosRespostasasCamp() {Resp = "f) Cursos de culinária e nutrição."}
        });

        //4. Para quem o projeto "Ser Campeão" oferece incentivo esportivo?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Para todos os alunos interessados em esportes."},
            new dadosRespostasasCamp() {Resp = "b) Apenas para alunos do último ano."},
            new dadosRespostasasCamp() {Resp = "c) Para professores e funcionários da instituição."},
            new dadosRespostasasCamp() {Resp = "d) Para atletas de alta performance que também são estudantes."},
            new dadosRespostasasCamp() {Resp = "e) Para pais e responsáveis dos alunos."},
            new dadosRespostasasCamp() {Resp = "f) Para convidados e palestrantes externos."}
        });

        //5. Por que o projeto "Ser Campeão" é considerado importante?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Porque promove o espírito competitivo entre os alunos."},
            new dadosRespostasasCamp() {Resp = "b) Porque valoriza e reconhece histórias de superação."},
            new dadosRespostasasCamp() {Resp = "c) Porque aumenta as taxas de matrícula na instituição."},
            new dadosRespostasasCamp() {Resp = "d) Porque incentiva a adoção de um estilo de vida saudável."},
            new dadosRespostasasCamp() {Resp = "e) Porque proporciona bolsas de estudo para os participantes."},
            new dadosRespostasasCamp() {Resp = "f) Porque amplia a presença da instituição nas redes sociais."}
        });
        
        //6. De que forma os alunos contribuem para o projeto "Ser Campeão"?
        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "a) Vendendo ingressos para os eventos."},
            new dadosRespostasasCamp() {Resp = "b) Competindo em torneios esportivos."},
            new dadosRespostasasCamp() {Resp = "c) Abordando suas histórias pessoais de superação."},
            new dadosRespostasasCamp() {Resp = "d) Organizando campanhas de arrecadação de fundos."},
            new dadosRespostasasCamp() {Resp = "e) Criando peças de arte para exibição."},
            new dadosRespostasasCamp() {Resp = "f) Traduzindo materiais para outras línguas."}
        });

        RespostasList.Add(new dadosRespostasasCamp[]
        {
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"},
            new dadosRespostasasCamp() {Resp = "Precione Q para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestõesCamp[6];

        Questões[0] = new dadosQuestõesCamp() {RespQ = "c) Compartilhar histórias inspiradoras de superação."};
        Questões[1] = new dadosQuestõesCamp() {RespQ = "c) Em eventos temáticos realizados remotamente."};
        Questões[2] = new dadosQuestõesCamp() {RespQ = "e) Práticas esportivas para atletas de alta performance."};
        Questões[3] = new dadosQuestõesCamp() {RespQ = "d) Para atletas de alta performance que também são estudantes."};
        Questões[4] = new dadosQuestõesCamp() {RespQ = "b) Porque valoriza e reconhece histórias de superação."};
        Questões[5] = new dadosQuestõesCamp() {RespQ = "c) Abordando suas histórias pessoais de superação."};
    }
}

public class dadosRespostasasCamp
{
    public string Resp {get; set; }
}
public class dadosQuestõesCamp
{
    public string RespQ {get; set; }
}