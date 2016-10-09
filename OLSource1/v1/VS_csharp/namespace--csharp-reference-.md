---
title: "namespace (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 28
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# namespace (C# Reference)
The `namespace` keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code elements and to create globally unique types.  
  
 [!code[csrefKeywordsNamespace#1](../VS_csharp/codesnippet/CSharp/namespace--csharp-reference-_1.cs)]  
  
## Remarks  
 Within a namespace, you can declare one or more of the following types:  
  
-   another namespace  
  
-   [class](../VS_csharp/class--csharp-reference-.md)  
  
-   [interface](../VS_csharp/interface--csharp-reference-.md)  
  
-   [struct](../VS_csharp/struct--csharp-reference-.md)  
  
-   [enum](../VS_csharp/enum--csharp-reference-.md)  
  
-   [delegate](../VS_csharp/delegate--csharp-reference-.md)  
  
 Whether or not you explicitly declare a namespace in a C# source file, the compiler adds a default namespace. This unnamed namespace, sometimes referred to as the global namespace, is present in every file. Any identifier in the global namespace is available for use in a named namespace.  
  
 Namespaces implicitly have public access and this is not modifiable. For a discussion of the access modifiers you can assign to elements in a namespace, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md).  
  
 It is possible to define a namespace in two or more declarations. For example, the following example defines two classes as part of the `MyCompany` namespace:  
  
 [!code[csrefKeywordsNamespace#2](../VS_csharp/codesnippet/CSharp/namespace--csharp-reference-_2.cs)]  
  
## Example  
 The following example shows how to call a static method in a nested namespace.  
  
 [!code[csrefKeywordsNamespace#3](../VS_csharp/codesnippet/CSharp/namespace--csharp-reference-_3.cs)]  
  
## For More Information  
 For more information about using namespaces, see the following topics:  
  
-   [Namespaces](../VS_csharp/namespaces--csharp-programming-guide-.md)  
  
-   [Using Namespaces](../VS_csharp/using-namespaces--csharp-programming-guide-.md)  
  
-   [How to: Use the Global Namespace Alias](../VS_csharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Namespace Keywords](../VS_csharp/namespace-keywords--csharp-reference-.md)   
 [using](../VS_csharp/using--csharp-reference-.md)