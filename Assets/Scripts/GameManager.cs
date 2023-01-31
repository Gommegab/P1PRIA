using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{
    void Awake()
    {

        StartCoroutine(GetQuestions("https://opentdb.com/api.php?amount=10"));
    }

    IEnumerator GetQuestions(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string[] pages = uri.Split('/');
                int page = pages.Length - 1;
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
        Questions q = JsonUtility.FromJson<Questions>(jsonString);
        foreach (Question item in q.results)
        {

            Debug.Log($"Categoria : {item.category} | tipo : {item.type} | dificultad : {item.difficulty}");
            Debug.Log($"Pregunta : {item.question}");
            string txt = $" {item.correct_answer} ";
            for (int i = 0; i < item.incorrect_answers.Length; i++)
            {
                txt += ($"| {item.incorrect_answers[i]} ");
            }
            Debug.Log(txt);
            Debug.Log("__________________________________________________________________________________________________________________________________");
        }


    }
}
