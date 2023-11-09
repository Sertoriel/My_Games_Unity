using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHandler : MonoBehaviour
{
    public List<dadosRespostasas[]> RespostasList;  // Uma lista de arrays de respostas
    public dadosQuestões[] Questões;

    void Start()
    {

        
        RespostasList = new List<dadosRespostasas[]>();  // Inicializando a lista

        // Adicionando o primeiro conjunto de respostas

        // 1. Qual é o principal objetivo do projeto "CRIA - Incubadora Digital"?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Avaliar negócios já estabelecidos no mercado."},
            new dadosRespostasas() {Resp = "b) Oferecer oficinas de artesanato para interessados."},
            new dadosRespostasas() {Resp = "c) Fornecer suporte completo para o desenvolvimento de novos negócios."},
            new dadosRespostasas() {Resp = "d) Ajudar alunos a encontrar estágios em empresas parceiras."},
            new dadosRespostasas() {Resp = "e) Promover competições esportivas para empreendedores."},
            new dadosRespostasas() {Resp = "f) Financiar totalmente a ideia do aluno."}
        });

        //2. Quais são algumas das modalidades de capacitação oferecidas pelo projeto?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Aulas de yoga e meditação."},
            new dadosRespostasas() {Resp = "b) Oficinas, minicursos e mentoria digital."},
            new dadosRespostasas() {Resp = "c) Cursos de culinária e gastronomia."},
            new dadosRespostasas() {Resp = "d) Programas de intercâmbio internacional."},
            new dadosRespostasas() {Resp = "e) Visitas técnicas a indústrias."},
            new dadosRespostasas() {Resp = "f) Treinamento físico para empreendedores."}
        });

        //3. Quem pode submeter propostas ao CRIA?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Apenas alunos formados."},
            new dadosRespostasas() {Resp = "b) Profissionais do mercado sem relação com a academia."},
            new dadosRespostasas() {Resp = "c) Alunos de todas as instituições de ensino superior do grupo Ser."},
            new dadosRespostasas() {Resp = "d) Somente professores das instituições parceiras."},
            new dadosRespostasas() {Resp = "e) Empreendedores de sucesso para compartilhar suas experiências."},
            new dadosRespostasas() {Resp = "f) Apenas alunos do último ano."}
        });

        //4. Qual é a primeira fase das atividades empreendedoras no CRIA?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Financiamento completo da ideia."},
            new dadosRespostasas() {Resp = "b) Implementação imediata da empresa."},
            new dadosRespostasas() {Resp = "c) Processo de consolidação, conhecido como embrião."},
            new dadosRespostasas() {Resp = "d) Cursos avançados sobre gestão empresarial."},
            new dadosRespostasas() {Resp = "e) Feira de apresentação para investidores."},
            new dadosRespostasas() {Resp = "f) Construção da sede da empresa."}
        });

        //5. O que é avaliado no processo de consolidação do CRIA?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Capacidades físicas do empreendedor."},
            new dadosRespostasas() {Resp = "b) A quantia de capital que o aluno possui."},
            new dadosRespostasas() {Resp = "c) Avaliação profissional do empreendedor e desenvolvimento de estratégia e plano de negócios."},
            new dadosRespostasas() {Resp = "d) Análise da presença online da ideia nas redes sociais."},
            new dadosRespostasas() {Resp = "e) Teste de aptidão técnica."},
            new dadosRespostasas() {Resp = "f) Capacidade do aluno de apresentar em diferentes línguas."}
        });
        
        //6. O CRIA foca em qual etapa do empreendedorismo?
        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "a) Expansão internacional."},
            new dadosRespostasas() {Resp = "b) Fase inicial, ajudando a formatar e consolidar ideias."},
            new dadosRespostasas() {Resp = "c) Venda e liquidação de negócios."},
            new dadosRespostasas() {Resp = "d) Parcerias com grandes corporações."},
            new dadosRespostasas() {Resp = "e) Promoção de eventos de networking."},
            new dadosRespostasas() {Resp = "f) Análise avançada de riscos."}
        });

        RespostasList.Add(new dadosRespostasas[]
        {
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"},
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"},
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"},
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"},
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"},
            new dadosRespostasas() {Resp = "Toque duas vezes para SAIR"}
        });

        // Adicionando o segundo conjunto de respostas

        // Continue adicionando mais conforme necessário...

        Questões = new dadosQuestões[6];

        Questões[0] = new dadosQuestões() {RespQ = "c) Fornecer suporte completo para o desenvolvimento de novos negócios."};
        Questões[1] = new dadosQuestões() {RespQ = "b) Oficinas, minicursos e mentoria digital."};
        Questões[2] = new dadosQuestões() {RespQ = "c) Alunos de todas as instituições de ensino superior do grupo Ser."};
        Questões[3] = new dadosQuestões() {RespQ = "c) Processo de consolidação, conhecido como embrião."};
        Questões[4] = new dadosQuestões() {RespQ = "c) Avaliação profissional do empreendedor e desenvolvimento de estratégia e plano de negócios."};
        Questões[5] = new dadosQuestões() {RespQ = "b) Fase inicial, ajudando a formatar e consolidar ideias."};
    }
}

public class dadosRespostasas
{
    public string Resp {get; set; }
}
public class dadosQuestões
{
    public string RespQ {get; set; }
}