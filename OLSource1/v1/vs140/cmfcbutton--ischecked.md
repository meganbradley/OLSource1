---
title: "CMFCButton::IsChecked"
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
  - "IsChecked"
  - "CMFCButton::IsChecked"
  - "CMFCButton.IsChecked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsChecked method"
ms.assetid: 1271a068-28aa-44ea-b1aa-3cb71d07e246
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::IsChecked
Indicates whether the current button is checked.  
  
## Syntax  
  
```  
BOOL IsChecked() const;  
```  
  
## Return Value  
 `TRUE` if the current button is checked; otherwise, `FALSE`.  
  
## Remarks  
 The framework uses different ways to indicate that different kinds of buttons are checked. For example, a radio button is checked when it contains a dot; a check box is checked when it contains an **X**.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)