---
title: "CSimpleArray::RemoveAt"
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
  - "CSimpleArray::RemoveAt"
  - "ATL::CSimpleArray::RemoveAt"
  - "CSimpleArray.RemoveAt"
  - "ATL.CSimpleArray.RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAt method"
ms.assetid: 422a523f-ba3a-47fa-b04c-3ecbda3dd1fe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::RemoveAt
Removes the specified element from the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index pointing to the element to remove.  
  
## Return Value  
 Returns TRUE if the element was removed, FALSE if the index was invalid.  
  
## Remarks  
 When an element is removed, the remaining elements in the array are renumbered to fill the empty space.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)   
 [CSimpleArray::RemoveAll](../vs140/csimplearray--removeall.md)   
 [CSimpleArray::Remove](../vs140/csimplearray--remove.md)