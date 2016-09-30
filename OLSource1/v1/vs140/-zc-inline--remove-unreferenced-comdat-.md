---
title: "-Zc:inline (Remove unreferenced COMDAT)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zc:inline (Remove unreferenced COMDAT)"
f1_keywords: 
  - "/Zc:inline"
  - "VC.Project.VCCLCompilerTool.RemoveUnreferencedCodeData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Zc compiler options (C++)"
  - "/Zc compiler options (C++)"
  - "Zc compiler options (C++)"
  - "/Zc:inline"
ms.assetid: a4c94224-1d73-4bea-a9d5-4fa73dc924df
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zc:inline (Remove unreferenced COMDAT)
Removes unreferenced functions or data that are COMDATs or only have internal linkage. When **/Zc:inline** is specified, the compiler requires that translation units that use inline data or inline functions must also include the definitions for the data or functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When **/Zc:inline** is specified, the compiler does not emit symbol information for unreferenced COMDAT functions or data, or for functions or data that have internal linkage only. By default, this option is off (**/Zc:inline-**). This optimization simplifies some of the work performed by the linker in release builds or when the linker option [/OPT:REF](../vs140/-opt--optimizations-.md) is specified. When the compiler performs this optimization, it can significantly reduce .obj file size and improve linker speeds. This compiler option is not enabled when optimizations are disabled ([/Od](../vs140/-od--disable--debug--.md)) or when [/GL (Whole Program Optimization)](../vs140/-gl--whole-program-optimization-.md) is specified.  
  
 If **/Zc:inline** is specified, the compiler enforces the C++11 requirement that all functions declared <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must have a definition available in the same translation unit if they are used. When the option is not specified, [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] allows non-conformant code that invokes functions declared <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> even if no definition is visible. For more information, see the C++11 standard, in section 3.2 and section 7.1.2. This compiler option was introduced in Visual Studio 2013 Update 2.  
  
 To use the **/Zc:inline** option, update non-compliant code. This example shows how the non-compliant use of an inline function declaration without a definition still compiles and links when the default **/Zc:inline-** option is used:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When **/Zc:inline** is enabled, the same code causes a [LNK2019](../vs140/linker-tools-error-lnk2019.md) error, because the compiler does not emit a non-inlined code body for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in example.obj. This causes the non-inlined call in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to reference an undefined external symbol.  
  
 To resolve this error, you can remove the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword from the declaration of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, move the definition of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> into the header file, or move the implementation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> into main.cpp. The next example moves the definition into the header file, where it is visible to any caller that includes the header.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information about conformance issues in Visual C++, see [Nonstandard Behavior](../vs140/nonstandard-behavior.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Modify the **Additional Options** property to include <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and then choose **OK**.  
  
## See Also  
 [/Zc (Conformance)](../vs140/-zc--conformance-.md)