---
title: "CWnd::FlashWindowEx"
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
  - "FlashWindowEx"
  - "CWnd.FlashWindowEx"
  - "CWnd::FlashWindowEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FlashWindowEx method"
ms.assetid: d1071a39-8fdf-4402-b06c-c66f34311f79
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FlashWindowEx
Flashes the given window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the flash status. For a complete list of values, see the [FLASHWINFO](http://msdn.microsoft.com/library/windows/desktop/ms679348) structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of times to flash the window.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the rate, in milliseconds, at which the window will be flashed. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, the function uses the default cursor blink rate.  
  
## Return Value  
 The return value specifies the window's state before the call to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. If the window caption was drawn as active before the call, the return value is nonzero. Otherwise, the return value is zero.  
  
## Remarks  
 This method emulates the functionality of the function [FlashWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms679347), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::FlashWindow](../vs140/cwnd--flashwindow.md)