---
title: "Recommended Tags for Documentation Comments (C# Programming Guide)"
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
  - "XML [C#], tags"
  - "XML documentation [C#], tags"
ms.assetid: 6e98f7a9-38f4-4d74-b644-1ff1b23320fd
caps.latest.revision: 20
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
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
|[\<c>](../VS_csharp/-c---csharp-programming-guide-.md)|[\<para>](../VS_csharp/-para---csharp-programming-guide-.md)|[\<see>](../VS_csharp/-see---csharp-programming-guide-.md)*|  
|[\<code>](../VS_csharp/-code---csharp-programming-guide-.md)|[\<param>](../VS_csharp/-param---csharp-programming-guide-.md)*|[\<seealso>](../VS_csharp/-seealso---csharp-programming-guide-.md)*|  
|[\<example>](../VS_csharp/-example---csharp-programming-guide-.md)|[\<paramref>](../VS_csharp/-paramref---csharp-programming-guide-.md)|[\<summary>](../VS_csharp/-summary---csharp-programming-guide-.md)|  
|[\<exception>](../VS_csharp/-exception---csharp-programming-guide-.md)*|[\<permission>](../VS_csharp/-permission---csharp-programming-guide-.md)*|[\<typeparam>](../VS_csharp/-typeparam---csharp-programming-guide-.md)*|  
|[\<include>](../VS_csharp/-include---csharp-programming-guide-.md)*|[\<remarks>](../VS_csharp/-remarks---csharp-programming-guide-.md)|[\<typeparamref>](../VS_csharp/-typeparamref---csharp-programming-guide-.md)|  
|[\<list>](../VS_csharp/-list---csharp-programming-guide-.md)|[\<returns>](../VS_csharp/-returns---csharp-programming-guide-.md)|[\<value>](../VS_csharp/-value---csharp-programming-guide-.md)|  
  
 (* denotes that the compiler verifies syntax.)  
  
 If you want angle brackets to appear in the text of a documentation comment, use `<` and `>`, as shown in the following example.  
  
```xml  
/// <summary cref="C < T >">  
/// </summary>  
```  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [/doc (C# Compiler Options)](../VS_csharp/-doc--csharp-compiler-options-.md)   
 [XML Documentation Comments](../VS_csharp/xml-documentation-comments--csharp-programming-guide-.md)