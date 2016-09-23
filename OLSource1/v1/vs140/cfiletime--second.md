---
title: "CFileTime::Second"
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
  - ATL.CFileTime.Second
  - Second
  - CFileTime::Second
  - ATL::CFileTime::Second
  - CFileTime.Second
dev_langs: 
  - C++
helpviewer_keywords: 
  - Second method
ms.assetid: f8c533af-2b98-4882-ba24-b959f4afdc9c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileTime::Second
A static data member storing the number of 100-nanosecond intervals that make up one day.  
  
## Syntax  
  
```  
  
static const ULONGLONG Second = Millisecond* 1000;  
  
```  
  
## Example  
 See the example for [CFileTime::Millisecond](../vs140/cfiletime--millisecond.md).  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CFileTime Class](../vs140/cfiletime-class.md)