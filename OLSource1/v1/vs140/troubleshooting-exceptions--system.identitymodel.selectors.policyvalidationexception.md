---
title: "Troubleshooting Exceptions: System.IdentityModel.Selectors.PolicyValidationException"
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
  - "PolicyValidationException exception"
  - "System.IdentityModel.Selectors.PolicyValidationException exception"
ms.assetid: 510c7698-a12b-4bcb-a9d8-87c704b62ffa
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.IdentityModel.Selectors.PolicyValidationException
A <xref:System.IdentityModel.Selectors.PolicyValidationException*> exception is thrown when the policy supplied by the recipient cannot be validated. For more information about policy requirements, see [A Technical Reference for the Information Card Profile V1.0](http://go.microsoft.com/fwlink/?LinkID=102401).  
  
 Any invalid policy content can cause this failure. Common problems with policy content include the following:  
  
-   Invalid key type  
  
-   Invalid key size  
  
-   Invalid XML  
  
-   No claims specified in the policy (at least one non-optional claim must be specified)  
  
## See Also  
 <xref:System.IdentityModel.Selectors.PolicyValidationException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)