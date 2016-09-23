---
title: "CSimpleArray::CSimpleArray"
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
  - ATL::CSimpleArray::CSimpleArray
  - CSimpleArray.CSimpleArray
  - ATL.CSimpleArray.CSimpleArray
  - CSimpleArray::CSimpleArray
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSimpleArray class, constructor
ms.assetid: dff029d0-1656-47c9-abe2-cfc2ffbfbbb3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleArray::CSimpleArray
The constructor for the array object.  
  
## Syntax  
  
```  
  
      CSimpleArray(  
   const CSimpleArray< T, TEqual >& src   
);  
CSimpleArray( );  
```  
  
#### Parameters  
 *src*  
 An existing `CSimpleArray` object.  
  
## Remarks  
 Initializes the data members, creating a new empty `CSimpleArray` object, or a copy of an existing `CSimpleArray` object.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArray::~CSimpleArray](../vs140/csimplearray--~csimplearray.md)