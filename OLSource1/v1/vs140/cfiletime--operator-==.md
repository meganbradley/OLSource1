---
title: "CFileTime::operator =="
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
  - "ATL::CFileTime::operator=="
  - "CFileTime.operator=="
  - "ATL.CFileTime.operator=="
  - "CFileTime::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, date time"
  - "operator ==, date time"
  - "== operator"
ms.assetid: 6b4eb79b-e950-4471-bdab-64fa18f512d4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileTime::operator ==
This operator compares two `CFileTime` objects for equality.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   CFileTime ft   
) const throw( );  
```  
  
#### Parameters  
 `ft`  
 The `CFileTime` object to compare.  
  
## Return Value  
 Returns **true** if the objects are equal, otherwise **false**.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)