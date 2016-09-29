---
title: "CHtmlView::GetStatusBar"
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
  - "CHtmlView.GetStatusBar"
  - "GetStatusBar"
  - "CHtmlView::GetStatusBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetStatusBar method"
  - "CHtmlView class, attributes"
ms.assetid: ce74253b-840c-477c-9d05-32d0a4569dd7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetStatusBar
Call this member function to determine whether the WebBrowser control displays a status bar.  
  
## Syntax  
  
```  
  
BOOL GetStatusBar( ) const;  
  
```  
  
## Return Value  
 Nonzero if the status bar can be displayed; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetStatusBar](../vs140/chtmlview--setstatusbar.md)   
 [IWebBrowser2::get_StatusBar](https://msdn.microsoft.com/en-us/library/aa768270.aspx)