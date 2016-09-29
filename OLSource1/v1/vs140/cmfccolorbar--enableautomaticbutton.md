---
title: "CMFCColorBar::EnableAutomaticButton"
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
  - "CMFCColorBar::EnableAutomaticButton"
  - "CMFCColorBar.EnableAutomaticButton"
  - "EnableAutomaticButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutomaticButton method"
ms.assetid: 1251f009-ac2f-46e4-987a-478b954e126b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::EnableAutomaticButton
Shows or hides the automatic button.  
  
## Syntax  
  
```  
void EnableAutomaticButton(  
   LPCTSTR lpszLabel,  
   COLORREF colorAutomatic,  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 The text label of the *automatic* (default) color button, or `NULL`.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] `colorAutomatic`  
 The default color that the framework applies when you click the automatic button.  
  
 [in] `bEnable`  
 `TRUE` to enable the automatic button; `FALSE` to disable the automatic button. The default value is `TRUE`.  
  
## Remarks  
 The text label of the automatic button is deleted if the `lpszLabel` parameter is `NULL` or the `bEnable` parameter is `FALSE`.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)