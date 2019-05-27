# Virtual Guild Workshop 29. Mai 2019

## Intro til Unity for begynnere
Dette oppgavesettet er ment for programmere med liten til ingen tidligere erfaring med Unity, grafikkprogrammering eller andre grafikkmotorer 

Løsnignsforslag til alle oppgavene finner du som en branch `task/*`

### Tiltenkt arbeidsmåte
- Fork og klon dette repo og bruk det som utgangspunkt
- Sitter du fast så kan du sjekke ut et løsningsforslag med `git checkout task/<task>`
- Hvis deler av oppgavesettet virker for enkelt så kan skippe fremover ved å starte fra et av løsningsforslagene 

## 1. Spillerobjekt
- Lag et prefab-objekt som representerer spilleren
- Spillerobjektet (eller et datterobjekt av spillerobjektet) må ha en `Camera` komponent
- Skript førstepersonkamerakontroll for spillerobjektet

### Ressurser
- https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
- https://docs.unity3d.com/ScriptReference/Transform.html
- https://docs.unity3d.com/Manual/class-Camera.html
- https://docs.unity3d.com/Manual/class-InputManager.html

### Løsningsforslag
`git checkout task/player-object` 

## 2. Prosjektilvåpen
- Lag en ny prefab som representerer en missile launcher
- Lag en ny prefab som representerer missilen 
- Skript instansiering av missiler i missile launcher løpet hver gang høyre museknapp trykkes på 
- Skript at missilen bevegser seg i rettning den ble skutt
- Koble missile launcher prefaben til spiller objektet med et spawner-skript eller direkte

### Ressurser
- https://docs.unity3d.com/ScriptReference/Object.Instantiate.html


### Løsningsforslag
`git checkout task/weapon` 

## 3. Mål å skyte på
- Lag en ny prefab for en målskive 
- Sørg for at målskiven har en missilene har en `Collider`
- Missiliene må også ha en `Rigidbody` (se ressurser)
- Sett noen målskiver ut i scenen
- Når en missil treffer en målskive skal målskiven endre farge

### Ressurser
- https://docs.unity3d.com/ScriptReference/Collider.html
- https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html

### Løsningsforslag
`git checkout task/targets` 

## 4. GUI og gamestate
- Lag et GUI element som viser en score for hvor mange målskiver man har skutt
- Lag et GUI element for en "game over"-melding
- Hver gang en målskive skytes så skal GUI oppdaters med ny score
- Når alle målskiver er skutt så vises "game over"

### Ressurser
- https://docs.unity3d.com/Manual/UISystem.html
- https://docs.unity3d.com/ScriptReference/Object.FindObjectOfType.html

### Løsningsforslag
`git checkout task/gui-and-state` 

## 5. Hovedmeny og flere scener
- Lag en ny scene for hovedmenyen
- Hovedmenyen må ha en tittel en en knapp for å starte spillet
- Spillet startes ved at vi laster inn spillscenen

### Ressurser
- https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

### Løsningsforslag
`git checkout task/main-menu` 

## Mer arbeid?
- Test ut unity sin fysikkmotor
- prøv å bytte ut noen av placeholder modellene med kulere modeller 
- ekperimenter med lyssetting
