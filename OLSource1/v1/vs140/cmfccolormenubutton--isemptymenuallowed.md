---
title: "CMFCColorMenuButton::IsEmptyMenuAllowed"
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
  - "IsEmptyMenuAllowed"
  - "CMFCColorMenuButton.IsEmptyMenuAllowed"
  - "CMFCColorMenuButton::IsEmptyMenuAllowed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEmptyMenuAllowed method"
ms.assetid: 55e1535a-575b-446e-aedb-b0561f951f0b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::IsEmptyMenuAllowed
Indicates whether empty menus are supported.  
  
## Syntax  
  
```  
virtual BOOL IsEmptyMenuAllowed() const;  
```  
  
## Return Value  
 Nonzero if empty menus are allowed; otherwise, zero.  
  
## Remarks  
 Empty menus are supported by default. Override this method to change this behavior in derived class.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)