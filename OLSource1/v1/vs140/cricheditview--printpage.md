---
title: "CRichEditView::PrintPage"
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
  - "CRichEditView.PrintPage"
  - "CRichEditView::PrintPage"
  - "PrintPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "PrintPage method"
ms.assetid: 75db1cef-e5ab-4552-b726-3da113f61f33
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::PrintPage
Call this function to format a range of text in a rich edit control for the output device specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a device context for page output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Zero-based index of the first character to be formatted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Zero-based index of the last character to be formatted.  
  
## Return Value  
 The index of the last character that fits on the page plus one.  
  
## Remarks  
 The layout of each page is controlled by [GetPageRect](../vs140/cricheditview--getpagerect.md) and [GetPrintRect](../vs140/cricheditview--getprintrect.md). Typically, this call is followed by a call to [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl--displayband.md) which generates the output.  
  
 Note that margins are relative to the physical page, not the logical page. Thus, margins of zero will often clip the text since many printers have unprintable areas on the page. To avoid clipping your text, you should call [SetMargins](../vs140/cricheditview--setmargins.md) and set reasonable margins before printing.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::PrintInsideRect](../vs140/cricheditview--printinsiderect.md)   
 [CRichEditView::GetPageRect](../vs140/cricheditview--getpagerect.md)   
 [CRichEditView::GetPrintRect](../vs140/cricheditview--getprintrect.md)   
 [CRichEditView::SetMargins](../vs140/cricheditview--setmargins.md)