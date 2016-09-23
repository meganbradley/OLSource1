---
title: "CWnd::OnToolHitTest"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWnd::OnToolHitTest
  - OnToolHitTest
  - CWnd.OnToolHitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd class, overridables
  - OnToolHitTest method
  - CWnd class, tool tip functions
  - tool tips [C++], getting information
ms.assetid: 130cdf57-2aec-4173-90d4-c2bd9c84dbd5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnToolHitTest
The framework calls this member function to detemine whether a point is in the bounding rectangle of the specified tool.  
  
## Syntax  
  
```  
  
      virtual INT_PTR OnToolHitTest(  
   CPoint point,  
   TOOLINFO* pTI   
) const;  
```  
  
#### Parameters  
 `point`  
 Specifies the x- and y-coordinate of the cursor. These coordinates are always relative to the upper-left corner of the window  
  
 `pTI`  
 A pointer to a [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure. The following structure values are set by default:  
  
-   *hwnd* = `m_hWnd` Handle to a window  
  
-   `uId` = **(UINT)hWndChild** Handle to a child window  
  
-   `uFlags` &#124;= **TTF_IDISHWND** Handle of the tool  
  
-   `lpszText` = **LPSTR_TEXTCALLBACK** Pointer to the string that is to be displayed in the specified window  
  
## Return Value  
 If the tooltip control was found, the window control ID. If the tooltip control was not found, -1.  
  
## Remarks  
 If the point is in the rectangle, it retrieves information about the tool.  
  
 If the area with which the tooltip is associated is not a button, `OnToolHitTest` sets the structure flags to **TTF_NOTBUTTON** and **TTF_CENTERTIP**.  
  
 Override `OnToolHitTest` to provide different information than the default provides.  
  
 See [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], for more information about the structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256)   
 [CWnd::FilterToolTipMessage](../vs140/cwnd--filtertooltipmessage.md)