---
title: "Compiler Error CS0451"
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
  - "CS0451"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0451"
ms.assetid: e73544f8-856b-4a92-90e0-dd6cb9d688b1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0451
The 'new()' constraint cannot be used with the 'struct' constraint  
  
 When specifying constraints on the type of a generic, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> constraint may only be used with class type constraints, interface type constraints, reference type constraints, and type parameter constraints, but not with value type constraints.  
  
## Example  
 The following sample generates CS0451.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>