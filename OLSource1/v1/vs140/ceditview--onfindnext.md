---
title: "CEditView::OnFindNext"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CEditView.OnFindNext
  - CEditView::OnFindNext
  - OnFindNext
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFindNext method
  - buffers, searching
  - CEditView class, overridables
ms.assetid: 60e5843a-d18b-4be8-9662-eb4d8fa2606f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEditView::OnFindNext
Searches the text in the buffer for the text specified by `lpszFind`, in the direction specified by `bNext`, with case sensitivity specified by `bCase`.  
  
## Syntax  
  
```  
  
      virtual void OnFindNext(   
   LPCTSTR lpszFind,   
   BOOL bNext,   
   BOOL bCase    
);  
```  
  
#### Parameters  
 `lpszFind`  
 The text to be found.  
  
 `bNext`  
 Specifies the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
 `bCase`  
 Specifies whether the search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
## Remarks  
 The search starts at the beginning of the current selection and is accomplished through a call to [FindText](../vs140/ceditview--findtext.md). In the default implementation, `OnFindNext` calls [OnTextNotFound](../vs140/ceditview--ontextnotfound.md) if the text is not found.  
  
 Override `OnFindNext` to change the way a `CEditView`-derived object searches text. `CEditView` calls `OnFindNext` when the user chooses the Find Next button in the standard Find dialog box.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::OnTextNotFound](../vs140/ceditview--ontextnotfound.md)   
 [CEditView::FindText](../vs140/ceditview--findtext.md)   
 [CEditView::OnReplaceAll](../vs140/ceditview--onreplaceall.md)   
 [CEditView::OnReplaceSel](../vs140/ceditview--onreplacesel.md)