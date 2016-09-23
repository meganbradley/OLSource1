---
title: "CHtmlView::OnMenuBar"
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
  - OnMenuBar
  - CHtmlView::OnMenuBar
  - CHtmlView.OnMenuBar
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnMenuBar method
  - displaying menu bars
  - CHtmlView class, events
ms.assetid: c5e8afcd-b868-4441-9b68-123c7a507698
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::OnMenuBar
This member function is called by the framework when the [MenuBar](https://msdn.microsoft.com/en-us/library/aa752131.aspx) property has changed.  
  
## Syntax  
  
```  
  
      virtual void OnMenuBar(  
   BOOL bMenuBar   
);  
```  
  
#### Parameters  
 *bMenuBar*  
 Nonzero if the Internet Explorer menu bar is visible; zero otherwise.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetMenuBar](../vs140/chtmlview--getmenubar.md)   
 [CHtmlView::SetMenuBar](../vs140/chtmlview--setmenubar.md)   
 [DWebBrowserEvents2::OnMenuBar](https://msdn.microsoft.com/en-us/library/aa768290.aspx)