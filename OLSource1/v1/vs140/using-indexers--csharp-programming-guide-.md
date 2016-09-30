---
title: "Using Indexers (C# Programming Guide)"
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
  - "indexers [C#], about indexers"
ms.assetid: df70e1a2-3ce3-4aba-ad80-4b2f3538699f
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Indexers (C# Programming Guide)
Indexers are a syntactic convenience that enable you to create a [class](../vs140/class--csharp-reference-.md), [struct](../vs140/struct--csharp-reference-.md), or [interface](../vs140/interface--csharp-reference-.md) that client applications can access just as an array. Indexers are most frequently implemented in types whose primary purpose is to encapsulate an internal collection or array. For example, suppose you have a class named TempRecord that represents the temperature in Farenheit as recorded at 10 different times during a 24 hour period. The class contains an array named "temps" of type float to represent the temperatures, and a \<xref:System.DateTime*> that represents the date the temperatures were recorded. By implementing an indexer in this class, clients can access the temperatures in a TempRecord instance as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instead of as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The indexer notation not only simplifies the syntax for client applications; it also makes the class and its purpose more intuitive for other developers to understand.  
  
 To declare an indexer on a class or struct, use the [this](../vs140/this--csharp-reference-.md) keyword, as in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type of an indexer and the type of its parameters must be at least as accessible as the indexer itself. For more information about accessibility levels, see [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md).  
  
 For more information about how to use indexers with an interface, see [Interface Indexers](../vs140/indexers-in-interfaces--csharp-programming-guide-.md).  
  
 The signature of an indexer consists of the number and types of its formal parameters. It does not include the indexer type or the names of the formal parameters. If you declare more than one indexer in the same class, they must have different signatures.  
  
 An indexer value is not classified as a variable; therefore, you cannot pass an indexer value as a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter.  
  
 To provide the indexer with a name that other languages can use, use a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute in the declaration. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This indexer will have the name <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Not providing the name attribute would make <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> the default name.  
  
## Example 1  
  
### Description  
 The following example shows how to declare a private array field, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and an indexer. The indexer enables direct access to the instance <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The alternative to using the indexer is to declare the array as a [public](../vs140/public--csharp-reference-.md) member and access its members, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, directly.  
  
 Notice that when an indexer's access is evaluated, for example, in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement, the [get](../vs140/get--csharp-reference-.md) accessor is invoked. Therefore, if no <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> accessor exists, a compile-time error occurs.  
  
### Code  
 [!code[csProgGuideIndexers#1](../vs140/codesnippet/CSharp/using-indexers--csharp-programming-guide-_1.cs)]  
  
## Indexing Using Other Values  
 C# does not limit the index type to integer. For example, it may be useful to use a string with an indexer. Such an indexer might be implemented by searching for the string in the collection, and returning the appropriate value. As accessors can be overloaded, the string and integer versions can co-exist.  
  
## Example 2  
  
### Description  
 In this example, a class is declared that stores the days of the week. A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> accessor is declared that takes a string, the name of a day, and returns the corresponding integer. For example, Sunday will return 0, Monday will return 1, and so on.  
  
### Code  
 [!code[csProgGuideIndexers#2](../vs140/codesnippet/CSharp/using-indexers--csharp-programming-guide-_2.cs)]  
  
## Robust Programming  
 There are two main ways in which the security and reliability of indexers can be improved:  
  
-   Be sure to incorporate some type of error-handling strategy to handle the chance of client code passing in an invalid index value. In the first example earlier in this topic, the TempRecord class provides a Length property that enables the client code to verify the input before passing it to the indexer. You can also put the error handling code inside the indexer itself. Be sure to document for users any exceptions that you throw inside an indexer accessor.  
  
-   Set the accessibility of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and [set](../vs140/set--csharp-reference-.md) accessors to be as restrictive as is reasonable. This is important for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> accessor in particular. For more information, see [Accessor Accessibility](../vs140/restricting-accessor-accessibility--csharp-programming-guide-.md).  
  
## See Also  
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Indexers](../vs140/indexers--csharp-programming-guide-.md)   
 [Properties](../vs140/properties--csharp-programming-guide-.md)