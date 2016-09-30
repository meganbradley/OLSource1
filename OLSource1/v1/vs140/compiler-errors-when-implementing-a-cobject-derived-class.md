---
title: "Compiler Errors when Implementing a CObject-Derived Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compiling source code, CObject-derived classes"
  - "errors [C++]"
  - "errors [C++], compiler"
  - "CObject class, compiler errors for derived classes"
ms.assetid: 9f249b52-aeff-41a1-8a74-a52aa08c4fcf
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Errors when Implementing a CObject-Derived Class
When you implement a class derived from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and your code is written so that the copy constructor or assignment operator for the class needs to be called, the compiler may report errors similar to the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can reproduce the problem by compiling the example in the Sample Code section below.  
  
> [!NOTE]
>  The sample code shown in this article generates the following error messages:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The reason for the compiler errors is that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> declares a private copy constructor and assignment operator in the AFX.h file. Consequently, the compiler does not generate a default copy constructor and assignment operator for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class. Because the compiler does not find these functions declared in the class, it reports the errors.  
  
 To avoid the compiler errors, you need to implement a copy constructor and assignment operator for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class. This is illustrated in the sample code below. You can avoid the errors by uncommenting the lines indicated in the sample code.  
  
## Sample Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Warnings C4600 Through C4999](../vs140/compiler-warnings-c4600-through-c4799.md)