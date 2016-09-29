---
title: "CDC::WidenPath"
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
  - "CDC::WidenPath"
  - "CDC.WidenPath"
  - "WidenPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, path functions"
  - "WidenPath method"
ms.assetid: 0b40fba8-8028-4278-a114-3397709384a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::WidenPath
Redefines the current path as the area that would be painted if the path were stroked using the pen currently selected into the device context.  
  
## Syntax  
  
```  
  
BOOL WidenPath( );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 This function is successful only if the current pen is a geometric pen created by the second version of `CreatePen` member function, or if the pen is created with the first version of `CreatePen` and has a width, in device units, of greater than 1. The device context must contain a closed path. Any Bzier curves in the path are converted to sequences of straight lines approximating the widened curves. As such, no Bzier curves remain in the path after `WidenPath` is called.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)   
 [CDC::SetMiterLimit](../vs140/cdc--setmiterlimit.md)   
 [WidenPath](http://msdn.microsoft.com/library/windows/desktop/dd145200)