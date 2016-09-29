---
title: "Security of Text Templates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, security"
ms.assetid: 567a2383-7d43-4acc-af4a-cd70b7a0151e
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Security of Text Templates
Text templates have the following security concerns:  
  
-   Text templates are vulnerable to arbitrary code insertions.  
  
-   If the mechanism that the host uses to find a directive processor is not secure, a malicious directive processor could be run.  
  
## Arbitrary Code  
 When you write a template, you can put any code within the <# #> tags. This allows arbitrary code to be executed from within a text template.  
  
 Be sure you obtain templates from trusted sources. Make sure to warn the end-users of your application not to execute templates that do not come from trusted sources.  
  
## Malicious Directive Processor  
 The text template engine interacts with a transformation host and one or more directive processors to transform the template text to an output file. For more information, see [The Text Template Transformation Process](../vs140/the-text-template-transformation-process.md).  
  
 If the mechanism that the host uses to find a directive processor is not secure, it runs the risk of running a malicious directive processor. The malicious directive processor could provide code that is run in `FullTrust` mode when the template is run. If you create a custom text template transformation host, you must use a secure mechanism, such as the registry, for the engine to locate directive processors.