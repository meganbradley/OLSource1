---
title: "Main() and Command-Line Arguments (C# Programming Guide)"
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
  - "CS5001"
  - "main_CSharpKeyword"
  - "Main"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "Main method [C#]"
  - "C# language, command-line arguments"
  - "arguments [C#], command-line"
  - "command line [C#], arguments"
  - "command-line arguments [C#], Main method"
ms.assetid: 73a17231-cf96-44ea-aa8a-54807c6fb1f4
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Main() and Command-Line Arguments (C# Programming Guide)
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method is the entry point of a C# console application or windows application. (Libraries and services do not require a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method as an entry point.). When the application is started, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method is the first method that is invoked.  
  
 There can only be one entry point in a C# program. If you have more than one class that has a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, you must compile your program with the **/main** compiler option to specify which <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to use as the entry point. For more information, see [/main (Specify Location of Main Method) (C# Compiler Options)](../vs140/-main--csharp-compiler-options-.md).  
  
 [!code[csProgGuideMain#17](../vs140/codesnippet/CSharp/main---and-command-line-arguments--csharp-programming-guide-_1.cs)]  
  
## Overview  
  
-   The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method is the entry point of an .exe program; it is where the program control starts and ends.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is declared inside a class or struct. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be [static](../vs140/static--csharp-reference-.md) and it should not be [public](../vs140/public--csharp-reference-.md). (In the earlier example, it receives the default access of [private](../vs140/private--csharp-reference-.md).) The enclosing class or struct is not required to be static.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can either have a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> return type.  
  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method can be declared with or without a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter that contains command-line arguments. When using [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to create Windows Forms applications, you can add the parameter manually or else use the \<xref:System.Environment*> class to obtain the command-line arguments. Parameters are read as zero-indexed command-line arguments. Unlike C and C++, the name of the program is not treated as the first command-line argument.  
  
## In This Section  
  
-   [Command-Line Arguments](../vs140/command-line-arguments--csharp-programming-guide-.md)  
  
-   [How to: Display Command Line Arguments (C#)](../vs140/how-to--display-command-line-arguments--csharp-programming-guide-.md)  
  
-   [How to: Access Command Line Arguments using foreach (C#)](../vs140/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-.md)  
  
-   [Main() Return Values (C#)](../vs140/main---return-values--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [Command-line Building With csc.exe](../vs140/command-line-building-with-csc.exe.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Inside a C# Program](../vs140/inside-a-csharp-program.md)   
 [\<paveover>C# Sample Applications](assetId:///9a9d7aaa-51d3-4224-b564-95409b0f3e15)