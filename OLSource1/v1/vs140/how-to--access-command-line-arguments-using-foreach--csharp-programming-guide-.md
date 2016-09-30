---
title: "How to: Access Command-Line Arguments Using foreach (C# Programming Guide)"
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
  - "command-line arguments [C#]"
ms.assetid: 89c3e335-3f5b-4e24-8c5a-b8036561fe8a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access Command-Line Arguments Using foreach (C# Programming Guide)
Another approach to iterating over the array is to use the [foreach](../vs140/foreach--in--csharp-reference-.md) statement as shown in this example. The `foreach` statement can be used to iterate over an array, a .NET Framework collection class, or any class or struct that implements the \<xref:System.Collections.IEnumerable*> interface.  
  
> [!NOTE]
>  When running an application in Visual Studio, you can specify command-line arguments in the [Debug Page, Project Designer](../vs140/debug-page--project-designer.md).  
  
## Example  
 This example demonstrates how to print out the command line arguments using `foreach`.  
  
 [!code[csProgGuideMain#10](../vs140/codesnippet/CSharp/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideMain#11](../vs140/codesnippet/CSharp/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-_2.cs)]  
  
## See Also  
 \<xref:System.Array*>   
 \<xref:System.Collections*>   
 [Command-line Building With csc.exe](../vs140/command-line-building-with-csc.exe.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [foreach, in (C# Reference)](../vs140/foreach--in--csharp-reference-.md)   
 [Main and Command Line Arguments](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Print Command Line Arguments (C#)](../vs140/how-to--display-command-line-arguments--csharp-programming-guide-.md)   
 [Main() Return Values (C#)](../vs140/main---return-values--csharp-programming-guide-.md)