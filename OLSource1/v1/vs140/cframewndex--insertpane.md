---
title: "CFrameWndEx::InsertPane"
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
  - "CFrameWndEx::InsertPane"
  - "CFrameWndEx.InsertPane"
  - "InsertPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertPane method"
ms.assetid: 7cb7a338-bad5-4542-87b2-bf4301fa9526
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::InsertPane
Inserts a pane into a list of control bars and registers it with the docking manager.  
  
## Syntax  
  
```  
BOOL InsertPane(  
   CBasePane* pControlBar,  
   CBasePane* pTarget,  
   BOOL bAfter=TRUE   
);  
```  
  
#### Parameters  
 `pControlBar`  
 A pointer to a control bar to be inserted into the list of control bars and registered with the docking manager.  
  
 `pTarget`  
 A pointer to a control bar before or after which to insert the pane.  
  
 `bAfter`  
 `TRUE` if you want to insert `pControlBar` after `pTarget`, `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the control bar was successfully inserted and registered, `FALSE` otherwise.  
  
## Remarks  
 You must register each control bar by using the [CDockingManager Class](../vs140/cdockingmanager-class.md) to take a part in the docking layout.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)