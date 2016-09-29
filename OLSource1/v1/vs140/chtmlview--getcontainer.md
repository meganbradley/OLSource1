---
title: "CHtmlView::GetContainer"
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
  - "GetContainer"
  - "CHtmlView.GetContainer"
  - "CHtmlView::GetContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetContainer method"
  - "CHtmlView class, attributes"
ms.assetid: 162f7c12-14f7-4e83-a27b-20d6ba5deb00
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetContainer
Call this member function to retrieve an object that evaluates to the container of the web browser.  
  
## Syntax  
  
```  
  
LPDISPATCH GetContainer( ) const;  
  
```  
  
## Return Value  
 A pointer to the `IDispatch` interface of the active document object.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetTopLevelContainer](../vs140/chtmlview--gettoplevelcontainer.md)   
 [IWebBrowser2::get_Container](https://msdn.microsoft.com/en-us/library/aa752115.aspx)