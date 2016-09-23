---
title: "CHtmlView::GetTopLevelContainer"
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
  - CHtmlView::GetTopLevelContainer
  - GetTopLevelContainer
  - CHtmlView.GetTopLevelContainer
dev_langs: 
  - C++
helpviewer_keywords: 
  - CHtmlView class, properties
  - GetTopLevelContainer method
  - CHtmlView class, attributes
ms.assetid: d709fae5-3344-47ce-989a-1485a01b669a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::GetTopLevelContainer
Call this member function to determine whether Internet Explorer is the top-level container of the WebBrowser control.  
  
## Syntax  
  
```  
  
BOOL GetTopLevelContainer( ) const;  
  
```  
  
## Return Value  
 Nonzero the container is the top-level container; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetContainer](../vs140/chtmlview--getcontainer.md)   
 [IWebBrowser2::get_TopLevelContainer](https://msdn.microsoft.com/en-us/library/aa768276.aspx)