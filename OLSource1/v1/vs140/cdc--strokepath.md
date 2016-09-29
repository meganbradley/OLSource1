---
title: "CDC::StrokePath"
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
  - "StrokePath"
  - "CDC.StrokePath"
  - "CDC::StrokePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StrokePath method"
  - "CDC class, path functions"
ms.assetid: 3603723f-eaa9-4d40-b342-a62d51d48460
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::StrokePath
Renders the specified path by using the current pen.  
  
## Syntax  
  
```  
  
BOOL StrokePath( );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The device context must contain a closed path.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)   
 [StrokePath](http://msdn.microsoft.com/library/windows/desktop/dd145124)