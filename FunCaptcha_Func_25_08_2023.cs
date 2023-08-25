public string GetImgInstructions_By_CaptCha69_Com(string CauHoiFullText)
{
	CauHoiFullText = CauHoiFullText.Trim().ToLower();
	if(CauHoiFullText.Contains("square icon pair similar")){return "ident";}
	else if(CauHoiFullText.Contains("square icon similar")){return "ident";}
	else if(CauHoiFullText.Contains("numericalmatch")){return "mask_match";}
	else if(CauHoiFullText.Contains("3d rollball animals alt")){return "finger_direction";}
	else if(CauHoiFullText.Contains("3d rollball animals")){return "finger_direction";}
	else if(CauHoiFullText.Contains("galaxy")){return "spiral_galaxy";}
	else if(CauHoiFullText.Contains("dice pair")){return "same_dice_pair";}
	else if(CauHoiFullText.Contains("dice 7 revised")){return "dicesum7";}
	else if(CauHoiFullText.Contains("dice 8 revised")){return "dicesum8";}
	else if(CauHoiFullText.Contains("dice 14 revised")){return "dicesum14";}
	else if(CauHoiFullText.Contains("dice 4 revised")){return "dicesum4";}
	else if(CauHoiFullText.Contains("dice slow 6 revised")){return "dicesum6";}
	else if(CauHoiFullText.Contains("dice slow 7 revised")){return "dicesum7";}
	else if(CauHoiFullText.Contains("dice slow 8 revised")){return "dicesum8";}
	else if(CauHoiFullText.Contains("dice slow 14 revised")){return "dicesum14";}
	else if(CauHoiFullText.Contains("dice slow 4 revised")){return "dicesum4";}
	else if(CauHoiFullText.Contains("pick one square that shows two identical objects")){return "ident";}
	else if(CauHoiFullText.Contains("pick the animal looking at the shape that matches the shape it's standing on")){return "animal_look_standing";}
	else if(CauHoiFullText.Contains("pick the image that is the correct way up")){return "rotated";}
	else if(CauHoiFullText.Contains("pick the shadow with a different object silhouette")){return "shadow_puppets";}
	else if(CauHoiFullText.Contains("pick the penguin")){return "penguins";}
	else if(CauHoiFullText.Contains("pick the card pair with matching numbers and symbols")){return "card";}
	else if(CauHoiFullText.Contains("pick the mouse that can't reach the cheese")){return "mouse_maze";}
	else if(CauHoiFullText.Contains("pick the mouse that can reach exactly 3 cheese in the maze")){return "mouse_maze";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 4")){return "dicesum4";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 6")){return "dicesum6";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 7")){return "dicesum7";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 8")){return "dicesum8";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 14")){return "dicesum14";}
	else if(CauHoiFullText.Contains("pick the dice pair with the same icon facing up")){return "same_dice_pair";}
	else if(CauHoiFullText.Contains("pick the matching cards")){return "card";}
	else if(CauHoiFullText.Contains("pick the spiral galaxy")){return "spiral_galaxy";}
	else if(CauHoiFullText.Contains("pick the wrong shadow")){return "wrong_shadow";}
	else if(CauHoiFullText.Contains("pick the butterfly")){return "butterfly";}
	else if(CauHoiFullText.Contains("pick the parrot")){return "parrot";}
	else if(CauHoiFullText.Contains("pick the dinosaur")){return "dinosaur";}
	else if(CauHoiFullText.Contains("pick the pig")){return "pig";}
	else if(CauHoiFullText.Contains("pick the bee")){return "bee";}
	else if(CauHoiFullText.Contains("pick the monkey")){return "monkey";}
	else if(CauHoiFullText.Contains("pick the snake")){return "snake";}
	else if(CauHoiFullText.Contains("pick the chicken")){return "chicken";}
	else if(CauHoiFullText.Contains("pick the ladybug")){return "ladybug";}
	else if(CauHoiFullText.Contains("pick the bread")){return "bread";}
	else if(CauHoiFullText.Contains("pick the octopus")){return "octopus";}
	else if(CauHoiFullText.Contains("pick the deer")){return "deer";}
	else if(CauHoiFullText.Contains("pick the cow")){return "cow";}
	else if(CauHoiFullText.Contains("pick the lobster")){return "lobster";}
	else if(CauHoiFullText.Contains("pick the apple")){return "apple";}
	else if(CauHoiFullText.Contains("pick the seal")){return "seal";}
	else if(CauHoiFullText.Contains("pick the camel")){return "camel";}
	else if(CauHoiFullText.Contains("pick the bear")){return "bear";}
	else if(CauHoiFullText.Contains("pick the crab")){return "crab";}
	else if(CauHoiFullText.Contains("pick the cat")){return "cat";}
	else if(CauHoiFullText.Contains("pick the pig")){return "pig";}
	else if(CauHoiFullText.Contains("pick the pineapple")){return "pineapple";}
	else if(CauHoiFullText.Contains("pick the ant")){return "ant";}
	else if(CauHoiFullText.Contains("pick the parrot")){return "parrot";}
	else if(CauHoiFullText.Contains("pick the owl")){return "owl";}
	else if(CauHoiFullText.Contains("pick the turtle")){return "turtle";}
	else if(CauHoiFullText.Contains("pick the donut")){return "donut";}
	else if(CauHoiFullText.Contains("pick the rabbit")){return "rabbit";}
	else if(CauHoiFullText.Contains("pick the banana")){return "banana";}
	else if(CauHoiFullText.Contains("pick the snail")){return "snail";}
	else if(CauHoiFullText.Contains("pick the pizza")){return "pizza";}
	else if(CauHoiFullText.Contains("pick the koala")){return "koala";}
	else if(CauHoiFullText.Contains("pick the duck")){return "duck";}
	else if(CauHoiFullText.Contains("pick the zebra")){return "zebra";}
	else if(CauHoiFullText.Contains("pick the sheep")){return "sheep";}
	else if(CauHoiFullText.Contains("pick the kangaroo")){return "kangaroo";}
	else if(CauHoiFullText.Contains("pick the dog")){return "dog";}
	else if(CauHoiFullText.Contains("pick the ice cream")){return "ice_cream";}
	else if(CauHoiFullText.Contains("pick the starfish")){return "starfish";}
	else if(CauHoiFullText.Contains("pick the dinosaur")){return "dinosaur";}
	else if(CauHoiFullText.Contains("pick the elephant")){return "elephant";}
	else if(CauHoiFullText.Contains("pick the shark")){return "shark";}
	else if(CauHoiFullText.Contains("pick the lion")){return "lion";}
	else if(CauHoiFullText.Contains("pick the grapes")){return "grapes";}
	else if(CauHoiFullText.Contains("pick the giraffe")){return "giraffe";}
	else if(CauHoiFullText.Contains("pick the bat")){return "bat";}
	else if(CauHoiFullText.Contains("pick the frog")){return "frog";}
	else if(CauHoiFullText.Contains("pick the goat")){return "goat";}
	else if(CauHoiFullText.Contains("pick the mouse")){return "mouse";}
	else if(CauHoiFullText.Contains("pick the dolphin")){return "dolphin";}
	else if(CauHoiFullText.Contains("pick the rhino")){return "rhino";}
	else if(CauHoiFullText.Contains("use the arrows to change the number of objects until it matches the left image")){return "mask_match";}
	else if(CauHoiFullText.Contains("use the arrows to rotate the animal to face in the direction of the hand")){return "finger_direction";}
	else if(CauHoiFullText.Contains("pick the mouse that can reach all the cheese in the maze")){return "mouse_multicheese_maze";}
	else if(CauHoiFullText.Contains("pick the shadow that matches the icons at the top of the image")){return "shadow_icons_top";}
	else if(CauHoiFullText.Contains("select the animal with the wrong head")){return "frankenhead";}
	else if(CauHoiFullText.Contains("pick the image of 2 checkered shapes")){return "two_checkered_shapes";}
	else if(CauHoiFullText.Contains("pick the image where all animals are walking in the same direction as the arrow")){return "animal_walk_arrow";}
	else if(CauHoiFullText.Contains("pick the image of the brick cone and the checkered cube")){return "mat_brickcone_checkercube";}
	else if(CauHoiFullText.Contains("pick the image of the brick cone and the checkered sphere")){return "mat_brickcone_checkersphere";}
	else if(CauHoiFullText.Contains("pick the image of the brick cone and the striped cone")){return "mat_brickcone_stripecone";}
	else if(CauHoiFullText.Contains("pick the image of the brick cube and the striped heart")){return "mat_brickcube_stripeheart";}
	else if(CauHoiFullText.Contains("pick the image of the brick cube and the striped sphere")){return "mat_brickcube_stripesphere";}
	else if(CauHoiFullText.Contains("pick the image of the brick heart and the striped heart")){return "mat_brickheart_stripeheart";}
	else if(CauHoiFullText.Contains("pick the image of the brick sphere and the checkered heart")){return "mat_bricksphere_checkerheart";}
	else if(CauHoiFullText.Contains("pick the image of the checkered cone and the checkered sphere")){return "mat_checkercone_checkersphere";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy cone and the brick sphere")){return "mat_fuzzcone_bricksphere";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy cube and the checkered cube")){return "mat_fuzzcube_checkercube";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy cube and the striped cube")){return "mat_fuzzcube_stripecube";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy heart and the brick heart")){return "mat_fuzzheart_brickheart";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy heart and the striped heart")){return "mat_fuzzheart_stripeheart";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy sphere and the striped cone")){return "mat_fuzzsphere_stripecone";}
	else if(CauHoiFullText.Contains("pick the image of the fuzzy sphere and the striped cube")){return "mat_fuzzsphere_stripecube";}
	else if(CauHoiFullText.Contains("pick the image of the striped cone and the checkered cube")){return "mat_stripecone_checkercube";}
	else if(CauHoiFullText.Contains("pick the image of the striped cube and the checkered cube")){return "mat_stripecube_checkercube";}
	else if(CauHoiFullText.Contains("pick the image of the striped cube and the checkered heart")){return "mat_stripecube_checkerheart";}
	else if(CauHoiFullText.Contains("pick the image of the striped cube and the checkered sphere")){return "mat_stripecube_checkersphere";}
	else if(CauHoiFullText.Contains("pick the image of the striped heart and the checkered cube")){return "mat_stripeheart_checkercube";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 6")){return "darts6";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 8")){return "darts8";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 10")){return "darts10";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 12")){return "darts12";}
	else if(CauHoiFullText.Contains("mat stripeshape checkershape")){return "mat_stripeshape_checkershape";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 9")){return "darts9";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 14")){return "darts14";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 17")){return "darts17";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 15")){return "darts15";}
	else if(CauHoiFullText.Contains("pick the image where the darts add up to 13")){return "darts13";}
	else if(CauHoiFullText.Contains("pick the alien")){return "alien";}
	else if(CauHoiFullText.Contains("pick the anchor")){return "anchor";}
	else if(CauHoiFullText.Contains("pick the aquarium")){return "aquarium";}
	else if(CauHoiFullText.Contains("pick the ball")){return "ball";}
	else if(CauHoiFullText.Contains("pick the bicycle")){return "bicycle";}
	else if(CauHoiFullText.Contains("pick the boat")){return "boat";}
	else if(CauHoiFullText.Contains("pick the calculator")){return "calculator";}
	else if(CauHoiFullText.Contains("pick the camera")){return "camera";}
	else if(CauHoiFullText.Contains("pick the car")){return "car";}
	else if(CauHoiFullText.Contains("pick the cheese")){return "cheese";}
	else if(CauHoiFullText.Contains("pick the computer")){return "computer";}
	else if(CauHoiFullText.Contains("pick the couch")){return "couch";}
	else if(CauHoiFullText.Contains("pick the crown")){return "crown";}
	else if(CauHoiFullText.Contains("pick the fan")){return "fan";}
	else if(CauHoiFullText.Contains("pick the fence")){return "fence";}
	else if(CauHoiFullText.Contains("pick the fire")){return "fire";}
	else if(CauHoiFullText.Contains("pick the flower")){return "flower";}
	else if(CauHoiFullText.Contains("pick the glasses")){return "glasses";}
	else if(CauHoiFullText.Contains("pick the helmet")){return "helmet";}
	else if(CauHoiFullText.Contains("pick the hotdog")){return "hotdog";}
	else if(CauHoiFullText.Contains("pick the key")){return "key";}
	else if(CauHoiFullText.Contains("pick the lamp")){return "lamp";}
	else if(CauHoiFullText.Contains("pick the money")){return "money";}
	else if(CauHoiFullText.Contains("pick the mushroom")){return "mushroom";}
	else if(CauHoiFullText.Contains("pick the pants")){return "pants";}
	else if(CauHoiFullText.Contains("pick the pencil")){return "pencil";}
	else if(CauHoiFullText.Contains("pick the printer")){return "printer";}
	else if(CauHoiFullText.Contains("pick the refrigerator")){return "refrigerator";}
	else if(CauHoiFullText.Contains("pick the ring")){return "ring";}
	else if(CauHoiFullText.Contains("pick the scissors")){return "scissors";}
	else if(CauHoiFullText.Contains("pick the shoe")){return "shoe";}
	else if(CauHoiFullText.Contains("pick the sock")){return "sock";}
	else if(CauHoiFullText.Contains("pick the spaceship")){return "spaceship";}
	else if(CauHoiFullText.Contains("pick the trophy")){return "trophy";}
	else if(CauHoiFullText.Contains("pick the watermelon")){return "watermelon";}
	else if(CauHoiFullText.Contains("pick the wristwatch")){return "wristwatch";}
	else if(CauHoiFullText.Contains("numericalmatch")){return "mask_match";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 5")){return "dicesum5";}
	else if(CauHoiFullText.Contains("pick the dice pair whose top sides add up to 9")){return "dicesum9";}
	else if(CauHoiFullText.Contains("use the arrows to move the person to the spot indicated by the cross")){return "hopscotch";}
	else if(CauHoiFullText.Contains("hopscotch v2")){return "hopscotch";}
	else if(CauHoiFullText.Contains("using the arrows, connect the same two icons with the dotted line as shown on the left")){return "icon_connect";}
	else if(CauHoiFullText.Contains("hopscotch highsec")){return "hopscotch_icon";}
	else if(CauHoiFullText.Contains("click the arrows to sum the dice and match the number on the left")){return "dicematch";}
	else if(CauHoiFullText.Contains("use the arrows to move the person to the icon indicated by the coloured circle")){return "hopscotch_icon";}
	else if(CauHoiFullText.Contains("use the arrows to move the person to the icon indicated by the colored circle")){return "hopscotch_icon";}
	else if(CauHoiFullText.Contains("use the arrows to move the person to the spot indicated by the cross")){return "hopscotch";}
	else if(CauHoiFullText.Contains("using the arrows, move the person to the indicated seat")){return "seat_coordinates";}
	else if(CauHoiFullText.Contains("coordinatesmatch")){return "seat_coordinates";}
	else if(CauHoiFullText.Contains("match reflection")){return "match_reflection";}
	else if(CauHoiFullText.Contains("counting")){return "counting";}
	else if(CauHoiFullText.Contains("stairs walking")){return "stairs_walking";}
	else if(CauHoiFullText.Contains("pick the umbrella")){return "umbrella";}
	else if(CauHoiFullText.Contains("pick the stapler")){return "stapler";}
	else if(CauHoiFullText.Contains("pick the snowman")){return "snowman";}
	else if(CauHoiFullText.Contains("pick the penguins-icon")){return "penguins-icon";}
	else if(CauHoiFullText.Contains("pick the lock")){return "lock";}
	else if(CauHoiFullText.Contains("pick the helicopter")){return "helicopter";}
	else if(CauHoiFullText.Contains("pick the guitar")){return "guitar";}
	else if(CauHoiFullText.Contains("pick the controller")){return "controller";}
	else if(CauHoiFullText.Contains("pick the burger")){return "burger";}
	else if(CauHoiFullText.Contains("pick the cactus")){return "cactus";}
	else if(CauHoiFullText.Contains("pick one square that shows three of the same object")){return "three_objects";}
	else if(CauHoiFullText.Contains("select the image where the total fingers add up to 4")){return "fingers_sum4";}
	else if(CauHoiFullText.Contains("select the image where the total fingers add up to 3")){return "fingers_sum3";}
	else if(CauHoiFullText.Contains("pick the shadow that matches the icons at the top of the image")){return "shadow_icons_top";}
	else if(CauHoiFullText.Contains("use the arrows to move the train into the position indicated in the left image")){return "train_stop";}
	else if(CauHoiFullText.Contains("use the arrows to move the train to the coordinates indicated in the left image")){return "train_coordinates";}
	else if(CauHoiFullText.Contains("pick the image with 3 circles in a row in any direction")){return "knots_crosses_circle";}
	else if(CauHoiFullText.Contains("pick the image with 3 crosses in a row in any direction")){return "knots_crosses_knot";}
	else if(CauHoiFullText.Contains("knotscrossescircle")){return "knots_crosses_circle";}
	else if(CauHoiFullText.Contains("knotscrossesknot")){return "knots_crosses_knot";}
	else if(CauHoiFullText.Contains("pick the cube with icons split in half")){return "mismatched_cube";}
	else if(CauHoiFullText.Contains("pick the image where the number matches the amount of animals")){return "counting";}
	else if(CauHoiFullText.Contains("3d rollball animals multi")){return "fingericon_animaldirection";}
	else if(CauHoiFullText.Contains("use the arrows to rotate the animal with the same icon to face where the hand is pointing")){return "fingericon_animaldirection";}
	else if(CauHoiFullText.Contains("pick the image with only one rope")){return "ropes";}
	else if(CauHoiFullText.Contains("use the buttons to place the indicated car, in the correct position in the race")){return "car_pos";}
	else if(CauHoiFullText.Contains("use the arrows to rotate the object to face in the direction of the hand")){return "3d_rollball_objects";}
	else if(CauHoiFullText.Contains("use the arrows to turn the animal's head in the direction of the hand")){return "finger_direction";}
	else if(CauHoiFullText.Contains("usa le frecce per ruotare l'animale in modo che sia rivolto nella direzione indicata dalla mano")){return "finger_direction";}
	return "ident";
}
