---
title: "CMFCRibbonEdit::OnRTLChanged"
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
  - "CMFCRibbonEdit.OnRTLChanged"
  - "OnRTLChanged"
  - "CMFCRibbonEdit::OnRTLChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnRTLChanged method"
ms.assetid: 81eb9a84-fcb7-4fee-9a59-94641de70383
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::OnRTLChanged
Called by the framework to update the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control when the layout changes direction.  
  
## Syntax  
  
```  
virtual void OnRTLChanged(  
   BOOL bIsRTL  
);  
```  
  
#### Parameters  
 [in] `bIsRTL`  
 `TRUE` if the layout is right-to-left; `FALSE` if the layout is left-to-right.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)