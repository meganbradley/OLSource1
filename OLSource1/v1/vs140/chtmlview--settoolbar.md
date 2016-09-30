---
title: "CHtmlView::SetToolBar"
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
  - "SetToolBar"
  - "CHtmlView::SetToolBar"
  - "CHtmlView.SetToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "SetToolBar method"
  - "CHtmlView class, attributes"
ms.assetid: 666cab0b-47c2-4203-8cf2-7448bcf1b7bb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetToolBar
Call this member function to show or hide the Internet Explorer toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether to display the toolbar. Nonzero if the toolbar is to be displayed; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetToolBar](../vs140/chtmlview--gettoolbar.md)   
 [IWebBrowser2::put_ToolBar](https://msdn.microsoft.com/en-us/library/aa768274.aspx)