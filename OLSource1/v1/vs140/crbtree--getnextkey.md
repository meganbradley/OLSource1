---
title: "CRBTree::GetNextKey"
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
  - "CRBTree.GetNextKey"
  - "CRBTree::GetNextKey"
  - "ATL.CRBTree.GetNextKey"
  - "GetNextKey"
  - "ATL::CRBTree::GetNextKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextKey method"
ms.assetid: b6b6f835-3974-470b-8dcc-266d96878783
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetNextKey
Call this method to get the key of an element stored in the tree and advance the position to the next element.  
  
## Syntax  
  
```  
  
      const K& GetNextKey(  
   POSITION& pos   
) const throw( );  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Return Value  
 Returns a reference to the next key in the tree.  
  
## Remarks  
 Updates the current position counter, `pos`. If there are no more entries in the tree, the position counter is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md)   
 [CRBTree::GetNextValue](../vs140/crbtree--getnextvalue.md)