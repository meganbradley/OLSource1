---
title: "CRBTree::FindFirstKeyAfter"
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
  - CRBTree.FindFirstKeyAfter
  - ATL.CRBTree.FindFirstKeyAfter
  - FindFirstKeyAfter
  - ATL::CRBTree::FindFirstKeyAfter
  - CRBTree::FindFirstKeyAfter
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindFirstKeyAfter method
ms.assetid: 9bb15150-5505-4dff-9b31-3547acb8403b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRBTree::FindFirstKeyAfter
Call this method to find the position of the element that uses the next available key.  
  
## Syntax  
  
```  
  
      POSITION FindFirstKeyAfter(  
   KINARGTYPE key   
) const throw( );  
```  
  
#### Parameters  
 `key`  
 A key value.  
  
## Return Value  
 Returns the position value of the element that uses the next available key. If there are no more elements, NULL is returned.  
  
## Remarks  
 This method makes it easy to traverse the tree without having to calculate position values beforehand.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)