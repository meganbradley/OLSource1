---
title: "CRichEditView::TextNotFound"
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
  - "TextNotFound"
  - "CRichEditView::TextNotFound"
  - "CRichEditView.TextNotFound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TextNotFound method"
  - "CRichEditView class, operations"
ms.assetid: 89a3ec32-f7a2-4c22-b395-dae62b8f15af
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::TextNotFound
Call this function to reset the internal search state of the [CRichEditView](../vs140/cricheditview-class.md) control after a failed call to [FindText](../vs140/cricheditview--findtext.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the text string that was not found.  
  
## Remarks  
 It is recommended that this method be called immediately after failed calls to [FindText](../vs140/cricheditview--findtext.md) so that the internal search state of the control is properly reset.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter should include the same content as the string provided to [FindText](../vs140/cricheditview--findtext.md). After resetting the internal search state, this method will call the [OnTextNotFound](../vs140/cricheditview--ontextnotfound.md) method with the provided search string.  
  
## Example  
 See the example for [CRichEditView::FindText](../vs140/cricheditview--findtext.md).  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::FindText](../vs140/cricheditview--findtext.md)   
 [CRichEditView::OnTextNotFound](../vs140/cricheditview--ontextnotfound.md)