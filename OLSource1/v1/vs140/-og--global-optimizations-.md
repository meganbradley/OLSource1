---
title: "-Og (Global Optimizations)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Og (Global Optimizations)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.GlobalOptimizations"
  - "/og"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Og compiler option [C++]"
  - "global optimizations compiler option [C++]"
  - "automatic register allocation"
  - "/Og compiler option [C++]"
  - "loop structures, optimizing"
  - "common subexpression elimination"
  - "Og compiler option [C++]"
ms.assetid: d10630cc-b9cf-4e97-bde3-8d7ee79e9435
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Og (Global Optimizations)
Deprecated. Provides local and global optimizations, automatic-register allocation, and loop optimization.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 **/Og** is deprecated. These optimizations are now generally enabled by default. For more information on optimizations, see [/O1, /O2](../vs140/-o1---o2--minimize-size--maximize-speed-.md) or [/Ox](../vs140/-ox--full-optimization-.md).  
  
 The following optimizations are available under **/Og**:  
  
-   Local and global common subexpression elimination  
  
     In this optimization, the value of a common subexpression is calculated once. In the following example, if the values of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> do not change between the three expressions, the compiler can assign the calculation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to a temporary variable, and substitute the variable for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     For local common subexpression optimization, the compiler examines short sections of code for common subexpressions. For global common subexpression optimization, the compiler searches entire functions for common subexpressions.  
  
-   Automatic register allocation  
  
     This optimization allows the compiler to store frequently used variables and subexpressions in registers; the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword is ignored.  
  
-   Loop optimization  
  
     This optimization removes invariant subexpressions from the body of a loop. An optimal loop contains only expressions whose values change through each execution of the loop. In the following example, the expression <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not change in the loop body:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     After optimization, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is calculated once rather than every time the loop is executed:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Loop optimization is much more effective when the compiler can assume no aliasing, which you set with [__restrict](../vs140/__restrict.md), [noalias](../vs140/noalias.md), or [restrict](../vs140/restrict.md).  
  
    > [!NOTE]
    >  You can enable or disable global optimization on a function-by-function basis using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pragma with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> option.  
  
 **/Og** also enables the Named Return Value optimization, which eliminates the copy constructor and destructor of a stack based return value. See [/O1, /O2 (Minimize Size, Maximize Speed)](../vs140/-o1---o2--minimize-size--maximize-speed-.md) for more information.  
  
 For related information, see [Generate Intrinsic Functions (/Oi)](../vs140/-oi--generate-intrinsic-functions-.md) and [Full Optimization (/Ox)](../vs140/-ox--full-optimization-.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the compiler option in the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [/O Options (Optimize Code)](../vs140/-o-options--optimize-code-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)