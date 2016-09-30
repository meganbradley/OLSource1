---
title: "Compiler Error CS0764"
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
  - "CS0764"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0764"
ms.assetid: 76a64149-49d8-40ea-a976-03835d8fb7eb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0764
Both partial method declarations must be unsafe or neither may be unsafe  
  
 A partial method consists of a defining declaration (signature) and an optional implementing declaration (body). If the defining declaration has the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier, the implementing declaration must also have it. Conversely, if the implementing declaration has the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier, the defining declaration must also.  
  
### To correct this error  
  
1.  Assuming that the defining declaration is correct, add or remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier from the implementing declaration to match the defining declaration.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)