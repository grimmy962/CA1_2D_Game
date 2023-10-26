# CA1_2D_Game
2D game engine CA1
(put references, video link into the readme file and add the video on youtube to play it (have backup if the internet crashes))

Original Idea:
- ufo trying to get from the planet earth to their home planet - different spheres
- horizontal movement only
- background moves vertically
- if they hit one of the object they lose one of three lives
    - if they get hit more and more smoke will come out of the ufo
    - after they loose their last life it will fall out of the game screen
- maybe can pick up some items that can regain their life, make them smaller, bigger, faster, etc.
- maybe can shoot down some object or make it purely just trying to avoid objects (birds, planes, comets, other object)


Things I want to implement:
- enemies will have different animations when just moving and after the player defeats them + explosion, can see enemy hp
- hp and power meter, when power at max = big shots
- score for every defeated enemy
- hp hit = -1, max health 20
- when ship moves changes animation plus engine animation
- when suffering damage - let the player know via animation
- randomly spawned enemies
- can collect stuff to increase hp, power + collect coins
- make ui menu - can pause game, start game, quit game, maybe options
- after getting defeated make another menu with final score and save their best score, so that they know they defeated it in the future
- play again button, store to buy stuff with the coins



Resources:
background:
  https://opengameart.org/content/animated-stars-background
  https://opengameart.org/content/space-background-11

“ufo” and shooting effects:
  https://assetstore.unity.com/packages/2d/textures-materials/galaxia-2d-space-shooter-sprite-pack-1-64944

another shooting effects:
  https://assetstore.unity.com/packages/2d/textures-materials/abstract/warped-shooting-fx-195246

explosion effect:
  https://opengameart.org/content/explosion-effects-and-more

screams space invaders!!!!:
  https://opengameart.org/content/arcade-space-shooter-game-assets



Good videos to lean about unity:

- unity tutorial for complete beginners
    
    https://www.youtube.com/watch?v=XtQMytORBmM
    
- space invaders movement tutorial
    
    https://www.youtube.com/watch?v=G3OKV1fcsGk&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=9
    

References:

- remove background from a sprite sheet
    https://www.youtube.com/watch?v=IjmZVdCFtso
    
- slicing up the sprite sheet and tile palette making
    https://www.youtube.com/watch?v=G7e_fzG_0Bk
    
- getting rid of line in the background
    https://www.youtube.com/watch?v=ZPfswitRxwI
    

- flying enemy script
    https://www.youtube.com/watch?v=TIXY0TR7Z0g
    
- enemy ai follow tutorial
    https://www.youtube.com/watch?v=2SXa10ILJms
    
- moves and  shoots towards a player
    ttps://www.youtube.com/watch?v=lHLZxd0O6XY&t=43s
    
- another shooting tutorial
    https://www.youtube.com/watch?v=vkKulG71Yzo

- fixing a shooting bug problem
    https://stackoverflow.com/questions/53139921/2d-unity-shooting-bug
    
- enemy spawner
    https://www.youtube.com/watch?v=SELTWo1XZ0c
    - school notes from the arcade game

- spawner limit
    https://forum.unity.com/threads/enemy-spawner-limit.901520/

- characters animation
    
    https://www.youtube.com/watch?v=hkaysu1Z-N8
    
- shooting projectile
    
    https://www.youtube.com/watch?v=NfQ89CD0uyc&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=5
    

- animated explosion
    
    https://www.youtube.com/watch?v=srr7jfi1BlY&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=4
    
- losing lives
    
    https://www.youtube.com/watch?v=VMrtDjH7IMA&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=5
    
- keeping score
    
    https://www.youtube.com/watch?v=GXJMjWRAeMY&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=6
    
- how to pause a game
    
    https://www.youtube.com/watch?v=1gvcyybDzgY&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=8
    
- setting and saving high score
    
    https://www.youtube.com/watch?v=6PkdHcVFM6M&list=PLSR2vNOypvs5jmv1YIP_IVtlPnU5yEunL&index=9
    
- main menu
    
    https://www.youtube.com/watch?v=DX7HyN7oJjE
    
- game over screen
    
    https://www.youtube.com/watch?v=Bzjat5pskrM

Game Diary

- 13.10.
    - writing down the “story”, game mechanics and what kind of game objects will the game have
    - looking for sprite sheets and settling on space invaders inspired sprite sheet

- 14.10.
    - looking for 2D unity game tutorial
    - meddling with the sprite sheet for almost two hours
        - deleting the background (making it transparent)
        - slicing up the sprite sheet

16.10.

- tile palette
- getting rid of line in the background

17.10.

- added flying enemy script
- also they follow player when he gets too close

18.10.

- changed up a code a bit in flying enemy and chase control

21.10.

- found a tutorial on an enemy that moves and shoots towards the player
    - changed up the code a bit in the flying enemy to use the gizmo
    - added the shooting feature for the enemies
    - made some prefabs

22.10.
- added:
  -  another type of bullets
  -  enemies
  -  enemy spawner
  -  got rid of starting point
- had some problem with the code/how to do things
  -   in enemy spawner there is only one slot for enemy prefab (i needed three)
      - had to do three enemy spawners (not sure if that's right)
  - too many enemies spawning even though i have a limit
  - enemies not shooting "bullets"



What I found but probably won’t use for the ca(?)

- https://www.youtube.com/watch?v=zqvgqhsXhqg

video:
https://clipchamp.com/watch/BZhwbkpRsfA
https://www.youtube.com/watch?v=-oBICXUb8Nw