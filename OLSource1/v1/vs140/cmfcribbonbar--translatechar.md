---
title: "CMFCRibbonBar::TranslateChar"
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
  - "CMFCRibbonBar::TranslateChar"
  - "CMFCRibbonBar.TranslateChar"
  - "TranslateChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TranslateChar method"
ms.assetid: 5079cb50-81a3-4296-b875-db181be4ea46
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::TranslateChar
Determines whether the specified keystroke character code is processed by the ribbon bar.  
  
## Syntax  
  
```  
virtual BOOL TranslateChar(  
   UINT nChar  
);  
```  
  
#### Parameters  
 [in] `nChar`  
 A user keystroke character code.  
  
## Return Value  
 `TRUE` if the character code was processed by the ribbon bar; otherwise `FALSE`.  
  
## Remarks  
 The keytips feature enables users to navigate the ribbon bar by using the keyboard.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)