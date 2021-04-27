# Project Review

## Stéphanie Andrade

---

<!-- Your review goes here -->
<!-- Explain why you did the things that way or any snippet that is word mentioning -->
<!-- If you had any issue and how you resolved them -->

For this project I started by changing the properties of the cube so that it would behave like the gif. I changed the mass, the drag and the speed so that it would move at a reasonable speed and fall through the platforms. I changed the collision detection to continuous so that the player would not pass through the floor or walls.

Then I proceeded with creating the spawning of the platforms. I made new different platform prefabs and created the script "PlatformGenerator" that spawns a new platform when the previous platform reaches a point in the sceen.

After I focused on creating the pause menu. I created a new panel on the canvas and added the buttons "Continue" and "Main menu" that when pressed call the respective. When the escape key is pressed, the time scale is set to 0 this way all objects on scene stop giving the pause illusion, and the pause panel is activated. Clicking in "Continue" or pressing the escape key again, will set the time scale at 1 and disable the pause panel so the game can proceed. When pressing the "Main menu" button the game changes to the initial home scene.

To make the player lose and do the bonus requirement of not using OnBecameInvisible for destroying the player, I added a ceiling object on the top of the scene and tagged it as "Limit" and the did the same for the floor, so when the player collides with an object tagged with "Limit" the game sops and activates the Game Over panel.

The Game Over screen has a button that returns to the main menu using the same function as the pause screen, and shows the current score and the highscore.




