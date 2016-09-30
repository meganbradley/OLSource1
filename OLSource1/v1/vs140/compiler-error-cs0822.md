---
title: "Compiler Error CS0822"
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
  - "CS0822"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0822"
ms.assetid: 519091be-2332-4df4-acd9-e3b633966b3d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0822
Implicitly typed locals cannot be const  
  
 Implicitly typed local variables are only necessary for storing anonymous types. In all other cases they are just a convenience. If the value of the variable never changes, just give it an explicit type. Attempting to use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier with an implicitly typed local will generate CS0106.  
  
### To correct this error  
  
1.  If you require the variable to be constant or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, give it an explicit type.  
  
## Example  
 The following code generates CS0822:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md)