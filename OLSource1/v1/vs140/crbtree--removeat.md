---
title: "CRBTree::RemoveAt"
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
  - CRBTree.RemoveAt
  - ATL::CRBTree::RemoveAt
  - ATL.CRBTree.RemoveAt
  - CRBTree::RemoveAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveAt method
ms.assetid: aad8105b-4b82-494a-8375-ddfef1ebd592
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRBTree::RemoveAt
Call this method to remove the element at the given position in the **CRBTree** object.  
  
## Syntax  
  
```  
  
      void RemoveAt(  
   POSITION pos   
) throw( );  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Remarks  
 Removes the key/value pair stored at the specified position. The memory used to store the element is freed. The POSITION referenced by `pos` becomes invalid, and while the POSITION of any other elements in the tree remains valid, they do not necessarily retain the same order.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::RemoveAll](../vs140/crbtree--removeall.md)