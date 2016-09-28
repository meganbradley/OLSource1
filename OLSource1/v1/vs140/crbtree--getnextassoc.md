---
title: "CRBTree::GetNextAssoc"
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
  - "ATL.CRBTree.GetNextAssoc"
  - "ATL::CRBTree::GetNextAssoc"
  - "CRBTree.GetNextAssoc"
  - "CRBTree::GetNextAssoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextAssoc method"
ms.assetid: 85ca5023-da96-41f4-84aa-e0bfe909682d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetNextAssoc
Call this method to get the key and value of an element stored in the map and advance the position to the next element.  
  
## Syntax  
  
```  
  
      void GetNextAssoc(  
   POSITION& pos,  
   KOUTARGTYPE key,  
   VOUTARGTYPE value   
) const;  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
 `key`  
 Template parameter specifying the type of the tree's key.  
  
 *value*  
 Template parameter specifying the type of the tree's value.  
  
## Remarks  
 The `pos` position counter is updated after each call. If the retrieved element is the last in the tree, `pos` is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetPrev](../vs140/crbtree--getprev.md)   
 [CRBTree::GetNext](../vs140/crbtree--getnext.md)   
 [CRBTree::GetAt](../vs140/crbtree--getat.md)