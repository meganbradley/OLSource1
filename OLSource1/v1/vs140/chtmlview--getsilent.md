---
title: "CHtmlView::GetSilent"
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
  - "CHtmlView.GetSilent"
  - "CHtmlView::GetSilent"
  - "GetSilent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetSilent method"
  - "CHtmlView class, attributes"
ms.assetid: 076187f0-fdb4-4125-a4f8-4761773d2b36
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetSilent
Call this member function to determine whether any dialog boxes can be shown in the WebBrowser control.  
  
## Syntax  
  
```  
  
BOOL GetSilent( ) const;  
  
```  
  
## Return Value  
 Nonzero if dialog boxes cannot be displayed from the WebBrowser control; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetSilent](../vs140/chtmlview--setsilent.md)   
 [IWebBrowser2::get_Silent](https://msdn.microsoft.com/en-us/library/aa768269.aspx)