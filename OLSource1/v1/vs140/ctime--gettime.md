---
title: "CTime::GetTime"
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
  - "CTime.GetTime"
  - "ATL::CTime::GetTime"
  - "ATL.CTime.GetTime"
  - "CTime::GetTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTime method"
  - "CTime class, extraction"
ms.assetid: 82e9dc7e-c7d3-492b-a26c-c129613b4a81
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetTime
Returns a **__time64_t** value for the given `CTime` object.  
  
## Syntax  
  
```  
  
__time64_t GetTime( ) const throw( );  
```  
  
## Return Value  
 **GetTime** will return the number of seconds between the current `CTime` object and January 1, 1970.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#158](../vs140/codesnippet/CPP/ctime--gettime_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::CTime](../vs140/ctime--ctime.md)