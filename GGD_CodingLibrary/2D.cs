/*
    Made by alzimmerman7

    Useful code for 2D games
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    //Can be used for 2D Sidescroller and 2D Topdown
    //However, Default will be set to Sidescroller, to switch uncomment the ones
    //labeled for topdown and recomment the ones for sidescroller
    internal class _2D
    {
        Utility util;
        Collision collision;

        private readonly IKeyboardInput kbInput;
        private readonly IMouseInput mouseInput;

        internal _2D(IKeyboardInput _kbInput, IMouseInput _mouseInput)
        {
            kbInput = _kbInput;
            mouseInput = _mouseInput;
            collision = new Collision();

            //Key Actions
            kbInput.OnKeyPressed += KeyAction;
        }

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
            //It will prevent the player sprite from overalapping any surrounding sprite
        }

        //---------------------------------
        //Movement
        //---------------------------------

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

    }
}
