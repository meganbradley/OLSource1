---
title: "Compiler Error C2259"
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
  - "C2259"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2259"
ms.assetid: e458236f-bdea-4786-9aa6-a98d8bffa5f4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2259
'class' : cannot instantiate abstract class  
  
 Code declares an instance of an abstract class or structure.  
  
 You cannot instantiate a class or structure with one or more pure virtual functions. To instantiate objects of a derived class, the derived class must override each pure virtual function.  
  
 For more information, see [Implicitly Abstract Classes](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Implicitly_abstract_classes).  
  
 The following sample generates C2259:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Whenever you derive from an interface and implement the interface methods in the derived class with access permissions other than public, you may receive C2259.  This occurs because the compiler expects the interface methods implemented in the derived class to have public access. When you implement the member functions for an interface with more restrictive access permissions, the compiler does not consider them to be implementations for the interface methods defined in the interface, which in turn makes the derived class an abstract class.  
  
 There are two possible workarounds for the problem:  
  
-   Make the access permissions public for the implemented methods.  
  
-   Use the scope resolution operator for the interface methods implemented in the derived class to qualify the implemented method name with the name of the interface.  
  
 C2259 can also occur as a result of conformance work that was done in Visual C++ 2005, **/Zc:wchar_t** is now on by default. In this situation, C2599 can be resolved either by compiling with **/Zc:wchar_t-**, to get the behavior from previous versions, or preferably, by updating your types so they are compatible. For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md).  
  
 The following sample generates C2259:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates C2259:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following sample generates C2259:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>