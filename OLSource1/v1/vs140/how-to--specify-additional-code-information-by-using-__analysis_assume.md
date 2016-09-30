---
title: "How to: Specify Additional Code Information by Using __analysis_assume"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__analysis_assume"
helpviewer_keywords: 
  - "__analysis_assume"
ms.assetid: 51205d97-4084-4cf4-a5ed-3eeaf67deb1b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify Additional Code Information by Using __analysis_assume
You can provide hints to the code analysis tool for C/C++ code that will help the analysis process and reduce warnings. To provide additional information, use the following function:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> - any expression that is assumed to evaluate to true.  
  
 The code analysis tool assumes that the condition represented by the expression is true at the point where the function appears and remains true until expression is altered, for example, by assignment to a variable.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not impact code optimization. Outside the code analysis tool, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is defined as a no-op.  
  
## Example  
 The following code uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to correct the code analysis warning [C6388](../vs140/c6388.md):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [__assume](../vs140/__assume.md)