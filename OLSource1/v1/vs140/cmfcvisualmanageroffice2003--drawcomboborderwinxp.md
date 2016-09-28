---
title: "CMFCVisualManagerOffice2003::DrawComboBorderWinXP"
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
  - "DrawComboBorderWinXP"
  - "CMFCVisualManagerOffice2003::DrawComboBorderWinXP"
  - "CMFCVisualManagerOffice2003.DrawComboBorderWinXP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawComboBorderWinXP method"
ms.assetid: 4d8aceb8-033e-4189-ae28-f42950989b9a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::DrawComboBorderWinXP
Draws the combo box border using the current Windows XP theme.  
  
## Syntax  
  
```  
virtual BOOL DrawComboBorderWinXP(  
   CDC* pDC,  
   CRect rect,  
   BOOL bDisabled,  
   BOOL bIsDropped,  
   BOOL bIsHighlighted  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 Bounding rectangle of the combo box border.  
  
 [in] `bDisabled`  
 Specifies whether the combo box border is disabled.  
  
 [in] `bIsDropped`  
 Specifies whether the combo box border is dropped down.  
  
 [in] `bIsHighlighted`  
 Specifies whether the combo box border is highlighted.  
  
## Return Value  
 Returns `TRUE` if the theme API is enabled or `FALSE` if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)