---
title: "CHtmlView::SetFullScreen"
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
  - "CHtmlView::SetFullScreen"
  - "SetFullScreen"
  - "CHtmlView.SetFullScreen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFullScreen method"
  - "CHtmlView class, properties"
  - "CHtmlView class, attributes"
ms.assetid: 47d39120-f5cb-4710-bf91-3d534c07403b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetFullScreen
Call this member function to set Internet Explorer to either full-screen or normal window mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Nonzero for full-screen mode; otherwise zero.  
  
## Remarks  
 In full-screen mode, the Internet Explorer main window is maximized and the status bar, toolbar, menu bar, and title bar are hidden.  
  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetFullScreen](../vs140/chtmlview--getfullscreen.md)   
 [CHtmlView::SetTheaterMode](../vs140/chtmlview--settheatermode.md)   
 [IWebBrowser2::put_FullScreen](https://msdn.microsoft.com/en-us/library/aa752119.aspx)