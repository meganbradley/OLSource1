---
title: "CMDIFrameWndEx::InsertPane"
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
  - "CMDIFrameWndEx.InsertPane"
  - "CMDIFrameWndEx::InsertPane"
  - "InsertPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertPane method"
ms.assetid: 39f99e98-4af2-45b8-8f4c-8dc559d8541f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::InsertPane
Registers the specified pane with the docking manager.  
  
## Syntax  
  
```  
BOOL InsertPane(  
   CBasePane* pControlBar,  
   CBasePane* pTarget,  
   BOOL bAfter=TRUE   
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
 A pointer to the pane to be inserted.  
  
 [in] `pTarget`  
 A pointer to the pane before or after which to insert the pane.  
  
 [in] `bAfter`  
 If `TRUE`, `pControlBar` is inserted after `pTarget`. If `FALSE`, `pControlBar` is inserted before `pTarget`.  
  
## Return Value  
 `TRUE` if the method successfully registers the pane, `FALSE` if the pane was already registered with the docking manager.  
  
## Remarks  
 Use this method to tell the docking manager about a pane specified by `pControlBar`. The docking manager will align this pane according to the pane's alignment and position in the docking manager's internal list.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDockingManager Class](../vs140/cdockingmanager-class.md)