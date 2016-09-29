---
title: "CMDIChildWndEx::InsertPane"
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
  - "CMDIChildWndEx.InsertPane"
  - "CMDIChildWndEx::InsertPane"
  - "InsertPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertPane method"
ms.assetid: eeb9151e-a754-41bb-9447-ca666b4b352a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::InsertPane
Registers the specified pane with the docking manager.  
  
## Syntax  
  
```  
BOOL InsertPane(  
   CBasePane* pControlBar,  
   CBasePane* pTarget,  
   BOOL bAfter = TRUE  
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
 A pointer to the pane to insert.  
  
 [in] `pTarget`  
 A pointer to the adjacent pane.  
  
 [in] `bAfter`  
 If `TRUE`, `pControlBar` is inserted after `pTarget`. If `FALSE`, `pControlBar` is inserted before `pTarget`.  
  
## Return Value  
 `TRUE` if the method succeeds, `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)