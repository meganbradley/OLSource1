---
title: "CFileTime::UTCToLocal"
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
  - "UTCToLocal"
  - "CFileTime::UTCToLocal"
  - "ATL::CFileTime::UTCToLocal"
  - "CFileTime.UTCToLocal"
  - "ATL.CFileTime.UTCToLocal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UTCToLocal method"
ms.assetid: 5240c254-3411-48f3-8801-0e2d37d7dc49
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::UTCToLocal
Call this method to convert time based on the Coordinated Universal Time (UTC) to local file time.  
  
## Syntax  
  
```  
  
CFileTime UTCToLocal( ) const throw( );  
  
```  
  
## Return Value  
 Returns a `CFileTime` object containing the time in local file time format.  
  
## Example  
 [!code[NVC_MFCFiles#42](../vs140/codesnippet/CPP/cfiletime--utctolocal_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)   
 [CFileTime::LocalToUTC](../vs140/cfiletime--localtoutc.md)