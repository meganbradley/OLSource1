---
title: "CHtmlView::SetOffline"
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
  - "CHtmlView.SetOffline"
  - "SetOffline"
  - "CHtmlView::SetOffline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "SetOffline method"
  - "CHtmlView class, attributes"
ms.assetid: 6325e285-7ff4-475a-b16a-f4e90967bbde
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::SetOffline
Call this member function to set a value indicating whether the WebBrowser control is currently operating in offline mode.  
  
## Syntax  
  
```  
  
      void SetOffline(  
   BOOL bNewValue   
);  
```  
  
#### Parameters  
 `bNewValue`  
 Nonzero to read from the local cache; otherwise zero.  
  
## Remarks  
 In offline mode, the browser reads HTML pages from the local cache rather than from the source document.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetOffline](../vs140/chtmlview--getoffline.md)   
 [IWebBrowser2::put_Offline](https://msdn.microsoft.com/en-us/library/aa752135.aspx)