---
title: "CSingleLock::IsLocked"
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
  - IsLocked
  - CSingleLock.IsLocked
  - CSingleLock::IsLocked
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsLocked method
ms.assetid: 9d23fecc-be98-4fa1-a878-667b7178f9e3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSingleLock::IsLocked
Determines if the object associated with the `CSingleLock` object is nonsignaled (unavailable).  
  
## Syntax  
  
```  
  
BOOL IsLocked( );  
  
```  
  
## Return Value  
 Nonzero if the object is locked; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_Utilities#20](../vs140/codesnippet/CPP/csinglelock--islocked_1.h)]
  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSingleLock Class](../vs140/csinglelock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)