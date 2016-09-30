---
title: "CDC::GetClipBox"
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
  - "CDC.GetClipBox"
  - "GetClipBox"
  - "CDC::GetClipBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClipBox method"
  - "CDC class, clipping functions"
ms.assetid: 50c825a9-4af1-452b-82b6-029c32c89ae7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetClipBox
Retrieves the dimensions of the tightest bounding rectangle around the current clipping boundary.  
  
## Syntax  
  
```  
  
      virtual int GetClipBox(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to the [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that is to receive the rectangle dimensions.  
  
## Return Value  
 The clipping region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** Clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** Clipping region is empty.  
  
-   **SIMPLEREGION** Clipping region has no overlapping borders.  
  
## Remarks  
 The dimensions are copied to the buffer pointed to by `lpRect`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SelectClipRgn](../vs140/cdc--selectcliprgn.md)   
 [GetClipBox](http://msdn.microsoft.com/library/windows/desktop/dd144865)   
 [RECT Structure](../vs140/rect-structure.md)