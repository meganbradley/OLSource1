---
title: "CLS Compliance Warning CLS01506"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CLS01506"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS01506"
ms.assetid: 030f1b81-1159-4057-9fee-8721a419a5d6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLS Compliance Warning CLS01506
The varargs constraint is not part of the CLS  
  
 The varargs constraint is not part of the Common Language Subset (CLS).  The only calling convention supported by the CLS is the standard managed calling convention.  
  
 For more information CLS compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 The following function declaration (using MSIL assembly language) shows what could cause CLS01506:  
  
```  
.method public instance vararg void  Method1() cil managed  
```  
  
 By removing the **vararg** keyword, you can resolve this warning:  
  
```  
.method public instance void  Method1() cil managed  
```