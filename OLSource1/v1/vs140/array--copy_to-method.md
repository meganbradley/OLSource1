---
title: "array::copy_to Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::array::copy_to"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_to method"
ms.assetid: 10f08975-2156-4b75-b836-e50b5b9f150c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::copy_to Method
Copies the contents of the [array](../vs140/array-class.md) to another `array`.  
  
## Syntax  
  
```  
void copy_to(  
   array<_Value_type, _Rank>& _Dest  
) const ;  
  
void copy_to(  
   array_view<_Value_type, _Rank>& _Dest  
) const ;  
```  
  
#### Parameters  
 `_Dest`  
 The [array_view](../vs140/array_view-class.md) object to copy to.  
  
## Remarks  
 A call to `copy(*this, dest)` is used to make the copy.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)