---
title: "Boxing (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Boxing (C++/CLI)"
dev_langs: 
  - "C++"
ms.assetid: f4ee27a8-6a34-432d-b9ec-39285d513b23
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boxing (C++-CLI)
Boxing is the process of converting a value type to the type `object` or to any interface type that's implemented by the value type. When the common language runtime (CLR) boxes a value type, it wraps the value in a `System.Object` and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit.  
  
## Related Articles  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Explicitly Request Boxing](../VS_csharp/how-to--explicitly-request-boxing.md)|Describes how to explicitly request boxing on a variable.|  
|[How to: Use gcnew to Create Value Types and Use Implicit Boxing](../VS_csharp/how-to--use-gcnew-to-create-value-types-and-use-implicit-boxing.md)|Shows how to use `gcnew` to create a boxed value type that can be placed on the managed, garbage-collected heap.|  
|[How to: Unbox](../VS_csharp/how-to--unbox.md)|Shows how to unbox and modify a value.|  
|[Standard Conversions and Implicit Boxing](../VS_csharp/standard-conversions-and-implicit-boxing.md)|Shows that a standard conversion is chosen by the compiler over a conversion that requires boxing.|  
|[.NET Programming in Visual C++](../VS_csharp/.net-programming-with-c---cli--visual-c---.md)|The top-level article for .NET programming in the Visual C++ documentation.|