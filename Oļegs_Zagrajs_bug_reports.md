TC: KIN-03 27.07.2026 18:26
VERSION: 93b9e0fe
Status: PASSED

TC: KIN-04 27.07.2026 18:31
VERSION: 93b9e0fe
Status: Blocked
BUG: Filmas treileri un lietotāju vērtējumi šajā sistēmas versijā nav pieejami

TC: KIN-11 27.07.2026 20:00
VERSION: c1b97195
Status: PASSED

TC: KIN-12 27.07.2026 20:06
VERSION: c1b97195
Status: FAILED
Bug: Maksājuma laikā rezervētas vietas var izvēlēties citi lietotāji
h2. Preconditions
*Izvēlēties filmas seansu, vietas un pievienot biļetes grozā - ok

h2. Steps
* 1. Izvēlēties filmu un seansu - ok
* 2. Izvēlēties vrīvas vietas - ok
* 3. Pāriet uz maksājuma procesu - ok
* 4. Atvērt sistēmu otrajā pārlūka logā kā cits lietotājs - ok
* 5. Izvēlēties to pašu filmu un seansu - failed

h2. Expected
Izvēlētas vietas ir rezervētas

COMMENTS:
Izvēlētas vietas ir brīvas

TC: KIN-14 27.07.2026 20:37



TC: KIN-01-01 27.07.2026 17:51
VERSION: ea05db6131dd9829ea2329b23c7cf0f5521dcb36
Status: FAILED
BUG:Nav parādīts gads
h2. Preconditions
* Datu baze satur 4+ filmas - ok

h2. Steps
* 1. Atver filmu saraksta lapu - ok
* 2. Nogaida ielades indikatoru - ok

h2. Expected
* Tiek paradits 4+ filmu saraksts - ok
* Katrai filmai redzams nosaukums, zanrs, gads - failed
COMMENTS:
Nav parādīts gads