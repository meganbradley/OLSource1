---
title: "Debugger Contexts"
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
  - "debugging [Debugging SDK], contexts"
ms.assetid: 79808036-b680-4e4c-9c61-4ed43aa11323
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Debugger Contexts
In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugging, the debug engine (DE) operates simultaneously within several distinct contexts, as follows:  
  
-   The code context, which describes the current location in a program's execution stream.  
  
-   The documentation context or position, which describes the current position within a source document.  
  
-   The expression evaluation context, which describes the context in which expression evaluation will take place.  
  
## In This Section  
 [Code Context](../vs140/code-context.md)  
 Discusses code context as an address in a program's instruction stream in today's run-time architectures versus nontraditional languages, where code may not be represented by instructions, but some other means.  
  
 [Document Position](../vs140/document-position.md)  
 Defines document position in Visual Studio debugging by means of an abstraction of a position in a source file as known to the IDE.  
  
 [Document Context](../vs140/document-context.md)  
 Discusses what document context represents in Visual Studio debugging in relation to a source file. Also discusses how the symbol handler maps a code context to documentation context.  
  
 [Expression Evaluation Context](../vs140/expression-evaluation-context.md)  
 Provides information on an expression evaluation context in Visual Studio. For example, an expression evaluation context associated with a stack frame provides the context for evaluating local variables, method parameters, and class members.  
  
## Related Sections  
 [Debugging Concepts](../vs140/debugger-concepts.md)  
 Describes the main debugging architectural concepts.  
  
 [Debugging Components](../vs140/debugger-components.md)  
 Provides an overview of the Visual Studio debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).  
  
 [Debugging Tasks](../vs140/debugging-tasks.md)  
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.