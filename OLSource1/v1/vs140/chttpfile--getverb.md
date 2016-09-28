---
title: "CHttpFile::GetVerb"
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
  - "GetVerb"
  - "CHttpFile::GetVerb"
  - "CHttpFile.GetVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HTTP commands"
  - "CHttpFile class, attributes"
  - "GetVerb method"
ms.assetid: c5445ec8-eb69-4de1-97e2-44b4a3294db1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::GetVerb
Call this member function to get the HTTP verb (or method) associated with this `CHttpFile`.  
  
## Syntax  
  
```  
  
CString GetVerb( ) const;  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the HTTP verb (or method).  
  
## Remarks  
 Use this member function only after a successful call to [SendRequest](../vs140/chttpfile--sendrequest.md) or on a `CHttpFile` object successfully created by [OpenURL](../vs140/cinternetsession--openurl.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)