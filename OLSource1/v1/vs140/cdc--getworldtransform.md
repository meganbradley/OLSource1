---
title: "CDC::GetWorldTransform"
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
  - "CDC::GetWorldTransform"
  - "CDC.GetWorldTransform"
  - "GetWorldTransform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "GetWorldTransform method"
ms.assetid: 991f3c7f-e5eb-4601-9364-d024150f0bf5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetWorldTransform
Retrieves the current world-space to page-space transformation.  
  
## Syntax  
  
```  
BOOL GetWorldTransform(  
   XFORM& rXform  
) const;  
```  
  
#### Parameters  
 `rXform`  
 Reference to an [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure that receives the current world-space to page-space transformation.  
  
## Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 This method wraps the Windows GDI function [GetWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd144953).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)