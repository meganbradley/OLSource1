---
title: "CHtmlView::GetFullScreen"
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
  - CHtmlView.GetFullScreen
  - GetFullScreen
  - CHtmlView::GetFullScreen
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFullScreen method
  - CHtmlView class, properties
  - CHtmlView class, attributes
ms.assetid: 92c53ce9-f1bb-4624-bbe3-458379ed0728
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::GetFullScreen
Call this member function to determine whether the WebBrowser control is operating in full-screen mode or in normal window mode.  
  
## Syntax  
  
```  
  
BOOL GetFullScreen( ) const;  
  
```  
  
## Return Value  
 Nonzero if the WebBrowser is operating in full-screen mode; otherwise zero.  
  
## Remarks  
 In full-screen mode, the Internet Explorer main window is maximized and the status bar, toolbar, menu bar, and title bar are hidden.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetFullScreen](../vs140/chtmlview--setfullscreen.md)   
 [IWebBrowser2::get_FullScreen](https://msdn.microsoft.com/en-us/library/aa752119.aspx)