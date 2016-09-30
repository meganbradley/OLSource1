---
title: "Troubleshooting Exceptions: System.ObjectDisposedException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ObjectDisposedException class, troubleshooting"
ms.assetid: 702912b6-e927-4f8e-8b7c-2e1880312b0e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.ObjectDisposedException
An \<xref:System.ObjectDisposedException*> exception is thrown when an operation is attempted on a disposed object, such as a closed stream or registry key.  
  
## Associated Tips  
 **Make sure you have not released a resource before attempting to use it.**  
 For example, if attempting to manipulate a stream, make sure it has not been previously closed.  
  
## See Also  
 \<xref:System.ObjectDisposedException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)