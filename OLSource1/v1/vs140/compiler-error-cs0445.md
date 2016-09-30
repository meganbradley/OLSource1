---
title: "Compiler Error CS0445"
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
  - "CS0445"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0445"
ms.assetid: 43f3e5c5-115c-4a34-b0f3-1b7623c49d64
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0445
Cannot modify the result of an unboxing conversion  
  
 The result of an unboxing conversion is a temporary variable. The compiler prevents you from modifying such variables because any modification would go away when the temporary variable goes away. To fix this, declare a new value-type variable to store the intermediate expression, and assign the result of the unboxing conversion to that variable.  
  
 The following code generates CS0455.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>