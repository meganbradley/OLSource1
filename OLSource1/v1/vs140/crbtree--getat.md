---
title: "CRBTree::GetAt"
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
  - "CRBTree.GetAt"
  - "ATL::CRBTree::GetAt"
  - "ATL.CRBTree.GetAt"
  - "CRBTree::GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [MFC]"
ms.assetid: 86b0c395-93b8-4afb-b8cc-ddd8191e864f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetAt
Call this method to get the element at a given position in the tree.  
  
## Syntax  
  
```  
  
      CPair* GetAt(  
   POSITION pos   
) throw( );  
const CPair* GetAt(  
   POSITION pos   
) const throw( );  
void GetAt(  
   POSITION pos,  
   KOUTARGTYPE key,  
   VOUTARGTYPE value   
) const;  
```  
  
#### Parameters  
 `pos`  
 The position value.  
  
 `key`  
 The variable that receives the key.  
  
 *value*  
 The variable that receives the value.  
  
## Return Value  
 The first two forms return a pointer to a [CPair](../vs140/crbtree--cpair-class.md). The third form obtains a key and a value for the given position.  
  
## Remarks  
 The position value can be previously determined with a call to a method such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::GetTailPosition](../vs140/crbtree--gettailposition.md).  
  
 In debug builds, an assertion failure will occur if `pos` is equal to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetValueAt](../vs140/crbtree--getvalueat.md)   
 [CRBTree::GetKeyAt](../vs140/crbtree--getkeyat.md)   
 [CRBTree::SetValueAt](../vs140/crbtree--setvalueat.md)