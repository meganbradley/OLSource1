---
title: "CDaoDatabase::GetRelationCount"
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
  - "GetRelationCount"
  - "CDaoDatabase::GetRelationCount"
  - "CDaoDatabase.GetRelationCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tables [C++], getting counts of relations"
  - "tables [C++]"
  - "GetRelationCount method"
  - "databases [C++], getting counts of relations"
  - "relationships [C++], many-to-many"
  - "counting relations"
  - "one-to-many relationships [C++], counting"
  - "DAO [C++], getting information about tables"
ms.assetid: 0328dc9f-8ea9-4e9a-8072-5c90e866928e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetRelationCount
Call this member function to obtain the number of relations defined between tables in the database.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of relations defined between tables in the database.  
  
## Remarks  
 **GetRelationCount** is useful if you need to loop through all defined relations in the database's Relations collection. To obtain information about a given relation in the collection, see [GetRelationInfo](../vs140/cdaodatabase--getrelationinfo.md).  
  
 To illustrate the concept of a relation, consider a Suppliers table and a Products table, which might have a one-to-many relationship. In this relationship, one supplier can supply more than one product. Other relations are one-to-one and many-to-many.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)