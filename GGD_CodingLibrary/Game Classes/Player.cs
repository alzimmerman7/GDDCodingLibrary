/*
    Made by alzimmerman7

    Useful code for 2D games
    Can be used for 2D Sidescroller and 2D Topdown
    However, Default will be set to Sidescroller, to switch uncomment the ones
    labeled for topdown and recomment the ones for sidescroller
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    /*
        This is the explanation of the Player class and what needs to be included for 
        standard 2D single player games
        
        The Player class will include the foundations of what the player can do such as:
            movement
            collision
            animation - will not be gone into due to differences based on game engine prefrence
            action
     */
    internal class Player
    {
        Utility util;
        Collision collision;

        private readonly IKeyboardInput kbInput;
        private readonly IMouseInput mouseInput;

        //Player based Properties

        //Player Based Variables
        private float X; //Holds X position
        private float Y; //Holds Y position
        private float _gravity;
        private float _friction;
        private float _velocity;

        internal Player(IKeyboardInput _kbInput, IMouseInput _mouseInput)
        {
            kbInput = _kbInput;
            mouseInput = _mouseInput;
            collision = new Collision();

            //Key Actions
            kbInput.OnKeyPressed += KeyAction;

            //Set any Player Constants Here
        }

        //Movement and Action Controls via Key Presses
        private void KeyAction(string key)
        {
            switch (key.ToLower())
            {
                case "rightarrow":
                    MoveRight();
                    break;
                case "d":
                    MoveRight();
                    break;
                case "uparrow":
                    //Use MoveUp for TopDown
                    //MoveUp(); //(Use for moving vertically upward)

                    //Use Jump and MoveUp for SideScroller
                    MoveUp(); //(Use for ladders or other upward movements)
                    Jump(); //(Use for basic jumping)
                    break;
                case "w":
                    //Use MoveUp for TopDown
                    //MoveUp(); //(Use for moving vertically upward)

                    //Use Jump and MoveUp for SideScroller
                    MoveUp(); //(Use for ladders or other upward movements)
                    Jump(); //(Use for basic jumping)
                    break;
                case "downarrow":
                    //Use MoveDown for TopDown
                    //MoveDown(); //(Use for moving vertically Downward)

                    //Use MoveDown and Crouch for SideScroller
                    Crouch(); //(Use for making the player crouch)
                    MoveDown(); //(Use for ladders or other downward movements)
                    break;
                case "s":
                    //Use MoveDown for TopDown
                    //MoveDown(); //(Use for moving vertically Downward)

                    //Use MoveDown and Crouch for SideScroller
                    Crouch(); //(Use for making the player crouch)
                    MoveDown(); //(Use for ladders or other downward movements)
                    break;
                case "leftarrow":
                    MoveLeft();
                    break;
                case "a":
                    MoveLeft();
                    break;
                case "space":
                    //Use Jump for sidescrollers, for topdown there's no jump
                    Jump();

                    //For Topdown space can be used for other actions
                    break;
                case "enter":
                    break;
                case "escape":
                    break;
            }
        }

        //---------------------------------
        //Collision for rectangle hitboxes
        //---------------------------------

        //Create a list of nearby tiles and use their hitboxes stored as an AABB
        //to compare against the hitbox of your player

        //To create the list of nearby tiles you can use your players X and Y as
        //a guide to locate the tiles near those coordinates

        //Use these methods
        private void ResolveCollision()
        {
            //Detects if they are Colliding
            //collision.Intersects(Player AABB, Tile AABB)

            //Calculates the amount the player needs to move to resolve it
            //and returns it as a List of two values the X and Y
            //List<float> directionVector = collision.Intersect(Player AABB, Tile AABB)

            //Once you have the X and Y that the player needs to move to avoid collision
            //You move the player accordingly
            //player.X += directionVector[0];
            //player.Y += directionVector[1];

            //This method works the same for sidescroller and topdown
            //It will prevent the player sprite from overlapping any surrounding sprites
        }

        //--------------------------------------------------------------------------------------------------
        //Movement
        //  For player movement it is typical to change the players position in the X and Y directions
        //  In 2D side scroller to go Left & Right you would change the X and to Jump & Crouch you change Y
        //      - Specifically for crouching you can either change the Y or make the player size be smaller
        //  In 2D Top Down to go Left & Right change the X and to move Up & Down change the Y
        //  Depending on the X & Y axis in your chosen game engine you either subtract or add to the X & Y
        //  
        //  Depending on whether you want to add friction or acceleration to your movement you can either 
        //  change the X and Y using vectors or set numbers
        //
        //  For Gravity needed when jumping or falling in a sidescroller it should be a set number that is
        //  continuously added to the Y direction while the player is not colliding with anything in the
        //  bottom Y direction. When the player is on solid tiles the gravity should no longer be added
        //
        //  For actions that affect movement such as a dash, double jump, speed boost, etc. They should be
        //  made seperate from the normal movement as their own methods and get called when needed
        //--------------------------------------------------------------------------------------------------

        //Character Moves Left
        private void MoveLeft(){}

        //Character Moves Right
        private void MoveRight(){}

        //Character Moves Up
        private void MoveUp() { }

        //Character Moves Down
        private void MoveDown() { }

        //Character Jumps
        private void Jump() { }

        //Character Crouchs
        private void Crouch() { }

        //-----------------------------------------------------------------------------------------
        //Action
        //The action section of the player class completely depends on what you want for you game
        //Most of the methods are completely specific depending on what you do
        //However, there are some base things that are often used in games such as:
        //  - attacking
        //  - interacting
        //  - movement based actions
        //attacking and interacting would be down through either mouse or keyboard inputs and
        //movement based actions would mostly be carried out through keyboard inputs
        //-----------------------------------------------------------------------------------------
    }
}
