using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using STUDENT_MANAGMENT_SYSTEM.Controllers;
using Google.Cloud.Firestore;
using System.Net.Http;
using System.Threading.Tasks;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using student_managment.Models;
using Google.Type;
using Microsoft.Ajax.Utilities;
using Google.Cloud.Firestore.V1;
using System.Net;
using Google.Protobuf.WellKnownTypes;
using System.Net.PeerToPeer;
using System.Data.Entity;

namespace STUDENT_MANAGMENT_SYSTEM.Controllers
{
    public class createController : Controller
    {
        FirestoreDb database;
        //public createController()
        //{
        //    INI
        //}
        private void create()
        {
            //FirestoreDb db = FirestoreDb.Create("student-managment-395611");
            string path = AppDomain.CurrentDomain.BaseDirectory + @"student.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("student-managment-395611");
        }
        public void testt(FirebaseData res)
        {
            create();
            CollectionReference coll = database.Collection("USERS");
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {

                { "firstname", res.firstname },
                {"lastname", res.lastname },
                {"password", res.password},
                {"username", res.username}
            };

            coll.AddAsync(data1);

        }

    }
}
    // GET: cre
    // ate
    //    public ActionResult testt(FirebaseData res)
    //    {
    //        var credentials = GoogleCredential.GetApplicationDefault();
    //        var firestoreDb = FirestoreDb.Create("student-managment-395611");
    //        var db = firestoreDb;
    //        var collection = db.Collection("USERS");
    //        var data = new Dictionary<string, object>
    //        {
    //            { "Field1", res }


    //        };
    //         collection.AddAsync(data);

    //        return Json(new { success = true });


    //    }

    //}
