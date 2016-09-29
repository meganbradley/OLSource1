---
title: "CRichEditView::GetPrintRect"
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
  - "CRichEditView::GetPrintRect"
  - "CRichEditView.GetPrintRect"
  - "GetPrintRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, attributes"
  - "GetPrintRect method"
ms.assetid: bbd46268-e0e8-4578-bce2-357e8dd83fa7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::GetPrintRect
Call this function to retrieve the bounds of the printing area within the page rectangle.  
  
## Syntax  
  
```  
  
CRect GetPrintRect( ) const;  
  
```  
  
## Return Value  
 The bounds of the image area used in printing, measured in `MM_TWIPS`.  
  
## Example  
 [!code[NVC_MFCDocView#154](../vs140/codesnippet/CPP/cricheditview--getprintrect_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetMargins](../vs140/cricheditview--getmargins.md)   
 [CRichEditView::GetPrintWidth](../vs140/cricheditview--getprintwidth.md)   
 [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md)   
 [CRichEditView::GetPageRect](../vs140/cricheditview--getpagerect.md)   
 [CRichEditView::PrintPage](../vs140/cricheditview--printpage.md)