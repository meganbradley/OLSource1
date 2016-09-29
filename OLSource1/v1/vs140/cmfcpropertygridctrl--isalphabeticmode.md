---
title: "CMFCPropertyGridCtrl::IsAlphabeticMode"
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
  - "CMFCPropertyGridCtrl.IsAlphabeticMode"
  - "CMFCPropertyGridCtrl::IsAlphabeticMode"
  - "IsAlphabeticMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAlphabeticMode method"
ms.assetid: 02e39371-ba53-4261-9f67-b83120c2fc63
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::IsAlphabeticMode
Indicates whether a property grid control is in alphabetic mode.  
  
## Syntax  
  
```  
BOOL IsAlphabeticMode() const;  
```  
  
## Return Value  
 `TRUE` if the property grid control is in alphabetic mode; otherwise `FALSE`.  
  
## Remarks  
 When the property grid control is in alphabetic mode, all properties are sorted alphabetically by their names. Otherwise, properties are grouped under their parent nodes.  
  
 Use the [CMFCPropertyGridCtrl::SetAlphabeticMode](../vs140/cmfcpropertygridctrl--setalphabeticmode.md) method to enable or disable alphabetic mode.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::SetAlphabeticMode](../vs140/cmfcpropertygridctrl--setalphabeticmode.md)