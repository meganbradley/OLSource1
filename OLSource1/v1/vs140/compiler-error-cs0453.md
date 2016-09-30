---
title: "Compiler Error CS0453"
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
  - "CS0453"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0453"
ms.assetid: a1bbd09e-6313-4bfd-84bf-bc15a8d214a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0453
The type 'Type Name' must be a non-nullable value type in order to use it as parameter 'Parameter Name' in the generic type or method 'Generic Identifier'  
  
 This error occurs when you use a non-value type argument in instantiating a generic type or method which has the **value** constraint on it. It can also occur when you use a nullable value type argument. See the last two lines of code in the following example.  
  
## Example  
 The following code generates this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>