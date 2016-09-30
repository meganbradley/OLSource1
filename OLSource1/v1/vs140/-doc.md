---
title: "-doc"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -doc
Processes documentation comments to an XML file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. Specifying +, or just <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, causes the compiler to generate documentation information and place it in an XML file. Specifying <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the equivalent of not specifying <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, causing no documentation information to be created.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used. Specifies the output XML file, which is populated with the comments from the source-code files of the compilation. If the file name contains a space, surround the name with quotation marks (" ").|  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> option controls whether the compiler generates an XML file containing the documentation comments. If you use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> syntax, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter specifies the name of the XML file. If you use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the compiler takes the XML file name from the executable file or library that the compiler is creating. If you use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or do not specify the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> option, the compiler does not create an XML file.  
  
 In source-code files, documentation comments can precede the following definitions:  
  
-   User-defined types, such as a [class](../vs140/class-statement--visual-basic-.md) or [interface](../vs140/interface-statement--visual-basic-.md)  
  
-   Members, such as a field, [event](../vs140/event-statement.md), [property](../vs140/property-statement.md), [function](../vs140/function-statement--visual-basic-.md), or [subroutine](../vs140/sub-statement--visual-basic-.md).  
  
 To use the generated XML file with the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] [IntelliSense](../vs140/using-intellisense.md) feature, let the file name of the XML file be the same as the assembly you want to support. Make sure the XML file is in the same directory as the assembly so that when the assembly is referenced in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project, the .xml file is found as well. XML documentation files are not required for IntelliSense to work for code within a project or within projects referenced by a project.  
  
 Unless you compile with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the XML file contains the tags <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. These tags specify the name of the file containing the assembly manifest for the output file of the compilation.  
  
 See [Recommended Tags for Documentation Comments (Visual Basic)](../vs140/recommended-xml-tags-for-documentation-comments--visual-basic-.md) for ways to generate documentation from comments in your code.  
  
||  
|-|  
|To set /doc in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).\<br />2.  Click the **Compile** tab.\<br />3.  Set the value in the **Generate XML documentation file** box.|  
  
## Example  
 See [Documenting Your Code with XML (Visual Basic)](../vs140/documenting-your-code-with-xml--visual-basic-.md) for a sample.  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Documenting Your Code with XML (Visual Basic)](../vs140/documenting-your-code-with-xml--visual-basic-.md)