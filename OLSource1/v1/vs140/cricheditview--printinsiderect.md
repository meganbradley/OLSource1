---
title: "CRichEditView::PrintInsideRect"
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
  - "PrintInsideRect"
  - "CRichEditView::PrintInsideRect"
  - "CRichEditView.PrintInsideRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "PrintInsideRect method"
ms.assetid: c5403f6c-aa86-496f-9a2e-ee8090d60f2c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::PrintInsideRect
Call this function to format a range of text in a rich edit control to fit within *rectLayout* for the device specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a device context for the output area.  
  
 *rectLayout*  
 [RECT](../vs140/rect-structure.md) or [CRect](../vs140/crect-class.md) which defines the output area.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Zero-based index of the first character to be formatted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Zero-based index of the last character to be formatted.  
  
 *bOutput*  
 Indicates if the text should be rendered. If **FALSE**, the text is just measured.  
  
## Return Value  
 The index of the last character that fits in the output area plus one.  
  
## Remarks  
 Typically, this call is followed by a call to [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl--displayband.md) which generates the output.  
  
## Example  
 See the example for [CRichEditView::GetPaperSize](../vs140/cricheditview--getpapersize.md).  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::FormatRange](../vs140/cricheditctrl--formatrange.md)   
 [CRichEditView::PrintPage](../vs140/cricheditview--printpage.md)   
 [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl--displayband.md)