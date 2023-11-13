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
            
            // ------------------------------------------------------ Noticia 8
            new News { 
                // 90 caracters
                title = "A subhasta un barret que va portar Napoleó i que podria arribar als 800.000 euros.",
                // 120 caracters
                shortDescription = "Un barret de feltre negre amb forma de bicorn. És una peça que se subhastarà a finals de novembre a París.",
                // 415 caracters
                extendedDescription = "Segons han explicat, la peça podria sortir a la venda per 800.000 euros i es tracta d'un barret amb marca registrada per Napoleó, és a dir, que es portava 'en bataille', és a dir, paral·lel a les espatlles, i no perpendicular com els duien la majoria dels seus oficials.\n" +
                "La venda la farà el 19 de novembre la casa de subhastes Osenat.",
                newsImage = "Sprites/NewsImages/ImageNew8",
                url = "https://www.ccma.cat/324/a-subhasta-un-barret-que-va-portar-napoleo-i-que-podria-arribar-als-800000-euros/noticia/3259619/",
                socialValue = 2,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 150,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 9
            new News { 
                // 90 caracters
                title = "Què ha convertit una petita illa del Pacífic en capital mundial de la dark web i el cibercrim.",
                // 120 caracters
                shortDescription = "Aquest petit atol sense gairebé connexió amb l'exterior se li va assignar un domini propi (.tk) que no havia demanat ni sabia o podia gestionar.",
                // 415 caracters
                extendedDescription = "Els responsables de Teletok van admetre que els va sorprendre l'èxit que tenia el seu domini, que de seguida va tenir més usuaris que la Xina, " +
                "però al principi no sabien que al darrere començava a haver-hi el pitjor de la dark web, que s'aprofitava dels avantatges de poder registrar gratuïtament tantes webs com vulguessin amb el domini de Tokelau. ",
                newsImage = "Sprites/NewsImages/ImageNew9",
                url = "https://www.ccma.cat/324/que-ha-convertit-una-petita-illa-del-pacific-en-capital-mundial-de-la-dark-web-i-el-cibercrim/noticia/3259417/",
                socialValue = 2,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 150,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 10
            new News { 
                // 90 caracters
                title = "Llum verda de la Comissió Europea per negociar l'adhesió d'Ucraïna.",
                // 120 caracters
                shortDescription = "La Comissió Europea ha donat llum verda perquè el Consell obri negociacions amb els governs d'Ucraïna, Moldàvia i Bòsnia i Hercegovina.",
                // 415 caracters
                extendedDescription = "Les negociacions amb Ucraïna i Moldàvia ja es podrien obrir de forma immediata i, en el cas de Bòsnia i Hercegovina, quan hagi acomplert 'els criteris necessaris' per convertir-se en estat membre.\n" +
                "La presidenta de la Comissió ha destacat, en un missatge a X, l'esforç que ha fet Ucraïna, malgrat la guerra amb Rússia, per adaptar el país i preparar-lo per entrar a la Unió Europea. Un esforç que també ha reconegut a Moldàvia. ",
                newsImage = "Sprites/NewsImages/ImageNew10",
                url = "https://www.ccma.cat/324/llum-verda-de-la-comissio-europea-per-negociar-ladhesio-ducraina/noticia/3259707/",
                socialValue = 3,
                sportsValue = 1,
                internationalValue = 3,
                moneyCost = 175,
                isBlocked = true},

            
            // ------------------------------------------------------ Noticia 11
            new News { 
                // 90 caracters
                title = "Calafell, Reus i Lleida es classifiquen per a la fase regular de la Champions.",
                // 120 caracters
                shortDescription = "L'hoquei català tindrà quatre representants a la màxima competició continental.",
                // 415 caracters
                extendedDescription = "Al pavelló Joan Ortoll de Calafell, on s'ha disputat el grup D, l'equip amfitrió s'ha imposat al La Vendéenne (4-1) per acabar primer de grup i el Reus també ha golejat el Sarzana (7-3). També jugant com a amfitrió, en el seu cas del grup C, el Lleida s'ha desfet del Noisy (4-1).\n" +
                "L'Igualada, per la seva banda, ha superat el Diessbach (3-1) mentre el Noia ha aconseguit una golejada estèril contra el Herringen (8-0). ",
                newsImage = "Sprites/NewsImages/ImageNew11",
                url = "https://www.ccma.cat/esport3/calafell-reus-i-lleida-es-classifiquen-per-a-la-fase-regular-de-la-champions/noticia/3259190/ ",
                socialValue = 2,
                sportsValue = 3,
                internationalValue = 3,
                moneyCost = 200,
                isBlocked = true},

            
            // ------------------------------------------------------ Noticia 12
            new News { 
                // 90 caracters
                title = "Els tres motius pels quals el Madrid descarta el fitxatge de Mbappé.",
                // 120 caracters
                shortDescription = "La SER ha informat aquest dimecres que el club hauria descartat el fitxatge del davanter a finals d'aquesta temporada.",
                // 415 caracters
                extendedDescription = "En aquest sentit, segons la SER, el Madrid ha tingut en compte tres raons: la imatge del jugador entre el madridisme, l'escala salarial de la plantilla i la política de fitxatges actual.\n" +
                "La setmana passada, el Madrid ja va emetre un comunicat desmentint que estigués negociant amb Mbappé, però es va interpretar com un moviment per cobrir-se les esquenes de cara a la FIFA.",
                newsImage = "Sprites/NewsImages/ImageNew12",
                url = "https://www.ccma.cat/esport3/els-tres-motius-pels-que-el-madrid-descarta-el-fitxatge-de-mbappe/noticia/3259835/ ",
                socialValue = 1,
                sportsValue = 3,
                internationalValue = 2,
                moneyCost = 150,
                isBlocked = true},
            
            
            // ------------------------------------------------------ Noticia 13
            new News { 
                // 90 caracters
                title = "Max Verstappen s'imposa també en el Gran Premi de Sao Paulo i Fernando Alonso torna al podi.",
                // 120 caracters
                shortDescription = "El tricampió mundial ha dominat de principi a final el Gran Premi de Sao Paulo per continuar trencant registres.",
                // 415 caracters
                extendedDescription = "Darrere Verstappen, Lando Norris no ha tingut problemes per consolidar el segon lloc, però on hi ha hagut una bona batalla ha estat en el tercer lloc: Fernando Alonso i Checo l'han lluitat fins al final.\n" +
                "El mexicà ha aconseguit avançar el pilot d'Aston Martin, però a l'últim revolt, l'asturià l'hi ha tornat amb un moviment de màxim nivell. ",
                newsImage = "Sprites/NewsImages/ImageNew13",
                url = "https://www.ccma.cat/esport3/en-directe-gp-de-sao-paulo-de-f1/noticia/3259020/",
                socialValue = 1,
                sportsValue = 3,
                internationalValue = 2,
                moneyCost = 150,
                isBlocked = true},
            
            
            // ------------------------------------------------------ Noticia 14
            new News { 
                // 90 caracters
                title = "El miracle del Joventut s'esvaeix davant dels London Lions (76-87).",
                // 120 caracters
                shortDescription = "El Joventut no ha pogut amb els London Lions i ha caigut per 76 a 87 a l'Olímpic de Badalona en partit de l'Eurocopa de bàsquet.",
                // 415 caracters
                extendedDescription = "El primer període ha estat elèctric. Amb un encert espectacular en el tir exterior i un joc molt viu els badalonins han arribat als 10 minuts amb un esperençador 28 a 20. Però un demolidor parcial de 8 a 24 ha fet baixar del núvol als catalans.\n" +
                "Els Lions han apujat considerablement la seva potència defensiva i han bloquejat l'atac català. L'aportació del pivot Gabe Olaseni ha estat fonamental.",
                newsImage = "Sprites/NewsImages/ImageNew14",
                url = "https://www.ccma.cat/esport3/el-miracle-del-joventut-sesvaeix-davant-dels-london-lions-76-87/noticia/3259856/",
                socialValue = 2,
                sportsValue = 3,
                internationalValue = 3,
                moneyCost = 200,
                isBlocked = true},
            
            // ------------------------------------------------------ Noticia 15
            new News { 
                // 90 caracters
                title = "Iga Swiatek recupera el número 1 mundial.",
                // 120 caracters
                shortDescription = "Era la gran favorita per coronar-se campiona i no ha fallat. ",
                // 415 caracters
                extendedDescription = "Pegula, número 4 del món i que havia arribat a la final després de signar un torneig sensacional, només ha resistit el tenis de la polonesa fins al segon joc del partit. Era l'1 a 1.\n" +
                "Ningú es podia imaginar aleshores que Swiatek encadenaria 11 jocs consecutius per tancar la final amb un espectacular 6 a 1 i 6 a 0 en una hora exacta de partit.",
                newsImage = "Sprites/NewsImages/ImageNew15",
                url = "https://www.ccma.cat/esport3/iga-swiatek-recupera-el-numero-1-mundial/noticia/3259403/ ",
                socialValue = 2,
                sportsValue = 3,
                internationalValue = 3,
                moneyCost = 200,
                isBlocked = true},
            
        };


        NewsList newsData = new NewsList { news = newsList };
        string json = JsonConvert.SerializeObject(newsData, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/newsData.json", json);
    }

}