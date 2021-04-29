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

For the score, each platform has a fucntion that increases the score by 1 when the player position is below the platform.

For the highscore i searched online a way to save them without using playerPrefs and found a tutorial on how to save and load from a binary file and used it to save the highscore. I made a new script "GameControl" where a save and load function were implemented to have access or modify the highscore in the file. Whenever a score surpasses the highscore, the highscore is updated and persists when reseting the game and can be also accessed by the main menu to display it.

To increase the platform spawn rate over time I made a simple function on the level manager that adds an acceleration whenever a platform spawns.

To change the initial spawn rate, an input field was created in the initial menu that lets the player choose the spawn rate from 1 to 10. I limited it this way because the game is unplayable at a rate over 10. I used the GameControl script to save the rate field.

Overall the parts that took the longest were figuring out a way to add a ponint to the score, after that the implementation was easy. Also finding out how to save a highscore without using playerPrefs, and I learned that playerPrefs is not secure to save data. Configuring the spawn data also took some time because initially I was tried to use remote config but the requirement didn't say it couldn't be done in the game so I decided to do directly on the menu screen.

I did not implement automatic tests as I didn't really understand how to do it.

By the end of the project i had some problems with git so the last thing I did, which was the spawn rate, had to be redone because it didn't get saved on git.

And when doing the build some problems emerged, the il2cpp wasn't installed, and some build errors appeared related to il2cpp, so I changed the Scripting backend to Mono.

After maing the build I noticed that the speed of the player was really low and the platform movement was lowas as well. I also noticed that it would be usefull to have a quit button to close the game. So I added the Quit button and changed the velocities of the objects.

