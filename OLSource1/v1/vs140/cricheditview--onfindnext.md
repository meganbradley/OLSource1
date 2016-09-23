---
title: "CRichEditView::OnFindNext"
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
  - CRichEditView.OnFindNext
  - CRichEditView::OnFindNext
  - OnFindNext
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnFindNext method
  - CRichEditView class, overridables
ms.assetid: ccff9731-4d19-4369-b4a5-93d7e8c24ce1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditView::OnFindNext
Called by the framework when processing commands from the Find/Replace dialog box.  
  
## Syntax  
  
```  
  
      virtual void OnFindNext(  
   LPCTSTR lpszFind,  
   BOOL bNext,  
   BOOL bCase,  
   BOOL bWord   
);  
```  
  
#### Parameters  
 `lpszFind`  
 The string to find.  
  
 `bNext`  
 The direction to search: **TRUE** indicates down; **FALSE**, up.  
  
 `bCase`  
 Indicates whether the search is to be case sensitive.  
  
 `bWord`  
 Indicates whether the search is to match whole words only or not.  
  
## Remarks  
 Call this function to find text within the `CRichEditView`. Override this function to alter search characteristics for your derived view class.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::FindText](../vs140/cricheditview--findtext.md)   
 [CRichEditView::FindTextSimple](../vs140/cricheditview--findtextsimple.md)