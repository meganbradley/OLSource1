---
title: "-doc"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/doc"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "doc compiler option [Visual Basic]"
  - "-doc compiler option [Visual Basic]"
  - "/doc compiler option [Visual Basic]"
ms.assetid: 5fc32ec9-a149-4648-994c-a8d0cccd0a65
caps.latest.revision: 18
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
# -doc
Processes documentation comments to an XML file.  
  
## Syntax  
  
```  
/doc[+ | -]  
' -or-  
/doc:file  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`+` &#124; `-`|Optional. Specifying +, or just `/doc`, causes the compiler to generate documentation information and place it in an XML file. Specifying `-` is the equivalent of not specifying `/doc`, causing no documentation information to be created.|  
|`file`|Required if `/doc:` is used. Specifies the output XML file, which is populated with the comments from the source-code files of the compilation. If the file name contains a space, surround the name with quotation marks (" ").|  
  
## Remarks  
 The `/doc` option controls whether the compiler generates an XML file containing the documentation comments. If you use the `/doc:``file` syntax, the `file` parameter specifies the name of the XML file. If you use `/doc` or `/doc+`, the compiler takes the XML file name from the executable file or library that the compiler is creating. If you use `/doc-` or do not specify the `/doc` option, the compiler does not create an XML file.  
  
 In source-code files, documentation comments can precede the following definitions:  
  
-   User-defined types, such as a [class](../VS_visualbasic/class-statement--visual-basic-.md) or [interface](../VS_visualbasic/interface-statement--visual-basic-.md)  
  
-   Members, such as a field, [event](../VS_visualbasic/event-statement.md), [property](../VS_visualbasic/property-statement.md), [function](../VS_visualbasic/function-statement--visual-basic-.md), or [subroutine](../VS_visualbasic/sub-statement--visual-basic-.md).  
  
 To use the generated XML file with the [!INCLUDE[vsprvs](../VS_visualbasic/includes/vsprvs_md.md)] [IntelliSense](../Topic/Using%20IntelliSense.md) feature, let the file name of the XML file be the same as the assembly you want to support. Make sure the XML file is in the same directory as the assembly so that when the assembly is referenced in the [!INCLUDE[vsprvs](../VS_visualbasic/includes/vsprvs_md.md)] project, the .xml file is found as well. XML documentation files are not required for IntelliSense to work for code within a project or within projects referenced by a project.  
  
 Unless you compile with `/target:module`, the XML file contains the tags `<assembly></assembly>`. These tags specify the name of the file containing the assembly manifest for the output file of the compilation.  
  
 See [XML Comment Tags](../VS_visualbasic/recommended-xml-tags-for-documentation-comments--visual-basic-.md) for ways to generate documentation from comments in your code.  
  
||  
|-|  
|To set /doc in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).<br />2.  Click the **Compile** tab.<br />3.  Set the value in the **Generate XML documentation file** box.|  
  
## Example  
 See [Documenting Your Code with XML](../VS_visualbasic/documenting-your-code-with-xml--visual-basic-.md) for a sample.  
  
## See Also  
 [Visual Basic Command-Line Compiler](../VS_visualbasic/visual-basic-command-line-compiler.md)   
 [Documenting Your Code with XML](../VS_visualbasic/documenting-your-code-with-xml--visual-basic-.md)