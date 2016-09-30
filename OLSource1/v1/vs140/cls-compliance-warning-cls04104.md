---
title: "CLS Compliance Warning CLS04104"
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
  - "CLS04104"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CLS04104"
ms.assetid: 89a5c080-c7f3-48b5-b2ff-90aa2236c90e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CLS Compliance Warning CLS04104
Attributes shall be of type 'System::Attribute', or inherit from it  
  
 In order to be CLS compliant, a custom attribute must inherit from System::Attribute.  An attribute that did not inherit from System::Attribute was applied to a member function.  
  
 The following declaration (using MSIL assembly language) shows what could cause CLS04111:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then a member function that uses the attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Causing the attribute to derive from System::Attribute resolves the warning:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>