---
title: "CAtlArray::SetAtGrow"
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
  - CAtlArray::SetAtGrow
  - ATL::CAtlArray::SetAtGrow
  - ATL.CAtlArray.SetAtGrow
  - CAtlArray.SetAtGrow
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetAtGrow method
ms.assetid: d64aa99f-793c-4a2b-9c04-6704d0a7c91a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlArray::SetAtGrow
Call this method to set the value of an element in the array object, expanding the array as required.  
  
## Syntax  
  
```  
  
      void SetAtGrow(  
   size_t iElement,  
   INARGTYPE element   
);  
```  
  
#### Parameters  
 `iElement`  
 The index pointing to the array element to set.  
  
 `element`  
 The new value of the specified element.  
  
## Remarks  
 Replaces the value of the element pointed to by the index. If `iElement` is larger than the current size of the array, the array is automatically increased using a call to [CAtlArray::SetCount](../vs140/catlarray--setcount.md). In debug builds, an ATLASSERT will be raised if the `CAtlArray` object is not valid. In retail builds, invalid parameters may cause unpredictable results.  
  
## Example  
 [!code[NVC_ATL_Utilities#12](../vs140/codesnippet/CPP/catlarray--setatgrow_1.cpp)]
  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::SetAt](../vs140/catlarray--setat.md)