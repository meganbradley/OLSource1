---
title: "Compiler Error CS1599"
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
  - "CS1599"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1599"
ms.assetid: 4cdb282d-0f5d-459b-afc1-8980fbb22067
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1599
Method or delegate cannot return type 'type'  
  
 Some types in the .NET Framework class library, for example, \<xref:System.TypedReference*>, \<xref:System.RuntimeArgumentHandle*> and \<xref:System.ArgIterator*> cannot be used as return types because they can potentially be used to perform unsafe operations.  
  
 The following sample generates CS1599:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>