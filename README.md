[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

Write about how the plan you wrote in the MG2 break-down activity connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

In my MG2 break-down activity, my plan was to set up a player GameObject which includes the sprite aas well as a script that handled movement, collision, and UI. In the script, I ended up using an OnTriggerEnter method where, if the player collided with a trigger collider with the tag "Coin", it would call the method CoinCaught as well as destroying the coin it collided with. CoinCaught() added 1 to the int variable _points and updated the points text at the top left. For the jumping, I checked if space was pressed and if _isGrounded was true, and used rigidbody to move the player up. The ground GameObject had the tag "Ground" and a collider, so if the player was collided with something with the tag "Ground", _isGrounded would be set to true, and false if not.

In the plan, I said the player would spawn in the coin, so what I did was look for a way to spawn in the sprite consistently. I found a something called [InvokeRepeating](https://docs.unity3d.com/ScriptReference/MonoBehaviour.InvokeRepeating.html?ampDeviceId=70fcabe6-263a-4fdd-84b0-856e5c0e0bc0&ampSessionId=1768859250044&ampTimestamp=1768946405383) which allowed me to spawn in the coin prefab at regular intervals using the method SpawnCoin(). In SpawnCoin(), I used Random.Range to set an int variable to something between 1 and 4, and if the variable == 2, it would instantiate the coin prefab as well as destroy it after a certain amount of time had passed (which was right after it exited the screen). The plan also said the coin would move towards the player, and this was done by putting a separate script on the coin prefab called CoinMovement() which moved the coin consistently to the left using transform.Transkate.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
