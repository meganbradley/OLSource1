---
title: "Compiler Error C3392"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3392
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3392
ms.assetid: e4757596-e2aa-4314-b01e-5c4bfd2110e9
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3392
'type_arg' : invalid type argument for generic parameter 'param' of generic 'generic_type', must have a public parameterless constructor  
  
 A generic type was instantiated incorrectly.  Check the type definition.  For more information [Generics (C++)](../vs140/generics---c---component-extensions-.md).  
  
## Example  
 The following sample, using C#, creates a component that contains a generic type, with certain constraints that are not supported when authoring generic types in [!INCLUDE[vcprvclong](../vs140/includes/vcprvclong_md.md)]. For more information, see .[Constraints on Type Parameters (C# Programmers Reference)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md).  
  
```  
// C3392.cs  
// compile with: /target:library  
// a C# program  
public class GR<C, V, N>  
where C : class  
where V : struct  
where N : new() {}  
```  
  
## Example  
 The following sample generates C3392.  
  
```  
// C3392_b.cpp  
// compile with: /clr  
#using <C3392.dll>  
  
ref class R { R(int) {} };  
ref class N { N() {} };  
  
value class V {};  
  
ref class N2 { public: N2() {} };  
ref class R2 { public: R2() {} };  
  
int main () {  
   GR<R^, V, N^>^ gr1;   // C3392  
   GR<R^, V, N2^>^ gr1a;   // OK  
  
   GR<R^, N^, N^>^ gr3;   // C3392  
   GR<R^, V, N2^>^ gr3a;   // OK  
  
   GR<R^, V, R^>^ gr4;   // C3392  
   GR<R^, V, R2^>^ gr4a;   // OK  
}  
```