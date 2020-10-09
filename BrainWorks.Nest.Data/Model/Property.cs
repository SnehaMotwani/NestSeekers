using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWorks.Nest.Data.Model
{
    public class Property
    {
        public int ID { get; set; }    //Primary key
        public String PropertyType{ get; set; }   //foreign key

        public PropertyType PropertyTypes {get;set;}   //reference of table for fk
        public String Address { get; set; }
        public String Landmarks { get; set; }
        public String City { get; set; }
        public String State{ get; set; }
        public int BHKTypeId { get; set; }    //Foreign Key

       public BHKType BHKType {get;set;}   //refrence of table for fk
        public int StatusId { get; set; }     //Foreign Key

        public Status Status{get;set;}       //reference of table for fk
        public String ConstructionYear { get; set; }
        public String Amenities { get; set; }
        public int TotalCarpetArea { get; set; }
        public int TotalBuiltupArea { get; set; }
        public int OwnerId { get; set; }    //Foreign Key
        public UserRole UserRole { get; set; } //reference of table for fk
        public int DirectionId { get; set; }  //Foreign key

        public Direction Direction{get;set;}   //reference of table for fk
        public int BathroomCount { get; set; }
        public int BalconyCount { get; set; }
        public String Parking { get; set; }
        public IList<PropertyType> PropertType { get; set; }
        public IList<BHKType> BHKTypes { get; set; }
        public IList<Status> Statuss { get; set; }
        public IList<UserRole> UserRoles { get; set; }
        public IList<Direction> Directions { get; set; }
        public IList<MyFavourites> MyFavourites { get; set; }
        public IList<Requests> Request{ get; set; }
        public IList<Document> Documents{ get; set; }



    }
}
