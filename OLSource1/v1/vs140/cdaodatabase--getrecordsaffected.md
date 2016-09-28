---
title: "CDaoDatabase::GetRecordsAffected"
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
  - "CDaoDatabase::GetRecordsAffected"
  - "GetRecordsAffected"
  - "CDaoDatabase.GetRecordsAffected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), records affected by Execute function"
  - "action queries [C++], records affected"
  - "SQL pass-through queries [C++]"
  - "SQL pass-through queries [C++], records affected"
  - "Execute method, records affected by"
  - "GetRecordsAffected method"
  - "records [C++], affected by Execute"
ms.assetid: b688843e-1634-4257-87cb-f118ef6cd136
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetRecordsAffected
Call this member function to determine the number of records affected by the most recent call of the [Execute](../vs140/cdaodatabase--execute.md) member function.  
  
## Syntax  
  
```  
  
long GetRecordsAffected( );  
  
```  
  
## Return Value  
 A long integer containing the number of records affected.  
  
## Remarks  
 The value returned includes the number of records deleted, updated, or inserted by an action query run with **Execute**. The count returned will not reflect changes in related tables when cascade updates or deletes are in effect.  
  
 For related information, see the topic "RecordsAffected Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)