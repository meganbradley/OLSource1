---
title: "CHtmlView::OnBeforeNavigate2"
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
  - "CHtmlView.OnBeforeNavigate2"
  - "OnBeforeNavigate2"
  - "CHtmlView::OnBeforeNavigate2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "navigation [C++], URLs"
  - "navigating URLs"
  - "OnBeforeNavigate2 method"
  - "URLs, navigation"
  - "CHtmlView class, events"
ms.assetid: e73c4f24-2038-495c-bb16-1077b400e438
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnBeforeNavigate2
This member function is called by the framework to cause an event to fire before a navigation occurs in the web browser.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a string containing the URL to navigate to.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A string that contains the name of the frame in which to display the resource, or **NULL** if no named frame is targeted for the resource.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object containing the data to send to the server if the HTTP POST transaction is being used.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a string containing additional HTTP headers to send to the server (HTTP URLs only). The headers can specify such things as the action required of the server, the type of data being passed to the server, or a status code.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a cancel flag. An application can set this parameter to nonzero to cancel the navigation operation, or to zero to allow it to proceed.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::Navigate](../vs140/chtmlview--navigate.md)   
 [CHtmlView::Navigate2](../vs140/chtmlview--navigate2.md)   
 [DWebBrowserEvents2::BeforeNavigate2](https://msdn.microsoft.com/en-us/library/aa768280.aspx)