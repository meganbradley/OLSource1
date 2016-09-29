---
title: "CWnd::PrintClient"
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
  - "PrintClient"
  - "CWnd::PrintClient"
  - "CWnd.PrintClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintClient method"
  - "drawing, functions"
  - "DC functions"
  - "CWnd class, DC functions"
  - "printer device contexts, drawing windows"
  - "printers, device contexts"
  - "CWnd class, printing and drawing functions"
ms.assetid: 016dd62f-bcd9-4de3-99b3-205855903175
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PrintClient
Call this member function to draw any window in the specified device context (usually a printer device context).  
  
## Syntax  
  
```  
  
      void PrintClient(  
   CDC* pDC,  
   DWORD dwFlags   
) const;  
```  
  
#### Parameters  
 `pDC`  
 A pointer to a device context.  
  
 `dwFlags`  
 Specifies drawing options. This parameter can be one or more of these flags:  
  
-   `PRF_CHECKVISIBLE` Draw the window only if it is visible.  
  
-   `PRF_CHILDREN` Draw all visible children windows.  
  
-   `PRF_CLIENT` Draw the client area of the window.  
  
-   `PRF_ERASEBKGND` Erase the background before drawing the window.  
  
-   `PRF_NONCLIENT` Draw the nonclient area of the window.  
  
-   `PRF_OWNED` Draw all owned windows.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_PRINTCLIENT](http://msdn.microsoft.com/library/windows/desktop/dd145217)