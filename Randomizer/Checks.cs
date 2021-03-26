using System;
using System.Collections.Generic;
using Assets.Items;

namespace Randomizer
{
    struct Check
    {
        string checkName { get; set;} //the common name for the check this can be used in the randomizer to identify the check."
        bool empty { get; set;} //Identifies if we already placed an item on this check (starts at true)
        bool logicalCondition { get; set;} //List of requirements to obtain this check while inside the room (so does not include the items needed to enter the room)
        ushort hash { get; set;} //the fletcher hash that will be compared to on stage load
        bool isExcluded { get; set;} //Identifies if the check is excluded or not. We can write the randomizer to not place important items in excluded checks
        List<string> checkCategory { get; set;} //Allows grouping of checks to make it easier to randomize them based on their type, region, exclusion status, etc.
        Item itemId { get; set;} //The original item id of the check. This allows us to make an array of all items in the item pool for randomization purposes. Also is useful for documentation purposes.
    }
}