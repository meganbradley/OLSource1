---
title: "COleControl::GetDC"
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
  - "COleControl.GetDC"
  - "COleControl::GetDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDC method"
ms.assetid: 7b0cadeb-628e-43c3-9ae1-492392124d9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetDC
Provides for a windowless object to get a screen (or compatible) device context from its container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lprcRect*  
 A pointer to the rectangle the windowless control wants to redraw, in client coordinates of the control. **NULL** means the full object's extent.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Drawing attributes of the device context. Choices are:  
  
-   **OLEDC_NODRAW** Indicates that the object won't use the device context to perform any drawing but merely to get information about the display device. The container should simply pass the window's DC without further processing.  
  
-   **OLEDC_PAINTBKGND** Requests that the container paint the background before returning the DC. An object should use this flag if it is requesting a DC for redrawing an area with transparent background.  
  
-   **OLEDC_OFFSCREEN** Informs the container that the object wishes to render into an off-screen bitmap that should then be copied to the screen. An object should use this flag when the drawing operation it is about to perform generates a lot of flicker. The container is free to honor this request or not. However, if this flag is not set, the container must hand back an on-screen DC. This allows objects to perform direct screen operations such as showing a selection (via an **XOR** operation).  
  
## Return Value  
 Pointer to the display device context for the container <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> client area if successful; otherwise, the return value is **NULL**. The display device context can be used in subsequent GDI functions to draw in the client area of the container's window.  
  
## Remarks  
 The [ReleaseDC](../vs140/colecontrol--releasedc.md) member function must be called to release the context after painting. When calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, objects pass the rectangle they wish to draw into in their own client coordinates. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> translates these to coordinates of the container client area. The object should not request a desired drawing rectangle larger than its own client area rectangle, the size of which can be retrieved with [GetClientRect](../vs140/colecontrol--getclientrect.md). This prevents objects from inadvertently drawing where they are not supposed to.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::ReleaseDC](../vs140/colecontrol--releasedc.md)