---
title: "CFrameWndEx::EnableDocking"
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
  - "CFrameWndEx::EnableDocking"
  - "EnableDocking"
  - "CFrameWndEx.EnableDocking"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableDocking method"
ms.assetid: 09ca1f1e-65f2-42b0-a283-c6c31da525a0
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::EnableDocking
Enables the docking of the panes of the frame window.  
  
## Syntax  
  
```  
BOOL EnableDocking(  
   DWORD dwDockStyle   
);  
```  
  
#### Parameters  
 [in] `dwDockStyle`  
 Specifies the side of the main frame window where the pane bar docks.  
  
## Return Value  
 `TRUE` if a bar pane can be successfully docked at the specified side. `FALSE` otherwise.  
  
## Remarks  
 The `dwDockStyle` parameter can have one of the following values:  
  
-   CBRS_ALIGN_TOP  
  
-   CBRS_ALIGN_BOTTOM  
  
-   CBRS_ALIGN_LEFT  
  
-   CBRS_ALIGN_RIGHT  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)