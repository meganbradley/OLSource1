---
title: "CDaoQueryDef::GetDateCreated"
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
  - "CDaoQueryDef::GetDateCreated"
  - "CDaoQueryDef.GetDateCreated"
  - "GetDateCreated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, getting information"
  - "dates, date stamps"
  - "timestamps, querydefs"
  - "QueryDef objects, getting creation dates"
  - "GetDateCreated method"
  - "creation date for querydef"
ms.assetid: 55c440c0-3411-4040-b303-25cd74e18475
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetDateCreated
Call this member function to get the date the querydef object was created.  
  
## Syntax  
  
```  
  
COleDateTime GetDateCreated( );  
  
```  
  
## Return Value  
 A [COleDateTime](../vs140/coledatetime-class.md) object containing the date and time the querydef was created.  
  
## Remarks  
 For related information, see the topic "DateCreated, LastUpdated Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetDateLastUpdated](../vs140/cdaoquerydef--getdatelastupdated.md)