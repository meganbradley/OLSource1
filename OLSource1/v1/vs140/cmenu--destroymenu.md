---
title: "CMenu::DestroyMenu"
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
  - "CMenu::DestroyMenu"
  - "CMenu.DestroyMenu"
  - "DestroyMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DestroyMenu method"
  - "CMenu class, initialization"
ms.assetid: 1a7db07a-d261-424f-a3a4-17ed7d10751e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::DestroyMenu
Destroys the menu and any Windows resources that were used.  
  
## Syntax  
  
```  
  
BOOL DestroyMenu( );  
```  
  
## Return Value  
 Nonzero if the menu is destroyed; otherwise 0.  
  
## Remarks  
 The menu is detached from the `CMenu` object before it is destroyed. The Windows `DestroyMenu` function is automatically called in the `CMenu` destructor.  
  
## Example  
 See the example for [CMenu::CreateMenu](../vs140/cmenu--createmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DestroyMenu](http://msdn.microsoft.com/library/windows/desktop/ms647631)