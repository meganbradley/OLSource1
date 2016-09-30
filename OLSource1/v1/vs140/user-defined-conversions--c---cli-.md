---
title: "User-Defined Conversions (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "User-Defined Conversions (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "user-defined conversions [C++]"
ms.assetid: 8010fd59-2775-4e9a-a6ed-58055032d66f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Conversions (C++-CLI)
This section discusses user-defined conversions (UDC) when one of the types in the conversion is a reference or instance of a value type or reference type.  
  
## Implicit and explicit conversions  
 A user-defined conversion can either be implicit or explicit.  A UDC should be implicit if the conversion does not result in a loss of information. Otherwise an explicit UDC should be defined.  
  
 A native class's constructor can be used to convert a reference or value type to a native class.  
  
 For more information about conversions, see [Implicit Boxing](../vs140/boxing---c---component-extensions-.md) and [Standard Conversions](../vs140/standard-conversions.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **in N::N**  
**in N::N**   
## Convert-From Operators  
 Convert-from operators create an object of the class in which the operator is defined from an object of some other class.  
  
 Standard C++ does not support convert-from operators; standard C++ uses constructors for this purpose. However, when using CLR types, Visual C++ provide syntactic support for calling convert-from operators.  
  
 To interoperate well with other CLS-compliant languages, you may wish to wrap each user-defined unary constructor for a given class with a corresponding convert-from operator.  
  
 Convert-from operators:  
  
-   Shall be defined as static functions.  
  
-   Can either be implicit (for conversions that do not lose precision such as short-to-int) or explicit, when there may be a loss of precision.  
  
-   Shall return an object of the containing class.  
  
-   Shall have the "from" type as the sole parameter type.  
  
 The following sample shows an implicit and explicit "convert-from", user-defined conversion (UDC) operator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **in operator**  
**in constructor**  
**10**  
**1**   
## Convert-to operators  
 Convert-to operators convert an object of the class in which the operator is defined to some other object. The following sample shows an implicit, convert-to, user-defined conversion operator:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **10** An explicit user-defined convert-to conversion operator is appropriate for conversions that potentially lose data in some way. To invoke an explicit convert-to operator, a cast must be used.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **10.3**  
**10**   
## To convert generic classes  
 You can convert a generic class to T.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **True** A converting constructor takes a type and uses it to create an object.  A converting constructor is called with direct initialization only; casts will not invoke converting constructors. By default, converting constructors are explicit for CLR types.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **5**  
**R** In this code sample, an implicit static conversion function does the same thing as an explicit conversion constructor.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Output**  
  
 **13**  
**12**  
**500**  
**2000**   
## See Also  
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)