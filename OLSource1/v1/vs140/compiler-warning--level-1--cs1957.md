---
title: "Compiler Warning (Level 1) CS1957"
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
  - "CS1957"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1957"
ms.assetid: a4823211-52ce-4ffa-b19b-ee874069409f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 1) CS1957
Member 'name' overrides 'method'. There are multiple override candidates at run-time. It is implementation dependent which method will be called.  
  
 Method parameters that vary only by whether they are <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be differentiated at run-time.  
  
### To avoid this warning  
  
1.  Give one of the methods a different name or different number of parameters.  
  
## Example  
 The following code generates CS1957:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>