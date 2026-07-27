TC: KIN-02-01 Kā pircējs es vēlos apskatīt filmas detalizētu informāciju — nosaukumu, īsu aprakstu, žanru, ilgumu minūtēs, vecuma ierobežojumu, valodu un subtitru valodu — lai varētu pieņemt lēmumu par filmas izvēli.
Date: 27.07.2026 18:24
VERSION: 39ddc010
Status: FAILED
BUG: Nav redzams pilnā garumā īsais filmas apraksts, filmas attēls pārklājas virs teksta.

h2. Preconditions
* Datu baze satur vismaz 1 filmu, lai būtu kur uzspiest "detalizācija informācija" -> OK

h2. Steps
* 1. Atvērt filmas detalizētu informāciju uzspiežot uz filmas attēla -> OK
* 2. Ir redzama prasībās minētā detalizētā informācija 
	2.1. nosaukumu, piemēram, "Mēness arhīvs" -> OK
	2.2. īsu aprakstu, piemēram, "Uz pamestas Mēness stacijas atstāta balss ieraksta atklāj stāstu, kuru neviens nebija paredzējis dzirdēt." -> FAILED
	2.3 žanru, piemēram, "ZINĀTNISKĀ FANTASTIKA" -> OK
	2.4 ilgumu minūtēs, piemēram, "132 min" -> OK
	2.5 vecuma ierobežojumu, piemēram, "12+" -> OK
	2.6 valodu, piemēram, "Angļu" -> OK
	2.7 subtitru valodu, piemēram, Subtitri: L"atviešu" -> OK

h2. Expected
* Ir redzama visa soļos minētā detalizētā informācija -> FAILED

COMMENTS: Nav redzams pilnā garumā īsais filmas apraksts, filmas attēls pārklājas virs teksta.

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.2
Filmas informācijas teksta laukums pielāgots, lai plakāts neaizsegtu aprakstu.

REVIEW OF RESOLUTION:
Status: FAILED
BUG: Teksts palien zem attēla situācijā, kad logs nav atvērts pilnībā, un ir samazināts par daļu no ekrāna - https://imgur.com/a/4udOQQi. Lietotājam jāredz pilns teksts pat, ja lieto pārlūku šādā ne pilnā ekrānā.

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.6
Filmas detaļu skats pielāgots dažādiem loga platumiem: šaurā logā plakāts atrodas teksta plūsmā un vairs neaizsedz aprakstu.

REVIEW OF RESOLUTION 2:
Status: FAILED
BUG: Pēc labojumiem filmas apraksta attēlošana nestrādā pareizi joprojām - gan pilnekrānā, gan samazinātā teksts pazūd
1) Pilns ekrāns: https://imgur.com/a/GEuNLwT
2) Samazināts: https://imgur.com/3ZiN6By

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.9
Filmas detaļu lapai pievienots atsevišķs adaptīvais izkārtojums ar garantētu teksta un plakāta atdalīšanu. Šaurā logā plakāts atrodas zem apraksta.

FOLLOW-UP: FIX APPROVED
Teksts attēlots pareizi gan pilnekrāna, gan samazinātajā ekrānā.

TC: KIN-03 Kā pircējs es vēlos filtrēt filmas pēc žanra un rādīt tikai filmas ar šodienas seansiem, lai ātrāk atrastu piemērotu filmu.
Date: 27.07.2026 19:04
Status: SUCCEED

h2. Preconditions
* 1. Tiek paradīta visā filmu sarakstā vismaz 4 filmas, kurā katra no tām ir atsevišķā žanrā -> OK
* 2. Kurā vismaz 1 no tām ir šodien, lai pārbaudītu, vai filtrs darbojas pareizi -> OK 

h2. Steps
* 1. Uzspiest uz man intersēšo žanru -> OK
* 2. Uzspiest uz pogas "Šodien" -> OK

h2. Expected
* Filmu sarakstā redzēt filmu/filmas, kuras ir šodien, izvēlētājā žanrā -> OK

