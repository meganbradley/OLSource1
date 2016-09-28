---
title: "CHtmlView::Navigate2"
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
  - "CHtmlView.Navigate2"
  - "CHtmlView::Navigate2"
  - "Navigate2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlView class, operations"
  - "Navigate2 method"
ms.assetid: e3645c6e-60f1-4b48-8603-54f40c64a723
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::Navigate2
Call this member function to navigate to the resource identified by a URL, or to the file identified by a full path.  
  
## Syntax  
  
```  
  
      void Navigate2(  
   LPITEMIDLIST pIDL,  
   DWORD dwFlags = 0,  
   LPCTSTR lpszTargetFrameName = NULL   
);  
void Navigate2(  
   LPCTSTR lpszURL,  
   DWORD dwFlags = 0,  
   LPCTSTR lpszTargetFrameName = NULL,  
   LPCTSTR lpszHeaders = NULL,  
   LPVOID lpvPostData = NULL,  
   DWORD dwPostDataLen = 0   
);  
void Navigate2(  
   LPCTSTR lpszURL,  
   DWORD dwFlags,  
   CByteArray& baPostedData,  
   LPCTSTR lpszTargetFrameName = NULL,  
   LPCTSTR lpszHeader = NULL   
);  
```  
  
#### Parameters  
 *pIDL*  
 A pointer to an [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) structure.  
  
 `dwFlags`  
 The flags of a variable that specifies whether to add the resource to the history list, whether to read to or write from the cache, and whether to display the resource in a new window. The variable can be a combination of the values defined by the [BrowserNavConstants](https://msdn.microsoft.com/en-us/library/aa768360.aspx) enumeration.  
  
 `lpszTargetFrameName`  
 A pointer to a string that contains the name of the frame in which to display the resource.  
  
 `lpszURL`  
 A pointer to a string containing the URL.  
  
 `lpvPostData`  
 Data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, `Navigate2` issues an HTTP GET transaction. This parameter is ignored if *URL* is not an HTTP or HTTPS URL.  
  
 `dwPostDataLen`  
 Length in bytes of the data pointed to by the `lpvPostData` parameter.  
  
 `lpszHeaders`  
 A pointer to a value that specifies the HTTP or HTTPS headers to send to the server. These headers are added to the default Internet Explorer headers. The headers can specify such things as the action required of the server, the type of data being passed to the server, or a status code. This parameter is ignored if *URL* is not an HTTP or HTTPS URL.  
  
 `baPostedData`  
 A reference to a [CByteArray](../vs140/cbytearray-class.md) object.  
  
## Remarks  
 This member function extends the **Navigate** member function by supporting browsing on special folders, such as Desktop and My Computer, that are represented by the parameter *pIDL*.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Example  
 [!code[NVC_MFCHtmlHttp#7](../vs140/codesnippet/CPP/chtmlview--navigate2_1.cpp)]  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::Navigate](../vs140/chtmlview--navigate.md)   
 [IWebBrowser2::Navigate2](https://msdn.microsoft.com/en-us/library/aa752134.aspx)