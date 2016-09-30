---
title: "CWnd::GetDCEx"
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
  - "GetDCEx"
  - "CWnd::GetDCEx"
  - "CWnd.GetDCEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDCEx method"
ms.assetid: efd6297e-086d-4e4b-89bf-b96f5e63191e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDCEx
Retrieves the handle of a device context for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies a clipping region that may be combined with the visible region of the client window.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Can have one of the following preset values:  
  
-   **DCX_CACHE** Returns a device context from the cache rather than the **OWNDC** or **CLASSDC** window. Overrides **CS_OWNDC** and **CS_CLASSDC**.  
  
-   **DCX_CLIPCHILDREN** Excludes the visible regions of all child windows below the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> window.  
  
-   **DCX_CLIPSIBLINGS** Excludes the visible regions of all sibling windows above the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> window.  
  
-   **DCX_EXCLUDERGN** Excludes the clipping region identified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from the visible region of the returned device context.  
  
-   **DCX_INTERSECTRGN** Intersects the clipping region identified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> within the visible region of the returned device context.  
  
-   **DCX_LOCKWINDOWUPDATE** Allows drawing even if there is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> call in effect that would otherwise exclude this window. This value is used for drawing during tracking.  
  
-   **DCX_PARENTCLIP** Uses the visible region of the parent window and ignores the parent window's **WS_CLIPCHILDREN** and **WS_PARENTDC** style bits. This value sets the device context's origin to the upper-left corner of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> window.  
  
-   **DCX_WINDOW** Returns a device context that corresponds to the window rectangle rather than the client rectangle.  
  
## Return Value  
 The device context for the specified window if the function is successful; otherwise **NULL**.  
  
## Remarks  
 The device context can be used in subsequent GDI functions to draw in the client area.  
  
 This function, which is an extension to the [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) function, gives an application more control over how and whether a device context for a window is clipped.  
  
 Unless the device context belongs to a window class, the [ReleaseDC](http://msdn.microsoft.com/library/windows/desktop/dd162920) function must be called to release the context after drawing. Since only five common device contexts are available at any given time, failure to release a device context can prevent other applications from gaining access to a device context.  
  
 To obtain a cached device context, an application must specify [DCX_CACHE](http://msdn.microsoft.com/library/windows/desktop/dd144873). If **DCX_CACHE** is not specified and the window is neither **CS_OWNDC** nor [CS_CLASSDC](http://msdn.microsoft.com/library/windows/desktop/ms633576), this function returns **NULL**.  
  
 A device context with special characteristics is returned by the [GetDCEx](http://msdn.microsoft.com/library/windows/desktop/dd144873) function if the **CS_CLASSDC**, [CS_OWNDC](http://msdn.microsoft.com/library/windows/desktop/ms633576), or [CS_PARENTDC](http://msdn.microsoft.com/library/windows/desktop/ms633576) style was specified in the [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) structure when the class was registered.  
  
 For more information about these characteristics, see the description of the **WNDCLASS** structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [CWnd::GetDC](../vs140/cwnd--getdc.md)   
 [CWnd::GetWindowDC](../vs140/cwnd--getwindowdc.md)   
 [CWnd::ReleaseDC](../vs140/cwnd--releasedc.md)   
 [GetDCEx](http://msdn.microsoft.com/library/windows/desktop/dd144873)