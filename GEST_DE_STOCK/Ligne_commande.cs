//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GEST_DE_STOCK
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ligne_commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ligne_commande()
        {
            this.Ligne_livraison = new HashSet<Ligne_livraison>();
        }
    
        public int ID_ligne_commande { get; set; }
        public int ID_commande { get; set; }
        public int ID_produit { get; set; }
        public int Qunatite_commande { get; set; }
        public int Prix_produit { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ligne_livraison> Ligne_livraison { get; set; }
    }
}