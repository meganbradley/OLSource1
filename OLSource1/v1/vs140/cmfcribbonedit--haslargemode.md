---
title: "CMFCRibbonEdit::HasLargeMode"
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
  - "CMFCRibbonEdit.HasLargeMode"
  - "HasLargeMode"
  - "CMFCRibbonEdit::HasLargeMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasLargeMode method"
ms.assetid: e6c145ec-8def-4c1b-ac06-b9a55dee1634
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::HasLargeMode
Indicates whether the display size for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control can be large.  
  
## Syntax  
  
```  
virtual BOOL HasLargeMode() const;  
```  
  
## Return Value  
 Always returns `FALSE`.  
  
## Remarks  
 By default this method always returns `FALSE`. Override this method to indicate whether the display size can be large.  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)