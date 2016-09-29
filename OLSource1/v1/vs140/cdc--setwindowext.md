---
title: "CDC::SetWindowExt"
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
  - "SetWindowExt"
  - "CDC.SetWindowExt"
  - "CDC::SetWindowExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowExt method"
  - "CDC class, mapping functions"
ms.assetid: 1fc4f139-14b2-4deb-b3b6-5d4048a90707
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetWindowExt
Sets the x- and y-extents of the window associated with the device context.  
  
## Syntax  
  
```  
  
      virtual CSize SetWindowExt(  
   int cx,  
   int cy   
);  
CSize SetWindowExt(  
   SIZE size   
);  
```  
  
#### Parameters  
 `cx`  
 Specifies the x-extent (in logical units) of the window.  
  
 `cy`  
 Specifies the y-extent (in logical units) of the window.  
  
 `size`  
 Specifies the x- and y-extents (in logical units) of the window.  
  
## Return Value  
 The previous extents of the window (in logical units) as a `CSize` object. If an error occurs, the x- and y-coordinates of the returned `CSize` object are both set to 0.  
  
## Remarks  
 The window, along with the device-context viewport, defines how GDI maps points in the logical coordinate system to points in the device coordinate system.  
  
 When the following mapping modes are set, calls to `SetWindowExt` and `SetViewportExt` functions are ignored:  
  
-   `MM_HIENGLISH`  
  
-   `MM_HIMETRIC`  
  
-   `MM_LOENGLISH`  
  
-   `MM_LOMETRIC`  
  
-   `MM_TEXT`  
  
-   `MM_TWIPS`  
  
 When `MM_ISOTROPIC` mode is set, an application must call the `SetWindowExt` member function before calling `SetViewportExt`.  
  
## Example  
 See the example for [CView::OnPrepareDC](../vs140/cview--onpreparedc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetWindowExt](../vs140/cdc--getwindowext.md)   
 [CDC::SetViewportExt](../vs140/cdc--setviewportext.md)   
 [CSize Class](../vs140/csize-class.md)