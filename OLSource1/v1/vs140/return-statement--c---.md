---
title: "return Statement (C++)"
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
  - "return"
  - "return_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "return keyword [C++], syntax"
  - "return keyword [C++]"
ms.assetid: a498903a-056a-4df0-a6cf-72f633a62210
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# return Statement (C++)
Terminates the execution of a function and returns control to the calling function (or to the operating system if you transfer control from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function). Execution resumes in the calling function at the point immediately following the call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause, if present, is converted to the type specified in the function declaration, as if an initialization were being performed. Conversion from the type of the expression to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type of the function can create temporary objects. For more information about how and when temporaries are created, see [Temporary Objects](../vs140/temporary-objects.md).  
  
 The value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause is returned to the calling function. If the expression is omitted, the return value of the function is undefined. Constructors and destructors, and functions of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>,cannot specify an expression in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement. Functions of all other types must specify an expression in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.  
  
 When the flow of control exits the block enclosing the function definition, the result is the same as it would be if a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement without an expression had been executed. This is invalid for functions that are declared as returning a value.  
  
 A function can have any number of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statements.  
  
 The following example uses an expression with a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement to obtain the largest of two integers.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Jump Statements](../vs140/jump-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)