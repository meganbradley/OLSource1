---
title: "CRichEditView::FindText"
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
  - "CRichEditView.FindText"
  - "CRichEditView::FindText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindText method"
  - "CRichEditView class, operations"
ms.assetid: f38d323e-98d5-4638-af52-e9990e5c4595
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::FindText
Call this function to find the specified text and set it to be the current selection.  
  
## Syntax  
  
```  
  
      BOOL FindText(  
   LPCTSTR lpszFind,  
   BOOL bCase = TRUE,  
   BOOL bWord = TRUE,  
   BOOL bNext = TRUE  
);  
```  
  
#### Parameters  
 `lpszFind`  
 Contains the string to search for.  
  
 `bCase`  
 Indicates if the search is case sensitive.  
  
 `bWord`  
 Indicates if the search should match whole words only, not parts of words.  
  
 `bNext`  
 Indicates the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
## Return Value  
 Nonzero if the `lpszFind` text is found; otherwise 0.  
  
## Remarks  
 This function displays the wait cursor during the find operation.  
  
## Example  
 [!code[NVC_MFCDocView#151](../vs140/codesnippet/CPP/cricheditview--findtext_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::FindText](../vs140/cricheditctrl--findtext.md)   
 [CRichEditCtrl::SetSel](../vs140/cricheditctrl--setsel.md)   
 [CRichEditView::FindTextSimple](../vs140/cricheditview--findtextsimple.md)   
 [CWaitCursor Class](../vs140/cwaitcursor-class.md)