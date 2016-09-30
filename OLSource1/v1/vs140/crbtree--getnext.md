---
title: "CRBTree::GetNext"
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
  - "ATL.CRBTree.GetNext"
  - "ATL::CRBTree::GetNext"
  - "CRBTree.GetNext"
  - "CRBTree::GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNext method"
ms.assetid: f2bb378d-f06c-4ad6-98c3-92c2f040c1a2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetNext
Call this method to obtain a pointer to an element stored in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, and advance the position to the next element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Return Value  
 Returns a pointer to the next [CPair](../vs140/crbtree--cpair-class.md) value in the tree.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> position counter is updated after each call. If the retrieved element is the last in the tree, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetPrev](../vs140/crbtree--getprev.md)