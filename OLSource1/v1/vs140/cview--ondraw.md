---
title: "CView::OnDraw"
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
  - CView.OnDraw
  - CView::OnDraw
dev_langs: 
  - C++
helpviewer_keywords: 
  - images [C++], rendering
  - OnDraw method
  - document views
  - CView class, overridables
  - drawing
  - rendering document images
  - document images
ms.assetid: 9ad3d5b4-445b-448a-80d3-4141a4321586
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CView::OnDraw
Called by the framework to render an image of the document.  
  
## Syntax  
  
```  
  
      virtual void OnDraw(  
   CDC* pDC   
) = 0;  
```  
  
#### Parameters  
 `pDC`  
 Points to the device context to be used for rendering an image of the document.  
  
## Remarks  
 The framework calls this function to perform screen display, printing, and print preview, and it passes a different device context in each case. There is no default implementation.  
  
 You must override this function to display your view of the document. You can make graphic device interface (GDI) calls using the [CDC](../vs140/cdc-class.md) object pointed to by the `pDC` parameter. You can select GDI resources, such as pens or fonts, into the device context before drawing and then deselect them afterwards. Often your drawing code can be device-independent; that is, it doesn't require information about what type of device is displaying the image.  
  
 To optimize drawing, call the [RectVisible](../vs140/cdc--rectvisible.md) member function of the device context to find out whether a given rectangle will be drawn. If you need to distinguish between normal screen display and printing, call the [IsPrinting](../vs140/cdc--isprinting.md) member function of the device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::IsPrinting](../vs140/cdc--isprinting.md)   
 [CDC::RectVisible](../vs140/cdc--rectvisible.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)   
 [CWnd::OnCreate](../vs140/cwnd--oncreate.md)   
 [CWnd::OnDestroy](../vs140/cwnd--ondestroy.md)   
 [CWnd::PostNcDestroy](../vs140/cwnd--postncdestroy.md)