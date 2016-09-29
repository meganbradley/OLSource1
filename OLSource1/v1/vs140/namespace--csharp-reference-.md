---
title: "namespace (C# Reference)"
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
  - "namespace_CSharpKeyword"
  - "namespace"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "namespace keyword [C#]"
  - "scope [C#]"
ms.assetid: 0a788423-9110-42e0-97d9-bda41ca4870f
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# namespace (C# Reference)
The `namespace` keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code elements and to create globally unique types.  
  
 [!code[csrefKeywordsNamespace#1](../vs140/codesnippet/CSharp/namespace--csharp-reference-_1.cs)]  
  
## Remarks  
 Within a namespace, you can declare one or more of the following types:  
  
-   another namespace  
  
-   [class](../vs140/class--csharp-reference-.md)  
  
-   [interface](../vs140/interface--csharp-reference-.md)  
  
-   [struct](../vs140/struct--csharp-reference-.md)  
  
-   [enum](../vs140/enum--csharp-reference-.md)  
  
-   [delegate](../vs140/delegate--csharp-reference-.md)  
  
 Whether or not you explicitly declare a namespace in a C# source file, the compiler adds a default namespace. This unnamed namespace, sometimes referred to as the global namespace, is present in every file. Any identifier in the global namespace is available for use in a named namespace.  
  
 Namespaces implicitly have public access and this is not modifiable. For a discussion of the access modifiers you can assign to elements in a namespace, see [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md).  
  
 It is possible to define a namespace in two or more declarations. For example, the following example defines two classes as part of the `MyCompany` namespace:  
  
 [!code[csrefKeywordsNamespace#2](../vs140/codesnippet/CSharp/namespace--csharp-reference-_2.cs)]  
  
## Example  
 The following example shows how to call a static method in a nested namespace.  
  
 [!code[csrefKeywordsNamespace#3](../vs140/codesnippet/CSharp/namespace--csharp-reference-_3.cs)]  
  
## For More Information  
 For more information about using namespaces, see the following topics:  
  
-   [Namespaces (C#)](../vs140/namespaces--csharp-programming-guide-.md)  
  
-   [Using Namespaces (C#)](../vs140/using-namespaces--csharp-programming-guide-.md)  
  
-   [How to: Use the Global Namespace Qualifier (C#)](../vs140/how-to--use-the-global-namespace-alias--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Namespace Keywords](../vs140/namespace-keywords--csharp-reference-.md)   
 [using](../vs140/using--csharp-reference-.md)