---
title: "Namespaces (C# Programming Guide)"
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
  - "C# language, namespaces"
  - "namespaces [C#]"
ms.assetid: b1c4ab46-3fad-4ffa-9deb-dd50a2d8c65a
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Namespaces (C# Programming Guide)
Namespaces are heavily used in C# programming in two ways. First, the .NET Framework uses namespaces to organize its many classes, as follows:  
  
 [!code[csProgGuide#22](../vs140/codesnippet/CSharp/namespaces--csharp-programming-guide-_1.cs)]  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is a namespace and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a class in that namespace. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword can be used so that the complete name is not required, as in the following example:  
  
 [!code[csProgGuide#1](../vs140/codesnippet/CSharp/namespaces--csharp-programming-guide-_2.cs)]  
  
 [!code[csProgGuide#25](../vs140/codesnippet/CSharp/namespaces--csharp-programming-guide-_3.cs)]  
  
 For more information, see [using clause](../vs140/using-directive--csharp-reference-.md).  
  
 Second, declaring your own namespaces can help you control the scope of class and method names in larger programming projects. Use the [namespace](../vs140/namespace--csharp-reference-.md) keyword to declare a namespace, as in the following example:  
  
 [!code[csProgGuideNamespaces#6](../vs140/codesnippet/CSharp/namespaces--csharp-programming-guide-_4.cs)]  
  
## Namespaces Overview  
 Namespaces have the following properties:  
  
-   They organize large code projects.  
  
-   They are delimited by using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator.  
  
-   The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> obviates the requirement to specify the name of the namespace for every class.  
  
-   The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> namespace is the "root" namespace: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will always refer to the .NET Framework namespace <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Related Sections  
 See the following topics for more information about namespaces:  
  
-   [Using Namespaces (C#)](../vs140/using-namespaces--csharp-programming-guide-.md)  
  
-   [How to: Use the Global Namespace Qualifier](../vs140/how-to--use-the-global-namespace-alias--csharp-programming-guide-.md)  
  
-   [How to: Use the My Namespace (Visual C#)](../vs140/how-to--use-the-my-namespace--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Namespace Keywords](../vs140/namespace-keywords--csharp-reference-.md)   
 [using directive](../vs140/using-directive--csharp-reference-.md)   
 [:: Operator](../vs140/---operator--csharp-reference-.md)   
 [. Operator](../vs140/.-operator--csharp-reference-.md)