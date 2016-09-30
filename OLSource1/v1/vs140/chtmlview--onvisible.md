---
title: "CHtmlView::OnVisible"
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
  - "CHtmlView.OnVisible"
  - "CHtmlView::OnVisible"
  - "OnVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hiding Web browser"
  - "OnVisible method"
  - "CHtmlView class, events"
ms.assetid: 6119f151-57ad-4a7d-96b4-513771afe858
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnVisible
This member function is called by the framework when the window for the WebBrowser should be shown or hidden.  
  
## Syntax  
  
```  
  
      virtual void OnVisible(  
   BOOL bVisible   
);  
```  
  
#### Parameters  
 `bVisible`  
 Nonzero if the object is visible or zero otherwise.  
  
## Remarks  
 This allows the object control host window to behave the same way the Internet Explorer window would behave.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetVisible](../vs140/chtmlview--setvisible.md)   
 [CHtmlView::GetVisible](../vs140/chtmlview--getvisible.md)   
 [DWebBrowserEvents2::OnVisible](https://msdn.microsoft.com/en-us/library/aa768294.aspx)