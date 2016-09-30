---
title: "-Qvec-report (Auto-Vectorizer Reporting Level)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Qvec-report (Auto-Vectorizer Reporting Level)"
dev_langs: 
  - "C++"
ms.assetid: 4778c9a3-0692-4085-9b05-1bfeadf4c74a
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Qvec-report (Auto-Vectorizer Reporting Level)
Enables the reporting feature of the compiler [Auto-Vectorizer](../vs140/auto-parallelization-and-auto-vectorization.md) and specifies the level of informational messages for output during compilation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 **/Qvec-report:1**  
 Outputs an informational message for loops that are vectorized.  
  
 **/Qvec-report:2**  
 Outputs an informational message for loops that are vectorized and for loops that are not vectorized, together with a reason code.  
  
 For information about reason codes and messages, see [Vectorizer/Parallelizer Messages](../vs140/vectorizer-and-parallelizer-messages.md).  
  
### To set the /Qvec-report compiler option in Visual Studio  
  
1.  In **Solution Explorer**, open the shortcut menu for the project and then choose **Properties**.  
  
2.  In the **Property Pages** dialog box, under **C/C++**, select **Command Line**.  
  
3.  In the **Additional Options** box, enter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
### To set the /Qvec-report compiler option programmatically  
  
-   Use the code example in \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/Q Options (Low-Level Operations)](../vs140/-q-options--low-level-operations-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [Parallel Programming in Native Code](http://go.microsoft.com/fwlink/?LinkId=263662)