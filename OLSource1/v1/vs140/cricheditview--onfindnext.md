---
title: "CRichEditView::OnFindNext"
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
  - "CRichEditView.OnFindNext"
  - "CRichEditView::OnFindNext"
  - "OnFindNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFindNext method"
  - "CRichEditView class, overridables"
ms.assetid: ccff9731-4d19-4369-b4a5-93d7e8c24ce1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnFindNext
Called by the framework when processing commands from the Find/Replace dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string to find.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The direction to search: **TRUE** indicates down; **FALSE**, up.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates whether the search is to be case sensitive.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicates whether the search is to match whole words only or not.  
  
## Remarks  
 Call this function to find text within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Override this function to alter search characteristics for your derived view class.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::FindText](../vs140/cricheditview--findtext.md)   
 [CRichEditView::FindTextSimple](../vs140/cricheditview--findtextsimple.md)