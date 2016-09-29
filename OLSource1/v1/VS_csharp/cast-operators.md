---
title: "Cast Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "cast operators"
  - "type casts, operators"
  - "operators [C++], cast"
  - "type conversion, cast operators"
ms.assetid: 43b90bbd-39ef-43e6-ae5d-e8a67a01de40
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cast Operators
A type cast provides a method for explicit conversion of the type of an object in a specific situation.  
  
## Syntax  
 *cast-expression*:  
 *unary-expression*  
  
 **(**  *type-name*  **)**  *cast-expression*  
  
 The compiler treats *cast-expression* as type *type-name* after a type cast has been made. Casts can be used to convert objects of any scalar type to or from any other scalar type. Explicit type casts are constrained by the same rules that determine the effects of implicit conversions, discussed in [Assignment Conversions](../VS_csharp/assignment-conversions.md). Additional restraints on casts may result from the actual sizes or representation of specific types. See [Storage of Basic Types](../VS_csharp/storage-of-basic-types.md) for information on actual sizes of integral types. For more information on type casts, see [Type-Cast Conversions](../VS_csharp/type-cast-conversions.md).  
  
## See Also  
 [Cast Operator: ()](../VS_csharp/cast-operator----.md)