using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibBase.Entity;
using Phoenix.Domain.Model.Base;


namespace PricingTool.DAL.Model
{
    public class Classifier : BaseEntity, IBaseNameable, IBaseDescriptable
    {
        /// <summary>
		/// Наименование
		/// </summary>
		[Index("Index_Classifier_Name", 1, IsUnique = false)]
        [MinLength(1)]
        [MaxLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [Index("Index_Classifier_Code", 1, IsUnique = false)]
        [MinLength(1)]
        [MaxLength(250)]
        public string Code { get; set; }
        /// <summary>
        /// Тип справочника
        /// </summary>
        public virtual ClassifierType ClassifierType { get; set; }
        /// <summary>
        /// Родитель
        /// </summary>
        public virtual Classifier Parent { get; set; }
        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int SortOrder { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public string Description { get; set; }
    }
}
