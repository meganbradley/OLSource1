---
title: "CHtmlView::GetLocationName"
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
  - "CHtmlView.GetLocationName"
  - "CHtmlView::GetLocationName"
  - "GetLocationName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetLocationName method"
  - "CHtmlView class, attributes"
ms.assetid: f5cf842a-4450-49f0-9912-37737c5b7c00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetLocationName
Call this member function to get the name of the resource being displayed in the WebBrowser.  
  
## Syntax  
  
```  
  
CString GetLocationName( ) const;  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the resource currently displayed in the WebBrowser.  
  
## Remarks  
 If the resource is an HTML page on the World Wide Web, the name is the title of that page. If the resource is a folder or file on the network or local computer, the name is the UNC or full path of the folder or file.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetLocationURL](../vs140/chtmlview--getlocationurl.md)   
 [IWebBrowser2::get_LocationName](https://msdn.microsoft.com/en-us/library/aa752129.aspx)