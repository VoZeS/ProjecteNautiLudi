using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAllNews : MonoBehaviour
{
    public List<News> newsList;
    public List<NewsObject> newsObjects = new List<NewsObject>();

    [System.Serializable]
    private class NewsList
    {
        public List<News> news;
    }

    private void Start()
    {
        // Leer el archivo JSON
        string json = File.ReadAllText(Application.persistentDataPath + "/newsData.json");

        Debug.Log(json);

        try
        {
            // Deserializar el JSON a una lista de noticias
            NewsList newsData = JsonUtility.FromJson<NewsList>(json);
            newsList = newsData.news;
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error al deserializar JSON: " + e.Message);
        }

        // Asignar noticias aleatorias a tus Game Objects de tipo News
        AssignRandomNews();
    }

    private void AssignRandomNews()
    {
        if (newsList != null && newsList.Count > 0)
        {
            foreach (NewsObject newsObject in newsObjects)
            {
                // Selecciona una noticia aleatoria
                News randomNews = newsList[Random.Range(0, newsList.Count)];

                // Asigna los datos de la noticia al GameObject
                newsObject.DisplayNews(randomNews);
                newsObject.GetNewsData(randomNews);
            }
        }
        else
        {
            Debug.LogWarning("La lista de noticias está vacía o no ha sido inicializada.");
        }
    }
}

