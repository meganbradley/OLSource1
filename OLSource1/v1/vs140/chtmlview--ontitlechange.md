---
title: "CHtmlView::OnTitleChange"
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
  - CHtmlView::OnTitleChange
  - CHtmlView.OnTitleChange
  - OnTitleChange
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnTitleChange method
  - CHtmlView class, events
ms.assetid: 55963493-8486-4bb2-b8fe-09d1fc642891
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::OnTitleChange
This member function is called by the framework to notify an application if the title of a document in the WebBrowser control becomes available or changes.  
  
## Syntax  
  
```  
  
      virtual void OnTitleChange(  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 `lpszText`  
 The new document title.  
  
## Remarks  
 For HTML, the title might change; while HTML is still downloading, the URL of the document is set as the title. After the real title (if there is one) is parsed from the HTML, the title is changed to reflect the actual title.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)