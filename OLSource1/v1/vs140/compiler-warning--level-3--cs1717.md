---
title: "Compiler Warning (level 3) CS1717"
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
  - "CS1717"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1717"
ms.assetid: 5b150a2c-5d61-4cd8-b4d4-e6c2b93b52c6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS1717
Assignment made to same variable; did you mean to assign something else?  
  
 This warning occurs when you assign a variable to itself, such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 Several common mistakes can generate this warning:  
  
-   Writing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as the condition of an **if** statement, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You probably meant to say <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which is always true, so you could write this more concisely as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   Mistyping. You probably meant to say <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   In a constructor where the parameter has the same name as the field, not using the **this** keyword: you probably meant to say <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates CS1717.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>