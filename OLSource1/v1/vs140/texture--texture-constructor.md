---
title: "texture::texture Constructor"
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
  - "amp_graphics/Concurrency::graphics::texture::texture"
dev_langs: 
  - "C++"
ms.assetid: 17175f00-a5b3-4040-bb12-6a26678ad865
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# texture::texture Constructor
Initializes a new instance of the [texture](../vs140/texture-class.md) class.  
  
## Syntax  
  
```  
texture(  
   const Concurrency::extent<_Rank>& _Ext  
) restrict(cpu);  
  
texture(  
   int _E0  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2  
) restrict(cpu);  
  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   int _E1,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   int _E1,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
template<  
   typename _Input_iterator  
>  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   _Input_iterator_Src_first,  
   _Input_iterator_Src_last,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu))  ;  
  
texture(  
   int _E0,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
)  ;  
  
texture(  
   int _E0,  
   int _E1,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   int _E0,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element  
) restrict(cpu);  
  
texture(  
   const Concurrency::extent<_Rank>& _Ext,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
)  ;  
  
texture(  
   int _E0,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   int _E0,  
   int _E1,  
   int _E2,  
   _In_ void * _Source,  
   unsigned int _Src_byte_size,  
   unsigned int _Bits_per_scalar_element,  
   const Concurrency::accelerator_view& _Av  
) restrict(cpu);  
  
texture(  
   const texture & _Src,  
   const Concurrency::accelerator_view & _Acc_view  
);  
  
texture(  
   texture && _Other  
);   
  
texture(  
   const Concurrency::extent<_Rank>& _Ext,   
   unsigned int _Bits_per_scalar_element,   
   const Concurrency::accelerator_view& _Av  
);   
  
texture(  
   const texture & _Src  
);  
```  
  
#### Parameters  
 `_Acc_view`  
 The [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 `_Av`  
 The [accelerator_view](../vs140/accelerator_view-class.md) that specifies the location of the texture.  
  
 `_Associated_av`  
 An accelerator_view that specifies the preferred target for copies to or from this texture.  
  
 `_Bits_per_scalar_element`  
 The number of bits per each scalar element in the underlying scalar type of the texture. In general, supported value are 8, 16, 32, and 64. If 0 is specified, the number of bits is the same as the underlying scalar_type. 64 is only valid for double-based textures.  
  
 `_Ext`  
 The extent in each dimension of the texture.  
  
 `_E0`  
 The most significant component of the texture.  
  
 `_E1`  
 The next-to-most-significant component of the texture.  
  
 `_E2`  
 The least significant component of the extent of the texture.  
  
 `_Input_iterator`  
 The type of the input interator.  
  
 `_Mipmap_levels`  
 The number of mipmap levels in the underlying texture. If 0 is specified, the texture will have the full range of mipmap levels down to the smallest possible size for the specified extent.  
  
 `_Rank`  
 The rank of the extent.  
  
 `_Source`  
 A pointer to a host buffer.  
  
 `_Src`  
 To texture to copy.  
  
 `_Src_byte_size`  
 The number of bytes in the source buffer.  
  
 `_Src_first`  
 A beginning iterator into the source container.  
  
 `_Src_last`  
 An ending iterator into the source container.  
  
 `_Other`  
 Other data source.  
  
 `_Rank`  
 The rank of the section.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** Concurrency::graphics  
  
## See Also  
 [texture Class](../vs140/texture-class.md)