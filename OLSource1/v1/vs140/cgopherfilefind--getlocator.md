---
title: "CGopherFileFind::GetLocator"
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
  - "GetLocator"
  - "CGopherFileFind.GetLocator"
  - "CGopherFileFind::GetLocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CGopherFileFind class, attributes"
  - "GetLocator method"
ms.assetid: 82822a3d-7f0b-4b4d-86e3-401e68aeabdd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::GetLocator
Call this member function to get the [CGopherLocator](../vs140/cgopherlocator-class.md) object that [FindFile](../vs140/cgopherfilefind--findfile.md) uses to find the gopher file.  
  
## Syntax  
  
```  
  
CGopherLocator GetLocator( ) const;  
  
```  
  
## Return Value  
 A `CGopherLocator` object.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGopherConnection::CreateLocator](../vs140/cgopherconnection--createlocator.md)