---
title: "Compiler Error CS0523"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS0523
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0523
ms.assetid: f91fb0ab-e1ef-4d6d-a3ef-5adc53a7e312
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0523
Struct member 'struct2 field' of type 'struct1' causes a cycle in the struct layout  
  
 The definitions of two structs include recursive references. Change the [struct](../vs140/struct--csharp-reference-.md) definitions such that each does not define itself on the other. This limitation applies only to structs, since structs are value types. If using recursive references, declare your types as classes.  
  
 The following sample generates CS0523:  
  
```  
// CS0523.cs  
// compile with: /target:library  
struct RecursiveLayoutStruct1  
{  
   public RecursiveLayoutStruct2 field;  
}  
  
struct RecursiveLayoutStruct2  
{  
   public RecursiveLayoutStruct1 field;   // CS0523  
}  
```