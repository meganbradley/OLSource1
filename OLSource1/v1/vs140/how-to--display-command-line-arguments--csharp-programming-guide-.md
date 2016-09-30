---
title: "How to: Display Command Line Arguments (C# Programming Guide)"
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
  - "command-line arguments [C#], displaying"
ms.assetid: b8479f2d-9e05-4d38-82da-2e61246e5437
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Display Command Line Arguments (C# Programming Guide)
Arguments provided to an executable on the command-line are accessible through an optional parameter to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. The arguments are provided in the form of an array of strings. Each element of the array contains one argument. White-space between arguments is removed. For example, consider these command-line invocations of a fictitious executable:  
  
|Input on Command-line|Array of strings passed to Main|  
|----------------------------|-------------------------------------|  
|**executable.exe a b c**|"a"\<br />\<br /> "b"\<br />\<br /> "c"|  
|**executable.exe one two**|"one"\<br />\<br /> "two"|  
|**executable.exe "one two" three**|"one two"\<br />\<br /> "three"|  
  
> [!NOTE]
>  When you are running an application in Visual Studio, you can specify command-line arguments in the [Debug Page, Project Designer](../vs140/debug-page--project-designer.md).  
  
## Example  
 This example displays the command line arguments passed to a command-line application. The output shown is for the first entry in the table above.  
  
 [!code[csProgGuideMain#9](../vs140/codesnippet/CSharp/how-to--display-command-line-arguments--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Command-line Building With csc.exe](../vs140/command-line-building-with-csc.exe.md)   
 [Main and Command Line Arguments](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md)   
 [How to: Access Command Line Arguments using foreach (C#)](../vs140/how-to--access-command-line-arguments-using-foreach--csharp-programming-guide-.md)   
 [Main() Return Values (C#)](../vs140/main---return-values--csharp-programming-guide-.md)