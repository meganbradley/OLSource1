---
title: "Compiler Error CS1716"
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
  - "CS1716"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1716"
ms.assetid: c9e65274-0cc3-41a6-967c-ac1804ecf3ba
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1716
Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute. Use the 'fixed' field modifier instead.  
  
 This error arises in an unsafe code section that contains a fixed-size array declaration similar to a field declaration. Do not use this attribute. Instead, use the keyword <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 The following example generates CS1716.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>