---
title: "Recommended Tags for Documentation Comments (C# Programming Guide)"
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
  - "XML [C#], tags"
  - "XML documentation [C#], tags"
ms.assetid: 6e98f7a9-38f4-4d74-b644-1ff1b23320fd
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recommended Tags for Documentation Comments (C# Programming Guide)
The C# compiler processes documentation comments in your code and formats them as XML in a file whose name you specify in the **/doc** command-line option. To create the final documentation based on the compiler-generated file, you can create a custom tool, or use a tool such as [Sandcastle](http://shfb.codeplex.com/).  
  
 Tags are processed on code constructs such as types and type members.  
  
> [!NOTE]
>  Documentation comments cannot be applied to a namespace.  
  
 The compiler will process any tag that is valid XML. The following tags provide generally used functionality in user documentation.  
  
## Tags  
  
||||  
|-|-|-|  
|[<c\>](../vs140/-c---csharp-programming-guide-.md)|[<para\>](../vs140/-para---csharp-programming-guide-.md)|[<see\>](../vs140/-see---csharp-programming-guide-.md)*|  
|[<code\>](../vs140/-code---csharp-programming-guide-.md)|[<param\>](../vs140/-param---csharp-programming-guide-.md)*|[<seealso\>](../vs140/-seealso---csharp-programming-guide-.md)*|  
|[<example\>](../vs140/-example---csharp-programming-guide-.md)|[<paramref\>](../vs140/-paramref---csharp-programming-guide-.md)|[<summary\>](../vs140/-summary---csharp-programming-guide-.md)|  
|[<exception\>](../vs140/-exception---csharp-programming-guide-.md)*|[<permission\>](../vs140/-permission---csharp-programming-guide-.md)*|[<typeparam\>](../vs140/-typeparam---csharp-programming-guide-.md)*|  
|[<include\>](../vs140/-include---csharp-programming-guide-.md)*|[<remarks\>](../vs140/-remarks---csharp-programming-guide-.md)|[<typeparamref\>](../vs140/-typeparamref---csharp-programming-guide-.md)|  
|[<list\>](../vs140/-list---csharp-programming-guide-.md)|[<returns\>](../vs140/-returns---csharp-programming-guide-.md)|[<value\>](../vs140/-value---csharp-programming-guide-.md)|  
  
 (* denotes that the compiler verifies syntax.)  
  
 If you want angle brackets to appear in the text of a documentation comment, use `<` and `>`, as shown in the following example.  
  
```xml  
/// <summary cref="C < T >">  
/// </summary>  
```  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [/doc (C# Compiler Options)](../vs140/-doc--csharp-compiler-options-.md)   
 [XML Documentation Comments](../vs140/xml-documentation-comments--csharp-programming-guide-.md)