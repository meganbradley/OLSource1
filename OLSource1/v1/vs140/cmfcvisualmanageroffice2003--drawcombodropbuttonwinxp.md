---
title: "CMFCVisualManagerOffice2003::DrawComboDropButtonWinXP"
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
  - CMFCVisualManagerOffice2003::DrawComboDropButtonWinXP
  - DrawComboDropButtonWinXP
  - CMFCVisualManagerOffice2003.DrawComboDropButtonWinXP
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawComboDropButtonWinXP method
ms.assetid: 193ba67d-fd66-47af-af42-b763e9224164
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::DrawComboDropButtonWinXP
Draws a combo box drop-down button using the current Windows XP theme.  
  
## Syntax  
  
```  
virtual BOOL DrawComboDropButtonWinXP(  
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
 The bounding rectangle of the combo box drop-down button.  
  
 [in] `bDisabled`  
 Specifies whether the combo box drop-down button is disabled.  
  
 [in] `bIsDropped`  
 Specifies whether the combo box drop-down button is dropped down.  
  
 [in] `bIsHighlighted`  
 Specifies whether the combo box drop-down button is highlighted.  
  
## Return Value  
 Returns `TRUE` if the theme API is enabled or `FALSE` if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)