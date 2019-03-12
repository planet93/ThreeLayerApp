using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Phoenix.Domain.Model.Base;

namespace PricingTool.DAL.Model
{
    public class ClassifierType: BaseEntity
    {
        [Index("Index_ClassifierType_Name", 1, IsUnique = true)]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; }
        public string RusName { get; set; }

        /// <summary>
        /// Является системным типом
        /// </summary>
        public bool SystemType { get; set; } = false;
    }
}
