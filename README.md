# M11-UF2-T1
Activitat de desenvolupament d'un programa d'atac simulat per l'assignatura d'M11.

## Què fa el programa?
El programa permet realitzar diversos "atacs":
- Atac de diccionari.
- Replicació d'un "cuc".
- DOS (fer pings).

### Atac de diccionari
El programa et demana les credencials que se suposa que són les que el servidor té.
Donades aquestes dades, el programa fa servir un diccionari per intentar accedir al "servidor" provant combinacions del diccionari.
Com a collita pròpia:
- El programa et permet indicar un delay que simula el temps d'enviament de les peticions.
- El programa per defecte fa servir tècniques de paral·lelisme per provar combinacions més ràpidament.

### Replicació d'un cuc
El programa et permet replicar un arxiu. Per defecte es replica 10 vegades al directori on se situa el programa.

### DOS
El programa et permet indicar una llista d'equips (per domini o IP) i es realitzaran pings.
