---
title: "Troubleshooting Exceptions: System.ServiceModel.ServerTooBusyException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - System.ServiceModel.ServerTooBusyException exception
  - ServerTooBusyException exception
ms.assetid: 80eb606a-ab3c-48af-b747-c9902989a059
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.ServiceModel.ServerTooBusyException
A <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False> exception is thrown when a server is too busy to accept a message.  
  
## Remarks  
 This exception derives from the <xref:System.ServiceModel.CommunicationException?qualifyHint=False> that represents a class of recoverable errors that might be thrown during communication between endpoints. Robust client and service [!INCLUDE[vsindigo](../vs140/includes/vsindigo_md.md)] applications are expected to handle these exceptions. To prevent a handler for <xref:System.ServiceModel.CommunicationException?qualifyHint=False> from catching the more specific <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False>, catch this exception prior to handling <xref:System.ServiceModel.CommunicationException?qualifyHint=False>.  
  
## See Also  
 <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)