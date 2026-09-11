# TP2 Ressources visuelles

## Vue à reproduire

Le fichier `Vue_A_Reproduire.png` montre l’organisation générale attendue :

- un niveau rectangulaire entouré de murs;
- un robot placé dans la partie inférieure gauche;
- exactement trois batteries accessibles;
- une porte de sortie dans le mur supérieur;
- une zone interdite rouge dans la partie droite;
- quelques décorations qui ne bloquent pas le joueur;
- trois profondeurs de décor visibles autour de la zone jouable.

La disposition n’a pas besoin d’être reproduite au pixel près, mais tous les éléments et tous les comportements du TP2 doivent être présents.

## Feuille de sprites

Fichier : `SpriteSheet_Robot_Batterie_Porte_4x4.png`

Configuration Unity :

- Texture Type : `Sprite (2D and UI)`;
- Sprite Mode : `Multiple`;
- Pixels Per Unit : environ `300`;
- Sprite Editor : `Slice > Grid by Cell Count`;
- Columns : `4`;
- Rows : `4`;
- Pivot : `Center`.

Organisation des rangées :

1. quatre images `Robot_Idle`;
2. quatre images `Robot_Move`;
3. quatre images `Batterie_Idle`;
4. quatre images d’ouverture de la porte.

## Tileset

Fichier : `Tileset_Spatial_4x4.png`

Configuration Unity :

- Texture Type : `Sprite (2D and UI)`;
- Sprite Mode : `Multiple`;
- Pixels Per Unit : environ `314`;
- Sprite Editor : `Slice > Grid by Cell Count`;
- Columns : `4`;
- Rows : `4`;
- Pivot : `Center`.

Utilisez les tuiles métalliques pour `Sol`, les bordures pour `Murs`, et les panneaux, conduites et grilles pour `Decoration`. Les tuiles rouges peuvent former la `ZoneInterdite`.

## Couches de parallaxe

Les trois fichiers sont :

- `Fond_Lointain.png` : image opaque du ciel spatial;
- `Fond_Usine.png` : couche intermédiaire transparente;
- `Fond_PremierPlan.png` : conduites transparentes au premier plan.

Pour les trois images :

- Texture Type : `Sprite (2D and UI)`;
- Sprite Mode : `Single`;
- Pixels Per Unit : `80`;
- Filter Mode : `Point (no filter)`;
- Compression : `None`.

Activez `Alpha Is Transparency` pour `Fond_Usine` et `Fond_PremierPlan`.

## Hiérarchie recommandée

```text
Scene_Sprites
  ArrierePlan
    Fond_Lointain
    Fond_Usine
    Fond_PremierPlan
  Grid
    Sol
    Murs
    Decoration
  Joueur
  Batterie
  Batterie (1)
  Batterie (2)
  ZoneInterdite
  PorteSortie
  PointDepart
```
