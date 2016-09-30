---
title: "Troubleshooting Exceptions: System.ServiceModel.Persistence.InstanceNotFoundException"
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
  - "InstanceNotFoundException exception"
  - "System.ServiceModel.Persistence.InstanceNotFoundException exception"
ms.assetid: e3905352-dff0-41d4-b970-8e1b26d85a83
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.ServiceModel.Persistence.InstanceNotFoundException
An \<xref:System.ServiceModel.Persistence.InstanceNotFoundException*> exception is thrown under the following circumstances:  
  
-   An operation is performed on a durable service instance that has been marked for completion.  
  
-   A persistence provider created by a \<xref:System.ServiceModel.Persistence.SqlPersistenceProviderFactory*> attempts to lock, unlock, or otherwise process state data that is not found in the database.  
  
## See Also  
 \<xref:System.ServiceModel.Persistence.InstanceNotFoundException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)