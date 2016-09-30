---
title: "-volatile (volatile Keyword Interpretation)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/volatile (volatile Keyword Interpretation)"
f1_keywords: 
  - "/volatile:iso"
  - "/volatile:ms"
  - "/volatile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/volatile compiler option"
  - "/volatile compiler option [C++]"
  - "-volatile compiler option"
  - "volatile compiler option [C++]"
  - "volatile compiler option"
  - "-volatile compiler option [C++]"
ms.assetid: 9d08fcc6-5bda-44c8-8151-8d8d54f164b8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -volatile (volatile Keyword Interpretation)
Specifies how the [volatile](../vs140/volatile--c---.md) keyword is to be interpreted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 **/volatile:iso**  
 Selects strict <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> semantics as defined by the ISO-standard C++ language. Acquire/release semantics are not guaranteed on volatile accesses. If the compiler targets ARM, this is the default interpretation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **/volatile:ms**  
 Selects Microsoft extended <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> semantics, which add memory ordering guarantees beyond the ISO-standard C++ language. Acquire/release semantics are guaranteed on volatile accesses. However, this option also forces the compiler to generate hardware memory barriers, which might add significant overhead on ARM and other weak memory-ordering architectures. If the compiler targets any platform except ARM, this is default interpretation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 We strongly recommend that you use **/volatile:iso** along with explicit synchronization primitives and compiler intrinsics when you are dealing with memory that is shared across threads. For more information, see [volatile (C++)](../vs140/volatile--c---.md).  
  
 If you port existing code or change this option in the middle of a project, it may be helpful to enable warning [C4746](../vs140/compiler-warning-c4746.md) to identify code locations that are affected by the difference in semantics.  
  
 There is no <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> equivalent to control this option.  
  
### To set the /volatile compiler option in Visual Studio  
  
1.  Open the **Property Pages** dialog box for the project. For more information, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  In the **Additional options** box, add <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## See Also  
 [volatile (C++)](../vs140/volatile--c---.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)