---
title: "CHtmlView::GetAddressBar"
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
  - "GetAddressBar"
  - "CHtmlView::GetAddressBar"
  - "CHtmlView.GetAddressBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "address bar [C++]"
  - "GetAddressBar method"
  - "CHtmlView class, attributes"
ms.assetid: 2503498d-fd90-4773-a0b9-90f78b158629
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetAddressBar
Call this member function to retrieve Internet Explorer's address bar.  
  
## Syntax  
  
```  
  
BOOL GetAddressBar( ) const;  
  
```  
  
## Return Value  
 Nonzero if the address bar is visible; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::SetAddressBar](../vs140/chtmlview--setaddressbar.md)   
 [IWebBrowser2::get_AddressBar](https://msdn.microsoft.com/en-us/library/aa752110.aspx)