---
title: "CRichEditView::SetMargins"
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
  - "CRichEditView.SetMargins"
  - "CRichEditView::SetMargins"
  - "SetMargins"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMargins method"
  - "CRichEditView class, attributes"
ms.assetid: 8e74c5f9-014e-4bb6-8cda-781fc935efae
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::SetMargins
Call this function to set the printing margins for this rich edit view.  
  
## Syntax  
  
```  
  
      void SetMargins(  
   const CRect& rectMargin   
);  
```  
  
#### Parameters  
 *rectMargin*  
 The new margin values for printing, measured in `MM_TWIPS`.  
  
## Remarks  
 If [m_nWordWrap](../vs140/cricheditview--m_nwordwrap.md) is `WrapToTargetDevice`, you should call [WrapChanged](../vs140/cricheditview--wrapchanged.md) after using this function to adjust printing characteristics.  
  
 Note that the margins used by [PrintPage](../vs140/cricheditview--printpage.md) are relative to the physical page, not the logical page. Thus, margins of zero will often clip the text since many printers have unprintable areas on the page. To avoid clipping your text, you should call use `SetMargins` to set reasonable printer margins before printing.  
  
## Example  
 See the example for [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md).  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetMargins](../vs140/cricheditview--getmargins.md)   
 [CRichEditView::GetPrintWidth](../vs140/cricheditview--getprintwidth.md)   
 [CRichEditView::GetPrintRect](../vs140/cricheditview--getprintrect.md)   
 [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md)   
 [CRichEditView::GetPageRect](../vs140/cricheditview--getpagerect.md)   
 [CRichEditView::PrintPage](../vs140/cricheditview--printpage.md)   
 [CRichEditView::WrapChanged](../vs140/cricheditview--wrapchanged.md)