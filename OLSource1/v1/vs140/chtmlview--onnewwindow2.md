---
title: "CHtmlView::OnNewWindow2"
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
  - "CHtmlView.OnNewWindow2"
  - "CHtmlView::OnNewWindow2"
  - "OnNewWindow2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, events"
  - "OnNewWindow2 method"
ms.assetid: 22216320-25fd-42f4-bb61-61f87a787796
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnNewWindow2
This member function is called by the framework when a new window is to be created for displaying a resource.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an interface pointer that, optionally, receives the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface pointer of a new WebBrowser or Internet Explorer object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a cancel flag. An application can set this parameter to nonzero to cancel the navigation operation, or to zero to allow it to proceed.  
  
## Remarks  
 This event precedes the creation of a new window from within the WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DWebBrowserEvents2::NewWindow2](https://msdn.microsoft.com/en-us/library/aa768287.aspx)