---
title: "CSimpleArray::Find"
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
  - "CSimpleArray::Find"
  - "ATL.CSimpleArray.Find"
  - "CSimpleArray.Find"
  - "ATL::CSimpleArray::Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Find method"
ms.assetid: 595482f7-33a0-43f8-a5c9-8fddc0d9408a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::Find
Finds an element in the array.  
  
## Syntax  
  
```  
  
      int Find(  
   const T& t   
) const;  
```  
  
#### Parameters  
 *t*  
 The element for which to search.  
  
## Return Value  
 Returns the index of the found element, or -1 if the element is not found.  
  
## Example  
 [!code[NVC_ATL_Utilities#88](../vs140/codesnippet/CPP/csimplearray--find_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)