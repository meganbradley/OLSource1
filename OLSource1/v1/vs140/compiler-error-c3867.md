---
title: "Compiler Error C3867"
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
  - "C3867"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3867"
ms.assetid: bc5de03f-e01a-4407-88c3-2c63f0016a1e
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3867
'func': function call missing argument list; use '&func' to create a pointer to member  
  
 You tried to take the address of a member function without qualifying the member function with its class name and the address-of operator.  
  
 This error can also be generated as a result of compiler conformance work that was done for Visual C++ 2005: enhanced pointer-to-member conformance. Code that compiled prior to Visual C++ 2005 will now generate C3867.  
  
## Example  
 C3867 can be issued from the compiler with a misleading suggested resolution. Whenever possible, use the most derived class.  
  
 The following sample generates C3867 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3867 and shows how to fix it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3867 and shows how to fix it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3867.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C3867.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>