---
title: "operator== Operator (&lt;scoped_allocator&gt;)"
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
  - "scoped_allocator/std::operator=="
dev_langs: 
  - "C++"
ms.assetid: a83e205f-cbea-450c-bff6-76a2f83cec29
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== Operator (&lt;scoped_allocator&gt;)
Tests two `scoped_allocator_adaptor` objects for equality.  
  
## Syntax  
  
```cpp  
template<class Outer, class... Inner>  
    bool operator==(  
        const scoped_allocator_adaptor<Outer, Inner...>& left,  
        const scoped_allocator_adaptor<Outer, Inner...>& right) noexcept;  
```  
  
#### Parameters  
 `left`  
 The left `scoped_allocator_adaptor` object.  
  
 `right`  
 The right `scoped_allocator_adaptor` object.  
  
## Return Value  
 `left.outer_allocator() == right.outer_allocator() && left.inner_allocator() == right.inner_allocator()`  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [operator!= Operator (<scoped_allocator>)](../vs140/operator!=-operator---scoped_allocator--.md)