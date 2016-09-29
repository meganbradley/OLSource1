---
title: "CEditView::SetPrinterFont"
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
  - "CEditView.SetPrinterFont"
  - "CEditView::SetPrinterFont"
  - "SetPrinterFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "printers, printer fonts"
  - "SetPrinterFont method"
  - "current printer font"
  - "CEditView class, attributes"
  - "fonts, printer"
  - "printer fonts"
ms.assetid: e3d5a885-c5ae-4e2b-94c7-d52099ee04e4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::SetPrinterFont
Call `SetPrinterFont` to set the printer font to the font specified by `pFont`.  
  
## Syntax  
  
```  
  
      void SetPrinterFont(  
   CFont* pFont   
);  
```  
  
#### Parameters  
 `pFont`  
 A pointer to an object of type `CFont`. If **NULL**, the font used for printing is based on the display font.  
  
## Remarks  
 If you want your view to always use a particular font for printing, include a call to `SetPrinterFont` in your class's `OnPreparePrinting` function. This virtual function is called before printing occurs, so the font change takes place before the view's contents are printed.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetFont](../vs140/cwnd--setfont.md)   
 [CFont Class](../vs140/cfont-class.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)