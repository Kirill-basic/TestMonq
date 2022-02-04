using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace DataLayer.Models
{
    public enum Status
    {
        OK,
        Failed
    }

    public class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

//TODO:разобраться с массивом
        public string Recipients { get; set; }

        public DateTime DateOfCreation { get; set; }

        public Status? Result { get; set; }

        public string FailedMessage { get; set; }
    }
}