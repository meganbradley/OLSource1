---
title: "CMFCRibbonEdit::OnHighlight"
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
  - "CMFCRibbonEdit::OnHighlight"
  - "OnHighlight"
  - "CMFCRibbonEdit.OnHighlight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHighlight method"
ms.assetid: 4c45f8f6-7b39-4907-9d2f-68b79eb7a450
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::OnHighlight
Called by the framework when the pointer enters or leaves the bounds of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
## Syntax  
  
```  
virtual void OnHighlight(  
   BOOL bHighlight  
);  
```  
  
#### Parameters  
 [in] `bHighlight`  
 `TRUE` if the pointer is in the bounds of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)