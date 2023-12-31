﻿using System.Linq.Expressions;



namespace BookStore.Models

{
    public class QueryOptions<T> 
    {
        //----- Attributes -----

        public Expression<Func<T, object>> OrderBy { get; set; } = null!;
        public Expression<Func<T, bool>> Where { get; set; } = null!;
        public string OrderByDirection { get; set; } = "asc";                   // Default value
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        //----- Methods -----



        //code for working with Include strings
        private string[] includes = Array.Empty<string>();

        //public write-only property for Include strings
        //accepts a string, converts it to a string array,
        //and stores in private string array field
        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');

        }
        // public get method for Include strings - returns private string array, or
        // empty string array if private backing field is null
        public string[] GetIncludes() => includes;

        // read-only properties 
        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;
        public bool HasPaging => PageNumber > 0 && PageSize > 0;

    }
}
