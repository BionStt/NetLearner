﻿using System.Collections.Generic;

namespace NetLearnerWeb.Models
{
    public class ItemList
    {
        public int Id { get; set; }
        public List<LearningResourceItemList> LearningResourceItemLists
        {
            get; set;
        }
    }
}