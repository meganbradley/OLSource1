---
title: "CFileTime::operator ="
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
  - "CFileTime.operator="
  - "ATL::CFileTime::operator="
  - "ATL.CFileTime.operator="
  - "CFileTime::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, date time"
  - "operator=, date time"
  - "= operator, with specific MFC objects"
ms.assetid: 2be57771-83bf-4f35-85b3-c3d736033bfd
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      CFileTime& operator =(  
   const FILETIME& ft   
) throw( );  
```  
  
#### Parameters  
 `ft`  
 A `CFileTime` object containing the new time and date.  
  
## Return Value  
 Returns the updated `CFileTime` object.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)