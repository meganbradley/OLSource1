---
title: "Explicit Overrides (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "virtual functions, explicit overrides"
  - "overriding, functions"
  - "derived classes, virtual functions"
  - "explicit virtual function overrides"
  - "explicit override of virtual function"
ms.assetid: ee583234-5cda-4e90-b55e-3f9fbf079ced
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Overrides (C++)
**Microsoft Specific**  
  
 If the same virtual function is declared in two or more [interfaces](../vs140/__interface.md) and if a class is derived from these interfaces, you can explicitly override each virtual function.  
  
 For information on explicit overrides in managed code using the new managed syntax, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md).  
  
 **END Microsoft Specific**  
  
## Example  
 The following code example illustrates how to use explicit overrides:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **In CMyClass::IMyInt1::mf1()**  
**In CMyClass::IMyInt1::mf1(int)**  
**In CMyClass::IMyInt1::mf2()**  
**In CMyClass::IMyInt1::mf2(int)**  
**In CMyClass::IMyInt2::mf1()**  
**In CMyClass::IMyInt2::mf1(int)**  
**In CMyClass::IMyInt2::mf2()**  
**In CMyClass::IMyInt2::mf2(int)**   
## See Also  
 [Inheritance](../vs140/inheritance---c---.md)