---
title: "-highentropyva (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/highentropyva (Visual Basic)"
helpviewer_keywords: 
  - "highentropyva compiler option (Visual Basic)"
  - "/highentropyva compiler option (Visual Basic)"
ms.assetid: ff25f20a-6ca2-467b-9e52-5cf439f5028e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -highentropyva (Visual Basic)
Indicates whether a 64-bit executable or an executable that's marked by the [/platform:anycpu](../vs140/-platform--visual-basic-.md) compiler option supports high entropy Address Space Layout Randomization (ASLR).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. The option is off by default or if you specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The option is on if you specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 If you specify this option, compatible versions of the Windows kernel can use higher degrees of entropy when the kernel randomizes the address space layout of a process as part of ASLR. If the kernel uses higher degrees of entropy, a larger number of addresses can be allocated to memory regions such as stacks and heaps. As a result, it is more difficult to guess the location of a particular memory region.  
  
 When the option is on, the target executable and any modules on which it depends must be able to handle pointer values that are larger than 4 gigabytes (GB) when those modules are running as 64-bit processes.  
  
 For more information about ASLR, see [Mitigating Software Vulnerabilities](http://go.microsoft.com/fwlink/?LinkId=226234).  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)