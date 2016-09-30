---
title: "Compiler Error CS1640"
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
  - "CS1640"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1640"
ms.assetid: 1393668e-05e9-4dc2-9203-3d9c2933406f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1640
foreach statement cannot operate on variables of type 'type' because it implements multiple instantiations of 'interface', try casting to a specific interface instantiation  
  
 The type inherits from two or more instances of IEnumerator\<T>, which means there is not a unique enumeration of the type that <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> could use. Specify the type of IEnumerator\<T> or use another looping construct.  
  
## Example  
 The following sample generates CS1640:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>