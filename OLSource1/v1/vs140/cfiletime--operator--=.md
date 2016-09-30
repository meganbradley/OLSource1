---
title: "CFileTime::operator -="
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
  - "CFileTime::operator-="
  - "ATL.CFileTime.operator-="
  - "ATL::CFileTime::operator-="
  - "CFileTime.operator-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-="
  - "-= operator"
ms.assetid: 0f243532-05e3-4203-b381-b0badcc866b5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::operator -=
This operator is used to perform subtraction on a `CFileTimeSpan` object and assign the result to the current object.  
  
## Syntax  
  
```  
  
      CFileTime& operator -=(  
   CFileTimeSpan span   
) throw( );  
```  
  
#### Parameters  
 `span`  
 A `CFileTimeSpan` object containing the relative time to subtract.  
  
## Return Value  
 Returns the updated `CFileTime` object.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)   
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)