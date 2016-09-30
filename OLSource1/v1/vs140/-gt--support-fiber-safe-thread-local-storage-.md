---
title: "-GT (Support Fiber-Safe Thread-Local Storage)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/GT (Support Fiber-Safe Thread-Local Storage)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.EnableFiberSafeOptimizations"
  - "/gt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/GT compiler option [C++]"
  - "GT compiler option [C++]"
  - "thread-local storage"
  - "static thread-local storage and fiber safety"
  - "-GT compiler option [C++]"
  - "fiber-safe static thread-local storage compiler option [C++]"
ms.assetid: 071fec79-c701-432b-9970-457344133159
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -GT (Support Fiber-Safe Thread-Local Storage)
Supports fiber safety for data allocated using static thread-local storage, that is, data allocated with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Data declared with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is referenced through a thread-local storage (TLS) array. The TLS array is an array of addresses that the system maintains for each thread. Each address in this array gives the location of thread-local storage data.  
  
 A fiber is a lightweight object that consists of a stack and a register context and can be scheduled on various threads. A fiber can run on any thread. Because a fiber may get swapped out and restarted later on a different thread, the address of the TLS array must not be cached or optimized as a common subexpression across a function call (see the [/Og (Global Optimizations)](../vs140/-og--global-optimizations-.md) option for details). **/GT** prevents such optimizations.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Optimization** property page.  
  
4.  Modify the **Enable Fiber-safe Optimizations** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.EnableFiberSafeOptimizations*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)