---
title: "norm Class"
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
  - "amp_short_vectors/Concurrency::graphics::norm"
dev_langs: 
  - "C++"
ms.assetid: 73002f3d-c25e-4119-bcd3-4c46c9b6abf1
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# norm Class
Represent a norm number. Each element is a floating point number in the range of [-1.0f, 1.0f].  
  
## Syntax  
  
```  
class norm;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[norm::norm Constructor](#norm__norm_constructor)|Overloaded. Default constructor. Initialize to 0.0f.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|norm::operator- Operator||  
|norm::operator-- Operator||  
|norm::operator float Operator|Conversion operator. Convert the norm number to a floating point value.|  
|norm::operator*= Operator||  
|norm::operator/= Operator||  
|norm::operator++ Operator||  
|norm::operator+= Operator||  
|norm::operator= Operator||  
|norm::operator-= Operator||  
  
## Inheritance Hierarchy  
 `norm`  
  
## Requirements  
 **Header:** amp_short_vectors.h  
  
 **Namespace:** Concurrency::graphics  
  
##  <a name="norm__norm_constructor"></a>  norm::norm Constructor  
 Default constructor. Initialize to 0.0f.  
  
```  
norm(  
   void  
) restrict(amp,cpu);  
explicit norm(  
   float                 _V  
) restrict(amp,cpu);  
explicit norm(  
   unsigned int                 _V  
) restrict(amp,cpu);  
explicit norm(  
   int                 _V  
) restrict(amp,cpu);  
explicit norm(  
   double                 _V  
) restrict(amp,cpu);  
norm(  
   const norm&                 _Other  
) restrict(amp,cpu);  
norm(  
   const unorm&                 _Other  
) restrict(amp,cpu);  
```  
  
### Parameters  
 `_V`  
 The value used to initialize.  
  
 `_Other`  
 The object used to initialize.  
  
## See Also  
 [Concurrency::graphics Namespace](../vs140/concurrency--graphics-namespace.md)