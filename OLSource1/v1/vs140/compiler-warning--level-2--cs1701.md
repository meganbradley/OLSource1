---
title: "Compiler Warning (level 2) CS1701"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1701"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1701"
ms.assetid: adbaf99e-c283-49a7-b940-4c9b84ebcb03
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS1701
Assuming assembly reference "Assembly Name #1" matches "Assembly Name #2", you may need to supply runtime policy  
  
 The two assemblies differ in release and/or version number. For unification to occur, you must specify directives in the application's .config file, and you must provide the correct strong name of an assembly, as demonstrated in the following example code.  
  
## Example  
 The following multifile sample references an assembly using two different external aliases. This first sample builds the older version of the code that creates assembly CS1701_d.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This is the code that creates the newer version of assembly CS1701_d. Note that it compiles into a different directory than the older version, necessary since the output files have the same names.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This sample sets up the external aliases A1 and A2.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This sample calls methods using two different aliases of A. The following sample generates C1701.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>