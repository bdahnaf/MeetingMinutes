using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingMinutes.Domain
{
    public class BaseEntity
    {
        /// <summary>
        /// The Primary Key for the entity.
        /// </summary>
        public int Id { get; set; }

        // --- Auditing Properties ---

        /// <summary>
        /// The ID of the user who created this entity.
        /// It's nullable in case the creator is a system process or anonymous.
        /// </summary>
        public int? CreatedBy { get; set; }

        /// <summary>
        /// The timestamp when this entity was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ID of the user who last updated this entity.
        /// </summary>
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// The timestamp when this entity was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        // --- Soft Delete Properties ---

        /// <summary>
        /// The ID of the user who deleted this entity.
        /// </summary>
        public int? DeletedBy { get; set; }

        /// <summary>
        /// The timestamp when this entity was "soft deleted".
        /// A null value means the entity is active.
        /// </summary>
        public DateTime? DeletedAt { get; set; }
    }
}
