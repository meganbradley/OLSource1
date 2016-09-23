---
title: "CDaoQueryDef::GetDateLastUpdated"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoQueryDef::GetDateLastUpdated
  - CDaoQueryDef.GetDateLastUpdated
  - GetDateLastUpdated
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoQueryDef class, getting information
  - dates, date stamps
  - timestamps, querydefs
  - last update date in querydefs
  - QueryDef objects, getting date last updated
  - GetDateLastUpdated method
ms.assetid: 04f36a53-78ca-450e-b98f-1fa7ad996bf5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::GetDateLastUpdated
Call this member function to get the date the querydef object was last updated — when any of its properties were changed, such as its name, its SQL string, or its connection string.  
  
## Syntax  
  
```  
  
COleDateTime GetDateLastUpdated( );  
  
```  
  
## Return Value  
 A [COleDateTime](../vs140/coledatetime-class.md) object containing the date and time the querydef was last updated.  
  
## Remarks  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetDateCreated](../vs140/cdaoquerydef--getdatecreated.md)