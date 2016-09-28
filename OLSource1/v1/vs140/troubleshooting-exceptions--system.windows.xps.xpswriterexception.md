---
title: "Troubleshooting Exceptions: System.Windows.Xps.XpsWriterException"
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
  - "EHWXXpsWriter"
helpviewer_keywords: 
  - "System.Windows.Xps.XpsWriterException exception"
  - "XpsWriterException exception"
ms.assetid: 3b9fbb94-ed67-44f2-82bb-af5cb5ada1ef
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Windows.Xps.XpsWriterException
An <xref:System.Windows.Xps.XpsWriterException*> exception is thrown when a method of either an <xref:System.Windows.Xps.XpsDocumentWriter*> or a <xref:System.Windows.Xps.VisualsToXpsDocument*> object is called that is incompatible with the current state of the object.  
  
## Remarks  
 For example, this exception is thrown if the `CancelAsync` method of either object type is called when the object is not performing an asynchronous write operation.  
  
## See Also  
 <xref:System.Windows.Xps.XpsWriterException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)