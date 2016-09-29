---
title: "Compiler Warning (level 1) CS3004"
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
  - "CS3004"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3004"
ms.assetid: 84aa3b44-42b7-4d31-82b8-386e56f88129
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3004
Mixed and decomposed Unicode characters are not CLS-compliant  
  
 Only composed UNICODE characters are allowed in [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or `protected``internal` identifiers in order to be compliant with the Common Language Specification (CLS). For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).