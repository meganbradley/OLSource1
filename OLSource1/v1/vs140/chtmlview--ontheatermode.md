---
title: "CHtmlView::OnTheaterMode"
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
  - "CHtmlView.OnTheaterMode"
  - "CHtmlView::OnTheaterMode"
  - "OnTheaterMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTheaterMode method"
  - "CHtmlView class, events"
ms.assetid: 53db102a-c8f2-4e2a-82fc-31f0926a8427
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnTheaterMode
This member function is called by the framework when the [TheaterMode](https://msdn.microsoft.com/en-us/library/aa768273.aspx) property has changed.  
  
## Syntax  
  
```  
  
      virtual void OnTheaterMode(  
   BOOL bTheaterMode   
);  
```  
  
#### Parameters  
 *bTheaterMode*  
 Nonzero if Internet Explorer is in theater mode; zero otherwise.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetTheaterMode](../vs140/chtmlview--gettheatermode.md)   
 [CHtmlView::SetTheaterMode](../vs140/chtmlview--settheatermode.md)   
 [DWebBrowserEvents2::OnTheaterMode](https://msdn.microsoft.com/en-us/library/aa768292.aspx)