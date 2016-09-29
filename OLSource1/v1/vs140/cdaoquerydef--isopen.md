---
title: "CDaoQueryDef::IsOpen"
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
  - "IsOpen"
  - "CDaoQueryDef.IsOpen"
  - "CDaoQueryDef::IsOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open state"
  - "CDaoQueryDef class, determining open status"
  - "QueryDef objects, getting information about"
  - "QueryDef objects, determining open status"
  - "IsOpen method"
  - "open state, querydefs"
ms.assetid: 8d60c0d2-0181-480f-b213-439e2324f3cf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::IsOpen
Call this member function to determine whether the `CDaoQueryDef` object is currently open.  
  
## Syntax  
  
```  
  
BOOL IsOpen( ) const;  
  
```  
  
## Return Value  
 Nonzero if the `CDaoQueryDef` object is currently open; otherwise 0.  
  
## Remarks  
 A querydef must be in an open state before you use it to call [Execute](../vs140/cdaoquerydef--execute.md) or to create a [CDaoRecordset](../vs140/cdaorecordset-class.md) object. To put a querydef into an open state call either [Create](../vs140/cdaoquerydef--create.md) (for a new querydef) or [Open](../vs140/cdaoquerydef--open.md) (for an existing querydef).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)