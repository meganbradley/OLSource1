---
title: "COleSafeArray::Lock"
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
  - "COleSafeArray.Lock"
  - "COleSafeArray::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 599fbbf3-5119-444b-948a-4d13c0df92f4
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Lock
Increments the lock count of an array and place a pointer to the array data in the array descriptor.  
  
## Syntax  
  
```  
  
void Lock( );  
```  
  
## Remarks  
 On error, it throws a [COleException](../vs140/coleexception-class.md).  
  
 The pointer in the array descriptor is valid until `Unlock` is called. Calls to `Lock` can be nested; an equal number of calls to `Unlock` are required.  
  
 An array cannot be deleted while it is locked.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Unlock](../vs140/colesafearray--unlock.md)