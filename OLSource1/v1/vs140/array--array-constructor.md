---
title: "array::array Constructor"
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
  - "amp/Concurrency::array::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array, constructor"
ms.assetid: 9d9c6b28-6f75-4b61-8694-586683891aba
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::array Constructor
Initializes a new instance of the [array](../vs140/array-class.md) class. There is no default constructor for `array<T,N>`. All constructors are run on the CPU only. They cannot be executed on a Direct3D target.  
  
## Syntax  
  
```  
explicit array(  
   const Concurrency::extent<_Rank> & _Extent  
) restrict(cpu);  
  
explicit array(  
   int _E0  
) restrict(cpu);  
  
explicit array(  
   int _E0,  
   int _E1  
) restrict(cpu);  
  
explicit array(  
   int _E0,  
   int _E1,  
   int _E2  
) restrict(cpu);  
  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
array(  
   int _E0,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
array(  
   int _E0,  
   int _E1,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
array(  
   int _E0,  
   accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
array(  
   int _E0,  
   int _E1,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av,  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   const Concurrency::extent<_Rank>& _Extent,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first,  
   _InputIterator _Src_last,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
template <  
   typename _InputIterator  
>  
array(  
   int _E0,  
   int _E1,  
   int _E2,  
   _InputIterator _Src_first,  
   Concurrency::accelerator_view _Av,  
   Concurrency::accelerator_view _Associated_Av  
) restrict(cpu);  
  
explicit array(  
   const array_view<const _Value_type, _Rank>& _Src  
) restrict(cpu);  
  
array(  
   const array_view<const _Value_type, _Rank>& _Src,  
   accelerator_view _Av  
   access_type _Cpu_access_type = access_type_auto  
) restrict(cpu);  
  
array(  
   const array_view<const _Value_type, _Rank>& _Src,  
   accelerator_view _Av,  
   accelerator_view _Associated_Av  
) restrict(cpu);  
  
array(  
   const array& _Other  
) restrict(cpu);  
  
array(  
   array && _Other  
) restrict(cpu);  
```  
  
#### Parameters  
 `_Associated_Av`  
 An accelerator_view which specifies the preferred target location of the array.  
  
 `_Av`  
 An [accelerator_view](../vs140/accelerator_view-class.md) object that specifies the location of the array.  
  
 `_Cpu_access_type`  
 The desired [access_type](../vs140/access_type-enumeration.md) for the array on the CPU. This parameter has a default value of `access_type_auto` leaving the CPU `access_type` determination to the runtime. The actual CPU `access_type` for the array can be queried using the `get_cpu_access_type` method.  
  
 `_Extent`  
 The extent in each dimension of the array.  
  
 `_E0`  
 The most significant component of the extent of this section.  
  
 `_E1`  
 The next-to-most-significant component of the extent of this section.  
  
 `_E2`  
 The least significant component of the extent of this section.  
  
 `_InputIterator`  
 The type of the input interator.  
  
 `_Src`  
 To object to copy.  
  
 `_Src_first`  
 A beginning iterator into the source container.  
  
 `_Src_last`  
 An ending iterator into the source container.  
  
 `_Other`  
 Other data source.  
  
 `_Rank`  
 The rank of the section.  
  
 `_Value_type`  
 The data type of the elements that are copied.  
  
## Remarks  
 Staging constructors have two [accelerator_view](../vs140/accelerator_view-class.md) objects as constructor parameters. Staging arrays are used as a hint to optimize repeated copies between two accelerators (between the CPU and a Direct3D accelerator). Staging arrays are optimized for data transfer and do not have stable user-space memory. They are backed by DirectX staging buffers that have the correct hardware alignment to make sure there is an efficient Direct Memory Access (DMA) transfer between the CPU and the accelerator. The `accelerator_view` property of a staging array returns the value of the first accelerator argument that it was constructed with. You can't change or examine the contents of a staging array when it is involved in a transfer operation, as demonstrated in the following code.  
  
```  
class SimulationServer   
{   
    array<float,2> acceleratorArray;   
    array<float,2> stagingArray;   
public:   
    SimulationServer(const accelerator_view& av)   
        :acceleratorArray(extent<2>(1000,1000), av),   
         stagingArray(extent<2>(1000,1000), accelerator("cpu"),   
         accelerator("gpu"))   
    {   
    }   
  
    void OnCompute()   
    {   
        array<float,2> &a = acceleratorArray;   
        ApplyNetworkChanges(stagingArray.data());   
  
        // Starting here, you can't change or examine contents.  
        a = stagingArray;   
        parallel_for_each(a.extents, [&](index<2> idx)   
        {   
           // Update a[idx] according to simulation.   
        }   
        stagingArray = a;   
  
        // Starting here, you can change or examine contents.  
        SendToClient(stagingArray.data());   
     }   
};  
  
```  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)