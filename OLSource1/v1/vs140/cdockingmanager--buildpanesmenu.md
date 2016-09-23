---
title: "CDockingManager::BuildPanesMenu"
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
  - BuildPanesMenu
  - CDockingManager::BuildPanesMenu
  - CDockingManager.BuildPanesMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - BuildPanesMenu method
ms.assetid: 693decf2-beae-4ca3-b740-2ff05231eed0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockingManager::BuildPanesMenu
Adds names of docking panes and toolbars to a menu.  
  
## Syntax  
  
```  
void BuildPanesMenu(  
   CMenu& menu,  
   BOOL bToolbarsOnly  
);  
```  
  
#### Parameters  
 [in] `menu`  
 A menu to add the names of docking panes and toolbars to.  
  
 [in] `bToolbarsOnly`  
 `TRUE` to add only toolbar names to the menu; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)