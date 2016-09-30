---
title: "CLS Compliance Warning CLS01201"
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
  - "CLS01201"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS01201"
ms.assetid: 8c3e6ce4-8ea5-487a-bbed-56a36eceb024
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLS Compliance Warning CLS01201
The visibility and accessibility of types and members shall be such that types in the signature of any member shall be visible and accessible whenever the member itself is visible and accessible. For example, a public constructor that is visible outside its assembly shall not have an argument whose type is visible only within the assembly.  
  
 Types in constructor signatures must have accessibility greater than or equal to that of the constructor.  For example, a public constructor visible outside its assembly shall not have an argument whose type is visible only within the assembly.  
  
 For more information CLS compliance checking, see [CLS Compliant Assemblies](assetId:///3320b57e-ea55-4697-a17d-f509a36a3c93).  
  
 The following sample generates CLS01201:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>