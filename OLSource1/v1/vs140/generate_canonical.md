---
title: "generate_canonical"
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
  - "random/std::tr1::generate_canonical"
  - "generate_canonical"
  - "tr1.generate_canonical"
  - "std.tr1.generate_canonical"
  - "tr1::generate_canonical"
  - "std::tr1::generate_canonical"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "generate_canonical"
ms.assetid: 43308c96-a144-47a8-973f-8b6e6b3cabd7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# generate_canonical
Returns a floating-point value from a random sequence.  
  
> [!NOTE]
>  The ISO C++ Standard states that this function should return values in the range [`0`, `1`). Visual Studio is not yet compliant with this constraint. As a workaround to generate values in this range, use [uniform_real_distribution](../vs140/uniform_real_distribution-class.md).  
  
## Syntax  
  
```  
template<class RealType, size_t Bits, class Generator>  
RealType generate_canonical(Generator& Gen);  
```  
  
#### Parameters  
 `RealType`  
 The floating point integral type. For possible types, see [<random\>](../vs140/-random-.md).  
  
 `Bits`  
 The random number generator.  
  
 `Gen`  
 The random number generator.  
  
## Remarks  
 The template function calls `operator()` of `Gen` repeatedly and packs the returned values into a floating-point value `x` of type `RealType` until it has gathered the specified number of mantissa bits in `x`. The specified number is the smaller of `Bits` (which must be nonzero) and the full number of mantissa bits in `RealType`. The first call supplies the lowest-order bits. The function returns `x`.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)