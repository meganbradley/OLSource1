---
title: "How to: Initialize Objects by Using an Object Initializer (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "object initializers [C#], how to use"
  - "objects [C#], initializing"
ms.assetid: 4b75ebb2-2e29-43de-929c-d736a8f27ce6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Initialize Objects by Using an Object Initializer (C# Programming Guide)
You can use object initializers to initialize type objects in a declarative manner without explicitly invoking a constructor for the type.  
  
 The following examples show how to use object initializers with named objects. The compiler processes object initializers by first accessing the default instance constructor and then processing the member initializations. Therefore, if the default constructor is declared as `private` in the class, object initializers that require public access will fail.  
  
 You must use an object initializer if you're defining an anonymous type. For more information, see [How To: Use Anonymous Types in a Query Expression (C# Programming Guide)](../vs140/how-to--return-subsets-of-element-properties-in-a-query--csharp-programming-guide-.md).  
  
## Example  
 The following example shows how to initialize a new `StudentName` type by using object initializers.  
  
 [!code[csProgGuideLINQ#35](../vs140/codesnippet/CSharp/how-to--initialize-objects-by-using-an-object-initializer--csharp-programming-guide-_1.cs)]  
  
## Example  
 The following example shows how to initialize a collection of `StudentName` types by using a collection initializer. Note that a collection initializer is a series of comma-separated object initializers.  
  
 [!code[csProgGuideLINQ#36](../vs140/codesnippet/CSharp/how-to--initialize-objects-by-using-an-object-initializer--csharp-programming-guide-_2.cs)]  
  
## Compiling the Code  
 To run this code, copy and paste the class into a Visual C# console application project that has been created in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)