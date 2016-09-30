---
title: "-Yc (Create Precompiled Header File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Yc (Create Precompiled Header File)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.UsePrecompiledHeader"
  - "/yc"
  - "VC.Project.VCCLWCECompilerTool.PrecompiledHeaderThrough"
  - "VC.Project.VCCLWCECompilerTool.UsePrecompiledHeader"
  - "VC.Project.VCCLCompilerTool.PrecompiledHeaderThrough"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "precompiled header files, creating"
  - "PCH files, creating"
  - ".pch files, creating"
  - "-Yc compiler option [C++]"
  - "/Yc compiler option [C++]"
  - "Yc compiler option [C++]"
ms.assetid: 47c2e555-b4f5-46e6-906e-ab5cf21f0678
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Yc (Create Precompiled Header File)
Instructs the compiler to create a precompiled header (.pch) file that represents the state of compilation at a certain point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a header (.h) file. When this argument is used, the compiler compiles all code up to and including the .h file.  
  
## Remarks  
 When **/Yc** is specified without an argument, the compiler compiles all code up to the end of the base source file, or to the point in the base file where a [hdrstop](../vs140/hdrstop.md) occurs. The resulting .pch file has the same base name as your base source file unless you specify a different file name using the **hdrstop** pragma or the **/Fp** option.  
  
 The precompiled code is saved in a file with a name created from the base name of the file specified with the **/Yc** option and a .pch extension. You can also use the [/Fp (Name .Pch File)](../vs140/-fp--name-.pch-file-.md) option to specify a name for the precompiled header file.  
  
 If you use **/Yc**<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the compiler compiles all code up to and including the specified file for subsequent use with the **/Yu** option.  
  
 If the options **/Yc**<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and [/Yu (Use Precompiled Header File)](../vs140/-yu--use-precompiled-header-file-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> occur on the same command line and both reference, or imply, the same file name, **/Yc**<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> takes precedence. This feature simplifies the writing of makefiles.  
  
 For more information on precompiled headers, see:  
  
-   [/Y (Precompiled Headers)](../vs140/-y--precompiled-headers-.md)  
  
-   [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Select a .cpp file. The .cpp file must #include the .h file that contains precompiled header information. The project's **/Yc** setting can be overridden at the file level.  
  
2.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
3.  Click the **C/C++** folder.  
  
4.  Click the **Precompiled Headers** property page.  
  
5.  Modify the **Create/Use PCH Through File** property or the **Create/Use Precompiled Header** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.PrecompiledHeaderThrough*> and \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UsePrecompiledHeader*>.  
  
## Example  
 Consider the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When this code is compiled with the command <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the compiler saves all the preprocessing for AFXWIN.h, RESOURCE.h, and MYAPP.h in a precompiled header file called MYAPP.pch.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)