---
title: "CMFCVisualManagerWindows7::GetRibbonEditBackgroundColor"
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
  - "GetRibbonEditBackgroundColor"
  - "afxvisualmanagerwindows7/CMFCVisualManagerWindows7::GetRibbonEditBackgroundColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRibbonEditBackgroundColor"
ms.assetid: 06a79c95-c534-4ab6-a913-8b087d3440b7
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerWindows7::GetRibbonEditBackgroundColor
Obtains the background color of a ribbon edit box.  
  
## Syntax  
  
```  
virtual COLORREF GetRibbonEditBackgroundColor (  
   CMFCRibbonRichEditCtrl* pEdit,  
   BOOL bIsHighlighted,  
   BOOL bIsPaneHighlighted,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pEdit`  
 A pointer to the edit control. This value cannot be `NULL`.  
  
 [out] `bIsHighlighted`  
 Returns whether the ribbon box is highlighted.  
  
 [out] `bIsPaneHighlighted`  
 Returns `TRUE` if the ribbon panel that contains `pEdit` is highlighted.  
  
 [out] `bIsDisabled`  
 Returns whether `pEdit` is disabled.  
  
## Return Value  
 The background color of the edit box `pEdit`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanagerwindows7.h  
  
## See Also  
 [CMFCVisualManagerWindows7 Class](../vs140/cmfcvisualmanagerwindows7-class.md)   
 [](../vs140/cmfcvisualmanagerwindows7-class.md "CMFCVisualManagerWindows7 Class")   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)