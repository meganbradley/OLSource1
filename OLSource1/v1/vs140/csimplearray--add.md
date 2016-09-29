---
title: "CSimpleArray::Add"
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
  - "CSimpleArray::Add"
  - "ATL::CSimpleArray::Add"
  - "ATL.CSimpleArray.Add"
  - "CSimpleArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 0bf3ffa0-69e8-43d3-999a-f8138ae729e2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::Add
Adds a new element to the array.  
  
## Syntax  
  
```  
  
      BOOL Add(  
   const T& t   
);  
```  
  
#### Parameters  
 *t*  
 The element to add to the array.  
  
## Return Value  
 Returns TRUE if the element is successfully added to the array, FALSE otherwise.  
  
## Example  
 [!code[NVC_ATL_Utilities#87](../vs140/codesnippet/CPP/csimplearray--add_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArray::SetAtIndex](../vs140/csimplearray--setatindex.md)