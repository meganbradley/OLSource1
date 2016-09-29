---
title: "CMFCVisualManager::GetToolbarDisabledTextColor"
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
  - "CMFCVisualManager.GetToolbarDisabledTextColor"
  - "GetToolbarDisabledTextColor"
  - "CMFCVisualManager::GetToolbarDisabledTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolbarDisabledTextColor method"
ms.assetid: fff122ad-67f0-4f79-86d5-54160bbd3739
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetToolbarDisabledTextColor
The framework calls this function to determine the text color of toolbar buttons that are unavailable.  
  
## Syntax  
  
```  
virtual COLORREF GetToolbarDisabledTextColor();  
```  
  
## Return Value  
 The color that the framework uses for the text color of toolbar buttons that are unavailable.  
  
## Remarks  
 Override this method in a custom visual manager to set the text color of toolbar buttons that are unavailable .  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)