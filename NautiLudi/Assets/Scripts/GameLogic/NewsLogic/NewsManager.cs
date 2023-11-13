using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewsManager : MonoBehaviour
{
    [System.Serializable]
    private class NewsList
    {
        public List<News> news;
    }

    public List<News> newsList;

    private void Start()
    {

        newsList = new List<News>
        {
            // ------------------------------------------------------ Noticia 1
            new News { title = "Aturada de taxistes al centre de Barcelona per protestar per la mort d'un company agredit.",
                shortDescription = "Centenars de taxis han tallat aquest dimecres els carrils centrals del passeig de Gràcia i de la Gran Via de Barcelona per l'aturada del sector entre les 10 i les 12.",
                extendedDescription = "El taxista va morir a l'Hospital Clínic de Barcelona a causa de les greus lesions. Tenia 53 anys i s'havia intercanviat el torn aquella nit amb la seva neboda, amb qui compartia el taxi.\n" +
                "El sindicat que ha convocat l'acció, Élite Taxi, demana que s'imputi a l'agressor un delicte d'homicidi i que ingressi a presó.\n" +
                "L'agressió mortal es va produir quan el taxista i el motorista van tenir una discussió de trànsit.",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://www.ccma.cat/324/aturada-de-taxistes-al-centre-de-barcelona-per-protestar-per-la-mort-dun-company-agredit/noticia/3259662/",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 1,
                moneyCost = 125,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 2
            new News { title = "Noticia 2",
                shortDescription = "Descripción corta 2",
                extendedDescription = "Descripción larga 2",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia2",
                socialValue = 2,
                sportsValue = 2,
                internationalValue = 2,
                moneyCost = 200,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 3
            new News { title = "Noticia 3",
                shortDescription = "Descripción corta 3",
                extendedDescription = "Descripción larga 3",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia3",
                socialValue = 3,
                sportsValue = 3,
                internationalValue = 3,
                moneyCost = 300,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 4
            new News { title = "Noticia 4",
                shortDescription = "Descripción corta 4",
                extendedDescription = "Descripción larga 4",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia4",
                socialValue = 1,
                sportsValue = 2,
                internationalValue = 3,
                moneyCost = 150,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 5
            new News { title = "Noticia 5",
                shortDescription = "Descripción corta 5",
                extendedDescription = "Descripción larga 5",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia5",
                socialValue = 3,
                sportsValue = 2,
                internationalValue = 1,
                moneyCost = 200,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 6
            new News { title = "Noticia 6",
                shortDescription = "Descripción corta 6",
                extendedDescription = "Descripción larga 6",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia6",
                socialValue = 3,
                sportsValue = 2,
                internationalValue = 2,
                moneyCost = 300,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 7
            new News { title = "Noticia 7",
                shortDescription = "Descripción corta 7",
                extendedDescription = "Descripción larga 7",
                newsImage = "Sprites/NewsImages/ImageNew1",
                url = "https://ejemplo.com/noticia7",
                socialValue = 3,
                sportsValue = 3,
                internationalValue = 2,
                moneyCost = 100,
                isBlocked = true},

            
        };


        NewsList newsData = new NewsList { news = newsList };
        string json = JsonConvert.SerializeObject(newsData, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/newsData.json", json);
    }

}