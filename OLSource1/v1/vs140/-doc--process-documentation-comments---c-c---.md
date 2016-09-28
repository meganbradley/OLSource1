---
title: "-doc (Process Documentation Comments) (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/doc (Process Documentation Comments) (C/C++)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.GenerateXMLDocumentationFiles"
  - "/doc"
  - "VC.Project.VCCLCompilerTool.XMLDocumentationFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/doc compiler option [C++]"
  - "comments, C++ code"
  - "XML documentation, comments in source files"
  - "-doc compiler option [C++]"
ms.assetid: b54f7e2c-f28f-4f46-9ed6-0db09be2cc63
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -doc (Process Documentation Comments) (C-C++)
Causes the compiler to process documentation comments in source code files and to create an .xdc file for each source code file that has documentation comments.  
  
## Syntax  
  
```  
/doc[name]  
```  
  
## Arguments  
 `name`  
 The name of the .xdc file that the compiler will create. Only valid when one .cpp file is passed in the compilation.  
  
## Remarks  
 The .xdc files are processed into an .xml file with xdcmake.exe. For more information, see [XDCMake Reference](../vs140/xdcmake-reference.md).  
  
 You can add documentation comments to your source code files. For more information, see [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--visual-c---.md).  
  
 **/doc** is not compatible with **/clr:oldSyntax**.  See [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) for more information.  
  
 To use the generated .xml file with IntelliSense, make the file name of the .xml file the same as the assembly that you want to support and put the .xml file is in the same directory as the assembly. When the assembly is referenced in the Visual Studio project, the .xml file is also found. For more information, see [Using IntelliSense](../vs140/using-intellisense.md) and [Supplying Code Comments](../vs140/supplying-xml-code-comments.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Expand the **Configuration Properties** node.  
  
3.  Expand the **C/C++** node.  
  
4.  Select the **Output Files** property page.  
  
5.  Modify the **Generate XML Documentation Files** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.GenerateXMLDocumentationFiles*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)