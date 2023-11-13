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
            new News { 
                // 90 caracters
                title = "Aturada de taxistes al centre de Barcelona per protestar per la mort d'un company agredit.",
                // 120 caracters
                shortDescription = "Centenars de taxis han tallat aquest dimecres els carrils centrals del passeig de Gràcia i de la Gran Via de Barcelona.",
                // 415 caracters
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
            new News { 
                // 90 caracters
                title = "Junts i PSOE tanquen un acord per a la investidura que inclou l'amnistia i casos de lawfare.",
                //120 caracters
                shortDescription = "Junts i PSOE han tancat finalment aquesta matinada de dimecres a dijous un acord per a la investidura de Pedro Sánchez.",
                //415 caracters
                extendedDescription = "Els membres del secretariat permanent de Junts estan anant ara cap a Brussel·les, on a les deu del matí estan convocats en una reunió d'urgència per analitzar els termes de l'acord.\n" +
                "Els equips dels dos partits havien pitjat l'accelerador les últimes hores de dimecres i els socialistes creien que l'acord seria imminent, mentre  que Junts guardava silenci però evitava desmentir-ho. ",
                newsImage = "Sprites/NewsImages/ImageNew2",
                url = "https://www.ccma.cat/324/psoe-i-junts-ultimen-lacord-per-a-la-investidura-que-es-podria-anunciar-les-proximes-hores/noticia/3259833/",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 2,
                moneyCost = 150,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 3
            new News { 
                // 90 caracters
                title = "Dimiteix el primer ministre de Portugal, António Costa, investigat per un cas de corrupció.",
                // 120 caracters
                shortDescription = "El primer ministre portuguès, António Costa, ha dimitit després que la Fiscalia l'hagi inclòs en una investigació.",
                // 415 caracters
                extendedDescription = "La investigació se centra en les concessions d'explotació de liti en les mines de Romano i Barroso, al nord del país, i en un projecte d'una central de producció d'energia a partir de l'hidrogen a Sines i un altre per a la construcció d'un centre de dades en el mateix indret.\n" +
                "'No he comès cap delicte. Estic disponible per col·laborar amb la justícia en tot el que calgui per escatir tota la veritat'.",
                newsImage = "Sprites/NewsImages/ImageNew3",
                url = "https://www.ccma.cat/324/dimiteix-el-primer-ministre-de-portugal-antonio-costa-investigat-per-un-cas-de-corrupcio/noticia/3259545/",
                socialValue = 2,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 150,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 4
            new News { 
                // 90 caracters
                title = "Denuncien vuit supermercats per un possible pacte de preus de l'oli d'oliva.",
                // 120 caracters
                shortDescription = "Aquest mes la mateixa ampolla havia pujat fins a 9,25 euros. Gairebé un 9% més car.",
                // 415 caracters
                extendedDescription = "La pujada de preu de la resta d'envasos és similar en totes les marques. Per aquest motiu, des de FACUA denuncien que no es tracta de pujades en cadena per un augment dels preus d'origen, sinó que podria ser 'una estratègia de fixar preus'.\n" +
                "L'associació de consumidors ha portat el cas al Ministeri de Consum, com ja hi ha elevat els últims mesos els casos d'aliments afectats per la rebaixa de l'IVA perquè ho investigui.",
                newsImage = "Sprites/NewsImages/ImageNew4",
                url = "https://www.ccma.cat/324/denuncien-vuit-supermercats-per-un-possible-pacte-de-preus-de-loli-doliva/noticia/3259812/ ",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 1,
                moneyCost = 125,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 5
            new News { 
                // 90 caracters
                title = "Nintendo anuncia una nova pel·lícula: 'The Legend of Zelda' arribarà a la gran pantalla.",
                // 120 caracters
                shortDescription = "Nintendo ha anunciat aquest dimecres que ja ha començat a treballar en una pel·lícula d'acció real de la franquícia 'The Legend of Zelda'.",
                // 415 caracters
                extendedDescription = "L'empresa japonesa ha confirmat, en un comunicat, que el film estarà produït per Shigeru Miyamoto, dissenyador i productor de videojocs i creador de sagues com Super Mario, Donkey Kong o el mateix Zelda, i Avi Arad, productor de cintes com 'Iron Man', 'Uncharted' o 'Spider-Man: Into the Spider-Verse'.\n" +
                "La companyia ha informat que la pel·lícula estarà produïda conjuntament amb Arad Productions i dirigida per Wes Ball.",
                newsImage = "Sprites/NewsImages/ImageNew5",
                url = "https://www.ccma.cat/324/nintendo-anuncia-una-nova-pellicula-the-legend-of-zelda-arribara-a-la-gran-pantalla/noticia/3259854/",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 175,
                isBlocked = true},

            // ------------------------------------------------------ Noticia 6
            new News {
                // 90 caracters
                title = "Astronautes de l'EEI perden una caixa d'eines a l'espai que ara orbita la Terra.",
                // 120 caracters
                shortDescription = "Dues astronautes de l'Estació Espacial Internacional (EEI) que estaven fent tasques de manteniment fora de la nau van tenir un petit contratemps.",
                // 415 caracters
                extendedDescription = "Després d'analitzar la trajectòria de la caixa extraviada, es va poder determinar que el risc de col·lisió amb la nau era baix i poc perillós.\n" +
                "La caixa d'eines, doncs, continua a l'espai, on estarà en òrbita al voltant de la Terra durant uns mesos fins que, a mesura que vagi perdent alçada, acabarà desintegrant-se a l'atmosfera terrestre.",
                newsImage = "Sprites/NewsImages/ImageNew6",
                url = "https://www.ccma.cat/324/astronautes-de-leei-perden-una-caixa-deines-a-lespai-que-ara-orbita-la-terra/noticia/3259676/",
                socialValue = 1,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 125,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 7
            new News { 
                // 90 caracters
                title = "L'exèrcit d'Israel diu que és al centre de Ciutat de Gaza i intenta inutilitzar túnels de Hamas.",
                // 120 caracters
                shortDescription = "L'exèrcit israelià ha assegurat que ja ha arribat al centre de la ciutat de Gaza, que està completament encerclada per les seves forces.",
                // 415 caracters
                extendedDescription = "Segons Israel, aquesta xarxa de túnels té centenars de quilòmetres per sota de la Franja de Gaza, però Hamas ha assegurat que l'exèrcit israelià no ha aconseguit cap objectiu important, a banda de matar civils." +
                "Mentrestant, la Creu Roja ha denunciat que un dels seus combois amb material mèdic ha estat atacat quan es dirigia a l'Hospital Al-Shifa, el més important de Gaza.",
                newsImage = "Sprites/NewsImages/ImageNew7",
                url = "https://www.ccma.cat/324/lexercit-disrael-diu-que-es-al-centre-de-ciutat-de-gaza-i-intenta-inutilitzar-tunels-de-hamas/noticia/3259642/",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 175,
                isBlocked = true},

            
        };


        NewsList newsData = new NewsList { news = newsList };
        string json = JsonConvert.SerializeObject(newsData, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/newsData.json", json);
    }

}