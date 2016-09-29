---
title: "Troubleshooting Exceptions: System.Threading.SynchronizationLockException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "SynchronizationLockException exception"
  - "System.Threading.SynchronizationLockException exception"
ms.assetid: 82d80643-fc5c-40ae-a579-46869772d25c
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Threading.SynchronizationLockException
The exception that is thrown when a method requires the caller to own the lock on a given `Monitor`, and the method is invoked by a caller that does not own that lock.  
  
## Remarks  
 A <xref:System.Threading.SynchronizationLockException*> is thrown by calling the <xref:System.Threading.Monitor.Exit*>, <xref:System.Threading.Monitor.Pulse*>, <xref:System.Threading.Monitor.PulseAll*>, and <xref:System.Threading.Monitor.Wait*> methods of the `Monitor` class from an unsynchronized block of code.  
  
## See Also  
 <xref:System.Threading.SynchronizationLockException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)