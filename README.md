# JelleezShaping
Continuation of a game made during Global Game Jam 2016. Theme: Ritual. Constraint: A game that make sense

- v0.1 :
 - RedCurtains has been globally disabled through the Decor Prefab
 - Class BlobCharacter has a property to precise the Blob type, that varies from TypeI to TypeVII
 - Characters Prefab has been updated : there is now only one Player. The Player type is changed in scripts

- v0.2 :
 - new StillBehaviour script to animate BlobCharacter instances that are in Still State
 - new prefab Views to gather Fungus Views
 - a new temp prebaf Decor.ortho that is a copy of prefab Decor, dedicated to
 an orthogtaphic camera
 - added a splash screen with the logo -> is there a webGL bug regarding logo
 position on screen
 - logo removed from scenes
 - REM : with a "perspective" camera, the parallax effect is automatic. With an  orthographic camera, a script must be attached to each "background" sprite to
 get the effect and there is no "perspective" effect.
  
Emma, Emmanuel, Forky, Kenny et Simon
