---
title: "CDaoWorkspace::CompactDatabase"
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
  - "CDaoWorkspace.CompactDatabase"
  - "CDaoWorkspace::CompactDatabase"
  - "CompactDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "databases [C++], compacting"
  - "CompactDatabase method"
  - "DAO [C++], compacting databases"
  - "workspaces [C++], compacting databases"
ms.assetid: a57ebab5-7e1f-4577-9943-edae5343bb5f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::CompactDatabase
Call this member function to compact a specified Microsoft Jet (.MDB) database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of an existing, closed database. It can be a full path and filename, such as "C:\\\MYDB.MDB". If the filename has an extension, you must specify it. If your network supports the uniform naming convention (UNC), you can also specify a network path, such as "\\\\\\\MYSERVER\\\MYSHARE\\\MYDIR\\\MYDB.MDB". (Double backslashes are required in the path strings because "\\" is the C++ escape character.)  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The full path of the compacted database that you are creating. You can also specify a network path as with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You cannot use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> argument to specify the same database file as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A password, used when you want to compact a password-protected database. Note that if you use the version of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that takes a password, you must supply all parameters. Also, because this is a connect parameter, it requires special formatting, as follows: ;PWD=<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For example: ;PWD="Happy". (The leading semicolon is required.)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A string expression used to specify collating order for creating <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If you omit this argument by accepting the default value of **dbLangGeneral** (see below), the locale of the new database is the same as that of the old database. Possible values are:  
  
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
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Indicates one or more options for the target database, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If you omit this argument by accepting the default value, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will have the same encryption and the same version as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. You can combine the **dbEncrypt** or **dbDecrypt** option with one of the version options using the bitwise-OR operator. Possible values, which specify a database format, not a database engine version, are:  
  
-   **dbEncrypt** Encrypt the database while compacting.  
  
-   **dbDecrypt** Decrypt the database while compacting.  
  
-   **dbVersion10** Create a database that uses the Microsoft Jet database engine version 1.0 while compacting.  
  
-   **dbVersion11** Create a database that uses the Microsoft Jet database engine version 1.1 while compacting.  
  
-   **dbVersion20** Create a database that uses the Microsoft Jet database engine version 2.0 while compacting.  
  
-   **dbVersion30** Create a database that uses the Microsoft Jet database engine version 3.0 while compacting.  
  
 You can use **dbEncrypt** or **dbDecrypt** in the options argument to specify whether to encrypt or to decrypt the database as it is compacted. If you omit an encryption constant or if you include both **dbDecrypt** and **dbEncrypt**, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will have the same encryption as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. You can use one of the version constants in the options argument to specify the version of the data format for the compacted database. This constant affects only the version of the data format of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. You can specify only one version constant. If you omit a version constant, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will have the same version as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You can compact <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> only to a version that is the same or later than that of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  If a database is not encrypted, it is possible, even if you implement user/password security, to directly read the binary disk file that constitutes the database.  
  
## Remarks  
 As you change data in a database, the database file can become fragmented and use more disk space than necessary. Periodically, you should compact your database to defragment the database file. The compacted database is usually smaller. You can also choose to change the collating order, the encryption, or the version of the data format while you copy and compact the database.  
  
> [!CAUTION]
>  The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function will not correctly convert a complete Microsoft Access database from one version to another. Only the data format is converted. Microsoft Access-defined objects, such as forms and reports, are not converted. However, the data is correctly converted.  
  
> [!TIP]
>  You can also use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to copy a database file.  
  
 For more information about compacting databases, see the topic "CompactDatabase Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::RepairDatabase](../vs140/cdaoworkspace--repairdatabase.md)