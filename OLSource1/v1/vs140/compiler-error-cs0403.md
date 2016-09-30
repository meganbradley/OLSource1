---
title: "Compiler Error CS0403"
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
  - "CS0403"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0403"
ms.assetid: 6e5d55ce-d6bf-419d-aded-aaa2e5963bb6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0403
Cannot convert null to type parameter 'name' because it could be a non-nullable value type. Consider using default('T') instead.  
  
 You cannot assign null to the unknown type named because it might be a value type, which does not allow null assignment. If your generic class is not intended to accept value types, use the class type constraint. If it can accept value types, such as the built-in types, you may be able to replace the assignment to null with the expression <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, as shown in the following example.  
  
## Example  
 The following sample generates CS0403.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>