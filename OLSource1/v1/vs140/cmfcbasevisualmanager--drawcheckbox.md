---
title: "CMFCBaseVisualManager::DrawCheckBox"
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
  - CMFCBaseVisualManager::DrawCheckBox
  - DrawCheckBox
  - CMFCBaseVisualManager.DrawCheckBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawCheckBox method
ms.assetid: 9293367c-488d-4f8c-ac13-07f487288f11
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseVisualManager::DrawCheckBox
Draws a check box control by using the current Windows theme.  
  
## Syntax  
  
```  
virtual BOOL DrawCheckBox(  
   CDC *pDC,   
   CRect rect,   
   BOOL bHighlighted,   
   int nState,   
   BOOL bEnabled,   
   BOOL bPressed);   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context  
  
 [in] `rect`  
 The bounding rectangle of the check box.  
  
 [in] `bHighlighted`  
 Specifies whether the check box is highlighted.  
  
 [in] `nState`  
 0 for unchecked, 1 for checked normal,  
  
 2 for mixed normal.  
  
 [in] `bEnabled`  
 Specifies whether the check box is enabled.  
  
 [in] `bPressed`  
 Specifies whether the check box is pressed.  
  
## Return Value  
 `TRUE` if Theme API is enabled; otherwise `FALSE`.  
  
## Remarks  
 The values of `nState` correspond to the following check box styles.  
  
|nState|Check box style|  
|------------|---------------------|  
|0|CBS_UNCHECKEDNORMAL|  
|1|CBS_CHECKEDNORMAL|  
|2|CBS_MIXEDNORMAL|  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)