# Vienotais produkta backlog — kinoteātra biļešu rezervēšanas sistēma

## Produkta mērķis

Pircējs var atrast filmu un seansu, izvēlēties brīvas vietas, droši tās rezervēt, samaksāt un saņemt biļeti. Sistēmas operators uztur filmas, seansus, zāles un pasūtījumus.

## Pieņemtie lēmumi pretrunu novēršanai

- Biļeti var iegādāties gan reģistrēts lietotājs, gan viesis; viesim biļetes saņemšanai nepieciešama tikai e-pasta adrese.
- Reģistrācijai nepieciešami tikai e-pasts un parole. Vārds, tālrunis, dzimšanas datums, adrese un mārketinga paziņojumi ir brīvprātīgi un tiek izmantoti tikai ar atsevišķu piekrišanu.
- Parolei ir vismaz 8 rakstzīmes, lielais un mazais burts, cipars un speciālā rakstzīme. Sistēma glabā paroles jaucējvērtību, nevis pašu paroli.
- Pēc trim neveiksmīgiem paroles mēģinājumiem konts tiek uz laiku bloķēts, bet lietotājs var sākt paroles atiestatīšanu ar e-pastu.
- Pirmajā laidienā autorizācija notiek ar e-pastu un paroli. Sociālo tīklu un tālruņa autorizācija ir nākamās versijas iespēja, nevis šī divu sprintu apjoms.
- Filmu saraksts pēc noklusējuma ir alfabētisks; lietotājs var atlasīt filmas pēc žanra un rādīt tikai filmas ar šodienas seansiem.

## Sprinta mērķi

| Sprints | Mērķis | Demonstrējams rezultāts |
|---|---|---|
| 1. sprints | Izveidot filmu un seansu izvēles pamatu. | Pircējs atrod filmu, apskata seansu un redz brīvās vietas; operators uztur datus. |
| 2. sprints | Pabeigt rezervēšanas un biļetes iegādes plūsmu. | Pircējs rezervē vietas, samaksā un saņem biļeti ar QR kodu e-pastā. |

## 1. sprints — filmu un seansu izvēle

| ID | Prioritāte | User story |
|---|---|---|
| KIN-01 | Must | Kā pircējs es vēlos redzēt pieejamo filmu sarakstu alfabētiskā secībā, lai ātri atrastu interesējošo filmu. |
| KIN-02 | Must | Kā pircējs es vēlos apskatīt filmas detalizētu informāciju — nosaukumu, īsu aprakstu, žanru, ilgumu minūtēs, vecuma ierobežojumu, valodu un subtitru valodu — lai varētu pieņemt lēmumu par filmas izvēli. |
| KIN-03 | Should | Kā pircējs es vēlos filtrēt filmas pēc žanra un rādīt tikai filmas ar šodienas seansiem, lai ātrāk atrastu piemērotu filmu. |
| KIN-04 | Should | Kā pircējs es vēlos redzēt filmas treileri un lietotāju vērtējumu, ja šī informācija ir pieejama, lai varētu labāk novērtēt filmu pirms biļetes pirkšanas. |
| KIN-05 | Must | Kā pircējs es vēlos izvēlēties filmas seansu un redzēt tā datumu, sākuma laiku, zāli un cenu, lai izvēlētos sev piemērotāko apmeklējuma laiku. |
| KIN-06 | Must | Kā pircējs es vēlos redzēt izvēlētā seansa zāles sēdvietu plānu ar brīvajām un aizņemtajām vietām, lai varētu izvēlēties vietas. |
| KIN-07 | Must | Kā sistēmas operators es vēlos pievienot, labot un noņemt filmas, lai pircēji redzētu aktuālu filmu informāciju. |
| KIN-08 | Must | Kā sistēmas operators es vēlos izveidot un rediģēt seansus, norādot filmu, zāli, datumu, laiku, cenu un pieejamos biļešu veidus, lai uzturētu kinoteātra repertuāru. |
| KIN-09 | Must | Kā sistēmas operators es vēlos pārvaldīt zāļu sēdvietu plānus, lai katram seansam būtu korekts vietu izvietojums. |
| KIN-10 | Should | Kā sistēmas operators es vēlos pārvaldīt filmu žanrus, lai filmu filtrēšana būtu konsekventa. |

## 2. sprints — rezervācija, maksājums un biļete

| ID | Prioritāte | User story |
|---|---|---|
| KIN-11 | Must | Kā pircējs es vēlos izvēlēties vienu vai vairākas brīvas vietas vienam seansam, lai vienā pasūtījumā nopirktu biļetes sev un saviem līdzgājējiem. |
| KIN-12 | Must | Kā pircējs es vēlos, lai izvēlētās vietas uz maksājuma laiku tiktu rezervētas un netiktu pārdotas citam pircējam, lai droši pabeigtu pirkumu. |
| KIN-13 | Must | Kā sistēmas operators es vēlos, lai neapmaksātas rezervācijas pēc noteikta laika automātiski tiktu atceltas un vietas atbrīvotos, lai vietas būtu pieejamas citiem pircējiem. |
| KIN-14 | Must | Kā pircējs es vēlos izvēlēties biļetes veidu un redzēt pareizi aprēķinātu kopējo cenu, lai pirms maksājuma saprastu pasūtījuma summu. |
| KIN-15 | Should | Kā pircējs es vēlos ievadīt atlaižu kodu un saņemt saprotamu paziņojumu, ja kods nav derīgs, lai varētu izmantot man pieejamās atlaides. |
| KIN-16 | Must | Kā pircējs es vēlos samaksāt ar atbalstītu maksājuma veidu un atkārtot maksājumu, ja pirmais mēģinājums nav izdevies, lai pabeigtu biļešu iegādi. |
| KIN-17 | Must | Kā pircējs es vēlos saņemt apmaksātas biļetes e-pastā ar unikālu QR kodu, lai varētu tās uzrādīt pie ieejas kinoteātrī. |
| KIN-18 | Should | Kā reģistrēts pircējs es vēlos apskatīt savas iegādātās biļetes profilā, lai tās varētu atrast arī pēc e-pasta saņemšanas. |
| KIN-19 | Must | Kā pircējs es vēlos reģistrēties ar e-pastu un drošu paroli, lai turpmāk ātrāk noformētu biļešu pirkumus. |
| KIN-20 | Must | Kā pircējs es vēlos iegādāties biļeti bez reģistrācijas, lai varētu palikt anonīms, vienlaikus saņemot biļeti e-pastā. |
| KIN-21 | Must | Kā reģistrēts pircējs es vēlos autorizēties ar e-pastu un paroli, kā arī atiestatīt aizmirstu paroli, lai varētu droši piekļūt savam profilam. |
| KIN-22 | Must | Kā sistēmas operators es vēlos pēc trim neveiksmīgiem paroles mēģinājumiem uz laiku bloķēt kontu un piedāvāt paroles atiestatīšanu, lai samazinātu konta uzlaušanas risku. |
| KIN-23 | Must | Kā sistēmas operators es vēlos redzēt pasūtījuma, maksājuma un biļetes nosūtīšanas statusu, lai varētu palīdzēt pircējam problēmas gadījumā. |
| KIN-24 | Should | Kā sistēmas operators es vēlos izveidot, aktivizēt un deaktivizēt atlaižu kodus, lai pārvaldītu atlaižu kampaņas. |

## Ārpus šo divu sprintu apjoma

- autorizācija ar tālruņa numuru vai sociālo tīklu kontiem;
- personalizēts mārketings, dzimšanas dienas atlaides un klientu segmentēšana;
- biļešu atcelšana un naudas atmaksa;
- vairākas saskarnes valodas, īpaši mobilās lietotnes un paplašināta veiktspējas uzraudzība.
