TC: KIN-03 27.07.2026 18:26
VERSION: 93b9e0fe
Status: PASSED

TC: KIN-04 27.07.2026 18:31
VERSION: 93b9e0fe
Status: Blocked
BUG: Filmas treileri un lietotāju vērtējumi šajā sistēmas versijā nav pieejami
COMMENTS: Testam trūkst priekšnosacījumu

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



TESTĒTĀJA KOMENTĀRS PAR KIN-04: ready!
Šis tests pašlaik ir bloķēts, jo demonstrācijas datos nav filmu treileru vai lietotāju vērtējumu. Lai testu varētu veikt pilnvērtīgi, vismaz vienai filmai jābūt pieejamai testa treilera saitei un vērtējumam, piemēram, 4,5/5.

Pēc testa datu sagatavošanas:
1. Atveriet filmas detalizēto lapu.
2. Pārbaudiet, ka treilera saite vai atskaņotājs ir redzams, ja filmai ir treileris.
3. Pārbaudiet, ka lietotāju vērtējums ir redzams, ja filmai ir vērtējums.
4. Pārbaudiet arī filmu bez treilera vai vērtējuma — šajā gadījumā saskarnei nevajadzētu rādīt tukšu vai kļūdainu bloku.

Ja treilera un vērtējuma funkcionalitāte nav iekļauta šīs versijas tvērumā, lūdzu, atstājiet KIN-04 statusu “Blocked”, nevis “Failed”, un norādiet, ka testam trūkst priekšnosacījumu.


TC: KIN-05-01 27.07.2026 20:55
VERSION: 93b9e0fe
Status: PASSED

TESTĒTĀJA KOMENTĀRS: ready!
Lūdzu, pabeidziet testu, izmantojot filmu, kurai ir vismaz divi seansi. Pašreizējā demonstrācijas versijā šādas filmas ir “Neona pilsēta” un “Mēness arhīvs”.

1. Atveriet vienas no šīm filmām detalizēto lapu.
2. Pārbaudiet, ka seansu sarakstā redzami abi seansi ar datumu, sākuma laiku, zāli un cenu.
3. Izvēlieties katru seansu pēc kārtas un pārbaudiet, ka sistēma aizved uz attiecīgā seansa sēdvietu plānu.
4. Ja kāds seanss nav redzams vai tajā redzami nepareizi dati, norādiet filmas nosaukumu, seansa laiku, sagaidāmo rezultātu un faktisko rezultātu.


TC: KIN-14 27.07.2026 21:05
VERSION: 2a849de4
Status: PASSED



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
