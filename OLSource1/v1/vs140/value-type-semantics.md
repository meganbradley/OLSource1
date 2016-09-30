---
title: "Value Type Semantics"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interior_ptr keyword [C++]"
  - "virtual functions, value types"
  - "inheritance, value types"
  - "pinning pointers"
  - "pin_ptr keyword [C++]"
  - "__pin keyword"
ms.assetid: 7f065589-ad25-4850-baf1-985142e35e52
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value Type Semantics
Value type semantics have changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 Here is the canonical simple value type used in the Managed Extensions for C++ spec:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In Managed Extensions, we can have four syntactic variants of a value type (where forms 2 and 3 are the same semantically):  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Invoking Inherited Virtual Methods  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the canonical value object, and it is reasonably well understood, except when someone attempts to invoke an inherited virtual method such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In order to invoke this method, because it is not overridden in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the compiler must have access to the associated virtual table of the base class. Because value types are in-state storage without the associated pointer to its virtual table (vptr), this requires that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> be boxed. In the Managed Extensions language design, implicit boxing is not supported but must be explicitly specified by the programmer, as in  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The primary motive behind this design is pedagogical: underlying mechanism needs to be visible to the programmer so that she will understand the 'cost' of not providing an instance within her value type. Were <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to contain an instance of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the boxing would not be necessary.  
  
 The lexical complexity of explicitly boxing the object, but not the underlying cost of the boxing itself, is removed in the new syntax:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 but at the cost of possibly misleading the class designer as to the cost of not having provided an explicit instance of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method within <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The reason for preferring the implicit boxing is that while there is usually just one class designer, there are an unlimited number of users, none of whom would have the freedom to modify <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to eliminate the possibly onerous explicit box.  
  
 The criteria by which to determine whether or not to provide an overriding instance of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> within a value class should be the frequency and location of its uses. If it is called very rarely, there is of course little benefit in its definition. Similarly, if it is called in non-performant areas of the application, adding it will also not measurably add to the general performance of the application. Alternatively, one can keep a tracking handle to the boxed value, and calls through that handle would not require boxing.  
  
## There is No Longer a Value Class Default Constructor  
 Another difference with a value type between Managed Extensions and the new syntax is the removal of support for a default constructor. This is because there are occasions during execution in which the CLR can create an instance of the value type without invoking the associated default constructor. That is, the attempt under Managed Extensions to support a default constructor within a value type could not in practice be guaranteed. Given that absence of guarantee, it was felt to be better to drop the support altogether rather than have it be non-deterministic in its application.  
  
 This is not as bad as it might initially seem. This is because each object of a value type is zeroed out automatically (that is, each type is initialized to its default value). As a result, the members of a local instance are never undefined. In this sense, the loss of the ability to define a trivial default constructor is really not a loss at all – and in fact is more efficient when performed by the CLR.  
  
 The problem is when a user of Managed Extensions defines a non-trivial default constructor. This has no mapping to the new syntax. The code within the constructor will need to be migrated into a named initialization method that would then need to be explicitly invoked by the user.  
  
 The declaration of a value type object within the new syntax is otherwise unchanged. The down side of this is that value types are not satisfactory for the wrapping of native types for the following reasons:  
  
-   There is no support for a destructor within a value type. That is, there is no way to automate a set of actions triggered by the end of an object's lifetime.  
  
-   A native class can be contained only within a managed type as a pointer which is then allocated on the native heap.  
  
 We would like to wrap a small native class in a value type rather than a reference type to avoid a double heap allocation: the native heap to hold the native type, and the CLR heap to hold the managed wrapper. Wrapping a native class within a value type allows you to avoid the managed heap, but provides no way to automate the reclamation of the native heap memory. Reference types are the only practicable managed type within which to wrap non-trivial native classes.  
  
## Interior Pointers  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> above can address nearly anything in this world or the next (that is, anything managed or native). So, for example, all the following are permitted in Managed Extensions:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 So, a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> can address a location within a local block (and therefore can be dangling), at global scope, within the native heap (for example, if the object it addresses has already been deleted), within the CLR heap (and therefore will be tracked if it should be relocated during garbage collection), and within the interior of a reference object on the CLR heap (an interior pointer, as this is called, is also transparently tracked).  
  
 In Managed Extensions, there is no way to separate out the native aspects of a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; that is, it is treated at its inclusive, which handles the possibility of it addressing an object or subobject on the managed heap.  
  
 In the new syntax, a value type pointer is factored into two types: <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, which is limited to non-CLR heap locations, and the interior pointer, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, which allows for but does not require an address within the managed heap.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> of Managed Extensions map into <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a tracking handle. It addresses the whole object that has been boxed within the managed heap. It is translated in the new syntax into a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>,  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The following declarations in Managed Extensions all map to interior pointers in the new syntax. (They are value types within the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> namespace.)  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The built-in types are not considered managed types, although they do serve as aliases to the types within the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> namespace. Thus the following mappings hold true between Managed Extensions and the new syntax:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 When translating a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> in your existing program, the most conservative strategy is to always turn it to an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. This is how it was treated under Managed Extensions. In the new syntax, the programmer has the option of restricting a value type to non-managed heap addresses by specifying <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> rather than an interior pointer. If, on translating your program, you can do a transitive closure of all its uses and be sure that no assigned address is within the managed heap, then leaving it as <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is fine.  
  
## Pinning Pointers  
 The garbage collector may optionally move objects that reside on the CLR heap to different locations within the heap, usually during a compaction phase. This movement is not a problem to tracking handles, tracking references, and interior pointers which update these entities transparently. This movement is a problem, however, if the user has passed the address of an object on the CLR heap outside of the runtime environment. In this case, the volatile movement of the object is likely to cause a runtime failure. To exempt objects such as these from being moved, we must locally pin them to their location for the extent of their outside use.  
  
 In Managed Extensions, a *pinning pointer* is declared by qualifying a pointer declaration with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> keyword. Here is an example slightly modified from the Managed Extensions specification:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 In the new language design, a pinning pointer is declared with syntax analogous to that of an interior pointer.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pinning pointer under the new syntax is a special case of an interior pointer. The original constraints on a pinning pointer remain. For example, it cannot be used as a parameter or return type of a method; it can be declared only on a local object. A number of additional constraints, however, have been added in the new syntax.  
  
 The default value of a pinning pointer is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> cannot be initialized or assigned <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. All assignments of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> in existing code will need to be changed to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 A pinning pointer under Managed Extensions was permitted to address a whole object, as in the following example taken from the Managed Extensions specification:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 In the new syntax, pinning the whole object returned by the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> expression is not supported. Rather, the address of the interior member needs to be pinned. For example,  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Value Types and Their Behaviors](../vs140/value-types-and-their-behaviors--c---cli-.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)   
 [interior_ptr](../vs140/interior_ptr--c---cli-.md)   
 [pin_ptr](../vs140/pin_ptr--c---cli-.md)