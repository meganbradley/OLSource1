---
title: "CFrameWndEx::AddPane"
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
  - "CFrameWndEx::AddPane"
  - "AddPane"
  - "CFrameWndEx.AddPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddPane method"
ms.assetid: 9d97d0f5-a953-4267-9ee1-ae4bcdd4c977
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::AddPane
Registers a control bar with the docking manager.  
  
## Syntax  
  
```  
BOOL AddPane(  
   CBasePane* pControlBar,  
   BOOL bTail=TRUE   
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
 A control bar pane to register.  
  
 [in] `bTail`  
 `TRUE` if you want to add the control bar pane to the end of the list; `FALSE` otherwise.  
  
## Return Value  
 `TRUE` if the control bar was successfully registered; `FALSE` otherwise.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)