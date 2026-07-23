### KIN-01	Must	Kā pircējs es vēlos redzēt pieejamo filmu sarakstu alfabētiskā secībā, lai ātri atrastu interesējošo filmu.

#### KIN-01-01: Saraksts tiek ieladets
h2. Preconditions
* Datu baze satur 5+ filmas

h2. Steps
* 1. Atver filmu saraksta lapu
* 2. Nogaida ielades indikatoru

h2. Expected
* Tiek paradits 5+ filmu saraksts
* Katrai filmai redzams nosaukums, zanrs, gads

### KIN-02	Must	Kā pircējs es vēlos apskatīt filmas detalizētu informāciju — nosaukumu, īsu aprakstu, žanru, ilgumu minūtēs, vecuma ierobežojumu, valodu un subtitru valodu — lai varētu pieņemt lēmumu par filmas izvēli.
sld-devops
#### KIN-02-01
h2. Preconditions
* Datu baze satur vismaz 1 filmu, lai būtu kur uzspiest "detalizācija informācija"

h2. Steps
* 1. Atvērt filmas detalizētu informāciju uzspiežot uz filmas attēla
* 2. Ir redzama prasībās minētā detalizētā informācija - 
	2.1. nosaukumu, piemēram, Mēness arhīvs,
	2.2. īsu aprakstu, piemēram, Uz pamestas Mēness stacijas atstāta balss ieraksta atklāj stāstu, kuru neviens nebija paredzējis dzirdēt.
	2.3 žanru, piemēram, ZINĀTNISKĀ FANTASTIKA
	2.4 ilgumu minūtēs, piemēram, 132 min
	2.5 vecuma ierobežojumu, piemēram, 12+
	2.6 valodu, piemēram, Angļu
	2.7 subtitru valodu, piemēram, Subtitri: Latviešu

h2. Expected
* Ir redzama visa soļos minētā detalizētā informācija

#### KIN-02-02
h2. Preconditions
* Datu baze nesatur nevienu filmu

h2. Steps
* 1. Atvērt pārlūku -> Uzreiz galvenajā lapā nav nevienas redzamu filmu seansu.

h2. Expected
* Nav pieejama detalizētas informācijas lapa

KIN-03	Should	Kā pircējs es vēlos filtrēt filmas pēc žanra un rādīt tikai filmas ar šodienas seansiem, lai ātrāk atrastu piemērotu filmu.
sld-devops

h2. Preconditions
* 1. Tiek paradīta visā filmu sarakstā vismaz 4 filmas, kurā katra no tām ir atsevišķā žanrā 
* 2. Kurā vismaz 1 no tām ir šodien, lai pārbaudītu, vai filtrs darbojas pareizi

h2. Steps
* 1. Uzspiest uz man intersēšo žanru
* 2. Uzspiest uz pogas "Šodien"

h2. Expected
* Filmu sarakstā redzēt filmu/filmas, kuras ir šodien, izvēlētājā žanrā

KIN-04	Should	Kā pircējs es vēlos redzēt filmas treileri un lietotāju vērtējumu, ja šī informācija ir pieejama, lai varētu labāk novērtēt filmu pirms biļetes pirkšanas.

### KIN-05	Must	Kā pircējs es vēlos izvēlēties filmas seansu un redzēt tā datumu, sākuma laiku, zāli un cenu, lai izvēlētos sev piemērotāko apmeklējuma laiku.
#### KIN-05-01: Seansa izvele
h2. Preconditions
* Filma ar vairak neka 1 seansu

h2. Steps
* 1. Atver filmu
* 2. Izvelas seansu

h2. Expected
* Seansi atteloti ar laiku un zales numuru
* Pec izveles parvieto uz sedvietu izveli



KIN-06	Must	Kā pircējs es vēlos redzēt izvēlētā seansa zāles sēdvietu plānu ar brīvajām un aizņemtajām vietām, lai varētu izvēlēties vietas.
Zhuciis

### KIN-07	Must	Kā sistēmas operators es vēlos pievienot, labot un noņemt filmas, lai pircēji redzētu aktuālu filmu informāciju.
#### KIN-07-01: Pievienot jaunu filmu
h2. Preconditions
* Operatora loma

h2. Steps
* 1. Atver ADD filmas formu
* 2. Ievada nosaukumu, zanru, ilgumu
* 3. Pievieno poster attelu
* 4. Saglabaj

h2. Expected
* Filma saglabata
* Paradits veiksmes prieksstats
* Filma redzama pirceja saraksta

#### KIN-07-02: Rediget - neaizpildits obligatais lauks
h2. Preconditions
* Esosa filma

h2. Steps
* 1. Atver filmas redigesanas formu
* 2. Notira nosaukumu
* 3. Saglabaj

h2. Expected
* Paradits validacijas kjuda: "Nosaukums ir obligats"
* Filma netiek saglabata ar tuksu nosaukumu

KIN-08	Must	Kā sistēmas operators es vēlos izveidot un rediģēt seansus, norādot filmu, zāli, datumu, laiku, cenu un pieejamos biļešu veidus, lai uzturētu kinoteātra repertuāru.
Zhuciis

KIN-09	Must	Kā sistēmas operators es vēlos pārvaldīt zāļu sēdvietu plānus, lai katram seansam būtu korekts vietu izvietojums.
sjuroz Test-KIN-09 Zāļu sēdvietu plāna pārvaldīšana
Preconditions:
* Pārvaldības sadaļā ir zāļu sēdvietu plāni.

Nav iespējams pārbaudīt, jo operatoram nav izveidota sadaļa ar zāļu sēdvietu plānu, ko varētu rediģēt.

KIN-10	Should	Kā sistēmas operators es vēlos pārvaldīt filmu žanrus, lai filmu filtrēšana būtu konsekventa.
sjuroz 
Test-KIN-10: Pievienot filmas žanru filtrā. 
Preconditions: 
1.Lietotājam ir piešķirtas tiesības izmantot pārvaldības sadaļu.
2.Filmas pievienošanas kartītē ir pieejams lauks "Žanrs".

Steps: 
1. Atver pārvaldības sadaļu sistēmā.
2. Sadaļā "Pievienot filmu" aizpildīt lauku "žanrs" un pārējos laukus ar informāciju par filmu.

Expected:
* Tiek pievienota jauna filma ar žanru.
* Sadaļā "Filmas" redzams jauns žanrs filtrā.
KIN-11	Must	Kā pircējs es vēlos izvēlēties vienu vai vairākas brīvas vietas vienam seansam, lai vienā pasūtījumā nopirktu biļetes sev un saviem līdzgājējiem.
mwfymjybdy-wq

KIN-12	Must	Kā pircējs es vēlos, lai izvēlētās vietas uz maksājuma laiku tiktu rezervētas un netiktu pārdotas citam pircējam, lai droši pabeigtu pirkumu.
mwfymjybdy-wq

KIN-13	Must	Kā sistēmas operators es vēlos, lai neapmaksātas rezervācijas pēc noteikta laika automātiski tiktu atceltas un vietas atbrīvotos, lai vietas būtu pieejamas citiem pircējiem.
BaibaGaile

KIN-14	Must	Kā pircējs es vēlos izvēlēties biļetes veidu un redzēt pareizi aprēķinātu kopējo cenu, lai pirms maksājuma saprastu pasūtījuma summu.
BaibaGaile

KIN-15	Should	Kā pircējs es vēlos ievadīt atlaižu kodu un saņemt saprotamu paziņojumu, ja kods nav derīgs, lai varētu izmantot man pieejamās atlaides.
pokyxrose

KIN-16	Must	Kā pircējs es vēlos samaksāt ar atbalstītu maksājuma veidu un atkārtot maksājumu, ja pirmais mēģinājums nav izdevies, lai pabeigtu biļešu iegādi.
pokyxrose

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

TC-22: TC-AUTH-03: Konta bloķēšana un paroles atiestatīšana
h2. Preconditions
* Lietotājs ir reģistrēts sistēmā
* Lietotāja konts nav bloķēts

h2. Steps

* Lietotājs atver autorizācijas lapu
* Lietotājs ievada e-pasta adresi
* Lietotājs ievada nederīgu paroli
* Lietotājs nospiež pogu "Autorizēties"
* Sistēma informē lietotāju par neveiksmīgu autorizācijas mēģinājumu
* Lietotājs atkārtoti ievada reģistrēto e-pasta adresi
* Lietotājs atkārtoti ievada nederīgu paroli
* Lietotājs nospiež pogu "Autorizēties"
* Sistēma informē lietotāju par neveiksmīgu autorizācijas mēģinājumu
* Lietotājs trešo reizi ievada reģistrēto e-pasta adresi
* Lietotājs ievada nederīgu paroli
* Lietotājs nospiež pogu "Autorizēties"
* Sistēma informē lietotāju par neveiksmīgu autorizācijas mēģinājumu un konta bloķešanu
* Lietotājs nospiež pogu "Atiestatīt paroli" 
* Lietotājs ievada savu e-pasta adresi 
* Lietotājs saņem paroles atiestatīšanas linku e-pastā
* Lietotājs atver saņemto saiti
* Lietotājs ievada jaunu paroli
* Lietotājs apstiprina jauno paroli

h2. Expected
* Pēc trim neveiksmīgiem paroles ievades mēģinājumiem konts tiek uz laiku bloķēts
* Sistēma informē lietotāju par konta bloķēšanu
* Sistēma piedāvā pogu "Atiestatīt paroli"
* Lietotājs saņem atiestatīšanas linku savā e-pastā
* Lietotājs var veiksmīgi izveidot jaunu paroli

KIN-23	Must	Kā sistēmas operators es vēlos redzēt pasūtījuma, maksājuma un biļetes nosūtīšanas statusu, lai varētu palīdzēt pircējam problēmas gadījumā.
=======
### KIN-23	Must	Kā sistēmas operators es vēlos redzēt pasūtījuma, maksājuma un biļetes nosūtīšanas statusu, lai varētu palīdzēt pircējam problēmas gadījumā.
>>>>>>> 92bc878c85d8507711c9b4a91f202c78309c0ee7
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