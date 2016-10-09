---
title: "-highentropyva (C# Compiler Options)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/highentropyva (C# Compiler Options)"
f1_keywords: 
  - "/highentropyva"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/highentropyva compiler option [C#]"
  - "-highentropyva compiler option [C#]"
  - "highentropyva compiler option [C#]"
ms.assetid: eaf409b3-384e-49dd-9417-62453658f421
caps.latest.revision: 8
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# -highentropyva (C# Compiler Options)
The **/highentropyva** compiler option tells the Windows kernel whether a particular executable supports high entropy Address Space Layout Randomization (ASLR).  
  
## Syntax  
  
```  
/highentropyva[+ | -]  
```  
  
## Arguments  
 `+` &#124; `-`  
 This option specifies that a 64-bit executable or an executable that is marked by the [/platform:anycpu](../VS_csharp/-platform--csharp-compiler-options-.md) compiler option supports a high entropy virtual address space. The option is disabled by default. Use **/highentropyva+** or **/highentropyva** to enable it.  
  
## Remarks  
 The **/highentropyva** option enables compatible versions of the Windows kernel to use higher degrees of entropy when randomizing the address space layout of a process as part of ASLR. Using higher degrees of entropy means that a larger number of addresses can be allocated to memory regions such as stacks and heaps. As a result, it is more difficult to guess the location of a particular memory region.  
  
 When the **/highentropyva** compiler option is specified, the target executable and any modules that it depends on must be able to handle pointer values that are larger than 4 gigabytes (GB) when they are running as a 64-bit process.  
  
 For more information about ASLR, see [Mitigating Software Vulnerabilities](http://go.microsoft.com/fwlink/?LinkId=226234).