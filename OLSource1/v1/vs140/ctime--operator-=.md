---
title: "CTime::operator ="
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
  - CTime.operator=
  - CTime::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - = operator, with specific ATL objects
  - operator =, date time
  - operator=, date time
  - = operator, with specific MFC objects
  - CTime class, operators
ms.assetid: 5cddcd43-9598-4020-b3da-045efb395fb4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTime::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      CTime& operator =(  
   __time64_t time   
) throw( );  
```  
  
#### Parameters  
 `time`  
 The new date/time value.  
  
## Return Value  
 The updated `CTime` object.  
  
## Remarks  
 This overloaded assignment operator copies the source time into this `CTime` object. The internal time storage in a `CTime` object is independent of time zone. Time zone conversion is not necessary during assignment.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::CTime](../vs140/ctime--ctime.md)