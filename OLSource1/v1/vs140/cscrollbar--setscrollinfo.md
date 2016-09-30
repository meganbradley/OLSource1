---
title: "CScrollBar::SetScrollInfo"
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
  - "CScrollBar.SetScrollInfo"
  - "CScrollBar::SetScrollInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scroll bars, setting information"
  - "SCROLLINFO"
  - "CScrollBar class, operations"
  - "SetScrollInfo method"
ms.assetid: c560387a-4f8a-4650-99eb-ce695df9e797
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::SetScrollInfo
Sets the information that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure maintains about a scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the scroll bar should be redrawn to reflect the new information. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **TRUE**, the scroll bar is redrawn. If it is **FALSE**, it is not redrawn. The scroll bar is redrawn by default.  
  
## Return Value  
 If successful, the return is **TRUE**. Otherwise, it is **FALSE**.  
  
## Remarks  
 You must provide the values required by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure parameters, including the flag values.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure contains information about a scroll bar, including the minimum and maximum scrolling positions, the page size, and the position of the scroll box (the thumb). See the [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about changing the structure defaults.  
  
## Example  
 [!code[NVC_MFC_CScrollBar#3](../vs140/codesnippet/CPP/cscrollbar--setscrollinfo_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::GetScrollInfo](../vs140/cscrollbar--getscrollinfo.md)   
 [CWnd::SetScrollInfo](../vs140/cwnd--setscrollinfo.md)   
 [CWnd::SetScrollPos](../vs140/cwnd--setscrollpos.md)   
 [CWnd::OnVScroll](../vs140/cwnd--onvscroll.md)   
 [CWnd::OnHScroll](../vs140/cwnd--onhscroll.md)   
 [CWnd::GetScrollInfo](../vs140/cwnd--getscrollinfo.md)   
 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537)