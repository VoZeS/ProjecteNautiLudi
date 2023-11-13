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
                shortDescription = "Centenars de taxis han tallat aquest dimecres els carrils centrals del passeig de Gr�cia i de la Gran Via de Barcelona.",
                // 415 caracters
                extendedDescription = "El taxista va morir a l'Hospital Cl�nic de Barcelona a causa de les greus lesions. Tenia 53 anys i s'havia intercanviat el torn aquella nit amb la seva neboda, amb qui compartia el taxi.\n" +
                "El sindicat que ha convocat l'acci�, �lite Taxi, demana que s'imputi a l'agressor un delicte d'homicidi i que ingressi a pres�.\n" +
                "L'agressi� mortal es va produir quan el taxista i el motorista van tenir una discussi� de tr�nsit.",
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
                shortDescription = "Junts i PSOE han tancat finalment aquesta matinada de dimecres a dijous un acord per a la investidura de Pedro S�nchez.",
                //415 caracters
                extendedDescription = "Els membres del secretariat permanent de Junts estan anant ara cap a Brussel�les, on a les deu del mat� estan convocats en una reuni� d'urg�ncia per analitzar els termes de l'acord.\n" +
                "Els equips dels dos partits havien pitjat l'accelerador les �ltimes hores de dimecres i els socialistes creien que l'acord seria imminent, mentre� que Junts guardava silenci per� evitava desmentir-ho.�",
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
                title = "Dimiteix el primer ministre de Portugal, Ant�nio Costa, investigat per un cas de corrupci�.",
                // 120 caracters
                shortDescription = "El primer ministre portugu�s, Ant�nio Costa, ha dimitit despr�s que la Fiscalia l'hagi incl�s en una investigaci�.",
                // 415 caracters
                extendedDescription = "La investigaci� se centra en les concessions d'explotaci� de liti en les mines de Romano i Barroso, al nord del pa�s, i en un projecte d'una central de producci� d'energia a partir de l'hidrogen a Sines i un altre per a la construcci� d'un centre de dades en el mateix indret.\n" +
                "'No he com�s cap delicte. Estic disponible per col�laborar amb la just�cia en tot el que calgui per escatir tota la veritat'.",
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
                shortDescription = "Aquest mes la mateixa ampolla havia pujat fins a 9,25 euros. Gaireb� un 9% m�s car.",
                // 415 caracters
                extendedDescription = "La pujada de preu de la resta d'envasos �s similar en totes les marques. Per aquest motiu, des de FACUA denuncien que no es tracta de pujades en cadena per un augment dels preus d'origen, sin� que podria ser 'una estrat�gia de fixar preus'.\n" +
                "L'associaci� de consumidors ha portat el cas al Ministeri de Consum, com ja hi ha elevat els �ltims mesos els casos d'aliments afectats per la rebaixa de l'IVA perqu� ho investigui.",
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
                title = "Nintendo anuncia una nova pel�l�cula: 'The Legend of Zelda' arribar� a la gran pantalla.",
                // 120 caracters
                shortDescription = "Nintendo ha anunciat aquest dimecres que ja ha comen�at a treballar en una pel�l�cula d'acci� real de la franqu�cia 'The Legend of Zelda'.",
                // 415 caracters
                extendedDescription = "L'empresa japonesa ha confirmat, en un comunicat, que el film estar� produ�t per Shigeru Miyamoto, dissenyador i productor de videojocs i creador de sagues com Super Mario, Donkey Kong o el mateix Zelda, i Avi Arad, productor de cintes com 'Iron Man', 'Uncharted' o 'Spider-Man: Into the Spider-Verse'.\n" +
                "La companyia ha informat que la pel�l�cula estar� produ�da conjuntament amb Arad Productions i dirigida per Wes Ball.",
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
                shortDescription = "Dues astronautes de l'Estaci� Espacial Internacional (EEI) que estaven fent tasques de manteniment fora de la nau van tenir un petit contratemps.",
                // 415 caracters
                extendedDescription = "Despr�s d'analitzar la traject�ria de la caixa extraviada, es va poder determinar que el risc de col�lisi� amb la nau era baix i poc perill�s.\n" +
                "La caixa d'eines, doncs, continua a l'espai, on estar� en �rbita al voltant de la Terra durant uns mesos fins que, a mesura que vagi perdent al�ada, acabar� desintegrant-se a l'atmosfera terrestre.",
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
                title = "L'ex�rcit d'Israel diu que �s al centre de Ciutat de Gaza i intenta inutilitzar t�nels de Hamas.",
                // 120 caracters
                shortDescription = "L'ex�rcit israeli� ha assegurat que ja ha arribat al centre de la ciutat de Gaza, que est� completament encerclada per les seves forces.",
                // 415 caracters
                extendedDescription = "Segons Israel, aquesta xarxa de t�nels t� centenars de quil�metres per sota de la Franja de Gaza, per� Hamas ha assegurat que l'ex�rcit israeli� no ha aconseguit cap objectiu important, a banda de matar civils." +
                "Mentrestant, la Creu Roja ha denunciat que un dels seus combois amb material m�dic ha estat atacat quan es dirigia a l'Hospital Al-Shifa, el m�s important de Gaza.",
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