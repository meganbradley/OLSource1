---
title: "CMFCToolBarMenuButton::IsTearOffMenu"
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
  - CMFCToolBarMenuButton::IsTearOffMenu
  - CMFCToolBarMenuButton.IsTearOffMenu
  - IsTearOffMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsTearOffMenu method
ms.assetid: e9dbd416-f8ce-472a-b293-0b905a18692c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarMenuButton::IsTearOffMenu
Indicates whether the drop-down menu has a tear-off bar.  
  
## Syntax  
  
```  
virtual BOOL IsTearOffMenu() const;  
```  
  
## Return Value  
 `TRUE` if the toolbar menu button has a tear-off bar; otherwise `FALSE`.  
  
## Remarks  
 To enable the tear-off feature and set the tear-off bar ID, call [CMFCToolBarMenuButton::SetTearOff](../vs140/cmfctoolbarmenubutton--settearoff.md).  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)