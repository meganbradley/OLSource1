---
title: "Compiler Error C2512"
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
  - "C2512"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2512"
ms.assetid: 15206da9-1164-451a-b869-280e00711aad
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2512
'identifier' : no appropriate default constructor available  
  
 No default constructor is available for the specified class, structure, or union. The compiler supplies a default constructor only if user-defined constructors are not provided.  
  
 If you provide a constructor that takes a non-void parameter, and you want to allow your class to be created with no parameters—for example, as the elements of an array—you must also provide a default constructor. The default constructor can be a constructor with default values for all parameters.  
  
 The following sample generates C2512 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample shows a more subtle C2512. To fix this error, rearrange the code to define the class before its constructor is referenced:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2512 can also be caused by a call to default-construct a class that contains a const or reference data member. These members must be initialized in a constructor initializer list, which prevents the compiler from generating a default constructor.  
  
 The following sample generates C2512 and shows how to fix it:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>