---
title: "CRichEditView::IsRichEditFormat"
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
  - "CRichEditView::IsRichEditFormat"
  - "CRichEditView.IsRichEditFormat"
  - "IsRichEditFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "IsRichEditFormat method"
ms.assetid: 888c6851-8a12-4a2f-b73d-63eae0684e9c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::IsRichEditFormat
Call this function to determine if <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a Clipboard format which is text, rich text, or rich text with OLE items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The Clipboard format of interest.  
  
## Return Value  
 Nonzero if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a rich edit or text Clipboard format.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::CanPaste](../vs140/cricheditctrl--canpaste.md)   
 [CRichEditCtrl::Paste](../vs140/cricheditctrl--paste.md)   
 [CRichEditView::DoPaste](../vs140/cricheditview--dopaste.md)