---
title: "CDaoDatabase::DeleteQueryDef"
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
  - "CDaoDatabase::DeleteQueryDef"
  - "CDaoDatabase.DeleteQueryDef"
  - "DeleteQueryDef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO [C++], deleting items"
  - "QueryDef objects, deleting"
  - "CDaoDatabase class, deleting querydefs"
  - "query definitions [C++]"
  - "databases [C++], deleting querydefs"
  - "DeleteQueryDef method"
ms.assetid: a2780bb4-7a8e-4482-ac98-a3ab235048e9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::DeleteQueryDef
Call this member function to delete the specified querydef — saved query — from the `CDaoDatabase` object's QueryDefs collection.  
  
## Syntax  
  
```  
  
      void DeleteQueryDef(   
   LPCTSTR lpszName    
);  
```  
  
#### Parameters  
 `lpszName`  
 The name of the saved query to delete.  
  
## Remarks  
 Afterwards, that query is no longer defined in the database.  
  
 For information about creating querydef objects, see class [CDaoQueryDef](../vs140/cdaoquerydef-class.md). A querydef object becomes associated with a particular `CDaoDatabase` object when you construct the `CDaoQueryDef` object, passing it a pointer to the database object.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::Create](../vs140/cdaoquerydef--create.md)   
 [CDaoDatabase::CreateRelation](../vs140/cdaodatabase--createrelation.md)   
 [CDaoTableDef::Create](../vs140/cdaotabledef--create.md)