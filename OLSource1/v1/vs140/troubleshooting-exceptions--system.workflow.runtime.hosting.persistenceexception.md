---
title: "Troubleshooting Exceptions: System.Workflow.Runtime.Hosting.PersistenceException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - EHWRHPersistence
helpviewer_keywords: 
  - PersistenceException exception
  - System.Workflow.Runtime.Hosting.PersistenceException exception
ms.assetid: cb2fb820-f990-4728-9a7f-5ec6fd8d5b10
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.Workflow.Runtime.Hosting.PersistenceException
A <xref:System.Workflow.Runtime.Hosting.PersistenceException?qualifyHint=False> exception is thrown when the persistence service cannot fulfill a request.  
  
## Remarks  
 The <xref:System.Workflow.Runtime.Hosting.SqlWorkflowPersistenceService?qualifyHint=False> throws a <xref:System.Workflow.Runtime.Hosting.PersistenceException?qualifyHint=False> if it cannot complete a request to commit either a completed scope or the workflow instance state to its database.  
  
 If you implement a persistence service by deriving from the <xref:System.Workflow.Runtime.Hosting.WorkflowPersistenceService?qualifyHint=False> class or the <xref:System.Workflow.Runtime.Hosting.SqlWorkflowPersistenceService?qualifyHint=False> class, you can throw the <xref:System.Workflow.Runtime.Hosting.PersistenceException?qualifyHint=False> with an appropriate message to indicate any error condition encountered by your service that prevents it from fulfilling a request made by the workflow runtime engine.  
  
 See <xref:System.Workflow.Runtime.Hosting.WorkflowPersistenceService?qualifyHint=False> for more information.  
  
## See Also  
 <xref:System.Workflow.Runtime.Hosting.PersistenceException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)