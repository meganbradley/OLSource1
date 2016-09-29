---
title: "CRichEditView::SetPaperSize"
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
  - "CRichEditView::SetPaperSize"
  - "CRichEditView.SetPaperSize"
  - "SetPaperSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPaperSize method"
  - "CRichEditView class, attributes"
ms.assetid: 426647c9-b7cb-4fa4-9a90-768811437e83
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::SetPaperSize
Call this function to set the paper size for printing this rich edit view.  
  
## Syntax  
  
```  
  
      void SetPaperSize(  
   CSize sizePaper   
);  
```  
  
#### Parameters  
 *sizePaper*  
 The new paper size values for printing, measured in `MM_TWIPS`.  
  
## Remarks  
 If [m_nWordWrap](../vs140/cricheditview--m_nwordwrap.md) is `WrapToTargetDevice`, you should call [WrapChanged](../vs140/cricheditview--wrapchanged.md) after using this function to adjust printing characteristics.  
  
## Example  
 [!code[NVC_MFCDocView#161](../vs140/codesnippet/CPP/cricheditview--setpapersize_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md)   
 [CRichEditView::GetMargins](../vs140/cricheditview--getmargins.md)   
 [CRichEditView::GetPrintWidth](../vs140/cricheditview--getprintwidth.md)   
 [CRichEditView::GetPrintRect](../vs140/cricheditview--getprintrect.md)   
 [CRichEditView::GetPageRect](../vs140/cricheditview--getpagerect.md)   
 [CRichEditView::PrintPage](../vs140/cricheditview--printpage.md)   
 [CRichEditView::WrapChanged](../vs140/cricheditview--wrapchanged.md)