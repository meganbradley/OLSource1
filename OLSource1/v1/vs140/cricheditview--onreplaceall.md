---
title: "CRichEditView::OnReplaceAll"
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
  - "OnReplaceAll"
  - "CRichEditView::OnReplaceAll"
  - "CRichEditView.OnReplaceAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnReplaceAll method"
  - "CRichEditView class, overridables"
ms.assetid: ca6788e7-e425-4149-bd9a-aa856df64834
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnReplaceAll
Called by the framework when processing Replace All commands from the Replace dialog box.  
  
## Syntax  
  
```  
  
      virtual void OnReplaceAll(  
   LPCTSTR lpszFind,  
   LPCTSTR lpszReplace,  
   BOOL bCase,  
   BOOL bWord   
);  
```  
  
#### Parameters  
 `lpszFind`  
 The text to be replaced.  
  
 `lpszReplace`  
 The replacement text.  
  
 `bCase`  
 Indicates if the search is case sensitive.  
  
 `bWord`  
 Indicates if the search must select whole words or not.  
  
## Remarks  
 Call this function to replace all occurrences of some given text with another string. Override this function to alter search characteristics for this view.  
  
## Example  
 See the example for [CRichEditView::FindText](../vs140/cricheditview--findtext.md).  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::OnReplaceSel](../vs140/cricheditview--onreplacesel.md)   
 [CRichEditView::OnFindNext](../vs140/cricheditview--onfindnext.md)