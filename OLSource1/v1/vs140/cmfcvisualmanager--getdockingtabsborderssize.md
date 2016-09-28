---
title: "CMFCVisualManager::GetDockingTabsBordersSize"
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
  - "CMFCVisualManager.GetDockingTabsBordersSize"
  - "GetDockingTabsBordersSize"
  - "CMFCVisualManager::GetDockingTabsBordersSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDockingTabsBordersSize method"
ms.assetid: bd4c4bf2-fa47-4786-b028-832d09074184
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetDockingTabsBordersSize
The framework calls this method when it draws a pane that is docked and tabbed.  
  
## Syntax  
  
```  
virtual int GetDockingTabsBordersSize();  
```  
  
## Return Value  
 An integer that indicates the border size of a pane that is docked and tabbed.  
  
## Remarks  
 A docked pane becomes tabbed when the user docks multiple panes to the same location in your application.  
  
 Override this method in a custom visual manager to change the border size of docked tabbed control bars. The default implementation returns -1.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)