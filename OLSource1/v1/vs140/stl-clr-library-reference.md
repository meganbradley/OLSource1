---
title: "STL-CLR Library Reference"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: STL/CLR Library Reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - STL/CLR Library
  - STL/CLR, redistribution
  - cliext directory
ms.assetid: a9d9ca00-7bf2-48c1-b205-3ae6f8c25f82
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# STL-CLR Library Reference
The STL/CLR Library is a packaging of the Standard Template Library (STL), a subset of the Standard C++ Library, for use with C++ and the .NET Framework common language runtime (CLR). With STL/CLR, you can use all the containers, iterators, and algorithms of STL in a managed environment.  
  
 To use STL/CLR:  
  
-   Include headers from the **cliext** include subdirectory instead of the usual Standard C++ Library equivalents.  
  
-   Qualify library names with `cliext::` instead of `std::`.  
  
 STL/CLR exposes the generic types and interfaces that it uses in cross-assembly scenarios in the .NET assembly **Microsoft.VisualC.STLCLR.dll**. This DLL is included in .NET Framework 3.5. If you redistribute an application that uses STL/CLR, you will need to include the .NET Framework 3.5, as well as any other Visual C++ libraries that your project uses, in the dependencies section of your setup project.  
  
## In This Section  
 [cliext Namespace](../vs140/cliext-namespace.md)  
 Discusses the namespace that contains all the types of the STL/CLR Library.  
  
 [STL/CLR Containers](../vs140/stl-clr-containers.md)  
 Provides an overview of the containers that are found in the Standard C++ Library, including requirements for container elements, types of elements that can be inserted, and ownership issues.  
  
 [Requirements for STL and STL/CLR Container Elements](../vs140/requirements-for-stl-clr-container-elements.md)  
 Describes minimum requirements for all reference types that are inserted into STL containers.  
  
 [How to: Convert from a .NET Collection to a STL/CLR Container](../vs140/how-to--convert-from-a-.net-collection-to-a-stl-clr-container.md)  
 Describes how to convert a .NET collection to an STL/CLR container.  
  
 [How to: Convert from a STL/CLR Container to a .NET Collection](../vs140/how-to--convert-from-a-stl-clr-container-to-a-.net-collection.md)  
 Describes how to convert an STL/CLR container to a .NET collection.  
  
 [How to: Expose an STL/CLR Container from an Assembly](../vs140/how-to--expose-an-stl-clr-container-from-an-assembly.md)  
 Shows how to display the elements of several STL/CLR containers written in a C++ assembly.  
  
 In addition, this section also describes the following components of STL/CLR:  
  
|||  
|-|-|  
|[adapter (STL/CLR)](../vs140/adapter--stl-clr-.md)|[algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)|  
|[deque (STL/CLR)](../vs140/deque--stl-clr-.md)|[for each, in](../vs140/for-each--in.md)|  
|[functional (STL/CLR)](../vs140/functional--stl-clr-.md)|[hash_map (STL/CLR)](../vs140/hash_map--stl-clr-.md)|  
|[hash_multimap (STL/CLR)](../vs140/hash_multimap--stl-clr-.md)|[hash_multiset (STL/CLR)](../vs140/hash_multiset--stl-clr-.md)|  
|[hash_set (STL/CLR)](../vs140/hash_set--stl-clr-.md)|[list (STL/CLR)](../vs140/list--stl-clr-.md)|  
|[map (STL/CLR)](../vs140/map--stl-clr-.md)|[multimap (STL/CLR)](../vs140/multimap--stl-clr-.md)|  
|[multiset (STL/CLR)](../vs140/multiset--stl-clr-.md)|[numeric (STL/CLR)](../vs140/numeric--stl-clr-.md)|  
|[priority_queue (STL/CLR)](../vs140/priority_queue--stl-clr-.md)|[queue (STL/CLR)](../vs140/queue--stl-clr-.md)|  
|[set (STL/CLR)](../vs140/set--stl-clr-.md)|[stack (STL/CLR)](../vs140/stack--stl-clr-.md)|  
|[utility (STL/CLR)](../vs140/utility--stl-clr-.md)|[vector (STL/CLR)](../vs140/vector--stl-clr-.md)|  
  
## See Also  
 [Standard C++ Library Reference](../vs140/c---standard-library-reference.md)