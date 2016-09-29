---
title: "CWindow::PrintClient"
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
  - "ATL.CWindow.PrintClient"
  - "ATL::CWindow::PrintClient"
  - "CWindow.PrintClient"
  - "CWindow::PrintClient"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintClient method"
  - "PRF_NONCLIENT"
  - "PRF_CLIENT"
  - "PRF_ERASEBKGND"
  - "PRF_CHILDREN"
  - "PRF_CHECKVISIBLE"
  - "PRF_OWNED"
ms.assetid: c82ed9df-f6f5-47f3-8a6a-a0e069b39966
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::PrintClient
Sends a [WM_PRINTCLIENT](http://msdn.microsoft.com/library/windows/desktop/dd145217) message to the window to request that it draw its client area in the specified device context.  
  
## Syntax  
  
```  
  
      void PrintClient(  
   HDC hDC,  
   DWORD dwFlags   
) const throw();  
```  
  
#### Parameters  
 `hDC`  
 [in] The handle to a device context.  
  
 `dwFlags`  
 [in] Specifies drawing options. You can combine one or more of the following flags:  
  
-   `PRF_CHECKVISIBLE` Draw the window only if it is visible.  
  
-   `PRF_CHILDREN` Draw all visible child windows.  
  
-   `PRF_CLIENT` Draw the client area of the window.  
  
-   `PRF_ERASEBKGND` Erase the background before drawing the window.  
  
-   `PRF_NONCLIENT` Draw the non-client area of the window.  
  
-   `PRF_OWNED` Draw all owned windows.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::Print](../vs140/cwindow--print.md)