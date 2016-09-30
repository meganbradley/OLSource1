---
title: "Troubleshooting Exceptions: System.Workflow.Runtime.WorkflowOwnershipException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "EHWRWorkflowOwnership"
helpviewer_keywords: 
  - "System.Workflow.Runtime.WorkflowOwnershipException exception"
  - "WorkflowOwnershipException exception"
ms.assetid: 20291283-dfc8-4e34-b84d-f380e04be376
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Workflow.Runtime.WorkflowOwnershipException
A \<xref:System.Workflow.Runtime.WorkflowOwnershipException*> exception is thrown when the workflow runtime engine attempts to load a workflow instance that is currently loaded by another workflow runtime engine instance. Additionally, this exception is thrown when the workflow runtime engine attempts to save a workflow after the ownership time-out that was specified while the workflow was loading has expired.  
  
## See Also  
 \<xref:System.Workflow.Runtime.WorkflowOwnershipException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)