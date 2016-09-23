---
title: "CEditView::OnTextNotFound"
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
  - CEditView.OnTextNotFound
  - CEditView::OnTextNotFound
  - OnTextNotFound
dev_langs: 
  - C++
helpviewer_keywords: 
  - CEditView class, overridables
  - OnTextNotFound method
ms.assetid: 72f1fa75-965f-4823-9871-785295cbabb8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEditView::OnTextNotFound
Override this function to change the default implementation, which calls the Windows function **MessageBeep**.  
  
## Syntax  
  
```  
  
      virtual void OnTextNotFound(  
   LPCTSTR lpszFind   
);  
```  
  
#### Parameters  
 `lpszFind`  
 The text to be found.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::FindText](../vs140/ceditview--findtext.md)   
 [CEditView::OnFindNext](../vs140/ceditview--onfindnext.md)   
 [CEditView::OnReplaceAll](../vs140/ceditview--onreplaceall.md)   
 [CEditView::OnReplaceSel](../vs140/ceditview--onreplacesel.md)