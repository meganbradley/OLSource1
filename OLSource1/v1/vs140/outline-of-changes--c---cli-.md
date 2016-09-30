---
title: "Outline of Changes (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Outline of Changes (C++/CLI)"
dev_langs: 
  - "C++"
ms.assetid: c0bbbd6b-c5c4-44cf-a6ca-c1010c377e9d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Outline of Changes (C++-CLI)
This outline shows you examples of some of the changes in the language from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)]. Follow the link that accompanies each item for more information.  
  
## No Double Underscore Keywords  
 The double underscore in front of all keywords has been removed, with one exception. Thus, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> becomes <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> becomes <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and so on. To prevent name clashes between keywords and identifiers in user code, keywords are primarily treated as contextual.  
  
 See [Language Keywords](../vs140/language-keywords--c---cli-.md) for more information.  
  
## Class Declarations  
 Managed Extensions syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 New syntax:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 See [The Managed Types](../vs140/managed-types--c---cl-.md) for more information.  
  
## Object Declaration  
 Managed Extensions syntax:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New syntax:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 See [Declaration of a CLR Reference Class Object](../vs140/declaration-of-a-clr-reference-class-object.md) for more information.  
  
### Managed Heap Allocation  
 Managed Extensions syntax:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New syntax:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 See [Declaration of a CLR Reference Class Object](../vs140/declaration-of-a-clr-reference-class-object.md) for more information.  
  
### A Tracking Reference to No Object  
 Managed Extensions syntax:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 New syntax:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 See [Declaration of a CLR Reference Class Object](../vs140/declaration-of-a-clr-reference-class-object.md) for more information.  
  
## Array Declaration  
 The CLR array has been redesigned. It is similar to the stl <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> template collection, but maps to the underlying <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class – that is, it is not a template implementation.  
  
 See [Declaration of a CLR Array](../vs140/declaration-of-a-clr-array.md) for more information.  
  
### Array as Parameter  
 Managed Extensions array syntax:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 New array syntax:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Array as Return Type  
 Managed Extensions array syntax:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 New array syntax:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Shorthand Initialization of Local CLR Array  
 Managed Extensions array syntax:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 New array syntax:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Explicit CLR Array Declaration  
 Managed Extensions array syntax:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 New array syntax:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 New to language: explicit array initialization that follows gcnew  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Scalar Properties  
 Managed Extensions property syntax:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 New property syntax:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 New to language: trivial properties  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 See [Property Declaration](../vs140/property-declaration.md) for more information.  
  
## Indexed Properties  
 Managed Extensions indexed property syntax:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 New indexed property syntax:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 New to language: class-level indexed property  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 See [Property Index Declaration](../vs140/property-index-declaration.md) for more information.  
  
## Overloaded Operators  
 Managed Extensions operator overload syntax:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 New operator overload syntax:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 See [Overloaded Operators](../vs140/overloaded-operators.md) for more information.  
  
## Conversion Operators  
 Managed Extensions conversion operator syntax:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 New conversion operator syntax:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 See [Changes to Conversion Operators](../vs140/changes-to-conversion-operators.md) for more information.  
  
## Explicit Override of an Interface Member  
 Managed Extensions explicit override syntax:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 New explicit override syntax:  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 See [Explicit Override of an Interface Member](../vs140/explicit-override-of-an-interface-member.md) for more information.  
  
## Private Virtual Functions  
 Managed Extensions private virtual function syntax:  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 New private virtual function syntax  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 See [Private Virtual Functions](../vs140/private-virtual-functions.md) for more information.  
  
## CLR Enum Type  
 Managed Extensions enum syntax:  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 New enum syntax:  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Apart from this small syntactic change, the behavior of the CLR enum type has been changed in a number of ways:  
  
-   A forward declaration of a CLR enum is no longer supported.  
  
-   The overload resolution between the built-in arithmetic types and the Object class hierarchy has reversed between Managed Extensions and [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)]. As a side-effect, CLR enums are no longer implicitly converted to arithmetic types.  
  
-   In the new syntax, a CLR enum maintains its own scope, which is not the case in Managed Extensions. Previously, enumerators were visible within the containing scope of the enum; now, enumerators are encapsulated within the scope of the enum.  
  
 See [CLR Enum Type](../vs140/clr-enum-type.md) for more information.  
  
## Removal of __box Keyword  
 Managed Extensions boxing syntax:  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 New boxing syntax:  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 See [A Tracking Handle to a Boxed Value](../vs140/a-tracking-handle-to-a-boxed-value.md) for more information.  
  
## Pinning Pointer  
 Managed Extensions pinning pointer syntax:  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 New pinning pointer syntax:  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 See [Value Type Semantics](../vs140/value-type-semantics.md) for more information.  
  
## __typeof Keyword becomes typeid  
 Managed Extensions typeof syntax:  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 New typeid syntax:  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 See [typeof Goes to T::typeid](../vs140/typeof-goes-to-t--typeid.md) for more information.  
  
## See Also  
 [C++/CLI Migration Primer](../vs140/c---cli-migration-primer.md)   
 [(NOTINBUILD)Managed Extensions for C++ Syntax Upgrade Checklist](assetId:///edbded88-7ef3-4757-bd9d-b8f48ac2aada)   
 [New C++ Language Features](../vs140/component-extensions-for-runtime-platforms.md)