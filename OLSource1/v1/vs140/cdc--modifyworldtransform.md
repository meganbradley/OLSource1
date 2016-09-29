---
title: "CDC::ModifyWorldTransform"
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
  - "CDC::ModifyWorldTransform"
  - "CDC.ModifyWorldTransform"
  - "ModifyWorldTransform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ModifyWorldTransform method"
  - "CDC class, mapping functions"
ms.assetid: b58cf614-29c8-4fac-a3f9-98d72962ff3a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ModifyWorldTransform
Changes the world transformation for a device context using the specified mode.  
  
## Syntax  
  
```  
BOOL ModifyWorldTransform(  
   const XFORM& rXform,  
   DWORD iMode  
);  
```  
  
#### Parameters  
 `rXform`  
 Reference to an [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure used to modify the world transformation for the given device context.  
  
 `iMode`  
 Specifies how the transformation data modifies the current world transformation. For a list of the values that this parameter can take, see [ModifyWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145060).  
  
## Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 This method wraps the Windows GDI function [ModifyWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145060).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)