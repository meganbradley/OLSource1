---
title: "CHtmlView::SetRegisterAsBrowser"
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
  - "SetRegisterAsBrowser"
  - "CHtmlView::SetRegisterAsBrowser"
  - "CHtmlView.SetRegisterAsBrowser"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "SetRegisterAsBrowser method"
  - "CHtmlView class, attributes"
ms.assetid: a3f393df-2a38-47a2-ab76-50c97b50fe1c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetRegisterAsBrowser
Call this member function to set a value indicating whether the WebBrowser control is registered as a top-level browser for target name resolution.  
  
## Syntax  
  
```  
  
      void SetRegisterAsBrowser(  
   BOOL bNewValue   
);  
```  
  
#### Parameters  
 `bNewValue`  
 Determines whether Internet Explorer is registered as a top-level browser. If nonzero, the web browser is registered as a top-level browser; if zero, it is not a top-level browser. The default value is zero.  
  
## Remarks  
 A top-level browser is the browser set in the registry as the default browser.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetRegisterAsBrowser](../vs140/chtmlview--getregisterasbrowser.md)   
 [IWebBrowser2::put_RegisterAsBrowser](https://msdn.microsoft.com/en-us/library/aa768264.aspx)