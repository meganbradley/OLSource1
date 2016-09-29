---
title: "CFrameWndEx::EnableAutoHidePanes"
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
  - "EnableAutoHidePanes"
  - "CFrameWndEx.EnableAutoHidePanes"
  - "CFrameWndEx::EnableAutoHidePanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoHidePanes method"
ms.assetid: db2ff5c1-a217-41ea-b867-ec4568c76f06
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::EnableAutoHidePanes
Enables auto-hide mode for the pane when it is docked to the specified side of the main frame window.  
  
## Syntax  
  
```  
BOOL EnableAutoHidePanes(  
   DWORD dwDockStyle   
);  
```  
  
#### Parameters  
 [in] `dwDockStyle`  
 Specifies the side of the main frame window to which to dock the pane.  
  
## Return Value  
 `TRUE` if a bar pane is successfully docked to the frame window side that is specified by `dwDockStyle`, `FALSE` otherwise.  
  
## Remarks  
 `dwDockStyle` can have one of the following values:  
  
-   CBRS_ALIGN_TOP: allows the control bar to be docked to the top of the client area of a frame window.  
  
-   CBRS_ALIGN_BOTTOM: allows the control bar to be docked to the bottom of the client area of a frame window.  
  
-   CBRS_ALIGN_LEFT: allows the control bar to be docked to the left side of the client area of a frame window.  
  
-   CBRS_ALIGN_RIGHT: allows the control bar to be docked to the right side of the client area of a frame window.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)