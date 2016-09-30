---
title: "CView::OnPrepareDC"
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
  - "OnPrepareDC"
  - "CView.OnPrepareDC"
  - "CView::OnPrepareDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPrepareDC method"
  - "preparing to draw"
  - "screen display"
  - "CView class, overridables"
  - "preparing DCs"
ms.assetid: e7d3920c-1f3e-440c-ab1d-0544974b119b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnPrepareDC
Called by the framework before the [OnDraw](../vs140/cview--ondraw.md) member function is called for screen display and before the [OnPrint](../vs140/cview--onprint.md) member function is called for each page during printing or print preview.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the device context to be used for rendering an image of the document.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [CPrintInfo](../vs140/cprintinfo-structure.md) structure that describes the current print job if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is being called for printing or print preview; the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member specifies the page about to be printed. This parameter is **NULL** if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is being called for screen display.  
  
## Remarks  
 The default implementation of this function does nothing if the function is called for screen display. However, this function is overridden in derived classes, such as [CScrollView](../vs140/cscrollview-class.md), to adjust attributes of the device context; consequently, you should always call the base class implementation at the beginning of your override.  
  
 If the function is called for printing, the default implementation examines the page information stored in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter. If the length of the document has not been specified, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> assumes the document to be one page long and stops the print loop after one page has been printed. The function stops the print loop by setting the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member of the structure to **FALSE**.  
  
 Override <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for any of the following reasons:  
  
-   To adjust attributes of the device context as needed for the specified page. For example, if you need to set the mapping mode or other characteristics of the device context, do so in this function.  
  
-   To perform print-time pagination. Normally you specify the length of the document when printing begins, using the [OnPreparePrinting](../vs140/cview--onprepareprinting.md) member function. However, if you don't know in advance how long the document is (for example, when printing an undetermined number of records from a database), override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to test for the end of the document while it is being printed. When there is no more of the document to be printed, set the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure to **FALSE**.  
  
-   To send escape codes to the printer on a page-by-page basis. To send escape codes from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, call the **Escape** member function of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter.  
  
 Call the base class version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> at the beginning of your override.  
  
## Example  
 [!code[NVC_MFCDocView#183](../vs140/codesnippet/CPP/cview--onpreparedc_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Escape](../vs140/cdc--escape.md)   
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [CView::OnBeginPrinting](../vs140/cview--onbeginprinting.md)   
 [CView::OnDraw](../vs140/cview--ondraw.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)