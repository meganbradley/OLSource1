---
title: "CRichEditView::WrapChanged"
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
  - "CRichEditView.WrapChanged"
  - "CRichEditView::WrapChanged"
  - "WrapChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WrapChanged method"
  - "CRichEditView class, overridables"
ms.assetid: 0519d4c6-6129-465e-abd6-28519e911951
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::WrapChanged
Call this function when the printing characteristics have changed ([SetMargins](../vs140/cricheditview--setmargins.md) or [SetPaperSize](../vs140/cricheditview--setpapersize.md)).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Override this function to modify the way the rich edit view responds to changes in [m_nWordWrap](../vs140/cricheditview--m_nwordwrap.md) or the printing characteristics ([OnPrinterChanged](../vs140/cricheditview--onprinterchanged.md)).  
  
## Example  
 [!code[NVC_MFCDocView#163](../vs140/codesnippet/CPP/cricheditview--wrapchanged_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::m_nWordWrap](../vs140/cricheditview--m_nwordwrap.md)   
 [CRichEditView::OnPrinterChanged](../vs140/cricheditview--onprinterchanged.md)   
 [CRichEditView::SetMargins](../vs140/cricheditview--setmargins.md)   
 [CRichEditView::SetPaperSize](../vs140/cricheditview--setpapersize.md)