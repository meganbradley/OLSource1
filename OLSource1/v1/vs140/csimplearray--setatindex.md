---
title: "CSimpleArray::SetAtIndex"
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
  - CSimpleArray::SetAtIndex
  - ATL::CSimpleArray::SetAtIndex
  - SetAtIndex
  - ATL.CSimpleArray.SetAtIndex
  - CSimpleArray.SetAtIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetAtIndex method
ms.assetid: fca9769e-bd7e-4562-a4ed-9b91bdaf5148
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleArray::SetAtIndex
Set the specified element in the array.  
  
## Syntax  
  
```  
  
      BOOL SetAtIndex(  
   int nIndex,  
   const T& t   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index of the element to change.  
  
 *t*  
 The value to assign to the specified element.  
  
## Return Value  
 Returns TRUE if successful, FALSE if the index was not valid.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArray::RemoveAt](../vs140/csimplearray--removeat.md)   
 [CSimpleArray::Add](../vs140/csimplearray--add.md)