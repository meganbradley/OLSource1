---
title: "allocators operators2"
ms.custom: na
ms.date: "09/21/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "allocators operators"
ms.assetid: 96ce52b9-c600-4ecb-8e92-b8817eccdb66
caps.latest.revision: 7
---
# allocators operators2
|||  
|-|-|  
|[operator!= (&lt;allocators&gt;)](#operatornot_eq___lt_allocators_gt__)|[operator== (&lt;allocators&gt;)](#operator_eq_eq___lt_allocators_gt__)|  
  
##  \<a name="operator_not_eq___lt_allocators_gt__"></a>  operator!= (&lt;allocators&gt;)  
 Tests for inequality between allocator objects of a specified class.  
  
```  
template <class Type, class Sync>  
    bool operator!=(  
        const allocator_base<Type, Sync>& _Left,  
        const allocator_base<Type, Sync>& _Right  
    );  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|One of the allocator objects to be tested for inequality.|  
|`_Right`|One of the allocator objects to be tested for inequality.|  
  
### Return Value  
 **true** if the allocator objects are not equal;                         **false** if allocator objects are equal.  
  
### Remarks  
 The template operator returns                         `!(_Left == _Right)`.  
  
##  \<a name="operator_eq_eq___lt_allocators_gt__"></a>  operator== (&lt;allocators&gt;)  
 Tests for equality between allocator objects of a specified class.  
  
```  
template <class Type, class Sync>  
    bool operator==(  
        const allocator_base<Type, Sync>& _Left,  
        const allocator_base<Type, Sync>& _Right  
    );  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|One of the allocator objects to be tested for equality.|  
|`_Right`|One of the allocator objects to be tested for equality.|  
  
### Return Value  
 **true** if the allocator objects are equal;                         **false** if allocator objects are not equal.  
  
### Remarks  
 This template operator returns                         `_Left.equals(_Right)`.