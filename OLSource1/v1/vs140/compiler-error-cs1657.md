---
title: "Compiler Error CS1657"
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
  - "CS1657"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1657"
ms.assetid: 6f0aeebe-5c90-4d5b-981c-1795d2e8fbb9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1657
Cannot pass 'parameter' as a ref or out argument because 'reason''  
  
 This error occurs when a variable is passed as a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) argument in a context in which that variable is readonly. Readonly contexts include [foreach](../vs140/foreach--in--csharp-reference-.md) iteration variables, [using](../vs140/using-statement--csharp-reference-.md) variables, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variables. To resolve this error, do not call functions that take the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> blocks, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statements, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statements.  
  
## Example  
 The following sample generates CS1657:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following code illustrates the same problem in a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>