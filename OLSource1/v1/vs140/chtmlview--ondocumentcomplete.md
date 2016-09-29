---
title: "CHtmlView::OnDocumentComplete"
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
  - "READYSTATE_COMPLETE"
  - "CHtmlView::OnDocumentComplete"
  - "CHtmlView.OnDocumentComplete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HTML download"
  - "OnDocumentComplete method"
  - "downloading HTML"
  - "READYSTATE_COMPLETE"
  - "CHtmlView class, events"
ms.assetid: 21f8a6f6-da83-47f0-a071-8dd06f66133c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnDocumentComplete
This member function is called by the framework to notify an application that a document has reached the `READYSTATE_COMPLETE` state.  
  
## Syntax  
  
```  
  
      virtual void OnDocumentComplete(  
   LPCTSTR lpszURL   
);  
```  
  
#### Parameters  
 `lpszURL`  
 A pointer to a string that evaluates to the URL, UNC file name, or a PIDL (a pointer to an item identifier list) that was navigated to.  
  
## Remarks  
 Not every frame will fire this event, but each frame that fires an [OnDownloadBegin](../vs140/chtmlview--ondownloadbegin.md) event will fire a corresponding `OnDocumentComplete` event.  
  
 The URL indicated by `lpszURL` can be different from the URL that the browser was told to navigate to, because this URL is the canonicalized and qualified URL. For example, if an application specifies a URL of "www.microsoft.com" in a call to [Navigate](../vs140/chtmlview--navigate.md) or [Navigate2](../vs140/chtmlview--navigate2.md), the URL passed by `OnNavigateComplete2` will be "http://www.microsoft.com/". Also, if the server has redirected the browser to a different URL, the redirected URL will be reflected here.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetHtmlDocument](../vs140/chtmlview--gethtmldocument.md)   
 [DWebBrowserEvents2::DocumentComplete](https://msdn.microsoft.com/en-us/library/aa768282.aspx)