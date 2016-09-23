---
title: "CView::OnPrint"
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
  - OnPrint
  - CView.OnPrint
  - CView::OnPrint
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPrint method
  - print preview, views
  - printing [MFC], beginning
  - CView class, overridables
ms.assetid: 49ccf2ca-3516-4caf-b820-4aacfb108560
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CView::OnPrint
Called by the framework to print or preview a page of the document.  
  
## Syntax  
  
```  
  
      virtual void OnPrint(  
   CDC* pDC,  
   CPrintInfo* pInfo   
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the printer device context.  
  
 `pInfo`  
 Points to a `CPrintInfo` structure that describes the current print job.  
  
## Remarks  
 For each page being printed, the framework calls this function immediately after calling the [OnPrepareDC](../vs140/cview--onpreparedc.md) member function. The page being printed is specified by the `m_nCurPage` member of the [CPrintInfo](../vs140/cprintinfo-structure.md) structure that `pInfo` points to. The default implementation calls the [OnDraw](../vs140/cview--ondraw.md) member function and passes it the printer device context.  
  
 Override this function for any of the following reasons:  
  
-   To allow printing of multipage documents. Render only the portion of the document that corresponds to the page currently being printed. If you're using `OnDraw` to perform the rendering, you can adjust the viewport origin so that only the appropriate portion of the document is printed.  
  
-   To make the printed image look different from the screen image (that is, if your application is not WYSIWYG). Instead of passing the printer device context to `OnDraw`, use the device context to render an image using attributes not shown on the screen.  
  
     If you need GDI resources for printing that you don't use for screen display, select them into the device context before drawing and deselect them afterwards. These GDI resources should be allocated in [OnBeginPrinting](../vs140/cview--onbeginprinting.md) and released in [OnEndPrinting](../vs140/cview--onendprinting.md).  
  
-   To implement headers or footers. You can still use `OnDraw` to do the rendering by restricting the area that it can print on.  
  
 Note that the **m_rectDraw** member of the `pInfo` parameter describes the printable area of the page in logical units.  
  
 Do not call `OnPrepareDC` in your override of `OnPrint`; the framework calls `OnPrepareDC` automatically before calling `OnPrint`.  
  
## Example  
 The following is a skeleton for an overridden `OnPrint` function:  
  
 [!code[NVC_MFCDocView#186](../vs140/codesnippet/CPP/cview--onprint_1.cpp)]
  
  
 For another example, see [CRichEditView::PrintInsideRect](../vs140/cricheditview--printinsiderect.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnBeginPrinting](../vs140/cview--onbeginprinting.md)   
 [CView::OnEndPrinting](../vs140/cview--onendprinting.md)   
 [CView::OnPrepareDC](../vs140/cview--onpreparedc.md)   
 [CView::OnDraw](../vs140/cview--ondraw.md)