---
title: "CAtlArray::RemoveAt"
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
  - "CAtlArray::RemoveAt"
  - "ATL.CAtlArray.RemoveAt"
  - "CAtlArray.RemoveAt"
  - "ATL::CAtlArray::RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAt method"
ms.assetid: 4ffb3659-8a3c-4435-86b8-190b571c7d3f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::RemoveAt
Call this method to remove one or more elements from the array.  
  
## Syntax  
  
```  
  
      void RemoveAt(  
   size_t iElement,  
   size_t nCount = 1   
);  
```  
  
#### Parameters  
 `iElement`  
 The index of the first element to remove.  
  
 `nCount`  
 The number of elements to remove.  
  
## Remarks  
 Removes one or more elements from the array. Any remaining elements are shifted down. The upper bound is decremented, but memory is not freed until a call to [CAtlArray::FreeExtra](../vs140/catlarray--freeextra.md) is made.  
  
 In debug builds, an ATLASSERT will be raised if the `CAtlArray` object is not valid, or if the combined total of `iElement` and `nCount` exceeds the total number of elements in the array. In retail builds, invalid parameters may cause unpredictable results.  
  
## Example  
 [!code[NVC_ATL_Utilities#11](../vs140/codesnippet/CPP/catlarray--removeat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::RemoveAll](../vs140/catlarray--removeall.md)