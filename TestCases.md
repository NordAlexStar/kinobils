KIN-01	Must	Kā pircējs es vēlos redzēt pieejamo filmu sarakstu alfabētiskā secībā, lai ātri atrastu interesējošo filmu.

TC-26: TC-FILM-01: Saraksts tiek ieladets
h2. Preconditions
* Datu baze satur 4+ filmas

h2. Steps
* 1. Atver filmu saraksta lapu
* 2. Nogaida ielades indikatoru

h2. Expected
* Tiek paradits 4+ filmu saraksts
* Katrai filmai redzams nosaukums, zanrs, gads

KIN-02	Must	Kā pircējs es vēlos apskatīt filmas detalizētu informāciju — nosaukumu, īsu aprakstu, žanru, ilgumu minūtēs, vecuma ierobežojumu, valodu un subtitru valodu — lai varētu pieņemt lēmumu par filmas izvēli.
sld-devops

KIN-03	Should	Kā pircējs es vēlos filtrēt filmas pēc žanra un rādīt tikai filmas ar šodienas seansiem, lai ātrāk atrastu piemērotu filmu.
sld-devops

KIN-04	Should	Kā pircējs es vēlos redzēt filmas treileri un lietotāju vērtējumu, ja šī informācija ir pieejama, lai varētu labāk novērtēt filmu pirms biļetes pirkšanas.

KIN-05	Must	Kā pircējs es vēlos izvēlēties filmas seansu un redzēt tā datumu, sākuma laiku, zāli un cenu, lai izvēlētos sev piemērotāko apmeklējuma laiku.
ALEKSEJS

KIN-06	Must	Kā pircējs es vēlos redzēt izvēlētā seansa zāles sēdvietu plānu ar brīvajām un aizņemtajām vietām, lai varētu izvēlēties vietas.
Zhuciis

KIN-07	Must	Kā sistēmas operators es vēlos pievienot, labot un noņemt filmas, lai pircēji redzētu aktuālu filmu informāciju.
ALEKSEJS

KIN-08	Must	Kā sistēmas operators es vēlos izveidot un rediģēt seansus, norādot filmu, zāli, datumu, laiku, cenu un pieejamos biļešu veidus, lai uzturētu kinoteātra repertuāru.
Zhuciis

KIN-09	Must	Kā sistēmas operators es vēlos pārvaldīt zāļu sēdvietu plānus, lai katram seansam būtu korekts vietu izvietojums.
sjuroz

KIN-10	Should	Kā sistēmas operators es vēlos pārvaldīt filmu žanrus, lai filmu filtrēšana būtu konsekventa.
sjuroz

### KIN-11	Must	Kā pircējs es vēlos izvēlēties vienu vai vairākas brīvas vietas vienam seansam, lai vienā pasūtījumā nopirktu biļetes sev un saviem līdzgājējiem.
### KIN-11-01 Vietu izvēle
h2. Preconditions
* Pircejs izvelejies filmu un seansu

h2. Steps
* 1. Atver sedvietu izveles ekranu
* 2. Izveleas vietas C5, C6, C7
* 3. Nospiez "Turpinat"

h2. Expected
* Visas 3 vietas apzimetas ka "izveletas"
* Redzams izveleto vietu skaits "3"
* Visas vietas ieklautas viena pasutijuma, summa = 3x biletes cena
### KIN-11-02 Aiznemta vieta
h2. Steps
* 1. Klikskina uz jau aiznemtas vietas D4

h2. Expected
* Vieta nemainas, sistema parada pazinojumu "Vieta jau aiznemta"


### KIN-12	Must	Kā pircējs es vēlos, lai izvēlētās vietas uz maksājuma laiku tiktu rezervētas un netiktu pārdotas citam pircējam, lai droši pabeigtu pirkumu.
### KIN-12-01: Vietas rezervesana maksajuma laika
h2. Preconditions
* Pircejs A izvelejies vietu un sacis maksajuma procesu

h2. Steps
* 1. Pircejs A izveleas vietu F5, pariet uz maksajuma lapu
* 2. Pircejs B tanistarpa atver to pasu seansu

h2. Expected
* Pircejam B vieta F5 raditam ka "tureta/aiznemta", nevis briva
* Pircejs B nevar izveleties vietu F5, kamer holds ir aktivs

### KIN-12-02: Rezervacijas termina beigas
h2. Preconditions
* Pircejs A nepabeidz maksajumu noteikta laika (piem., 10 min)

h2. Steps
* 1. Nogaidit, lidz rezervacijas laiks beidzas
* 2. Pircejs B mekjina izveleties to pasu vietu

h2. Expected
* Vieta atgriezjas "brivas" statusa
* Pircejs B var to veiksmigi izveleties

### KIN-12-03: Veiksmigs maksajums
h2. Steps
* 1. Pircejs A pabeidz maksajumu par tureto vietu

h2. Expected
* Vieta kluust par "aiznemtu" 
* Vieta vairs nav pieejama citiem pircejiem

KIN-13	Must	Kā sistēmas operators es vēlos, lai neapmaksātas rezervācijas pēc noteikta laika automātiski tiktu atceltas un vietas atbrīvotos, lai vietas būtu pieejamas citiem pircējiem.
BaibaGaile

KIN-14	Must	Kā pircējs es vēlos izvēlēties biļetes veidu un redzēt pareizi aprēķinātu kopējo cenu, lai pirms maksājuma saprastu pasūtījuma summu.
BaibaGaile

### KIN-15	Should	Kā pircējs es vēlos ievadīt atlaižu kodu un saņemt saprotamu paziņojumu, ja kods nav derīgs, lai varētu izmantot man pieejamās atlaides.
pokyxrose

#### KIN-15-01: Derīgs atlaides kods
h2. Preconditions
* Grozā ir pievienota kino biļete un ir pieejams atlaides koda ievades lauks

h2. Steps
* 1. Ievadīt atlaides kodu "blegh"
* 2. Nospiest pogu "piemērot"

h2. Expected
* Sistēma pieņem ievadīto atlaides kodu
* Atlaide tiek piemērota pasūtījumam
* Rēķina summa tiek samazināta atbilstoši atlaides koda nosacījumiem
* Sistēma parāda ziņojumu par piemēroto atlaidi

#### KIN-15-02: Nederīgs atlaides kods
h2. Preconditions
* Grozā ir pievienota kino biļete un ir pieejams atlaides koda ievades lauks

h2. Steps
* 1. Ievadīt atlaides kodu "bleg"
* 2. Nospiest pogu "piemērot"

h2. Expected
* Sistēma nepieņem ievadīto atlaides kodu
* Atlaide netiek piemērota
* Sistēma parāda ziņojumu kā nederīgs atlaides kods
* Pircējs var turpināt pasūtījuma noformēšanu

### KIN-16	Must	Kā pircējs es vēlos samaksāt ar atbalstītu maksājuma veidu un atkārtot maksājumu, ja pirmais mēģinājums nav izdevies, lai pabeigtu biļešu iegādi.
pokyxrose

#### KIN-16-01: Veiksmīga maksājuma pārbaude
h2. Preconditions
Grozā ir pievienota kino biļete un pircējam ir pieejams atbalstīts maksājuma veids

h2. Steps
* 1. Izvēlēties maksājuma veidu
* 2. Ievadīt nepieciešamos maksājuma datus
* 3. Nospiest pogu "Maksāt"

h2. Expected
* Sistēma veiksmīgi apstrādā maksājumu
* Pasūtījums tiek apstiprināts
* Pircējs saņem paziņojumu par veiksmīgu maksājumu

#### KIN-16-02: Neveiksmīga maksājuma pārbaude
h2. Preconditions
Grozā ir pievienota kino biļete un pircējam ir pieejams atbalstīts maksājuma veids

h2. Steps
* 1. Izvēlēties maksājuma veidu
* 2. Veikt maksājumu ar nederīgiem maksājuma datiem
* 3. Pārbaudīt sistēmas parādīto kļūdas ziņojumu
* 4. Atkārtoti mēģināt veikt maksājumu ar pareiziem datiem
	
h2. Expected
* Sistēma parāda ziņojumu par neveiksmīgu maksājumu
* Pasūtījums netiek noformēts līdz veiksmīgai apmaksai
* Pircējam ir iespēja atkārtoti mēģināt veikt maksājumu
* Pircējs saņem paziņojumu par veiksmīgu maksājumu

KIN-17	Must	Kā pircējs es vēlos saņemt apmaksātas biļetes e-pastā ar unikālu QR kodu, lai varētu tās uzrādīt pie ieejas kinoteātrī.
anasteisa124

KIN-18	Should	Kā reģistrēts pircējs es vēlos apskatīt savas iegādātās biļetes profilā, lai tās varētu atrast arī pēc e-pasta saņemšanas.
anasteisa124

KIN-19	Must	Kā pircējs es vēlos reģistrēties ar e-pastu un drošu paroli, lai turpmāk ātrāk noformētu biļešu pirkumus.
alipal123

KIN-20	Must	Kā pircējs es vēlos iegādāties biļeti bez reģistrācijas, lai varētu palikt anonīms, vienlaikus saņemot biļeti e-pastā.
alipal123

### KIN-21	Must	Kā reģistrēts pircējs es vēlos autorizēties ar e-pastu un paroli, kā arī atiestatīt aizmirstu paroli, lai varētu droši piekļūt savam profilam.
Linda7315

TC-21: TC-AUTH-01: Pircēja autorizācija
h1. Preconditions
* Sistēmā ir reģistrēts lietotājs ar esošu e-pasta adresi un paroli 

h1. Steps
* Lietotājs atver autorizācijas lapu
* Lietotājs ievada e-pasta adresi
* Lietotājs ievada paroli
* Lietotājs nospiež pogu "Autorizēties"

h2. Expected
* Lietotājs tiek veiksmīgi autorizēts sistēmā
* Lietotājs tiek novirzīts uz savu profilu

TC-21: TC-AUTH-02: Pircēja iespēja attiestatīt aizmirstu paroli

h1. Preconditions
* Sistēmā ir reģistrēts lietotājs ar esošu e-pasta adresi un paroli
* Lietotājs nav autorizējies

h1. Steps
* Lietotājs atver autorizācijas lapu
* Lietotājs nospiež pogu "Aizmirsu paroli"
* Lietotājs ievada savu e-pasta adresi
* Lietotājs nospiež pogu "Atiestatīt paroli"
* Lietotājs saņem paroles atiestatīšanas linku e-pastā
* Lietotājs atver saņemto saiti
* Lietotājs ievada jaunu paroli
* Lietotājs apstiprina jauno paroli

h2. Expected
* Jaunā parole tiek veiksmīgi saglabāta
* Lietotājs var autorizēties ar jauno paroli


### KIN-22	Must	Kā sistēmas operators es vēlos pēc trim neveiksmīgiem paroles mēģinājumiem uz laiku bloķēt kontu un piedāvāt paroles atiestatīšanu, lai samazinātu konta uzlaušanas risku.
Linda7315

### KIN-23	Must	Kā sistēmas operators es vēlos redzēt pasūtījuma, maksājuma un biļetes nosūtīšanas statusu, lai varētu palīdzēt pircējam problēmas gadījumā.
aijanilendere-max

#### Pasūtījumu statusi

h1. Pasūtījumu statusi
Kā sistēmas operators es vēlos redzēt pasūtījuma, maksājuma un biļetes nosūtīšanas statusu.

h2. Testēšanas mērķis
Pārbaudīt, ka sistēma izpilda šo prasību. Testa gadījumi tiek pievienoti šim plānam.


### KIN-24	Should	Kā sistēmas operators es vēlos izveidot, aktivizēt un deaktivizēt atlaižu kodus, lai pārvaldītu atlaižu kampaņas.
aijanilendere-max

#### Atlaižu kodu pārvaldība
h1. Atlaižu kodu pārvaldība

Kā sistēmas operators es vēlos izveidot, aktivizēt un deaktivizēt atlaižu kodus.

h2. Testēšanas mērķis

Pārbaudīt, ka sistēma izpilda šo prasību. Testa gadījumi tiek pievienoti šim plānam.