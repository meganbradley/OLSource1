---
title: "array_view::array_view Constructor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - amp/Concurrency::array_view::array_view
dev_langs: 
  - C++
helpviewer_keywords: 
  - array_view, constructor
ms.assetid: 36ef935a-2fb0-443e-b9af-c23a248ea158
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array_view::array_view Constructor
Initializes a new instance of the [array_view](../vs140/array_view-class.md) class.  
  
## Syntax  
  
```  
array_view(  
   array<_Value_type, _Rank>& _Src  
)restrict(amp,cpu);  
  
array_view(  
   const array_view& _Other  
)restrict(amp,cpu);  
  
explicit array_view(  
   const Concurrency::extent<_Rank>& _Extent  
) restrict(cpu);  
  
template <  
   typename _Container  
>  
array_view(  
   const Concurrency::extent<_Rank>& _Extent,  
   _Container& _Src  
) restrict(cpu);  
  
array_view(  
   const Concurrency::extent<_Rank>& _Extent,  
   _Value_type * _Src  
)restrict(amp,cpu);  
  
explicit array_view(  
   int _E0  
) restrict(cpu);  
  
template <  
   typename _Container  
>  
explicit array_view(  
   _Container& _Src,  
   typename std::enable_if<details::_Is_container<_Container>::type::value, void **>::type = 0  
) restrict(cpu);  
  
template <  
   typename _Container  
>  
explicit array_view(  
   int _E0,  
   _Container& _Src  
) restrict(cpu);  
  
explicit array_view(  
   int _E0,  
   int _E1  
) __CPU_ONLY;  
  
template <  
   typename _Container  
>  
explicit array_view(  
   int _E0,  
   int _E1,  
   _Container& _Src  
) restrict(cpu);  
  
explicit array_view(  
   int _E0,  
   int _E1,  
   int _E2  
) __CPU_ONLY;  
  
template <  
   typename _Container  
>  
explicit array_view(  
   int _E0,  
   int _E1,  
   int _E2,  
   _Container& _Src  
);  
  
explicit array_view(  
   int _E0,  
   _In_ _Value_type * _Src  
)restrict(amp,cpu);  
  
template <  
   typename _Arr_type,  
   int _Size  
>  
explicit array_view(  
   _In_ _Arr_type (&_Src) [_Size]  
) restrict(amp,cpu);  
  
explicit array_view(  
   int _E0,  
   int _E1,  
   _In_ _Value_type * _Src  
)restrict(amp,cpu);  
  
explicit array_view(  
   int _E0,  
   int _E1,  
   int _E2,  
   _In_ _Value_type * _Src  
)restrict(amp,cpu);  
  
array_view(  
   const array<_Value_type, _Rank>& _Src  
)restrict(amp,cpu);  
  
array_view(  
   const array_view<_Value_type, _Rank>& _Src  
)restrict(amp,cpu);  
  
array_view(  
   const array_view<const _Value_type, _Rank>& _Src  
)restrict(amp,cpu);  
  
template <  
   typename _Container  
>  
array_view(  
   const Concurrency::extent<_Rank>& _Extent,  
   const _Container& _Src  
) restrict(cpu);  
  
template <  
   typename _Container  
>  
explicit array_view(  
   const _Container& _Src,  
   typename std::enable_if<details::_Is_container<_Container>::type::value, void **>::type = 0  
) restrict(cpu);  
  
array_view(  
   const Concurrency::extent<_Rank>& _Extent,  
   const _Value_type * _Src  
)restrict(amp,cpu);  
  
template <  
   typename _Arr_type,  
   int _Size  
>  
explicit array_view(  
   const _In_ _Arr_type (&_Src) [_Size]  
) restrict(amp,cpu);  
  
template <  
   typename _Container  
>  
array_view(  
   int _E0,  
   const _Container& _Src  
);  
  
template <  
   typename _Container  
>  
array_view(  
   int _E0,  
   int _E1,  
   const _Container& _Src  
);  
  
template <  
   typename _Container  
>  
array_view(  
   int _E0,  
   int _E1,  
   int _E2,  
   const _Container& _Src  
);  
  
array_view(  
   int _E0,  
   const _Value_type * _Src  
)restrict(amp,cpu);  
  
array_view(  
   int _E0,  
   int _E1,  
   const _Value_type * _Src  
) restrict(amp,cpu);  
  
array_view(  
   int _E0,  
   int _E1,  
   int _E2,  
   const _Value_type * _Src  
) restrict(amp,cpu);   
```  
  
#### Parameters  
 `_Arr_type`  
 The element type of a C-style array from which data is supplied.  
  
 `_Container`  
 A template argument that must specify a linear container that supports `data()` and `size()` members.  
  
 `_E0`  
 The most significant component of the extent of this section.  
  
 `_E1`  
 The next-to-most-significant component of the extent of this section.  
  
 `_E2`  
 The least significant component of the extent of this section.  
  
 `_Extent`  
 The extent in each dimension of this `array_view`.  
  
 `_Other`  
 An object of type `array_view<T,N>` from which to initialize the new `array_view`.  
  
 `_Size`  
 The size of a C-style array from which data is supplied.  
  
 `_Src`  
 A pointer to the source data that will be copied into the new array.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)