---
title: "Managed Types (C++-CL)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: Managed Types (C++/CL)
dev_langs: 
  - C++
helpviewer_keywords: 
  - __gc types
  - types [C++], CLR
ms.assetid: 1ddd114e-be02-4de7-a4dd-a2d72ad8ff81
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Managed Types (C++-CL)
The syntax for the declaration of managed types and the creation and use of objects of these types has been significantly altered from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)]. This was done to promote their integration within the ISO-C++ type system. These changes are presented in detail in the following subsections.  
  
## In This Section  
 [Declaration of a Managed Class Type](../vs140/declaration-of-a-managed-class-type.md)  
 Discusses how to declare a managed `class`, `struct`, or `interface`.  
  
 [Declaration of a CLR Reference Class Object](../vs140/declaration-of-a-clr-reference-class-object.md)  
 Discusses how to declare a reference class type object using a tracking handle.  
  
 [Declaration of a CLR Array](../vs140/declaration-of-a-clr-array.md)  
 Explains how to declare and initialize an array.  
  
 [Changes in Constructor Initialization Order](../vs140/changes-in-constructor-initialization-order.md)  
 Discusses key changes in class constructor initialization order.  
  
 [Changes in Destructor Semantics](../vs140/changes-in-destructor-semantics.md)  
 Discusses non-deterministic finalization, `Finalize` versus `Dispose`, ramifications for reference objects, and use of an explicit `Finalize`.  
  
 **Note:** The discussion of delegates is deferred until [Delegates and Events](../vs140/delegates-and-events.md) in order to present them with event members within a class, the general topic of [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md).  
  
## See Also  
 [C++/CLI Migration Primer](../vs140/c---cli-migration-primer.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)   
 [array](../vs140/arrays--c---component-extensions-.md)