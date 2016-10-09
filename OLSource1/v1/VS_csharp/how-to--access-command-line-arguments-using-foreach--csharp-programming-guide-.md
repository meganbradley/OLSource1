---
title: "How to: Access Command-Line Arguments Using foreach (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 15
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
# How to: Access Command-Line Arguments Using foreach (C# Programming Guide)
Another approach to iterating over the array is to use the [foreach](../VS_csharp/foreach--in--csharp-reference-.md) statement as shown in this example. The `foreach` statement can be used to iterate over an array, a .NET Framework collection class, or any class or struct that implements the \<xref:System.Collections.IEnumerable> interface.  
  
> [!NOTE]
>  When running an application in Visual Studio, you can specify command-line arguments in the [Debug Page, Project Designer](../Topic/Debug%20Page,%20Project%20Designer.md).  
  
## Example  
 This example demonstrates how to print out the command line arguments using `foreach`.  
  
 [!code[csProgGuideMain#10](../VS_csharp/codesnippet/CSharp/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideMain#11](../VS_csharp/codesnippet/CSharp/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-_2.cs)]  
  
## See Also  
 \<xref:System.Array>   
 \<xref:System.Collections>   
 [Command-line Building With csc.exe](../VS_csharp/command-line-building-with-csc.exe.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [foreach, in](../VS_csharp/foreach--in--csharp-reference-.md)   
 [Main() and Command-Line Arguments](../VS_csharp/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Display Command Line Arguments](../VS_csharp/how-to--display-command-line-arguments--csharp-programming-guide-.md)   
 [Main() Return Values](../VS_csharp/main---return-values--csharp-programming-guide-.md)