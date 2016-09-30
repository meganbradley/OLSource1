---
title: "Troubleshooting Exceptions: System.Workflow.Activities.EventDeliveryFailedException"
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
  - "EHWAEventDeliveryFailed"
helpviewer_keywords: 
  - "System.Workflow.Activities.EventDeliveryFailedException exception"
  - "EventDeliveryFailedException exception"
ms.assetid: 85ee2cb8-5cd1-4878-9421-2a78614e819f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Workflow.Activities.EventDeliveryFailedException
An \<xref:System.Workflow.Activities.EventDeliveryFailedException*> exception is thrown when an event that is raised from the host cannot be delivered to the workflow instance. Typically, the event is raised from an \<xref:System.Workflow.Activities.ExternalDataExchangeService*> on a workflow instance. This class cannot be inherited.  
  
## Remarks  
 The following string is added to the event log when this exception is thrown: <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
 When using a state machine workflow, you may get an exception with the message <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. This happens when the current state of the state machine is not able to handle a specific event. For example, the message occurs when a state other than the current state contains the \<xref:System.Workflow.Activities.EventDrivenActivity*> that contains the \<xref:System.Workflow.Activities.HandleExternalEventActivity*> that is represented by the queue <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:System.Workflow.Activities.EventDeliveryFailedException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)