---
title: "CHtmlView::GetLocationURL"
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
  - "GetLocationURL"
  - "CHtmlView.GetLocationURL"
  - "CHtmlView::GetLocationURL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetLocationURL method"
  - "CHtmlView class, attributes"
ms.assetid: 11192373-3e1a-4bfa-8ce1-db2a7337c0bf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetLocationURL
Call this member function to retrieve the URL of the resource that the WebBrowser control is currently displaying.  
  
## Syntax  
  
```  
  
CString GetLocationURL( ) const;  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the URL of the resource currently displayed in the WebBrowser.  
  
## Remarks  
 If the resource is a folder or file on the network or local computer, the name is the UNC or full path of the folder or file.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetLocationName](../vs140/chtmlview--getlocationname.md)   
 [IWebBrowser2::get_LocationURL](https://msdn.microsoft.com/en-us/library/aa752130.aspx)