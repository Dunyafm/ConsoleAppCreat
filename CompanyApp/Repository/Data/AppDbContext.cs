using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

//Domain library - Bu library ayri bir priyektdir ozude bir dll,assemblerdir.
//Common icinde BaseEntity var abstract icinde Id qoymusuq icinde nacaq modellerimiz olur.
//Repository lr- Domainle elaqeni temin eden lr-dir.Domaindeki modelleri repository nin icinde inssalayzer edirik,(yeni istifade edirik)
//AppdbContext classi-Data bunun icinde saxlasin deye yaradiriq.
//Exceptions-Hansisa exception mesaji istediyimiz yerde gostermek ucun yaradiriq.
//Implimentetion-Interfacelerin implimentasiyasi,classlarda eilir!!!
//LibraryRepo-miras aldi Irepositroyden,impliment eledi hemin interfacesi.
//Servise lr- Service yazdigimiz metodlari impliment edirik istediyimiz elaveleri ora ede bilrerik.
//Her classin oz metodlari var,her class oz interfacelerini impliment eliyir.hamisi strukturlu sekilde.
//Referans ardiciligi-Domainden baslayir.Domainden IRepo,Service Repodan goturur,Company Serviceden goturur
//Repository-Domainden goturur.Repo databasadan klass vastesiyle datani goturur.
//
//
//






namespace Repository.Data
{
    public static class AppDbContext<T>
    {

        public static List<T> datas { get; }
        public AppDbContext()
        {

            datas = new List<T>();


        }













}   }
















 
