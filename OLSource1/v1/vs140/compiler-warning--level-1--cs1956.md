---
title: "Compiler Warning (level 1) CS1956"
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
  - "CS1956"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1956"
ms.assetid: 841f8b2b-692b-49ae-a587-a40797cf9797
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1956
Member 'name' implements interface member 'name' in type 'type'. There are multiple matches for the interface member at run-time. It is implementation dependent which method will be called.  
  
 This warning can be generated when two interface methods are differentiated only by whether a particular parameter is marked with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It is best to change your code to avoid this warning because it is not obvious or guaranteed which method is called at runtime.  
  
 Although C# distinguishes between <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the CLR sees them as the same. When deciding which method implements the interface, the CLR just picks one.  
  
### To avoid this warning  
  
1.  Give the compiler some way to differentiate the methods. For example, you can give them different names or provide an additional parameter on one of them.  
  
## Example  
 The following code generates CS1956 because the two <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> differ only by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier on the first parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>