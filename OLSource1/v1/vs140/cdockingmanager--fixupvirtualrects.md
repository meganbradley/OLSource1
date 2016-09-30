---
title: "CDockingManager::FixupVirtualRects"
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
  - "FixupVirtualRects"
  - "CDockingManager::FixupVirtualRects"
  - "CDockingManager.FixupVirtualRects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FixupVirtualRects method"
ms.assetid: f3681766-e19f-4884-b831-23c7d04cb9a6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::FixupVirtualRects
Commits all current toolbar positions to virtual rectangles.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the user starts to drag a toolbar, the application remembers its original position in the *virtual rectangle*. When the user moves a toolbar across its dock site, the toolbar may shift other toolbars. The original positions of the other toolbars are stored in the corresponding virtual rectangles.  
  
## Requirements  
 **Header:** afxdockingmanager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)