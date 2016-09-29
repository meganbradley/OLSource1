---
title: "CHtmlView::SetAddressBar"
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
  - "CHtmlView::SetAddressBar"
  - "CHtmlView.SetAddressBar"
  - "SetAddressBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAddressBar method"
  - "CHtmlView class, properties"
  - "CHtmlView class, attributes"
ms.assetid: c890e3f4-6510-4329-ba6b-c6cf606bf207
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetAddressBar
Call this member function to show or hide the Internet Explorer object's address bar.  
  
## Syntax  
  
```  
  
      void SetAddressBar(  
   BOOL bNewValue   
);  
```  
  
#### Parameters  
 `bNewValue`  
 Nonzero to show address bar; otherwise zero.  
  
## Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetAddressBar](../vs140/chtmlview--getaddressbar.md)   
 [IWebBrowser2::put_AddressBar](https://msdn.microsoft.com/en-us/library/aa752110.aspx)