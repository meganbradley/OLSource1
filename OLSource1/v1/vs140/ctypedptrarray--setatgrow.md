---
title: "CTypedPtrArray::SetAtGrow"
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
  - "CTypedPtrArray.SetAtGrow"
  - "CTypedPtrArray::SetAtGrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAtGrow method"
  - "CTypedPtrArray class, operations"
ms.assetid: b13587b6-1f7d-4ee0-b865-811bf96f1785
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::SetAtGrow
This member function calls `BASE_CLASS`**::SetAtGrow**.  
  
## Syntax  
  
```  
  
      void SetAtGrow(   
   INT_PTR nIndex,   
   TYPE newElement    
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that is greater than or equal to 0.  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 `newElement`  
 The object pointer to be added to this array. A **NULL** value is allowed.  
  
## Remarks  
 For more detailed remarks, see [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)