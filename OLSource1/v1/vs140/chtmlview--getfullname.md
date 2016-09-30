---
title: "CHtmlView::GetFullName"
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
  - "CHtmlView::GetFullName"
  - "GetFullName"
  - "CHtmlView.GetFullName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, properties"
  - "GetFullName method"
  - "CHtmlView class, attributes"
ms.assetid: 2e1de14c-d1ef-4930-9cd3-515034f5c2b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::GetFullName
Call this member function to retrieve the full path of the file that Internet Explorer is currently displaying.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the path and name of the currently displayed file. If no path and filename exist, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns an empty <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IWebBrowser2::get_FullName](https://msdn.microsoft.com/en-us/library/aa752118.aspx)