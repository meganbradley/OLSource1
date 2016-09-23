---
title: "CHttpFile::GetFileURL"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHttpFile.GetFileURL
  - CHttpFile::GetFileURL
  - GetFileURL
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFileURL method
  - CHttpFile class, attributes
  - HTTP files
  - HTTP requests, requesting and reading files
ms.assetid: 447c57da-881d-4e04-90d0-ac7335ae831c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHttpFile::GetFileURL
Call this member function to get the name of the HTTP file as a URL.  
  
## Syntax  
  
```  
  
virtual CString GetFileURL( ) const;  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing a URL referencing the resource associated with this file.  
  
## Remarks  
 Use this member function only after a successful call to [SendRequest](../vs140/chttpfile--sendrequest.md) or on a `CHttpFile` object successfully created by [OpenURL](../vs140/cinternetsession--openurl.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)