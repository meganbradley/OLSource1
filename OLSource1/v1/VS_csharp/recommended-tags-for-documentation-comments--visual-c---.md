---
title: "Recommended Tags for Documentation Comments (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 6548e798-5235-4a38-9482-bdc7b88f40a9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recommended Tags for Documentation Comments (Visual C++)
The Visual C++ compiler will process documentation comments in your code and creates an .xdc file for each compiland, and xdcmake.exe will process the .xdc files to an .xml file. Processing the .xml file to create documentation is a detail that needs to be implemented at your site.  
  
 Tags are processed on constructs such as types and type members.  
  
 Tags must immediately precede types or members.  
  
> [!NOTE]
>  Documentation comments cannot be applied to a namespace or on out of line definition for properties and events; documentation comments must on the in-class declarations.  
  
 The compiler will process any tag that is valid XML. The following tags provide commonly used functionality in user documentation:  
  
||||  
|-|-|-|  
|[<c\>](../VS_csharp/-c---visual-c---.md)|[<code\>](../VS_csharp/-code---visual-c---.md)|[<example\>](../VS_csharp/-example---visual-c---.md)|  
|[<exception\>](../VS_csharp/-exception---visual-c---.md)1|[<include\>](../VS_csharp/-include---visual-c---.md)1|[<list\>](../VS_csharp/-list---visual-c---.md)|  
|[<para\>](../VS_csharp/-para---visual-c---.md)|[<param\>](../VS_csharp/-param---visual-c---.md)1|[<paramref\>](../VS_csharp/-paramref---visual-c---.md)1|  
|[<permission\>](../VS_csharp/-permission---visual-c---.md)1|[<remarks\>](../VS_csharp/-remarks---visual-c---.md)|[<returns\>](../VS_csharp/-returns---visual-c---.md)|  
|[<see\>](../VS_csharp/-see---visual-c---.md)1|[<seealso\>](../VS_csharp/-seealso---visual-c---.md)1|[<summary\>](../VS_csharp/-summary---visual-c---.md)|  
|[<value\>](../VS_csharp/-value---visual-c---.md)|||  
  
 1. Compiler verifies syntax.  
  
 In the current release, the Visual C++ compiler does not support `<paramref>`, a tag that is supported by other Visual Studio compilers. Visual C++ may support `<paramref>` in a future release.  
  
## See Also  
 [XML Documentation](../VS_csharp/xml-documentation--visual-c---.md)