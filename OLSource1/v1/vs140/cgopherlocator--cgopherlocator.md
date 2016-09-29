---
title: "CGopherLocator::CGopherLocator"
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
  - "CGopherLocator"
  - "CGopherLocator::CGopherLocator"
  - "CGopherLocator.CGopherLocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "searching, gopher"
  - "gopher locator"
  - "CGopherLocator class, constructor"
ms.assetid: 1f5e9056-c37a-43f9-9eb3-b438de52462e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherLocator::CGopherLocator
This member function is called to create a `CGopherLocator` object.  
  
## Syntax  
  
```  
  
      CGopherLocator(  
   const CGopherLocator& ref   
);  
```  
  
#### Parameters  
 `ref`  
 A reference to a constant `CGopherLocator` object.  
  
## Remarks  
 You never create a `CGopherLocator` object directly. Instead, call [CGopherConnection::CreateLocator](../vs140/cgopherconnection--createlocator.md) to create and return a pointer to the `CGopherLocator` object.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)