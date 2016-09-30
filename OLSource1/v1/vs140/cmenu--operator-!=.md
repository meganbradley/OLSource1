---
title: "CMenu::operator !="
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
  - "CMenu.operator!="
  - "CMenu::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, menus"
  - "operator !=, menus"
ms.assetid: 0a02cc60-cd79-40e4-a3df-732b525a6967
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::operator !=
Determines if two menus are logically not equal.  
  
## Syntax  
  
```  
  
      BOOL operator!=(   
   const CMenu& menu   
) const;  
```  
  
#### Parameters  
 `menu`  
 A `CMenu` object for comparison.  
  
## Remarks  
 Tests if a menu object on the left side is not equal to a menu object on the right side.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)