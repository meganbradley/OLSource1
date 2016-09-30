---
title: "Compiler Warning (level 1) CS3009"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS3009"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3009"
ms.assetid: 41a1d2c4-d558-4066-8f3f-e9d2d69298a8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3009
'type': base type 'type' is not CLS-compliant  
  
 A base type was marked as not having to be compliant with the Common Language Specification (CLS) in an assembly that was marked as being CLS compliant. Either remove the attribute that specifies the assembly is CLS compliant or remove the attribute that indicates the type is not CLS compliant. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3009:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>