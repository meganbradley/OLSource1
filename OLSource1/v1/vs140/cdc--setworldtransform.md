---
title: "CDC::SetWorldTransform"
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
  - SetWorldTransform
  - CDC.SetWorldTransform
  - CDC::SetWorldTransform
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, mapping functions
  - SetWorldTransform method
ms.assetid: d46e16a0-8b4b-4b3e-be55-a544e8805ada
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::SetWorldTransform
Sets a two-dimensional linear transformation between world space and page space for the specified device context. This transformation can be used to scale, rotate, shear, or translate graphics output.  
  
## Syntax  
  
```  
BOOL SetWorldTransform(  
   const XFORM& rXform  
);  
```  
  
#### Parameters  
 `rXform`  
 Reference to an [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure that contains the transformation data.  
  
## Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 This method wraps the Windows GDI function [SetWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145104).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)