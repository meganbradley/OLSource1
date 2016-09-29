---
title: "CMDIChildWndEx::EnableAutoHidePanes"
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
  - "CMDIChildWndEx::EnableAutoHidePanes"
  - "CMDIChildWndEx.EnableAutoHidePanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutoHidePanes method"
ms.assetid: 030b7dfb-da0d-469f-9e01-91207a8d5239
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::EnableAutoHidePanes
Enables auto-hide mode for panes when they are docked at the specified sides of the window.  
  
## Syntax  
  
```  
BOOL EnableAutoHidePanes(  
   DWORD dwDockStyle  
);  
```  
  
#### Parameters  
 [in] `dwDockStyle`  
 Specifies the sides of the main frame window that is enabled. Use one or more of the following flags.  
  
-   `CBRS_ALIGN_LEFT`  
  
-   `CBRS_ALIGN_RIGHT`  
  
-   `CBRS_ALIGN_TOP`  
  
-   `CBRS_ALIGN_BOTTOM`  
  
## Return Value  
 `TRUE` if the method succeeds; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)