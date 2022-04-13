using System;
using System.ComponentModel.DataAnnotations;

namespace NexaraProject.Core.Entities
{
    public interface IEntity<T>
        where T : struct
    {
        [Key]
        public T Id { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}