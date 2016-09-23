---
title: "CMFCToolBarMenuButton::CreateMenu"
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
  - CMFCToolBarMenuButton::CreateMenu
  - CreateMenu
  - CMFCToolBarMenuButton.CreateMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateMenu method
ms.assetid: 58c5ac98-ec2b-4465-a2ac-00035ff325c5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarMenuButton::CreateMenu
Creates a menu that consists of the commands in the toolbar menu. Returns a handle to the menu.  
  
## Syntax  
  
```  
virtual HMENU CreateMenu() const;  
```  
  
## Return Value  
 A handle to the menu if success. `NULL` if the list of commands associated with the toolbar menu button is empty.  
  
## Remarks  
 You can override this method in a derived class to customize the way the menu is generated.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)