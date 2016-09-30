---
title: "Compiler Error C2660"
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
  - "C2660"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2660"
ms.assetid: 2e01a1db-4f00-4df6-a04d-cb6f70a6922b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2660
'function' : function does not take number parameters  
  
 The function is called with an incorrect number of parameters.  
  
 C2660 can occur if you accidentally call a Windows API function rather than an MFC member function of the same name. To solve this problem:  
  
-   Adjust the function call to conform to the format of the member function call.  
  
-   Use the scope resolution operator (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) to tell the compiler to seek the function name in the global name space.  
  
## Example  
 The following sample generates C2660.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C2660 can also occur if you attempt to directly call the Dispose method of a managed type. For more information, see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers). The following sample generates C2660.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 C2660 will occur if a derived class hides a function.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 C2660 can occur if you invoke an indexed property incorrectly.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 C2660 can occur if you invoke an indexed property incorrectly.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 C2660 can occur if you define a new operator in a template class, but where the new operator creates an object whose type is other than the enclosing type.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>