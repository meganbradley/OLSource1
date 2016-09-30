---
title: "Compiler Error C2059"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2059"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2059"
ms.assetid: 2be4eb39-3f37-4b32-8e8d-75835e07c78a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2059
syntax error : 'token'  
  
 The token caused a syntax error.  
  
 The following example generates an error message for the line that declares <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To determine the cause of the error, examine not only the line that's listed in the error message, but also the lines above it. If examining the lines yields no clue about the problem, try commenting out the line that's listed in the error message and perhaps several lines above it.  
  
 If the error message occurs on a symbol that immediately follows a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable, make sure that the variable is defined in the source code.  
  
 You may get C2059 if a symbol evaluates to nothing, as can occur when **/D**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**=** is used to compile.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Another case in which C2059 can occur is when you compile an application that specifies a structure in the default arguments for a function. The default value for an argument must be an expression. An initializer list—for example, one that used to initialize a structure—is not an expression.  To resolve this problem, define a constructor to perform the required initialization.  
  
 The following example generates C2059:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can also get C2059 if you define a member template class or function outside the class. For information, see [Knowledge Base article 241949](http://support.microsoft.com/kb/241949).  
  
 C2059 can occur for an ill-formed cast.  
  
 The following sample generates C2059:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 C2059 can also occur if you attempt to create a namespace name that contains a period.  
  
 The following sample generates C2059:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 C2059 can occur when an operator that can qualify a name (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) must be followed by the keyword <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, as shown in this example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 By default, C++ assumes that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> isn't a template; therefore, the following <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is interpreted as a less-than sign.  You must tell the compiler explicitly that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a template so that it can correctly parse the angle bracket. To correct this error, use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword on the dependent type's name, as shown here:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>