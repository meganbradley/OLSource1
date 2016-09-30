---
title: "Anonymous Methods and Code Analysis"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "methods, anonymous"
  - "code analysis, anonymous methods"
  - "anonymous methods, code analysis"
ms.assetid: bf0a1a9b-b954-4d46-9c0b-cee65330ad00
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anonymous Methods and Code Analysis
An *anonymous method* is a method that has no name. Anonymous methods are most frequently used to pass a code block as a delegate parameter.  
  
 This topic explains how Code Analysis handles warnings and metrics that are associated with anonymous methods.  
  
## Anonymous Methods Declared In a Member  
 Warnings and metrics for an anonymous method that is declared in a member, such as a method or accessor, are associated with the member that declares the method. They are not associated with the member that calls the method.  
  
 For example, in the following class, any warnings that are found in the declaration of **anonymousMethod** should be raised against **Method1** and not **Method2**.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Inline Anonymous Methods  
 Warnings and metrics for an anonymous method that is declared as an inline assignment to a field are associated with the constructor. If the field is declared as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]), the warnings and metrics are associated with the class constructor; otherwise, they are associated with the instance constructor.  
  
 For example, in the following class, any warnings that are found in the declaration of **anonymousMethod1** will be raised against the implicitly generated default constructor of **Class**. Whereas, those found in **anonymousMethod2** will be applied against the implicitly generated class constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A class could contain an inline anonymous method that assigns a value to a field that has multiple constructors. In this case, warnings and metrics are associated with all the constructors unless that constructor chains to another constructor in the same class.  
  
 For example, in the following class, any warnings that are found in the declaration of **anonymousMethod** should be raised against **Class(int)** and **Class(string)** but not against **Class()**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Although this might seem unexpected, this occurs because the compiler outputs a unique method for every constructor that does not chain to another constructor. Because of this behavior, any violation that occurs in **anonymousMethod** must be suppressed separately. This also means that if a new constructor is introduced, warnings that were previously suppressed against **Class(int)** and **Class(string)** must also be suppressed against the new constructor.  
  
 You can work around this issue in one of two ways. You could declare **anonymousMethod** in a common constructor that all constructors chain. Or you could declare it in an initialization method that is called by all constructors.  
  
## See Also  
 [Analyzing Managed Code Quality By Using Code Analysis](../vs140/analyzing-managed-code-quality-by-using-code-analysis.md)