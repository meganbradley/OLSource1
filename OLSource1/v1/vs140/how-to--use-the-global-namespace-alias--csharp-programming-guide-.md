---
title: "How to: Use the Global Namespace Alias (C# Programming Guide)"
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
  - "aliases [C#]"
  - "namespaces [C#], global namespace qualifier"
  - "global namespace [C#]"
ms.assetid: 98a1d89b-3c5a-44f7-8400-c4a3c0ec22a9
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the Global Namespace Alias (C# Programming Guide)
The ability to access a member in the global [namespace](../vs140/namespace--csharp-reference-.md) is useful when the member might be hidden by another entity of the same name.  
  
 For example, in the following code, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> resolves to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instead of to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type in the \<xref:System*> namespace.  
  
 [!code[csProgGuide#1](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideNamespaces#1](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_2.cs)]  
  
 Using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> still results in an error because the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace is hidden by the class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideNamespaces#2](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_3.cs)]  
  
 However, you can work around this error by using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, like this:  
  
 [!code[csProgGuideNamespaces#3](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_4.cs)]  
  
 When the left identifier is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the search for the right identifier starts at the global namespace. For example, the following declaration is referencing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a member of the global space.  
  
 [!code[csProgGuideNamespaces#4](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_5.cs)]  
  
 Obviously, creating your own namespaces called <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not recommended, and it is unlikely you will encounter any code in which this has happened. However, in larger projects, it is a very real possibility that namespace duplication may occur in one form or another. In these situations, the global namespace qualifier is your guarantee that you can specify the root namespace.  
  
## Example  
 In this example, the namespace <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used to include the class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> therefore, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be used to reference the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class, which is hidden by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> namespace. Also, the alias <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is used to refer to the namespace <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; therefore, the instance of a \<xref:System.Collections.Hashtable*?displayProperty=fullName> was created using this alias instead of the namespace.  
  
 [!code[csProgGuideNamespaces#5](../vs140/codesnippet/CSharp/how-to--use-the-global-namespace-alias--csharp-programming-guide-_6.cs)]  
  
 **A 1**  
**B 2**  
**C 3**   
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Namespaces (C#)](../vs140/namespaces--csharp-programming-guide-.md)   
 [. Operator](../vs140/.-operator--csharp-reference-.md)   
 [:: Operator](../vs140/---operator--csharp-reference-.md)   
 [extern (C# Programmer's Reference)](../vs140/extern--csharp-reference-.md)