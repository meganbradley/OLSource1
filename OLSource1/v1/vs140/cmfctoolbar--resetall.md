---
title: "CMFCToolBar::ResetAll"
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
  - CMFCToolBar::ResetAll
  - CMFCToolBar.ResetAll
  - ResetAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - ResetAll method
ms.assetid: 0c03b7fb-0d43-4f0b-b233-1218ec9f3d12
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBar::ResetAll
Restores all toolbars to their original states.  
  
## Syntax  
  
```  
static void __stdcall ResetAll();  
```  
  
## Remarks  
 This method calls the [CMFCToolBar::RestoreOriginalState](../vs140/cmfctoolbar--restoreoriginalstate.md) method on each toolbar in the application that can be restored. It uses the [CMFCToolBar::CanBeRestored](../vs140/cmfctoolbar--canberestored.md) method to determine whether a toolbar can be restored.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::RestoreOriginalState](../vs140/cmfctoolbar--restoreoriginalstate.md)   
 [CMFCToolBar::CanBeRestored](../vs140/cmfctoolbar--canberestored.md)