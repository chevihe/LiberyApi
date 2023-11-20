# LiberyApi
ספריה (בכמה סניפים):




 Book:


מאפינים:

קוד ספר-BookId


שם ספר -Name


מחבר-Writer


מצב (נמצא בספריה,נלקח ע"י מנוי)-State


קוד סניף אליו הוא שייך -BranchId


הצגת הספרים במלאי עם אופציות להצגת ספרים לפי :


א.	שם


ב.	ספרים שלא\ הושאלו


ג.	קוד הסניף אליו הוא שייך


(ניתן להשתמש: בכמה אופציות יחד \אחת מהן \ או לא בכלל) :

GET  https://localhost:7009/api/Book  



מציאת ספר לפי הקוד שלו :

GET https://localhost:7009/api/Book/1

	          

הכנסת ספר חדש : 

POST https://localhost:7009/api/Book 

	
	
עדכון ספר נלקח או הוחזר :

PUT https://localhost:7009/api/Book/status/1 



מחיקת ספר מהמלאי :

DELETE https://localhost:7009/api/Book/1







Branch:



מאפינים:



קוד סניף-BranchId


שם סניף -Name


כתובת-Adress


מנויים  Partner:  


.	הצגת הסניפים

GET https://localhost:7009/api/Branch

.	הצגת פרטי סניף לפי הקוד שלו
	
GET https://localhost:7009/api/Branch/1

.	הכנסת סניף חדש
	
POST https://localhost:7009/api/Branch

.	עדכון פירטי סניף קיים


PUT https://localhost:7009/api/Branch/1

.	מחיקת סניף

DELETE https://localhost:7009/api/Branch/1





Partner:


מאפינים:

קוד מנוי- PartnerId


שם מנוי- Name


כתובת- Addres


טלפון- Phone


קוד ספר שלווה  BookId-


פונקציות:



.  הצגת פירטי מנויים(אפשרות להצגת מנוי שהשאיל ספר מסוים לפי קוד ספר)

GET https://localhost:7009/api/Partner


.  הצגת פירטי מנוי לפי קוד 


 GET https://localhost:7009/api/Partner/1

 


.  הכנסת מנוי חדש


 POST https://localhost:7009/api/Partner
  

	
.  עדכון פירטי מנוי קיים

 
PUT https://localhost:7009/api/Partner/1
 

	
.  מחיקת מנוי 

 DELETE https://localhost:7009/api/Partner/1
 


