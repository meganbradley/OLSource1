---
title: "Compiler Error C3392"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3392"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3392"
ms.assetid: e4757596-e2aa-4314-b01e-5c4bfd2110e9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3392
'type_arg' : invalid type argument for generic parameter 'param' of generic 'generic_type', must have a public parameterless constructor  
  
 A generic type was instantiated incorrectly.  Check the type definition.  For more information [Generics (C++)](../vs140/generics---c---component-extensions-.md).  
  
## Example  
 The following sample, using C#, creates a component that contains a generic type, with certain constraints that are not supported when authoring generic types in [!INCLUDE[vcprvclong](../vs140/includes/vcprvclong_md.md)]. For more information, see .[Constraints on Type Parameters (C# Programmers Reference)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3392.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>