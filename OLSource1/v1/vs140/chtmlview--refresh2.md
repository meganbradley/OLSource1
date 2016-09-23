---
title: "CHtmlView::Refresh2"
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
  - CHtmlView.Refresh2
  - Refresh2
  - CHtmlView::Refresh2
dev_langs: 
  - C++
helpviewer_keywords: 
  - CHtmlView class, operations
  - Refresh2 method
ms.assetid: 8e0b6237-da65-47e2-bf51-37115aa0ea79
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlView::Refresh2
Reloads the file that Internet Explorer is currently displaying.  
  
## Syntax  
  
```  
  
      void Refresh2(  
   int nLevel   
);  
```  
  
#### Parameters  
 `nLevel`  
 The address of the variable specifying the refresh level. The possible variables are defined in [RefreshConstants](https://msdn.microsoft.com/en-us/library/aa768363.aspx), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 Unlike [Refresh](../vs140/chtmlview--refresh.md), `Refresh2` contains a parameter that specifies the refresh level.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IWebBrowser2::Refresh2](https://msdn.microsoft.com/en-us/library/aa768260.aspx)