---
title: "CBasePane::AddPane"
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
  - CBasePane.AddPane
  - CBasePane::AddPane
  - AddPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddPane method
ms.assetid: 8c5844dd-895f-404e-82e7-ae32e7a660d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::AddPane
Adds a pane to the docking manager.  
  
## Syntax  
  
```  
void AddPane(  
   CBasePane* pBar  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to a pane to add.  
  
## Remarks  
 This is a convenience method that adds a pane to a docking manager. By using this method, you do not have to write code that analyzes the type of the parent frame.  
  
 For more information, see [CDockingManager Class](../vs140/cdockingmanager-class.md) and [CMDIFrameWndEx::AddPane](../vs140/cmdiframewndex--addpane.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)