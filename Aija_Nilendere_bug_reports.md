TC: KIN-05-01 27.07.2026 18:22 \
Version: a65bae780eec52ff372f757db62aebcbbaf6162c
STATUS: FAILED

BUG: Nerāda vairāk par 1 seansu
h2. Preconditions
* Filma ar vairak neka 1 seansu - FAILED


Comments:
Tikai vienai filmai ir 1+ seansi, pārējām ir tikai 1 seanss.


TC:  KIN-15-01 27.07.2026 18:30 \
Version: 0414c7cd75d086cc954347d27bf93a39944c7de2
STATUS: FAILED

BUG: Nav lauka, kurā norādīt atlaidi.

KIN-15-01: Derīgs atlaides kods
h2. Preconditions
* Grozā ir pievienota kino biļete un ir pieejams atlaides koda ievades lauks - FAILED

Comments: Nav lauka, kurā norādīt atlaidi.

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.4
Pasūtījuma noformēšanā pievienots atlaides koda lauks. Derīgs kods `blegh` piemēro 10% atlaidi, nederīgs kods parāda saprotamu paziņojumu.

FOLLOW-UP:
Versijas attēlojums izlabots; tas ir redzams lietotnes galvenē versijā 0.1.4

CONCLUSION: TC PASSED 0.1.4 27.07.2026 19.44