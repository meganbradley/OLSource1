---
title: "PROCESS_INFO_FLAGS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "PROCESS_INFO_FLAGS"
helpviewer_keywords: 
  - "PROCESS_INFO_FLAGS enumeration"
ms.assetid: 696951ce-701a-40c2-ac8c-b897f3aae6e2
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PROCESS_INFO_FLAGS
Describes or specifies properties of a process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 PIFLAG_SYSTEM_PROCESS  
 Indicates that the process is a system process.  
  
 PIFLAG_DEBUGGER_ATTACHED  
 Indicates that the process is being debugged by a debugger. It may be a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugger, or it may be some other debugger, for example, WinDbg.  
  
 PIFLAG_PROCESS_STOPPED  
 Indicates the process is stopped. Valid only if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is also specified. Available in [!INCLUDE[vsprvslong](../vs140/includes/vsprvslong_md.md)] and later.  
  
 PIFLAG_PROCESS_RUNNING  
 Indicates the process is running. Valid only if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is also specified. Available in [!INCLUDE[vsprvslong](../vs140/includes/vsprvslong_md.md)] and later.  
  
## Remarks  
 Used for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member of the [PROCESS_INFO](../vs140/process_info.md) structure.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [PROCESS_INFO](../vs140/process_info.md)