---
title: "Member Declarations within a Class or Interface (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: Member Declarations within a Class or Interface (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - members, declaration syntax
  - class members, declaration syntax
ms.assetid: 95d312a4-198b-46f0-b8f5-15253807c55e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Member Declarations within a Class or Interface (C++-CLI)
The declaration of properties and operators has been extensively reworked from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)], hiding the underlying implementation details that were exposed in the Managed Extensions design. Event declarations have been modified as well.  
  
 Under the category of changes that have no Managed Extensions support, static constructors can now be defined out-of-line (they were required to be defined inline within Managed Extensions), and the notion of a delegating constructor has been introduced.  
  
## In This Section  
 [Property Declaration](../vs140/property-declaration.md)  
 Discusses changes to property declarations.  
  
 [Property Index Declaration](../vs140/property-index-declaration.md)  
 Discusses changes to indexed property declarations.  
  
 [Delegates and Events](../vs140/delegates-and-events.md)  
 Discusses changes to the syntax for declaring delegates and events.  
  
 [Sealing a Virtual Function](../vs140/sealing-a-virtual-function.md)  
 Discusses changes to the syntax for sealing a function.  
  
 [Overloaded Operators](../vs140/overloaded-operators.md)  
 Discusses changes to operator overloading.  
  
 [Changes to Conversion Operators](../vs140/changes-to-conversion-operators.md)  
 Discusses changes to conversion operators.  
  
 [Explicit Override of an Interface Member](../vs140/explicit-override-of-an-interface-member.md)  
 Discusses changes to the method for explicitly overriding an interface member.  
  
 [Private Virtual Functions](../vs140/private-virtual-functions.md)  
 Discusses changes in the way private virtual functions are handled in derived classes.  
  
 [Static Const Int Linkage Is No Longer Literal](../vs140/static-const-int-linkage-is-no-longer-literal.md)  
 Discusses changes in the way `static const` integral members are linked and how to explicitly declare a constant using the new `literal` keyword.  
  
## See Also  
 [C++/CLI Migration Primer](../vs140/c---cli-migration-primer.md)