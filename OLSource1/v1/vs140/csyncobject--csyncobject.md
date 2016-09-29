---
title: "CSyncObject::CSyncObject"
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
  - "CSyncObject::CSyncObject"
  - "CSyncObject.CSyncObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSyncObject constructor"
  - "CSyncObject class, constructor"
ms.assetid: 6361e66b-2f68-4400-8ed4-53f8a4e20737
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSyncObject::CSyncObject
Constructs a synchronization object with the supplied name.  
  
## Syntax  
  
```  
  
      explicit CSyncObject(  
   LPCTSTR pstrName   
);  
virtual ~CSyncObject( );  
```  
  
#### Parameters  
 `pstrName`  
 The name of the object. If **NULL**, *pstrName* will be null.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSyncObject Class](../vs140/csyncobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)