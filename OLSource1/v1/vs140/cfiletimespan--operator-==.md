---
title: "CFileTimeSpan::operator =="
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
  - CFileTimeSpan::operator==
  - ATL::CFileTimeSpan::operator==
  - CFileTimeSpan.operator==
  - ATL.CFileTimeSpan.operator==
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator==, date time
  - operator ==, date time
  - == operator
ms.assetid: 3887d1bc-34fc-4f79-969a-1b9002202a24
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileTimeSpan::operator ==
Compares two `CFileTimeSpan` objects for equality.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   CFileTimeSpan span   
) const throw( );  
```  
  
#### Parameters  
 `span`  
 The `CFileTimeSpan` object to be compared.  
  
## Return Value  
 Returns **true** if the objects are equal, otherwise **false**.  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTimeSpan Class](../vs140/cfiletimespan-class.md)