---
title: "CRichEditView::GetPageRect"
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
  - "CRichEditView.GetPageRect"
  - "CRichEditView::GetPageRect"
  - "GetPageRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPageRect method"
  - "CRichEditView class, attributes"
ms.assetid: a7ae0ca0-57bb-4312-a3e3-7910f4fefc92
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetPageRect
Call this function to get the dimensions of the page used in printing.  
  
## Syntax  
  
```  
  
CRect GetPageRect( ) const;  
  
```  
  
## Return Value  
 The bounds of the page used in printing, measured in `MM_TWIPS`.  
  
## Remarks  
 This value is based on the paper size.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetMargins](../vs140/cricheditview--getmargins.md)   
 [CRichEditView::GetPrintWidth](../vs140/cricheditview--getprintwidth.md)   
 [CRichEditView::GetPrintRect](../vs140/cricheditview--getprintrect.md)   
 [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md)   
 [CRichEditView::PrintPage](../vs140/cricheditview--printpage.md)