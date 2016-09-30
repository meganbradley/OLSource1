---
title: "CScrollBar::EnableScrollBar"
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
  - "CScrollBar.EnableScrollBar"
  - "CScrollBar::EnableScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enabling scroll bars"
  - "EnableScrollBar method"
  - "CScrollBar class, operations"
  - "disabling scroll bar arrows"
  - "scroll bars, enabling"
  - "scroll bars, arrows"
ms.assetid: 58db93fd-5df4-4bf0-bb01-7215274ca404
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::EnableScrollBar
Enables or disables one or both arrows of a scroll bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the scroll arrows are enabled or disabled and which arrows are enabled or disabled. This parameter can be one of the following values:  
  
-   **ESB_ENABLE_BOTH** Enables both arrows of a scroll bar.  
  
-   **ESB_DISABLE_LTUP** Disables the left arrow of a horizontal scroll bar or the up arrow of a vertical scroll bar.  
  
-   **ESB_DISABLE_RTDN** Disables the right arrow of a horizontal scroll bar or the down arrow of a vertical scroll bar.  
  
-   **ESB_DISABLE_BOTH** Disables both arrows of a scroll bar.  
  
## Return Value  
 Nonzero if the arrows are enabled or disabled as specified; otherwise 0, which indicates that the arrows are already in the requested state or that an error occurred.  
  
## Example  
 See the example for [CScrollBar::SetScrollRange](../vs140/cscrollbar--setscrollrange.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableScrollBar](../vs140/cwnd--enablescrollbar.md)   
 [EnableScrollBar](http://msdn.microsoft.com/library/windows/desktop/bb787579)