---
title: "CMultiLock::IsLocked"
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
  - "CMultiLock.IsLocked"
  - "IsLocked"
  - "CMultiLock::IsLocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLocked method"
ms.assetid: 7bf6520f-92d2-473c-9ef4-075a0e77b5b9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiLock::IsLocked
Determines if the specified object is nonsignaled (unavailable).  
  
## Syntax  
  
```  
  
      BOOL IsLocked(  
   DWORD dwItem   
);  
```  
  
#### Parameters  
 *dwItem*  
 The index in the array of objects corresponding to the object whose state is being queried.  
  
## Return Value  
 Nonzero if the specified object is locked; otherwise 0.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)