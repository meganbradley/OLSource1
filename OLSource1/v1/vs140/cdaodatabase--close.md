---
title: "CDaoDatabase::Close"
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
  - "CDaoDatabase::Close"
  - "CDaoDatabase.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO objects [C++]"
  - "Close method"
  - "CDaoDatabase class, closing"
  - "DAO objects [C++], closing"
  - "Close method, DAO objects"
  - "database objects [C++], closing"
  - "databases [C++], effects of closing"
ms.assetid: 61a264e7-044f-412d-b907-19a9794ab47e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::Close
Call this member function to disconnect from a database and close any open recordsets, tabledefs, and querydefs associated with the database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 It is good practice to close these objects yourself before you call this member function. Closing a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object removes it from the Databases collection in the associated [workspace](../vs140/cdaoworkspace-class.md). Because **Close** does not destroy the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, you can reuse the object by opening the same database or a different database.  
  
> [!CAUTION]
>  Call the [Update](../vs140/cdaorecordset--update.md) member function (if there are pending edits) and the **Close** member function on all open recordset objects before you close a database. If you exit a function that declares [CDaoRecordset](../vs140/cdaorecordset-class.md) or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects on the stack, the database is closed, any unsaved changes are lost, all pending transactions are rolled back, and any pending edits to your data are lost.  
  
> [!CAUTION]
>  If you try to close a database object while any recordset objects are open, or if you try to close a workspace object while any database objects belonging to that specific workspace are open, those recordset objects will be closed and any pending updates or edits will be rolled back. If you try to close a workspace object while any database objects belonging to it are open, the operation closes all database objects belonging to that specific workspace object, which may result in unclosed recordset objects being closed. If you do not close your database object, MFC reports an assertion failure in debug builds.  
  
 If the database object is defined outside the scope of a function, and you exit the function without closing it, the database object will remain open until explicitly closed or the module in which it is defined is out of scope.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase::Open](../vs140/cdaodatabase--open.md)   
 [CDaoRecordset::Close](../vs140/cdaorecordset--close.md)   
 [CDaoWorkspace::Close](../vs140/cdaoworkspace--close.md)   
 [CDaoQueryDef::Close](../vs140/cdaoquerydef--close.md)   
 [CDaoTableDef::Close](../vs140/cdaotabledef--close.md)