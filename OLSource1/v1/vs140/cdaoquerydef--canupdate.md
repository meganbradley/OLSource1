---
title: "CDaoQueryDef::CanUpdate"
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
  - "CDaoQueryDef.CanUpdate"
  - "CanUpdate"
  - "CDaoQueryDef::CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), update support"
  - "CanUpdate method"
  - "updatability"
  - "QueryDef objects, updatability"
  - "CDaoQueryDef class, updatability"
ms.assetid: 1b28f414-8db0-43a0-9587-57f957b42476
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::CanUpdate
Call this member function to determine whether you can modify the querydef — such as changing its name or SQL string.  
  
## Syntax  
  
```  
  
BOOL CanUpdate( );  
  
```  
  
## Return Value  
 Nonzero if you are permitted to modify the querydef; otherwise 0.  
  
## Remarks  
 You can modify the querydef if:  
  
-   It is not based on a database that is open read-only.  
  
-   You have update permissions for the database.  
  
     This depends on whether you have implemented security features. MFC does not provide support for security; you must implement it yourself by calling DAO directly or by using Microsoft Access. See the topic "Permissions Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)