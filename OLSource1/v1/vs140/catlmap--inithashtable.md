---
title: "CAtlMap::InitHashTable"
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
  - "ATL.CAtlMap.InitHashTable"
  - "CAtlMap.InitHashTable"
  - "ATL::CAtlMap::InitHashTable"
  - "CAtlMap::InitHashTable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitHashTable method"
ms.assetid: 1faecd3e-160c-4027-8808-5862bfcb6b63
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::InitHashTable
Call this method to initialize the hash table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of bins used by the hash table. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for an explanation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A flag indication when memory should be allocated.  
  
## Return Value  
 Returns **true** on successful initialization, **false** on failure.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be called before any elements are stored in the hash table.  If this method is not called explicitly, it will be called automatically the first time an element is added using the bin count specified by the **CAtlMap** constructor.  Otherwise, the map will be initialized using the new bin count specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is false, the memory required by the hash table will not be allocated until it is first required. This can be useful if it is uncertain if the map will be used.  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)