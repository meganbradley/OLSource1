---
title: "Compiler Error CS0718"
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
  - "CS0718"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0718"
ms.assetid: f18ea7b7-7495-4039-9876-409e9fe98ba1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0718
'type': static types cannot be used as type arguments  
  
 Because a static type cannot be instantiated, it cannot be used as a generic argument. To resolve this error, remove the static type from the generic argument.  
  
## Example  
 The following sample generates CS0718:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>