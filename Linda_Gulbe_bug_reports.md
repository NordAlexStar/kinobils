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
VERSION: 84f8257b
Status: FAILED

h2. Preconditions
Grozā ir pievienota kino biļete un pircējam ir pieejams atbalstīts maksājuma veids 

h2. Steps
* 1. Izvēlēties maksājuma veidu - FAILED
* 2. Ievadīt nepieciešamos maksājuma datus
* 3. Nospiest pogu "Maksāt"

h2. Expected
* Sistēma veiksmīgi apstrādā maksājumu
* Pasūtījums tiek apstiprināts
* Pircējs saņem paziņojumu par veiksmīgu maksājumu

COMMENT: Nav iespējams Izvēlēties maksājumu veidu