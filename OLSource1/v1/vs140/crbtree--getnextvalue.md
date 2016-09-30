---
title: "CRBTree::GetNextValue"
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
  - "ATL::CRBTree::GetNextValue"
  - "CRBTree::GetNextValue"
  - "ATL.CRBTree.GetNextValue"
  - "GetNextValue"
  - "CRBTree.GetNextValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextValue method"
ms.assetid: 1e031b24-1750-4c0f-8992-99259c890860
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRBTree::GetNextValue
Call this method to get the value of an element stored in the tree and advance the position to the next element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to methods such as [CRBTree::GetHeadPosition](../vs140/crbtree--getheadposition.md) or [CRBTree::FindFirstKeyAfter](../vs140/crbtree--findfirstkeyafter.md).  
  
## Return Value  
 Returns a reference to the next value in the tree.  
  
## Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If there are no more entries in the tree, the position counter is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CRBTree Class](../vs140/crbtree-class.md)   
 [CRBTree::GetNextKey](../vs140/crbtree--getnextkey.md)