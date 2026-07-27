TC: KIN-07-01 27.07.2026 18:26

VERSION: 038c64ec

Status: Failed

BUG: Nav iespējams pievienot attēlu
h2. Preconditions

* Operatora loma
h2. Steps

* Atver ADD filmas formu - ok
* Ievada nosaukumu, zanru, ilgumu - ok
* Pievieno poster attelu - failed
* Saglabaj - ok
h2. Expected

* Filma saglabata - ok
* Paradits veiksmes prieksstats - ok
* Filma redzama pirceja saraksta - ok

COMMENT:
Nav iespējams pievienot attēlu

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.7
Filmas pievienošanas formā pievienota plakāta augšupielāde PNG, JPG un WEBP formātos.


TC: KIN-16-01 27.07.2026 19:00
VERSION: 038c64ec
Status: FAILED

h2. Preconditions
* Iepirkumu grozā ir pievienota biļete uz kino, un pircējs var izvēlēties maksāšanas veidu

h2. Steps
* izvēlēties maksājuma veidu - FAILED
* Ievadīt nepieciešamos maksājuma datus
* Nospiest pogu "Maksāt"

h2. Expected
* Sistēma veiksmīgi apstrādā maksājumu
* Pasūtījums tiek apstiprināts
* Pircējs saņem paziņojumu par veiksmīgu maksājumu

COMMENT: Nav iespējams izvēlēties maksājuma veidu

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.5
Pasūtījuma noformēšanā pievienota kartes maksājuma un internetbankas izvēle, kā arī maksājuma datu pārbaude.


TC: KIN-23-01 27.07.2026 20:50
VERSION: f5a69d11
Status: FAILED

h2. Preconditions
* Sistēmas operators ir autorizējies sistēmā - ok
* Sistēmā ir izveidots pasūtījums - ok
* Pasūtījuma apmaksa ir veiksmīgi pabeigta - ok
* Biļete ir nosūtīta pircējam - ok

h2. Steps
* Atvērt sadaļu "Pasūtījumi" - failed
* Atrast nepieciešamo pasūtījumu
* Atvērt pasūtījuma informāciju

h2. Expected
* Sistēma parāda izvēlētā pasūtījuma statusu

COMMENT: Nav iespējams atvert sadaļu "Pasūtījumi", sadaļa nav pieejama;


TC: KIN-02-01 27.07.2026 21:05
VERSION: f5a69d11
STATUS: Failed

h2. Preconditions
* Datu baze satur vismaz 1 filmu, lai būtu kur uzspiest "detalizācija informācija" - ok

h2. Steps
* 1. Atvērt filmas detalizētu informāciju uzspiežot uz filmas attēla - ok
* 2. Ir redzama prasībās minētā detalizētā informācija - ok
	2.1. nosaukumu, piemēram, Mēness arhīvs, - ok
	2.2. īsu aprakstu, piemēram, Uz pamestas Mēness stacijas atstāta balss ieraksta atklāj stāstu, kuru neviens nebija paredzējis dzirdēt. - ok
	2.3 žanru, piemēram, ZINĀTNISKĀ FANTASTIKA - ok
	2.4 ilgumu minūtēs, piemēram, 132 min -ok
	2.5 vecuma ierobežojumu, piemēram, 12+ - ok
	2.6 valodu, piemēram, Angļu - ok
	2.7 subtitru valodu, piemēram, Subtitri: Latviešu - failed

h2. Expected
* Ir redzama visa soļos minētā detalizētā informācija

COMMENT: Netiek parādīta subtitru valoda