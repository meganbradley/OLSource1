---
title: "Execution Control and State Evaluation"
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
  - "debugging [Debugging SDK], execution control"
  - "expression evaluation, control of execution"
ms.assetid: 55adde38-1622-4b51-83cb-ce1b04c1ca7a
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Execution Control and State Evaluation
Debugging an application requires implementing such execution control features as stepping into functions, stopping at breakpoints, and continuing execution. Visual Studio debugging bases its execution control on events sent between debugger components.  
  
## In This Section  
 [Program Control](../vs140/program-control.md)  
 Lists the following routines that occur at the program level: setting the next statement, executing, stepping, continuing, suspending, and resuming.  
  
 [Breakpoint-Related Methods](../vs140/breakpoint-related-methods.md)  
 Defines the bound and pending types of breakpoints that Visual Studio supports.  
  
 [Call Stack Evaluation](../vs140/call-stack-evaluation.md)  
 Discusses implementation of the methods that allow viewing of the stack frames of the call stack during break mode.  
  
 [Expression Evaluation](../vs140/expression-evaluation--visual-studio-debugging-sdk-.md)  
 Explains how the debug engine (DE), expression evaluation (EE), and session debug manager are involved in the parsing and evaluation of an expression entered into one of the windows of the IDE.  
  
 [Control Events](../vs140/control-events.md)  
 Discusses the interface used to send events during the controlled execution of the program.