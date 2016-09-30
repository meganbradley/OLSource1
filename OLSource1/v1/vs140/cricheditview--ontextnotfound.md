---
title: "CRichEditView::OnTextNotFound"
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
  - "OnTextNotFound"
  - "CRichEditView::OnTextNotFound"
  - "CRichEditView.OnTextNotFound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, overridables"
  - "OnTextNotFound method"
ms.assetid: 696b8afe-698b-499e-a5b2-0ee4b63666cd
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnTextNotFound
Called by the framework whenever a search fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The text which was not found.  
  
## Remarks  
 Override this function to change the output notification from a [MessageBeep](http://msdn.microsoft.com/library/windows/desktop/ms680356).  
  
 For more information, see [MessageBeep](http://msdn.microsoft.com/library/windows/desktop/ms680356) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#157](../vs140/codesnippet/CPP/cricheditview--ontextnotfound_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::FindText](../vs140/cricheditview--findtext.md)   
 [CRichEditView::FindTextSimple](../vs140/cricheditview--findtextsimple.md)   
 [CRichEditView::OnFindNext](../vs140/cricheditview--onfindnext.md)