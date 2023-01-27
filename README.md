# P1PRIA
P1.0 Chamada a API e serialización JSON
Neste exercicio utilizando UnityWebRequest, JSONUtility e corutinas deberás chamar á API:
___

https://opentdb.com/

Solicitando 10 preguntas.

Esta API devolve un JSON que deberás serializar, creando as clases que coincidan coa estructura do JSON.

### JSON
~~~
{
    "response_code": 0,
    "results": [
        {
            "category": "Entertainment: Video Games",
            "type": "multiple",
            "difficulty": "hard",
            "question": "In the Kingdom Hearts series, which is not an optional boss you can fight?",
            "correct_answer": "Master Yen Sid",
            "incorrect_answers": [
                "Sephiroth",
                "Julius",
                "Kurt Zisa"
            ]
        }
    ]
}
~~~
___

Crea a variable cos datos como un atributo público do script principal. Imprime na consola o número de preguntas solicitadas e 4 datos da primeira pregunta.

Entregables:

* ### Enlace ao repositorio GitHub co proxecto
 1. Avaliarase o código que esté no último commit da rama main
 2. O fluxo de traballo será na rama develop, únicamente engadindo contido a esta rama mediante PRs de outras ramas
 3. É necesario utilizar git ao longo do tempo, non se admitirá un único commit a última hora nin todos os commits no último día ás presas. Mellor ir equivocándose e cambiando cousas que subir todo á última hora.
* ### Os 3 ficheiros .cs do proxecto (Script principal, clase da resposta, clase da pregunta)
