---
title: "Troubleshooting Exceptions: System.CannotUnloadAppDomainException"
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
  - "CannotUnloadAppDomainException class"
ms.assetid: eeee07c3-fdbc-4c91-859b-a419d23be9ba
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.CannotUnloadAppDomainException
A <xref:System.CannotUnloadAppDomainException*> exception is thrown when there is an attempt to unload one of the following:  
  
-   The default application domain, which must remain loaded throughout the lifetime of the application  
  
-   An application domain with a running thread that cannot stop execution immediately  
  
-   An application domain that has already been unloaded  
  
## Associated Tips  
 **Make sure you are not trying to unload the application domain that is the default, has a running thread, or that has already been unloaded.**  
 Any of these conditions will cause this exception to be thrown. For more information, see <xref:System.AppDomain.Unload*>.  
  
## See Also  
 <xref:System.CannotUnloadAppDomainException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)