---
title: "Compiler Warning (level 3) CS1718"
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
  - "CS1718"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1718"
ms.assetid: 7c1c11fd-4f91-482d-b8f7-efe2a361634e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS1718
Comparison made to same variable; did you mean to compare something else?  
  
 If you meant to compare to something else, then you should simply correct the statement.  
  
 But another possibility is that you were testing for true or false, and were doing so by statements such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It is better to simply say <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. There are two reasons for this:  
  
-   It is simpler: it is always clearer to simply say what you mean.  
  
-   It helps avoid confusion: a new feature of C# 2.0 is nullable value types, which are analogous to the value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in T-SQL, the programming language used by SQL Server. Developers familiar with T-SQL might be concerned about the effect of nullable types on expressions such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, because of the use of ternary logic in T-SQL. If you use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you avoid this possible confusion.  
  
## Example  
 The following code generates warning CS1718.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>