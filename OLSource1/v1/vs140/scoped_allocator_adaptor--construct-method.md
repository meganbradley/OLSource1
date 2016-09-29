---
title: "scoped_allocator_adaptor::construct Method"
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
  - "scoped_allocator/std::scoped_allocator_adaptor::construct"
dev_langs: 
  - "C++"
ms.assetid: 01420cc5-8905-4039-af41-6ef3b825cbc6
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# scoped_allocator_adaptor::construct Method
Constructs an object.  
  
## Syntax  
  
```cpp  
template<class Ty, class... Atypes>  
    void construct(Ty *ptr, Atypes&&... args);  
template<class Ty1, class Ty2, class... Atypes1, class... Atypes2>  
    void construct(pair<Ty1, Ty2> *ptr, piecewise_construct_t,  
        tuple<Atypes1&&...> first, tuple<Atypes1&&...> second);  
template<class Ty1, class Ty2>  
    void construct(pair<Ty1, Ty2> *ptr);  
template<class Ty1, class Ty2, class Uy1, class Uy2>  
    void construct(pair<Ty1, Ty2> *ptr,  
        class Uy1&& first, class Uy2&& second);  
template<class Ty1, class Ty2, class Uy1, class Uy2>  
    void construct(pair<Ty1, Ty2> *ptr, const pair<Uy1, Uy2>& right);  
template<class Ty1, class Ty2, class Uy1, class Uy2>  
    void construct(pair<Ty1, Ty2> *ptr, pair<Uy1, Uy2>&& right);  
```  
  
#### Parameters  
 `ptr`  
 A pointer to the memory location where the object is to be constructed.  
  
 `args`  
 A list of arguments.  
  
 `first`  
 An object of the first type in a pair.  
  
 `second`  
 An object of the second type in a pair.  
  
 `right`  
 An existing object to be moved or copied.  
  
## Remarks  
 The first method constructs the object at `ptr` by calling `Outermost_traits::construct(OUTERMOST(*this), ptr, xargs...)`, where `xargs...` is one of the following.  
  
-   If `uses_allocator<Ty, inner_allocator_type>` holds false, then `xargs...` is `args...`.  
  
-   If `uses_allocator<Ty, inner_allocator_type>` holds true, and `is_constructible<Ty, allocator_arg_t, inner_allocator_type, args...>` holds true, then `xargs...` is `allocator_arg, inner_allocator(), args...`.  
  
-   If `uses_allocator<Ty, inner_allocator_type>` holds true, and `is_constructible<Ty, args..., inner_allocator()>` holds true, then `xargs...` is `args..., inner_allocator()`.  
  
 The second method constructs the pair object at `ptr` by calling `Outermost_traits::construct(OUTERMOST(*this), &ptr->first, xargs...)`, where `xargs...` is `first...` modified as in the above list, and `Outermost_traits::construct(OUTERMOST(*this), &ptr->second, xargs...)`, where `xargs...` is `second...` modified as in the above list.  
  
 The third method behaves the same as `this->construct(ptr, piecewise_construct, tuple<>, tuple<>)`.  
  
 The fourth method behaves the same as `this->construct(ptr, piecewise_construct, forward_as_tuple(std::forward<Uy1>(first), forward_as_tuple(std::forward<Uy2>(second))`.  
  
 The fifth method behaves the same as `this->construct(ptr, piecewise_construct, forward_as_tuple(right.first), forward_as_tuple(right.second))`.  
  
 The sixth method behaves the same as `this->construct(ptr, piecewise_construct, forward_as_tuple(std::forward<Uy1>(right.first), forward_as_tuple(std::forward<Uy2>(right.second))`.  
  
## Requirements  
 **Header:** <scoped_allocator>  
  
 **Namespace:** std  
  
## See Also  
 [scoped_allocator_adaptor Class](../vs140/scoped_allocator_adaptor-class.md)   
 [allocator_traits::construct Method](../vs140/allocator_traits--construct-method.md)