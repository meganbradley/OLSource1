---
title: "CA5122 P-Invoke declarations should not be safe critical"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "CA5122 P/Invoke declarations should not be safe critical"
ms.assetid: f2581a6d-2a0e-40c1-b600-f5dc70909200
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA5122 P-Invoke declarations should not be safe critical
|||  
|-|-|  
|TypeName|PInvokesShouldNotBeSafeCriticalFxCopRule|  
|CheckId|CA5122|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A P/Invoke declaration has been marked with a \<xref:System.Security.SecuritySafeCriticalAttribute*>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has been marked as a security safe critical method.  
  
## Rule Description  
 Methods are marked as SecuritySafeCritical when they perform a security sensitive operation, but are also safe to be used by transparent code. One of the fundamental rules of the security transparency model is that transparent code may never directly call native code through a P/Invoke. Therefore, marking a P/Invoke as security safe critical will not enable transparent code to call it, and is misleading for security analysis.  
  
## How to Fix Violations  
 To make a P/Invoke available to transparent code, expose a security safe critical wrapper method for it:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.