---
title: "Run-Time Type Information"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "index-page "
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RTTI compiler option"
  - "run-time type information"
  - "run time, type checking"
  - "type information, run-time type checking"
  - "run-time checks, type checking"
ms.assetid: becbd0e5-0439-4c61-854f-8a74f7160c54
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run-Time Type Information
Run-time type information (RTTI) is a mechanism that allows the type of an object to be determined during program execution. RTTI was added to the C++ language because many vendors of class libraries were implementing this functionality themselves. This caused incompatibilities between libraries. Thus, it became obvious that support for run-time type information was needed at the language level.  
  
 For the sake of clarity, this discussion of RTTI is almost completely restricted to pointers. However, the concepts discussed also apply to references.  
  
 There are three main C++ language elements to run-time type information:  
  
-   The [dynamic_cast](../vs140/dynamic_cast-operator.md) operator.  
  
     Used for conversion of polymorphic types.  
  
-   The [typeid](../vs140/typeid-operator.md) operator.  
  
     Used for identifying the exact type of an object.  
  
-   The [type_info](../vs140/type_info-class.md) class.  
  
     Used to hold the type information returned by the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operator.  
  
## See Also  
 [Casting](../vs140/casting.md)