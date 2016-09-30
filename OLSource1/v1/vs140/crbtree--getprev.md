---
title: "CRBTree::GetPrev"
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
  - "ATL::CRBTree::GetPrev"
  - "ATL.CRBTree.GetPrev"
  - "CRBTree::GetPrev"
  - "CRBTree.GetPrev"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPrev method"
ms.assetid: aa08344c-3a8d-40dd-aca5-30baedc23e83
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetPrev
Call this method to obtain a pointer to an element stored in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, and then update the position to the previous element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Return Value  
 Returns a pointer to the previous [CPair](../vs140/crbtree--cpair-class.md) value stored in the tree.  
  
## Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If there are no more entries in the tree, the position counter is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetNext](../vs140/crbtree--getnext.md)