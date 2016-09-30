---
title: "Compiler Error C2558"
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
  - "C2558"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2558"
ms.assetid: 822b701e-dcae-423a-b21f-47f36aff9c90
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2558
'identifier' : no copy constructor available or copy constructor is declared 'explicit'  
  
 A copy constructor initializes an object from another object of the same type. (It makes a copy of the object.) The compiler generates a default copy constructor if you do not define any constructors.  
  
### To fix this error  
  
1.  The problem can occur when an attempt is made to copy a class whose copy constructor is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. In most cases, a class that has a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> copy constructor should not be copied. A common programming technique declares a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> copy constructor to prevent the direct use of a class. The class may be useless by itself or require another class in order to work correctly.  
  
     If you determine that it is safe to use a class that has a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> copy constructor, derive a new class from the class that has the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> constructor and make a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> copy constructor available in the new class. Use the derived class in place of the original.  
  
2.  The problem can occur when an attempt is made to copy a class whose copy constructor is explicit. Declaring a copy constructor as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> prevents passing/returning objects of a class to/from functions. For more information about explicit constructors, see [Conversions](../vs140/user-defined-type-conversions--c---.md).  
  
3.  The problem can occur when an attempt is made to copy a class instance declared <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> by using a copy constructor that does not take a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> reference parameter. Declare your copy constructor with a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type reference instead of a non-const type reference.