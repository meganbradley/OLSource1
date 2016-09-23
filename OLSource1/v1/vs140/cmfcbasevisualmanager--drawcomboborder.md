---
title: "CMFCBaseVisualManager::DrawComboBorder"
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
  - DrawComboBorder
  - CMFCBaseVisualManager::DrawComboBorder
  - CMFCBaseVisualManager.DrawComboBorder
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawComboBorder method
ms.assetid: fe1e2123-d9cb-4f10-8b96-d16513cdb821
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseVisualManager::DrawComboBorder
Draws the combo box border using the current Windows theme.  
  
## Syntax  
  
```  
virtual BOOL DrawComboBorder(  
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
 `TRUE` if Theme API is enabled; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)