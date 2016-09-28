---
title: "CFileTime::GetTime"
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
  - "CFileTime.GetTime"
  - "ATL::CFileTime::GetTime"
  - "ATL.CFileTime.GetTime"
  - "CFileTime::GetTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTime method"
ms.assetid: 09d638f4-d8d3-4bbe-b483-d1ce78a6b36b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::GetTime
Call this method to retrieve the time from the `CFileTime` object.  
  
## Syntax  
  
```  
  
ULONGLONG GetTime( ) const throw( );  
  
```  
  
## Return Value  
 Returns the date and time as a 64-bit number, which may be in either local or Coordinated Universal Time (UTC) format.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)   
 [CFileTime::SetTime](../vs140/cfiletime--settime.md)