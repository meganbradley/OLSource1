---
title: "-STACK (Stack Allocations)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /STACK (Stack Allocations)
f1_keywords: 
  - VC.Project.VCLinkerTool.StackReserveSize
  - VC.Project.VCLinkerTool.StackCommitSize
  - /stack
dev_langs: 
  - C++
helpviewer_keywords: 
  - STACK linker option
  - -STACK linker option
  - memory allocation, stack
  - /STACK linker option
  - stack, setting size
ms.assetid: 73283660-e4bd-47cc-b5ca-04c5d739034c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -STACK (Stack Allocations)
```  
/STACK:reserve[,commit]  
```  
  
## Remarks  
 The /STACK option sets the size of the stack in bytes. Use this option only when you build an .exe file.  
  
 The `reserve` value specifies the total stack allocation in virtual memory. For ARM, x86 and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] machines, the default stack size is 1 MB.  
  
 `commit` is subject to interpretation by the operating system. In Windows WindowsRT it specifies the amount of physical memory to allocate at a time. Committed virtual memory causes space to be reserved in the paging file. A higher `commit` value saves time when the application needs more stack space, but increases the memory requirements and possibly the startup time. For ARM, x86 and [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] machines, the default commit value is 4 KB.  
  
 Specify the `reserve` and `commit` values in decimal or C-language notation.  
  
 Another way to set the size of the stack is with the [STACKSIZE](../vs140/stacksize.md) statement in a module-definition (.def) file. **STACKSIZE** overrides the Stack Allocations (/STACK) option if both are specified. You can change the stack size after the .exe file is built by using the [EDITBIN](../vs140/editbin-reference.md) tool.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **Linker** folder.  
  
3.  Select the **System** property page.  
  
4.  Modify one of the following properties:  
  
    -   **Stack Commit Size**  
  
    -   **Stack Reserve Size**  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.StackCommitSize?qualifyHint=False> and <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.StackReserveSize?qualifyHint=False> properties.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)