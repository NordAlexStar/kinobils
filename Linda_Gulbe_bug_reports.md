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
