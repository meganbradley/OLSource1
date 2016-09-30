---
title: "CRichEditView::OnReplaceSel"
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
  - "OnReplaceSel"
  - "CRichEditView.OnReplaceSel"
  - "CRichEditView::OnReplaceSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnReplaceSel method"
  - "CRichEditView class, overridables"
ms.assetid: 14298560-cf20-4b1e-aa6f-c0d39034326e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnReplaceSel
Called by the framework when processing Replace commands from the Replace dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The text to be replaced.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates the direction of the search: **TRUE** is down; **FALSE**, up.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates if the search is case sensitive.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicates if the search must select whole words or not.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The replacement text.  
  
## Remarks  
 Call this function to replace one occurrence of some given text with another string. Override this function to alter search characteristics for this view.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::OnReplaceAll](../vs140/cricheditview--onreplaceall.md)