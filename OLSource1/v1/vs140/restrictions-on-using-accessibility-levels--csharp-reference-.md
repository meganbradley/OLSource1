---
title: "Restrictions on Using Accessibility Levels (C# Reference)"
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
  - "access modifiers [C#], accessibility level restrictions"
ms.assetid: 987e2f22-46bf-4fea-80ee-270b9cd01045
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Restrictions on Using Accessibility Levels (C# Reference)
When you specify a type in a declaration, check whether the accessibility level of the type is dependent on the accessibility level of a member or of another type. For example, the direct base class must be at least as accessible as the derived class. The following declarations cause a compiler error because the base class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is less accessible than <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table summarizes the restrictions on declared accessibility levels.  
  
|Context|Remarks|  
|-------------|-------------|  
|[Classes](../vs140/classes--csharp-programming-guide-.md)|The direct base class of a class type must be at least as accessible as the class type itself.|  
|[Interfaces](../vs140/interfaces--csharp-programming-guide-.md)|The explicit base interfaces of an interface type must be at least as accessible as the interface type itself.|  
|[Delegates](../vs140/delegates--csharp-programming-guide-.md)|The return type and parameter types of a delegate type must be at least as accessible as the delegate type itself.|  
|[Constants](../vs140/constants--csharp-programming-guide-.md)|The type of a constant must be at least as accessible as the constant itself.|  
|[Fields](../vs140/fields--csharp-programming-guide-.md)|The type of a field must be at least as accessible as the field itself.|  
|[Methods](../vs140/methods--csharp-programming-guide-.md)|The return type and parameter types of a method must be at least as accessible as the method itself.|  
|[Properties](../vs140/properties--csharp-programming-guide-.md)|The type of a property must be at least as accessible as the property itself.|  
|[Events](../vs140/events--csharp-programming-guide-.md)|The type of an event must be at least as accessible as the event itself.|  
|[Indexers](../vs140/indexers--csharp-programming-guide-.md)|The type and parameter types of an indexer must be at least as accessible as the indexer itself.|  
|[Operators](../vs140/operators--csharp-programming-guide-.md)|The return type and parameter types of an operator must be at least as accessible as the operator itself.|  
|[Constructors](../vs140/constructors--csharp-programming-guide-.md)|The parameter types of a constructor must be at least as accessible as the constructor itself.|  
  
## Example  
 The following example contains erroneous declarations of different types. The comment following each declaration indicates the expected compiler error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md)   
 [Accessibility Domain](../vs140/accessibility-domain--csharp-reference-.md)   
 [Accessibility Levels](../vs140/accessibility-levels--csharp-reference-.md)   
 [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [public (C# Programmer's Reference)](../vs140/public--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../vs140/private--csharp-reference-.md)   
 [protected (C# Programmer's Reference)](../vs140/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../vs140/internal--csharp-reference-.md)