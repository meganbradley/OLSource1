---
title: "array_view::copy_to Method"
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
  - "amp/Concurrency::array_view::copy_to"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_to method"
ms.assetid: d0e55f3e-8fb8-4df5-afde-013cf72bed84
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::copy_to Method
Copies the contents of the [array_view](../VS_csharp/array_view-class.md) object to the specified destination object by calling `copy(*this, dest)`.  
  
## Syntax  
  
```  
void copy_to(  
   array<_Value_type, _Rank>& _Dest  
) const;  
  
void copy_to(  
   array_view<_Value_type, _Rank>& _Dest  
) const;  
```  
  
#### Parameters  
 `_Dest`  
 The object to copy to.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../VS_csharp/array_view-class.md)