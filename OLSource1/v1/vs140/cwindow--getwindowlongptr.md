---
title: "CWindow::GetWindowLongPtr"
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
  - "GetWindowLongPtr"
  - "ATL::CWindow::GetWindowLongPtr"
  - "CWindow.GetWindowLongPtr"
  - "CWindow::GetWindowLongPtr"
  - "ATL.CWindow.GetWindowLongPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowLongPtr method"
ms.assetid: 9b56420a-1d49-422a-b67e-dc3aa11bd27d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetWindowLongPtr
Retrieves information about the specified window, including a value at a specified offset into the extra window memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 See [GetWindowLongPtr](http://msdn.microsoft.com/library/windows/desktop/ms633585) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you are retrieving a pointer or a handle, this function supersedes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method.  
  
> [!NOTE]
>  Pointers and handles are 32 bits on 32-bit Windows and 64 bits on 64-bit Windows.  
  
 To write code that is compatible with both 32-bit and 64-bit versions of Windows, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetWindowLongPtr](../vs140/cwindow--setwindowlongptr.md)   
 [CWindow::GetWindowLong](../vs140/cwindow--getwindowlong.md)