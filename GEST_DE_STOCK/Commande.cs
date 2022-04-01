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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Ligne_commande = new HashSet<Ligne_commande>();
            this.Livraison = new HashSet<Livraison>();
        }
    
        public int ID_commande { get; set; }
        public string ID_employe { get; set; }
        public System.DateTime Date_commande { get; set; }
        public int ID_fournisseur { get; set; }
        public int montant_commande { get; set; }
    
        public virtual Employe Employe { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ligne_commande> Ligne_commande { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livraison> Livraison { get; set; }
    }
}