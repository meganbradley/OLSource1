---
title: "CMFCBaseVisualManager::DrawComboDropButton"
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
  - "DrawComboDropButton"
  - "CMFCBaseVisualManager.DrawComboDropButton"
  - "CMFCBaseVisualManager::DrawComboDropButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawComboDropButton method"
ms.assetid: 6020f71c-2333-4157-9c02-23512d922d14
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager::DrawComboDropButton
Draws a combo box drop-down button using the current Windows theme.  
  
## Syntax  
  
```  
virtual BOOL DrawComboDropButton(  
   CDC* pDC,   
   CRect rect,   
   BOOL bDisabled,   
   BOOL bIsDropped,   
   BOOL bIsHighlighted   
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pDC`|A pointer to a device context.|  
|[in] `rect`|The bounding rectangle of the combo box drop-down button.|  
|[in] `bDisabled`|Specifies whether the combo box drop-down button is disabled.|  
|[in] `bIsDropped`|Specifies whether the combo box drop-down button is dropped down.|  
|[in] `bIsHighlighted`|Specifies whether the combo box drop-down button is highlighted.|  
  
## Return Value  
 `TRUE` if Theme API is enabled; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)