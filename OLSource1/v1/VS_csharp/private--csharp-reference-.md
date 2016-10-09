---
title: "private (C# Reference)"
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
  - "private_CSharpKeyword"
  - "private"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "private keyword [C#]"
ms.assetid: 654c0bb8-e6ac-4086-bf96-7474fa6aa1c8
caps.latest.revision: 17
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
# private (C# Reference)
The `private` keyword is a member access modifier. Private access is the least permissive access level. Private members are accessible only within the body of the class or the struct in which they are declared, as in this example:  
  
```  
class Employee  
{  
    private int i;  
    double d;   // private access by default  
}  
```  
  
 Nested types in the same body can also access those private members.  
  
 It is a compile-time error to reference a private member outside the class or the struct in which it is declared.  
  
 For a comparison of `private` with the other access modifiers, see [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md) and [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
## Example  
 In this example, the `Employee` class contains two private data members, `name` and `salary`. As private members, they cannot be accessed except by member methods. Public methods named `GetName` and `Salary` are added to allow controlled access to the private members. The `name` member is accessed by way of a public method, and the `salary` member is accessed by way of a public read-only property. (See [Properties](../VS_csharp/properties--csharp-programming-guide-.md) for more information.)  
  
 [!code[csrefKeywordsModifiers#10](../VS_csharp/codesnippet/CSharp/private--csharp-reference-_1.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md)   
 [Accessibility Levels](../VS_csharp/accessibility-levels--csharp-reference-.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [public](../VS_csharp/public--csharp-reference-.md)   
 [protected](../VS_csharp/protected--csharp-reference-.md)   
 [internal](../VS_csharp/internal--csharp-reference-.md)