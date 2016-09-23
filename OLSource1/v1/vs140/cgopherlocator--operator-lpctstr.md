---
title: "CGopherLocator::operator LPCTSTR"
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
  - CGopherLocator.operatorLPCTSTR
  - operatorLPCTSTR
  - CGopherLocator::operatorLPCTSTR
dev_langs: 
  - C++
helpviewer_keywords: 
  - CGopherLocator class, operators
  - LPCTSTR
  - operator LPCTSTR
ms.assetid: 09830ab5-6a2b-4f10-a169-0e5aad5398c6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGopherLocator::operator LPCTSTR
This useful casting operator provides an efficient method to access the null-terminated C string contained in a `CGopherLocator` object.  
  
## Syntax  
  
```  
  
operator LPCTSTR ( ) const;  
  
```  
  
## Return Value  
 A character pointer to the string's data.  
  
## Remarks  
 No characters are copied; only a pointer is returned.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)