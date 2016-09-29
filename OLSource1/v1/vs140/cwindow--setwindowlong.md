---
title: "CWindow::SetWindowLong"
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
  - "CWindow::SetWindowLong"
  - "CWindow.SetWindowLong"
  - "ATL::CWindow::SetWindowLong"
  - "SetWindowLong"
  - "ATL.CWindow.SetWindowLong"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowLong method"
ms.assetid: 342b4e0a-e122-4861-ab6a-82b52b57eb14
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetWindowLong
Sets a 32-bit value at a specified offset into the extra window memory.  
  
## Syntax  
  
```  
  
      LONG SetWindowLong(  
   int nIndex,  
   LONG dwNewLong   
) throw();  
```  
  
## Remarks  
 See [SetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  To write code that is compatible with both 32-bit and 64-bit versions of Windows, use [CWindow::SetWindowLongPtr](../vs140/cwindow--setwindowlongptr.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetWindowLong](../vs140/cwindow--getwindowlong.md)   
 [CWindow::SetWindowWord](../vs140/cwindow--setwindowword.md)