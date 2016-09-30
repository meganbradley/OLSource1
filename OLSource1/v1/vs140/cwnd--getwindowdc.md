---
title: "CWnd::GetWindowDC"
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
  - "CWnd::GetWindowDC"
  - "CWnd.GetWindowDC"
  - "GetWindowDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowDC method"
ms.assetid: 5f27e471-7e81-4f72-bcda-d9cda846155f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetWindowDC
Retrieves the display context for the entire window, including caption bar, menus, and scroll bars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Identifies the display context for the given window if the function is successful; otherwise **NULL**.  
  
 The returned pointer may be temporary and should not be stored for later use. [ReleaseDC](../vs140/cwnd--releasedc.md) should be called once for each successful call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 A window display context permits painting anywhere in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, since the origin of the context is the upper-left corner of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instead of the client area.  
  
 Default attributes are assigned to the display context each time it retrieves the context. Previous attributes are lost.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is intended to be used for special painting effects within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> nonclient area. Painting in nonclient areas of any window is not recommended.  
  
 The [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385) Windows function can be used to retrieve the dimensions of various parts of the nonclient area, such as the caption bar, menu, and scroll bars.  
  
 After painting is complete, the [ReleaseDC](../vs140/cwnd--releasedc.md) member function must be called to release the display context. Failure to release the display context will seriously affect painting requested by applications due to limitations on the number of device contexts that can be open at the same time.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetSystemMetrics](http://msdn.microsoft.com/library/windows/desktop/ms724385)   
 [CWnd::ReleaseDC](../vs140/cwnd--releasedc.md)   
 [GetWindowDC](http://msdn.microsoft.com/library/windows/desktop/dd144947)   
 [CWnd::GetDC](../vs140/cwnd--getdc.md)   
 [CWindowDC Class](../vs140/cwindowdc-class.md)