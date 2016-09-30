---
title: "Compiler Warning (level 1) C4838"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "error-reference"
H1: "Compiler Warning (level 1) C4838"
f1_keywords: 
  - "C4838"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4838"
ms.assetid: fea07924-5feb-4ed4-99b5-1a8c41d28db6
caps.latest.revision: 8
---
# Compiler Warning (level 1) C4838
conversion from 'type_1' to 'type_2' requires a narrowing conversion  
  
 An implicit narrowing conversion was found when using aggregate or list initialization.  
  
 The C language allows implicit narrowing conversions in assignments and initialization, and C++ follows suit, even though unexpected narrowing is a cause of many code errors. To make code safer, the C++ standard requires a diagnostic message when a narrowing conversion occurs in an initialization list. In Visual C++, the diagnostic is [Compiler Error C2397](../vs140/compiler-error-c2397.md) when using the uniform initialization syntax supported beginning in Visual Studio 2015. The compiler generates  warning C4838 when using the list or aggregate initialization syntax supported by Visual Studio 2013.  
  
 A narrowing conversion can be okay when you know the possible range of converted values can fit in the target. In this case, you know more than the compiler does. If you make a narrowing conversion intentionally, make your intentions explicit by using a static cast. Otherwise, this warning message almost always indicates that you have a bug in your code. You can fix it by making sure the objects you initialize have types that are large enough to handle the inputs.  
  
 The following sample generates C4838 and shows one way to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>