---
title: "CWindow::Print"
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
  - "Print"
  - "PRF_CHILDREN"
  - "ATL::CWindow::Print"
  - "PRF_CLIENT"
  - "CWindow::Print"
  - "PRF_NONCLIENT"
  - "PRF_ERASEBKGND"
  - "PRF_OWNED"
  - "CWindow.Print"
  - "ATL.CWindow.Print"
  - "PRF_CHECKVISIBLE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PRF_NONCLIENT"
  - "PRF_CLIENT"
  - "PRF_ERASEBKGND"
  - "PRF_CHILDREN"
  - "PRF_CHECKVISIBLE"
  - "Print method"
  - "PRF_OWNED"
ms.assetid: 2b55abaa-94e6-405f-a6f4-ba9f5370fb32
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::Print
Sends a [WM_PRINT](http://msdn.microsoft.com/library/windows/desktop/dd145216) message to the window to request that it draw itself in the specified device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to a device context.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the drawing options. You can combine one or more of the following flags:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Draw the window only if it is visible.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Draw all visible child windows.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Draw the client area of the window.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Erase the background before drawing the window.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Draw the non-client area of the window.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Draw all owned windows.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::PrintClient](../vs140/cwindow--printclient.md)