---
title: "-Zc:rvalueCast (Enforce type conversion rules)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Zc:rvalueCast (Enforce type conversion rules)"
f1_keywords: 
  - "rvaluecast"
  - "/Zc:rvalueCast"
  - "VC.Project.VCCLCompilerTool.EnforceTypeConversionRules"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Zc compiler options (C++)"
  - "rvaluecast"
  - "Enforce type conversion rules"
  - "/Zc compiler options (C++)"
  - "Zc compiler options (C++)"
ms.assetid: 7825277d-e565-4c48-b0fb-76ac0b0c6e38
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Zc:rvalueCast (Enforce type conversion rules)
When the **/Zc:rvalueCast** option is specified, the compiler correctly identifies an rvalue reference type as the result of a cast operation in accordance with the C++11 standard. When the option is not specified, the compiler behavior is the same as in Visual Studio 2012. By default, **/Zc:rvalueCast** is off. For conformance and to eliminate errors in the use of casts, we recommend that you use **/Zc:rvalueCast**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If **/Zc:rvalueCast** is specified, the compiler follows section 5.4 of the C++11 standard and treats only cast expressions that result in non-reference types and cast expressions that result in rvalue references to non-function types as rvalue types. By default, or if **/Zc:rvalueCast-** is specified, the compiler is non-conformant and treats all cast expressions that result in rvalue references as rvalues.  
  
 Use **/Zc:rvalueCast** if you pass a cast expression as an argument to a function that takes an rvalue reference type. The default behavior causes compiler error [C2664](../vs140/compiler-error-c2664.md) when the compiler incorrectly determines the type of the cast expression. This example shows a compiler error in correct code when /Zc:rvalueCast is not specified:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The default compiler behavior may not report error C2102 when appropriate. In this example, the compiler does not report an error if the address of an rvalue created by an identity cast is taken when **/Zc:rvalueCast** is not specified:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information about conformance issues in Visual C++, see [Nonstandard Behavior](../vs140/nonstandard-behavior.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Modify the **Additional Options** property to include **/Zc:rvalueCast** and then choose **OK**.  
  
## See Also  
 [/Zc (Conformance)](../vs140/-zc--conformance-.md)