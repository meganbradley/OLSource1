---
title: "CLS Compliance Warning CLS04106"
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
  - "CLS04106"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS04106"
ms.assetid: a74e4cb7-c96a-4673-bf11-c2ff3c4b02f1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLS Compliance Warning CLS04106
Attributes shall be of type 'System::Attribute', or inherit from it  
  
 In order to be CLS compliant, a custom attribute must inherit from System::Attribute.  An attribute that did not inherit from System::Attribute was applied to a function.  
  
 The following declaration (using MSIL assembly language) shows what could cause CLS04106:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then a function that uses the attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Causing the attribute to derive from System::Attribute resolves the warning:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>