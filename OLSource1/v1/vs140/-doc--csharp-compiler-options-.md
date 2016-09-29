---
title: "-doc (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/doc (C# Compiler Options)"
f1_keywords: 
  - "FileProperties.BuildAction"
  - "/doc"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "comments, C# code"
  - "XML documentation [C#], comments in source files"
  - "doc compiler option [C#]"
  - "Visual C#, XML documentation for"
  - "-doc compiler option [C#]"
  - "/doc compiler option [C#]"
ms.assetid: 849eea59-c936-4311-bad8-d07404480f2a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -doc (C# Compiler Options)
The **/doc** option allows you to place documentation comments in an XML file.  
  
## Syntax  
  
```  
/doc:file  
```  
  
## Arguments  
 `file`  
 The output file for XML, which is populated with the comments in the source code files of the compilation.  
  
## Remarks  
 In source code files, documentation comments that precede the following can be processed and added to the XML file:  
  
-   Such user-defined types as a [class](../vs140/class--csharp-reference-.md), [delegate](../vs140/delegate--csharp-reference-.md), or [interface](../vs140/interface--csharp-reference-.md)  
  
-   Such members as a field, [event](../vs140/event--csharp-reference-.md), [property](../vs140/using-properties--csharp-programming-guide-.md), or method  
  
 The source code file that contains Main is output first into the XML.  
  
 To use the generated .xml file for use with the [IntelliSense](../vs140/using-intellisense.md) feature, let the file name of the .xml file be the same as the assembly you want to support and then make sure the .xml file is in the same directory as the assembly. Thus, when the assembly is referenced in the Visual Studio project, the .xml file is found as well. See [Supplying Code Comments](../vs140/supplying-xml-code-comments.md) and for more information.  
  
 Unless you compile with [/target:module](../vs140/-target-module--csharp-compiler-options-.md), `file` will contain <assembly\></assembly\> tags specifying the name of the file containing the assembly manifest for the output file of the compilation.  
  
> [!NOTE]
>  The /doc option applies to all input files; or, if set in the Project Settings, all files in the project. To disable warnings related to documentation comments for a specific file or section of code, use [#pragma warning](../vs140/sharppragma-warning--csharp-reference-.md).  
  
 See [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md) for ways to generate documentation from comments in your code.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page.  
  
2.  Click the **Build** tab.  
  
3.  Modify the **XML documentation file** property.  
  
 For information on how to set this compiler option programmatically, see <xref:VSLangProj80.CSharpProjectConfigurationProperties3.DocumentationFile*>.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)