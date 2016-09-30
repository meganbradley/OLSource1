---
title: "fenv_access"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-pragma.fenv_access"
  - "fenv_access_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, fenv_access"
  - "fenv_access pragma"
ms.assetid: 2ccea292-0ae4-42ce-9c67-cc189299857b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fenv_access
Disables (ON) or enables (OFF) optimizations that could change flag tests and mode changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is OFF.  
  
 For more information on floating-point behavior, see [/fp (Specify Floating-Point Behavior)](../vs140/-fp--specify-floating-point-behavior-.md).  
  
 The kinds of optimizations that are subject to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are:  
  
-   Global common subexpression elimination  
  
-   Code motion  
  
-   Constant folding  
  
 Other floating-point pragmas include:  
  
-   [float_control](../vs140/float_control.md)  
  
-   [fp_contract](../vs140/fp_contract.md)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **out=9.999999776482582e-003**   
## Example  
 The following sample is for compiler producing output files for Itanium processors. **/fp:precise** keeps the intermediate results in extended precision where values greater than FLT_MAX (3.402823466e+38F) can be calculated and as a result of that sum will have 1.0 result, as it should if manually calculated. **/fp:strict** keeps intermediate results in their source precision (float) so the first addition produces infinity, which is kept throughout the expression.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **1.000000**   
## Example  
 When commenting out <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from the previous sample, note that the output is different because the compiler does compile-time evaluation, which does not use the control mode.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **out=1.000000000000000e-002**   
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)