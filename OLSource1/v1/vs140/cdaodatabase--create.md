---
title: "CDaoDatabase::Create"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoDatabase.Create"
  - "CDaoDatabase::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDB databases"
  - "databases [C++], creating"
  - "Create method [C++]"
  - "DAO [C++], creating Jet databases"
  - "Jet databases [C++]"
  - "Jet databases [C++], creating"
  - "CDaoDatabase class, creating"
ms.assetid: cd67b89e-dc1d-4cbf-b066-127bfd5c1917
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::Create
To create a new Microsoft Jet (.MDB) database, call this member function after you construct a `CDaoDatabase` object.  
  
## Syntax  
  
```  
  
      virtual void Create(   
   LPCTSTR lpszName,   
   LPCTSTR lpszLocale = dbLangGeneral,   
   int dwOptions = 0    
);  
```  
  
#### Parameters  
 `lpszName`  
 A string expression that is the name of the database file that you are creating. It can be the full path and filename, such as "C:\\\MYDB.MDB". You must supply a name. If you do not supply a filename extension, .MDB is appended. If your network supports the uniform naming convention (UNC), you can also specify a network path, such as "\\\\\\\MYSERVER\\\MYSHARE\\\MYDIR\\\MYDB". Only Microsoft Jet (.MDB) database files can be created using this member function. (Double backslashes are required in string literals because "\\" is the C++ escape character.)  
  
 `lpszLocale`  
 A string expression used to specify collating order for creating the database. The default value is **dbLangGeneral**. Possible values are:  
  
-   **dbLangGeneral** English, German, French, Portuguese, Italian, and Modern Spanish  
  
-   **dbLangArabic** Arabic  
  
-   **dbLangCyrillic** Russian  
  
-   **dbLangCzech** Czech  
  
-   **dbLangDutch** Dutch  
  
-   **dbLangGreek** Greek  
  
-   **dbLangHebrew** Hebrew  
  
-   **dbLangHungarian** Hungarian  
  
-   **dbLangIcelandic** Icelandic  
  
-   **dbLangNordic** Nordic languages (Microsoft Jet database engine version 1.0 only)  
  
-   **dbLangNorwdan** Norwegian and Danish  
  
-   **dbLangPolish** Polish  
  
-   **dbLangSpanish** Traditional Spanish  
  
-   **dbLangSwedfin** Swedish and Finnish  
  
-   **dbLangTurkish** Turkish  
  
 `dwOptions`  
 An integer that indicates one or more options. Possible values are:  
  
-   **dbEncrypt** Create an encrypted database.  
  
-   **dbVersion10** Create a database with Microsoft Jet database version 1.0.  
  
-   **dbVersion11** Create a database with Microsoft Jet database version 1.1.  
  
-   **dbVersion20** Create a database with Microsoft Jet database version 2.0.  
  
-   **dbVersion30** Create a database with Microsoft Jet database version 3.0.  
  
 If you omit the encryption constant, an unencrypted database is created. You can specify only one version constant. If you omit a version constant, a database that uses the Microsoft Jet database version 3.0 is created.  
  
> [!CAUTION]
>  If a database is not encrypted, it is possible, even if you implement user/password security, to directly read the binary disk file that constitutes the database.  
  
## Remarks  
 **Create** creates the database file and the underlying DAO database object and initializes the C++ object. The object is appended to the associated workspace's Databases collection. The database object is in an open state; do not call **Open** after **Create**.  
  
> [!NOTE]
>  With **Create**, you can create only Microsoft Jet (.MDB) databases. You cannot create ISAM databases or ODBC databases.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase::CDaoDatabase](../vs140/cdaodatabase--cdaodatabase.md)