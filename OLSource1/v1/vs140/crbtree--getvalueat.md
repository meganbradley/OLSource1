---
title: "CRBTree::GetValueAt"
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
  - "GetValueAt"
  - "CRBTree::GetValueAt"
  - "ATL.CRBTree.GetValueAt"
  - "CRBTree.GetValueAt"
  - "ATL::CRBTree::GetValueAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValueAt method"
ms.assetid: 07f6f005-59f2-4467-b571-4b71b12e55e4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetValueAt
Call this method to retrieve the value stored at a given position in the `CRBTree` object.  
  
## Syntax  
  
```  
  
      const V& GetValueAt(  
   POSITION pos   
) const throw( );  
V& GetValueAt(  
   POSITION pos   
) throw( );  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Return Value  
 Returns a reference to the value stored at the given position in the `CRBTree` object.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetAt](../vs140/crbtree--getat.md)   
 [CRBTree::GetKeyAt](../vs140/crbtree--getkeyat.md)