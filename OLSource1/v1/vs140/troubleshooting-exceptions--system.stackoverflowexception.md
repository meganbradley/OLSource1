---
title: "Troubleshooting Exceptions: System.StackOverflowException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - JScript
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - StackOverflowException class
ms.assetid: 51b71217-c507-4f5b-bc35-0236180d7968
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.StackOverflowException
A <xref:System.StackOverflowException?qualifyHint=False> exception is thrown when the execution stack overflows by having too many nested method calls.  
  
## Associated Tips  
 Make sure you do not have an infinite loop or infinite recursion.  
 Too many method calls is often indicative of a very deep or unbounded recursion.  
  
## Remarks  
 You cannot catch stack overflow exceptions, because the exception-handling code may require the stack. Instead, when a stack overflow occurs in a normal application, the Common Language Runtime (CLR) terminates the process.  
  
 An application that hosts the CLR can change the default behavior and specify that the CLR unload the application domain where the exception occurs, but lets the process continue. For more information, see [ICLRPolicyManager](assetId:///5c834aa1-f2db-408a-b230-c7bec093d364).  
  
## See Also  
 <xref:System.StackOverflowException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)