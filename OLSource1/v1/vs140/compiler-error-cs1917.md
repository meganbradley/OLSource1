---
title: "Compiler Error CS1917"
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
  - "CS1917"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1917"
ms.assetid: 05688706-e4b4-4273-9244-48cce1f7f9b9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1917
Members of read-only field 'name' of type 'struct name' cannot be assigned with an object initializer because it is of a value type.  
  
 Read-only fields that are value types can only be assigned in a constructor.  
  
### To correct this error  
  
-   Change the struct to a class type.  
  
-   Initialize the struct with a constructor.  
  
## Example  
 The following code generates CS1917:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>