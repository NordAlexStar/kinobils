TC: KIN-09-01 27.07.2026 18:40
VERSION: eb82ec58
Status: FAILED
Preconditions:
* Pārvaldības sadaļā ir zāļu sēdvietu plāni. - failed
Steps:
1.Pārvaldības sadaļā rediģēt rindu un sēdvietu skaitu zālei.
2.Izvēlēties filmas seansu, kas notiek zālē ar izmaiņām sēdvietu plānā.
3.Pārliecināties, ka rindu un sēdvietu skaits sakrīt ar pēdējām izmaiņām.

Expected:
Katrai zālei var ievadīt aktuālo rindu un sēdvietu skaitu.

COMMENTS:
Nav iespējams pārbaudīt, jo operatoram nav izveidota sadaļa ar zāļu sēdvietu plānu, ko varētu rediģēt.

RESOLUTION:
Status: FIXED
FIXED IN VERSION: 0.1.3
Pārvaldības sadaļā pievienota zāļu sēdvietu plānu konfigurācija ar rindu un vietu skaita rediģēšanu.

CONCLUSION: TC PASSED 0.1.3 27.07.2026 19:47

TC: KIN-02-01 27.07.2026 18:27
VERSION: eb82ec58
Status: PASSED

TC: KIN-03-01 27.07.2026 18:28
VERSION: eb82ec58
Status: PASSED

TC: KIN-04-01 27.07.2026 20:05
VERSION: 29d989fc
Status: FAILED
BUG: Pie filmas detalizētas informācijas nav video treilera un lietotāja vērtējuma.

Preconditions: 
1. Repertuārā ir attēlota vismaz 1 filma. - OK

Steps:
1. Nospiest uz filmas attēlu, lai redzētu detalizētu informāciju. - OK
2. Nospiest uz video treilera atskaņošanas pogas. - FAILED
3. Apskatīt lietotāju vērtējumu par filmu. - FAILED

Expected:
Pie filmas detalizētas informācijas ir redzams video treileris un lietotāju vērtējums.


TC: KIN-05-01 27.07.2026 18:35
VERSION: eb82ec58
Status: PASSED

TC: KIN-07-01 27.07.2026 18:35
VERSION: eb82ec58
Status: PASSED

TC: KIN-10-01 27.07.2026 20:20
VERSION: 29d989fc
Status: PASSED

TC: KIN-11-01 27.07.2026 20:25
VERSION: 29d989fc
Status: PASSED

TC: KIN-12-01 27.07.2026 20:40
VERSION: 29d989fc
Status: FAILED
BUG: nav redzams rezervācijas atskaites laiks biļetes pirkšanas brīdī
Preconditions:
* Filmas seansā var izvēlēties vietas apmaksai. - OK

Steps:
1. Izvēlēties vietas filmas seansam. - OK
2. Turpināt uz maksājuma lapu. - OK
3. Pārliecināties, ka ir redzama rezervācijas laika atskaite. - FAILED

Expected:
Maksājuma lapā ir redzams vietu rezervācijas atskaites laiks.

COMMENTS: Maksājumā lapā pēc vietas izvēles nav redzams rezervācijas atskaites laiks.


