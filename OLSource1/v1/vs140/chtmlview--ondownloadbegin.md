---
title: "CHtmlView::OnDownloadBegin"
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
  - "CHtmlView::OnDownloadBegin"
  - "CHtmlView.OnDownloadBegin"
  - "OnDownloadBegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "downloading HTML"
  - "CHtmlView class, events"
  - "OnDownloadBegin method"
ms.assetid: 1ec816d5-337e-4e89-9b8e-d9f7c743e8be
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnDownloadBegin
This member function is called by the framework to begin downloading a document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This event is fired shortly after the [OnBeforeNavigate2](../vs140/chtmlview--onbeforenavigate2.md) event, unless the navigation is canceled. Any animation or "busy" indication that the container needs to display should be connected to this event.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::OnDownloadComplete](../vs140/chtmlview--ondownloadcomplete.md)   
 [CHtmlView::Navigate](../vs140/chtmlview--navigate.md)   
 [CHtmlView::Navigate2](../vs140/chtmlview--navigate2.md)