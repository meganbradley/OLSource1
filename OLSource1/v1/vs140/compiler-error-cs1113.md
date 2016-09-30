---
title: "Compiler Error CS1113"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1113"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1113"
ms.assetid: ef2d828f-b5ee-4be9-ba2e-36df5502cc5a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1113
Extension methods 'name' defined on value type 'name' cannot be used to create delegates.  
  
 Extension methods that are defined for class types can be used to create delegates. Extension methods that are defined for value types cannot.  
  
### To correct this error  
  
1.  Associate the extension method with a class type.  
  
2.  Make the method a regular method on the struct.  
  
## Example  
 The following example generates CS1113:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)