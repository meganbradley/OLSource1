---
title: "CDC::AbortPath"
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
  - CDC.AbortPath
  - AbortPath
  - CDC::AbortPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - AbortPath method
  - CDC class, path functions
ms.assetid: 9f55961c-28b3-44a6-b29c-137f53207ab0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::AbortPath
Closes and discards any paths in the device context.  
  
## Syntax  
  
```  
  
BOOL AbortPath( );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 If there is an open path bracket in the device context, the path bracket is closed and the path is discarded. If there is a closed path in the device context, the path is discarded.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)