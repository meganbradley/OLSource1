---
title: "CSimpleArray::operator"
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
  - "CSimpleArray::operator[]"
  - "CSimpleArray.operator[]"
  - "ATL.CSimpleArray.operator[]"
  - "ATL::CSimpleArray::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], arrays"
  - "[] operator"
  - "operator[], arrays"
ms.assetid: 074a23c8-e767-4461-8785-2b9c19cdb043
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::operator
Retrieves an element from the array.  
  
## Syntax  
  
```  
  
      T& operator[](int nIndex);  
```  
  
#### Parameters  
 `nIndex`  
 The element index.  
  
## Return Value  
 Returns the element of the array referenced by `nIndex`.  
  
## Example  
 [!code[NVC_ATL_Utilities#89](../vs140/codesnippet/CPP/csimplearray--operator_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)