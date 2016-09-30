---
title: "Registering the Program"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "programs, registration"
  - "debugging [Debugging SDK], program registration"
ms.assetid: d726a161-7db3-4ef4-b258-9f6a5be68418
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering the Program
After the debug engine has acquired a port, represented by an [IDebugPort2](../vs140/idebugport2.md) interface, the next step in enabling the program to be debugged is to register it with the port. Once registered, the program is available for debugging by one of the following means:  
  
-   The process of attaching, which allows the debugger to gain complete debugging control of a running application.  
  
-   Just-in-time (JIT) debugging, which allows for after-the-fact debugging of a program that runs independently of a debugger. When the run-time architecture catches a fault, the debugger is notified before the operating system or runtime environment releases the memory and resources of the faulting program.  
  
## Registering Procedure  
  
#### To register your program  
  
1.  Call the [AddProgramNode](../vs140/idebugportnotify2--addprogramnode.md) method implemented by the port.  
  
     <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> requires a pointer to an [IDebugProgramNode2](../vs140/idebugprogramnode2.md) interface.  
  
     Typically, when the operating system or run-time environment loads a program, it creates the program node. If the debug engine (DE) is asked to load the program then the DE creates and registers the program node.  
  
     The following example shows the debug engine launching the program and registering it with a port.  
  
    > [!NOTE]
    >  This is not the only way to launch and resume a process; this is mainly an example of registering a program with a port.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Getting a Port](../vs140/getting-a-port.md)   
 [Enabling a Program to Be Debugged](../vs140/enabling-a-program-to-be-debugged.md)