---
title: "CHttpFile::GetObject"
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
  - "CHttpFile.GetObject"
  - "CHttpFile::GetObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHttpFile class, attributes"
  - "GetObject method"
ms.assetid: a035f088-9894-431b-a4ec-a647bc25569c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::GetObject
Call this member function to get the name of the object associated with this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the object.  
  
## Remarks  
 Use this member function only after a successful call to [SendRequest](../vs140/chttpfile--sendrequest.md) or on a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession--openurl.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)