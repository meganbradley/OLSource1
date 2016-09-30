---
title: "CMDIChildWndEx::AddPane"
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
  - "CMDIChildWndEx.AddPane"
  - "AddPane"
  - "CMDIChildWndEx::AddPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPane method"
ms.assetid: b90a5a26-7d74-4b3b-9fa0-8f25e7bb7fd8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::AddPane
Adds a pane.  
  
## Syntax  
  
```  
BOOL AddPane(  
   CBasePane* pControlBar,  
   BOOL bTail = TRUE  
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
 A pointer to the pane.  
  
 [in] `bTail`  
 `TRUE` to add the pane to the end of the list of panes for the docking manager; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the pane was successfully registered with the docking manager; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)