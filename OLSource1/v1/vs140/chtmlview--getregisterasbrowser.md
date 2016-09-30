---
title: "CHtmlView::GetRegisterAsBrowser"
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
  - "CHtmlView.GetRegisterAsBrowser"
  - "GetRegisterAsBrowser"
  - "CHtmlView::GetRegisterAsBrowser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetRegisterAsBrowser method"
  - "CHtmlView class, attributes"
ms.assetid: 03a0dba6-f4e2-4eb5-bdc8-436d13e0a2b7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetRegisterAsBrowser
Call this member function to determine whether the WebBrowser object is registered as a top-level browser for target name resolution.  
  
## Syntax  
  
```  
  
BOOL GetRegisterAsBrowser( ) const;  
  
```  
  
## Return Value  
 Nonzero if the browser is registered as a top-level browser; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetRegisterAsBrowser](../vs140/chtmlview--setregisterasbrowser.md)   
 [IWebBrowser2::get_RegisterAsBrowser](https://msdn.microsoft.com/en-us/library/aa768264.aspx)