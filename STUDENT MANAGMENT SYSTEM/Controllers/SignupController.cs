//using STUDENT_MANAGMENT_SYSTEM.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Google.Cloud.Firestore;
//using System.Web.Mvc;
//using System.Net.Http;
//using System.Threading.Tasks;
//using FirebaseAdmin;
//using Google.Apis.Auth.OAuth2;
//using student_managment.Models;
//using Google.Type;

//namespace STUDENT_MANAGMENT_SYSTEM.Controllers
//{

//    public class FirebaseService
//    {
//        private readonly FirestoreDb _db;

//        public FirebaseService(string projectId)
//        {
//            _db = FirestoreDb.Create(projectId);
//        }

//        public class SignupController : Controller
//    {


//            private readonly FirestoreDb _db;

//            //private lindaaEntities1 db = new lindaaEntities1();
//            // POST: Signup/Create
//            [HttpPost]
//        public ActionResult Create1(FirebaseData res)
//        {
//            if (ModelState.IsValid)
//            {
//                //db.users.Add(res);
//                //db.SaveChanges();
//                return RedirectToAction("View1");
//                // Process and save the user data to the database
//                // For this example, we'll skip database operations

//            }
//            return View();
//            // Retrieve data from your data source (e.g., database)
//            //string data = "This is the data you retrieved.";

//            //return Json(new { data = res }, JsonRequestBehavior.AllowGet);
//        }
//            public async Task Creates(FirebaseData res )
//            {
//                CollectionReference collection = _db.Collection("res");
//                await collection.AddAsync(res);
   
//            }
//        }
//        /// <test>
//        /// 
//        /// 
//        /// </summary>




//        //


//        class FirebaseConfig
//        {
//            public static FirebaseApp InitializeFirebaseApp()
//            {
//                FirebaseApp firebaseApp;

//                // Replace "path/to/your/firebase/credentials.json" with the actual path to your Firebase Admin SDK credentials JSON file.
//                var credentials = GoogleCredential.FromFile("path/to/your/firebase/credentials.json");

//                var firebaseAppOptions = new AppOptions()
//                {
//                    Credential = credentials,
//                };

//                // Replace "your-firebase-app-id" with your Firebase project's App ID.
//                firebaseApp = FirebaseApp.Create(new AppOptions
//                {
//                    Credential = credentials,
//                    ProjectId = "your-firebase-project-id",
//                }, "your-firebase-app-id");

//                return firebaseApp;
//            }
//        }
//    }
//}

//    // GET: Signup/Edit/5
