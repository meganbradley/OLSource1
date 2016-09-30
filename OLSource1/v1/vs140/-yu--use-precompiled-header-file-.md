---
title: "-Yu (Use Precompiled Header File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Yu (Use Precompiled Header File)"
f1_keywords: 
  - "/yu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Yu compiler option [C++]"
  - "/Yu compiler option [C++]"
  - "-Yu compiler option [C++]"
  - "PCH files, use existing"
  - ".pch files, use existing"
  - "precompiled header files, use existing"
ms.assetid: 24f1bd0e-b624-4296-a17e-d4b53e374e1f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Yu (Use Precompiled Header File)
Instructs the compiler to use an existing precompiled header (.pch) file in the current compilation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 *filename*  
 The name of a header file, which is included in the source file using an **#include** preprocessor directive.  
  
## Remarks  
 The name of the include file must be the same for both the **/Yc** option that creates the precompiled header and any subsequent **/Yu** option indicating use of the precompiled header.  
  
 For **/Yc**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies the point at which precompilation stops; the compiler precompiles all code though <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and names the resulting precompiled header using the base name of the include file and an extension of .pch.  
  
 The .pch file must have been created using **/Yc**.  
  
 The compiler treats all code occurring before the .h file as precompiled. It skips to just beyond the **#include** directive associated with the .h file, uses the code contained in the .pch file, and then compiles all code after <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 On the command line, no space is allowed between **/Yu** and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 When you specify the **/Yu** option without a file name, your source program must contain a [#pragma hdrstop](../vs140/hdrstop.md) pragma that specifies the file name of the precompiled header, .pch file. In this case, the compiler will use the precompiled header (.pch file) named by [/Fp (Name .Pch File)](../vs140/-fp--name-.pch-file-.md). The compiler skips to the location of that pragma, restores the compiled state from the precompiled header file specified by the pragma, and then compiles only code that follows the pragma. If **#pragma hdrstop** does not specify a file name, the compiler looks for a file with a name derived from the base name of the source file with a .pch extension. You can also use the **/Fp** option to specify a different .pch file.  
  
 If you specify the **/Yu** option without a file name and fail to specify a **hdrstop** pragma, an error message is generated and the compilation is unsuccessful.  
  
 If the **/Yc**<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and **/Yu**<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> options occur on the same command line and both reference the same file name, **/Yc**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> takes precedence, precompiling all code up to and including the named file. This feature simplifies the writing of makefiles.  
  
 Because .pch files contain information about the machine environment as well as memory address information about the program, you should only use a pch file on the machine where it was created.  
  
 For more information on precompiled headers, see:  
  
-   [/Y (Precompiled Headers)](../vs140/-y--precompiled-headers-.md)  
  
-   [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Specify [/Yc (Create Precompiled Header File)](../vs140/-yc--create-precompiled-header-file-.md) on a .cpp file in your project.  
  
2.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
3.  Click the **C/C++** folder.  
  
4.  Click the **Precompiled Headers** property page.  
  
5.  Modify the **Create/Use PCH Through File** property or the **Create/Use Precompiled Header** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.PrecompiledHeaderThrough*> and \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UsePrecompiledHeader*>.  
  
## Examples  
 If the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is compiled with the command line <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the compiler does not process the three include statements but uses precompiled code from MYAPP.pch, thereby saving the time involved in preprocessing all three of the files (and any files they might include).  
  
 You can use the [/Fp (Name .Pch File)](../vs140/-fp--name-.pch-file-.md) option with the **/Yu** option to specify the name of the .pch file if the name is different from either the file name argument to **/Yc** or the base name of the source file, as in the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This command specifies a precompiled header file named MYPCH.pch. The compiler uses its contents to restore the precompiled state of all header files up to and including MYAPP.h. The compiler then compiles the code that occurs after the MYAPP.h **include** statement.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)