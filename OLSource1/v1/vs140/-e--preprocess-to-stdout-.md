---
title: "-E (Preprocess to stdout)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/E (Preprocess to stdout)"
f1_keywords: 
  - "/e"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-E compiler option [C++]"
  - "/E compiler option [C++]"
  - "preprocessor output, copy to stdout"
  - "preprocessor output"
ms.assetid: ddbb1725-d950-4978-ab2f-30a5cd7b778c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -E (Preprocess to stdout)
Preprocesses C and C++ source files and copies the preprocessed files to the standard output device.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In this process, all preprocessor directives are carried out, macro expansions are performed, and comments are removed. To preserve comments in the preprocessed output, use the [/C (Preserve Comments During Preprocessing)](../vs140/-c--preserve-comments-during-preprocessing-.md) compiler option as well.  
  
 **/E** adds <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directives to the output at the beginning and end of each included file and around lines removed by preprocessor directives for conditional compilation. These directives renumber the lines of the preprocessed file. As a result, errors generated during later stages of processing refer to the line numbers of the original source file rather than lines in the preprocessed file.  
  
 The **/E** option suppresses compilation. You must resubmit the preprocessed file for compilation. **/E** also suppresses the output files from the **/FA**, **/Fa**, and **/Fm** options. For more information, see [/FA, /Fa (Listing File)](../vs140/-fa---fa--listing-file-.md) and [/Fm (Name Mapfile)](../vs140/-fm--name-mapfile-.md).  
  
 To suppress <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directives, use the [/EP (Preprocess to stdout Without #line Directives)](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md) option instead.  
  
 To send the preprocessed output to a file instead of to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, use the [/P (Preprocess to a File)](../vs140/-p--preprocess-to-a-file-.md) option instead.  
  
 To suppress <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directives and send the preprocessed output to a file, use **/P** and **/EP** together.  
  
 You cannot use precompiled headers with the **/E** option.  
  
 Note that when preprocessing to a separate file, spaces are not emitted after tokens. This can result in an illegal program or have unintended side effects. The following program compiles successfully:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, if you compile with:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in test2.cpp will incorrectly be <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options**box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.GeneratePreprocessedFile*>.  
  
## Example  
 The following command line preprocesses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, preserves comments, adds <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives, and displays the result on the standard output device:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)