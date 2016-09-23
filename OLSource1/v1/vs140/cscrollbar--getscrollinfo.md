---
title: "CScrollBar::GetScrollInfo"
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
  - CScrollBar.GetScrollInfo
  - CScrollBar::GetScrollInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - scroll bars, getting information
  - scroll bar information, retrieving
  - scroll bar information
  - CScrollBar class, operations
  - GetScrollInfo method
  - retrieving scroll bar information
ms.assetid: 800cb4bc-d6fe-4060-b6c8-d732fcc4f193
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CScrollBar::GetScrollInfo
Retrieves the information that the `SCROLLINFO` structure maintains about a scroll bar.  
  
## Syntax  
  
```  
  
      BOOL GetScrollInfo(  
   LPSCROLLINFO lpScrollInfo,  
   UINT nMask = SIF_ALL   
);  
```  
  
#### Parameters  
 `lpScrollInfo`  
 A pointer to a [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure. See the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about this structure.  
  
 `nMask`  
 Specifies the scroll bar parameters to retrieve. Typical usage, SIF_ALL, specifies a combination of SIF_PAGE, SIF_POS, SIF_TRACKPOS, and SIF_RANGE. See `SCROLLINFO` for more information on the nMask values.  
  
## Return Value  
 If the message retrieved any values, the return is **TRUE**. Otherwise, it is **FALSE**.  
  
## Remarks  
 `GetScrollInfo` enables applications to use 32-bit scroll positions.  
  
 The [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure contains information about a scroll bar, including the minimum and maximum scrolling positions, the page size, and the position of the scroll box (the thumb). See the `SCROLLINFO` structure topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about changing the structure defaults.  
  
 The MFC Windows message handlers that indicate scroll bar position, [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md) and [CWnd::OnVScroll](../vs140/cwnd--onvscroll.md), provide only 16 bits of position data. `GetScrollInfo` and `SetScrollInfo` provide 32 bits of scroll bar position data. Thus, an application can call `GetScrollInfo` while processing either `CWnd::OnHScroll` or `CWnd::OnVScroll` to obtain 32-bit scroll bar position data.  
  
## Example  
 See the example for [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::SetScrollInfo](../vs140/cscrollbar--setscrollinfo.md)   
 [CWnd::SetScrollInfo](../vs140/cwnd--setscrollinfo.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [CWnd::OnVScroll](../vs140/cwnd--onvscroll.md)   
 [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md)   
 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537)