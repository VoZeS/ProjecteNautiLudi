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
            
            // ------------------------------------------------------ Noticia 8
            new News { 
                // 90 caracters
                title = "A subhasta un barret que va portar Napole� i que podria arribar als 800.000 euros.",
                // 120 caracters
                shortDescription = "Un barret de feltre negre amb forma de bicorn. �s una pe�a que se subhastar� a finals de novembre a Par�s.",
                // 415 caracters
                extendedDescription = "Segons han explicat, la pe�a podria sortir a la venda per 800.000 euros i es tracta d'un barret amb marca registrada per Napole�, �s a dir, que es portava 'en bataille', �s a dir, paral�lel a les espatlles, i no perpendicular com els duien la majoria dels seus oficials.\n" +
                "La venda la far� el 19 de novembre la casa de subhastes Osenat.",
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
                title = "Qu� ha convertit una petita illa del Pac�fic en capital mundial de la dark web i el cibercrim.",
                // 120 caracters
                shortDescription = "Aquest petit atol sense gaireb� connexi� amb l'exterior se li va assignar un domini propi (.tk) que no havia demanat ni sabia o podia gestionar.",
                // 415 caracters
                extendedDescription = "Els responsables de Teletok van admetre que els va sorprendre l'�xit que tenia el seu domini, que de seguida va tenir m�s usuaris que la Xina, " +
                "per� al principi no sabien que al darrere comen�ava a haver-hi el pitjor de la dark web, que s'aprofitava dels avantatges de poder registrar gratu�tament tantes webs com vulguessin amb el domini de Tokelau.�",
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
                title = "Llum verda de la Comissi� Europea per negociar l'adhesi� d'Ucra�na.",
                // 120 caracters
                shortDescription = "La Comissi� Europea ha donat llum verda perqu� el Consell obri negociacions amb els governs d'Ucra�na, Mold�via i B�snia i Hercegovina.",
                // 415 caracters
                extendedDescription = "Les negociacions amb Ucra�na i Mold�via ja es podrien obrir de forma immediata i, en el cas de B�snia i Hercegovina, quan hagi acomplert 'els criteris necessaris' per convertir-se en estat membre.\n" +
                "La presidenta de la Comissi� ha destacat, en un missatge a X, l'esfor� que ha fet Ucra�na, malgrat la guerra amb R�ssia, per adaptar el pa�s i preparar-lo per entrar a la Uni� Europea. Un esfor� que tamb� ha reconegut a Mold�via.�",
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
                shortDescription = "L'hoquei catal� tindr� quatre representants a la m�xima competici� continental.",
                // 415 caracters
                extendedDescription = "Al pavell� Joan Ortoll de Calafell, on s'ha disputat el grup D, l'equip amfitri� s'ha imposat al La Vend�enne (4-1) per acabar primer de grup i el Reus tamb� ha golejat el Sarzana (7-3). Tamb� jugant com a amfitri�, en el seu cas del grup C, el Lleida s'ha desfet del Noisy (4-1).\n" +
                "L'Igualada, per la seva banda, ha superat el Diessbach (3-1) mentre el Noia ha aconseguit una golejada est�ril contra el Herringen (8-0).�",
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
                title = "Els tres motius pels quals el Madrid descarta el fitxatge de Mbapp�.",
                // 120 caracters
                shortDescription = "La SER ha informat aquest dimecres que el club hauria descartat el fitxatge del davanter a finals d'aquesta temporada.",
                // 415 caracters
                extendedDescription = "En aquest sentit, segons la SER, el Madrid ha tingut en compte tres raons: la imatge del jugador entre el madridisme, l'escala salarial de la plantilla i la pol�tica de fitxatges actual.\n" +
                "La setmana passada, el Madrid ja va emetre un comunicat desmentint que estigu�s negociant amb Mbapp�, per� es va interpretar com un moviment per cobrir-se les esquenes de cara a la FIFA.",
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
                title = "Max Verstappen s'imposa tamb� en el Gran Premi de Sao Paulo i Fernando Alonso torna al podi.",
                // 120 caracters
                shortDescription = "El tricampi� mundial ha dominat de principi a final el Gran Premi de Sao Paulo per continuar trencant registres.",
                // 415 caracters
                extendedDescription = "Darrere Verstappen, Lando Norris no ha tingut problemes per consolidar el segon lloc, per� on hi ha hagut una bona batalla ha estat en el tercer lloc: Fernando Alonso i Checo l'han lluitat fins al final.\n" +
                "El mexic� ha aconseguit avan�ar el pilot d'Aston Martin, per� a l'�ltim revolt, l'asturi� l'hi ha tornat amb un moviment de m�xim nivell.�",
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
                shortDescription = "El Joventut no ha pogut amb els London Lions i ha caigut per 76 a 87 a l'Ol�mpic de Badalona en partit de l'Eurocopa de b�squet.",
                // 415 caracters
                extendedDescription = "El primer per�ode ha estat el�ctric. Amb un encert espectacular en el tir exterior i un joc molt viu els badalonins han arribat als 10 minuts amb un esperen�ador 28 a 20.�Per� un demolidor parcial de 8 a 24 ha fet baixar del n�vol als catalans.\n" +
                "Els Lions han apujat considerablement la seva pot�ncia defensiva i han bloquejat l'atac catal�. L'aportaci� del pivot Gabe Olaseni ha estat fonamental.",
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
                title = "Iga Swiatek recupera el n�mero 1 mundial.",
                // 120 caracters
                shortDescription = "Era la gran favorita per coronar-se campiona i no ha fallat. ",
                // 415 caracters
                extendedDescription = "Pegula, n�mero 4 del m�n i que havia arribat a la final despr�s de signar un torneig sensacional, nom�s ha resistit el tenis de la polonesa fins al segon joc del partit. Era l'1 a 1.\n" +
                "Ning� es podia imaginar aleshores que Swiatek encadenaria 11 jocs consecutius per tancar la final amb un espectacular 6 a 1 i 6 a 0 en una hora exacta de partit.",
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