---
title: "CComObject::~CComObject"
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
  - "~CComObject"
  - "CComObject.~CComObject"
  - "CComObject::~CComObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CComObject destructor"
  - "CComObject class, destructor"
ms.assetid: e42872b3-83e1-4e86-a870-72e89a779dad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObject::~CComObject
The destructor.  
  
## Syntax  
  
```  
  
CComObject( );  
  
```  
  
## Remarks  
 Frees all allocated resources, calls [FinalRelease](../vs140/ccomobjectrootex--finalrelease.md), and decrements the module lock count.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObject Class](../vs140/ccomobject-class.md)