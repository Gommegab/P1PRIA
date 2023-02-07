using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{
    public Question question;
    public int solicitadas=10;
    private Questions questions;

    void Awake()
    {
         StartCoroutine(GetQuestions($"https://opentdb.com/api.php?amount={solicitadas}"));
    }
    
    IEnumerator GetQuestions(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                LoadJson(webRequest.downloadHandler.text);
            }
            else
            {
                Debug.Log("No se puede conectar con la api");
            }
        }
    }

    public void LoadJson(string jsonString)
    {
        questions = JsonUtility.FromJson<Questions>(jsonString);
        question = questions.results[0];
        Debug.Log($"Preguntas solicidas a la api:{solicitadas}");
        Debug.Log($"Categoria : {question.category} | tipo : {question.type} | dificultad : {question.difficulty}");
        Debug.Log($"Pregunta : {question.question}");
    }
}
