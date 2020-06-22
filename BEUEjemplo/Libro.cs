//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUEjemplo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Libro
    {
        [ScaffoldColumn(false)]

        public int id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El titulo es requerido"), MaxLength(55)]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Los autores son requeridos"), MaxLength(55)]
        [Display(Name = "Autor")]
        public string autores { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El ISBM es requerido"), MaxLength(55)]
        [Display(Name = "iSBM")]
        public string ISBM { get; set; }
        [Display(Name = "Fecha de Publicación")]

        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> fpublicacion { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El numero de ejemplares es requerido"), MaxLength(55)]
        [Display(Name = "Numero de Ejemplares")]
        public string nejemplares { get; set; }
        [Display(Name = "Categoria")]
        public Nullable<int> id_categoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
