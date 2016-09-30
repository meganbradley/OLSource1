---
title: "Compiler Error C2668"
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
  - "C2668"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2668"
ms.assetid: 041e9627-1c76-420e-a653-cfc83f933bd3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2668
'function' : ambiguous call to overloaded function  
  
 The specified overloaded function call could not be resolved. You may want to explicitly cast one or more of the actual parameters.  
  
 You can also get this error through template use. If, in the same class, you have a regular member function and a templated member function with the same signature, the templated one must come first. This is a limitation of the current implementation of Visual C++.  
  
 See Knowledge Base article Q240869 for more information on partial ordering of function templates.  
  
 If you are building an ATL project containing a COM object supporting <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, see Knowledge Base article Q243298.  
  
## Example  
 The following sample generates C2668:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Another way to resolve this error is with a [using declaration](../vs140/using-declaration.md):  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: ambiguous conversion on cast of constant 0.  
  
 Conversion on a cast using constant 0 is ambiguous since int requires a conversion both to long and to void*. To resolve this error, cast 0 to the exact type of the function parameter it is being used for so that no conversions need to take place (this code will be valid in the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 This error can occur because the CRT now has float and double forms of all math functions.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 This error can occur because the pow(int, int) was removed from math.h in the CRT.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>