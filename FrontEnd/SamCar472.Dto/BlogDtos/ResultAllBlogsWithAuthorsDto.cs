﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Dto.BlogDtos
{
    public class ResultAllBlogsWithAuthorsDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int CategoryID { get; set; }
    }
}
