---
title: "Compiler Error CS1656"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1656"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1656"
ms.assetid: b5463a12-d685-4dae-9f88-08383e271b7a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1656
Cannot assign to 'variable' because it is a 'read-only variable type'  
  
 This error occurs when an assignment to variable occurs in a read-only context. Read-only contexts include [foreach](../vs140/foreach--in--csharp-reference-.md) iteration variables, [using](../vs140/using-statement--csharp-reference-.md) variables, and [fixed](../vs140/fixed-statement--csharp-reference-.md) variables. To resolve this error, avoid assignments to a statement variable in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statements, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements.  
  
## Example  
 The following example generates error CS1656 because it tries to replace complete elements of a collection inside a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop. One way to work around the error is to change the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop to a [for](../vs140/for--csharp-reference-.md) loop. Another way, not shown here, is to modify the members of the existing element; this is possible with classes, but not with structs.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample demonstrates how CS1656 can be generated in other contexts besides a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>