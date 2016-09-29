---
title: "Compound Statements (Blocks)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "}"
  - "{"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "blocks, about blocks"
  - "compound statements"
ms.assetid: 23855939-7430-498e-8936-0c70055ea701
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compound Statements (Blocks)
A compound statement consists of zero or more statements enclosed in curly braces (**{ }**). A compound statement can be used anywhere a statement is expected. Compound statements are commonly called "blocks."  
  
## Syntax  
  
```  
  
{ [ statement-list ] }  
```  
  
## Remarks  
 The following example uses a compound statement as the *statement* part of the **if** statement (see [The if Statement](../VS_csharp/if-else-statement--c---.md) for details about the syntax):  
  
```  
if( Amount > 100 )  
{  
    cout << "Amount was too large to handle\n";  
    Alert();  
}  
else  
    Balance -= Amount;  
```  
  
> [!NOTE]
>  Because a declaration is a statement, a declaration can be one of the statements in the *statement-list*. As a result, names declared inside a compound statement, but not explicitly declared as static, have local scope and (for objects) lifetime. See [Scope](../VS_csharp/scope--visual-c---.md) for details about treatment of names with local scope.  
  
## See Also  
 [Overview of C++ Statements](../VS_csharp/overview-of-c---statements.md)