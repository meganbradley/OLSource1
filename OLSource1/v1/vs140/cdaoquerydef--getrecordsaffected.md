---
title: "CDaoQueryDef::GetRecordsAffected"
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
  - CDaoQueryDef.GetRecordsAffected
  - GetRecordsAffected
  - CDaoQueryDef::GetRecordsAffected
dev_langs: 
  - C++
helpviewer_keywords: 
  - DAO (Data Access Objects), records affected by Execute function
  - QueryDef objects, records affected by Execute
  - GetRecordsAffected method
  - records, affected by querydef Execute
  - CDaoQueryDef class, records affected by Execute
ms.assetid: bf338492-0231-44e2-9611-e026cf88501e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::GetRecordsAffected
Call this member function to determine how many records were affected by the last call of [Execute](../vs140/cdaoquerydef--execute.md).  
  
## Syntax  
  
```  
  
long GetRecordsAffected( );  
  
```  
  
## Return Value  
 The number of records affected.  
  
## Remarks  
 The count returned will not reflect changes in related tables when cascade updates or deletes are in effect.  
  
 For related information see the topic "RecordsAffected Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)