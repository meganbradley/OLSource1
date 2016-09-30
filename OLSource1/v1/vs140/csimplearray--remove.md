---
title: "CSimpleArray::Remove"
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
  - "ATL.CSimpleArray.Remove"
  - "CSimpleArray.Remove"
  - "ATL::CSimpleArray::Remove"
  - "CSimpleArray::Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: 6966054e-aceb-4a08-844c-80fe85394cf0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::Remove
Removes a given element from the array.  
  
## Syntax  
  
```  
  
      BOOL Remove(  
   const T& t   
);  
```  
  
#### Parameters  
 *t*  
 The element to remove from the array.  
  
## Return Value  
 Returns TRUE if the element is found and removed, FALSE otherwise.  
  
## Remarks  
 When an element is removed, the remaining elements in the array are renumbered to fill the empty space.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArray::RemoveAll](../vs140/csimplearray--removeall.md)   
 [CSimpleArray::RemoveAt](../vs140/csimplearray--removeat.md)