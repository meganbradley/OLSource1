---
title: "Declaration of a CLR Reference Class Object"
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
  - "types [C++], reference types"
  - "reference types, CLR"
ms.assetid: 6d64f746-3715-4948-ada3-88859f4150e4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaration of a CLR Reference Class Object
The syntax to declare and instantiate an object of a reference class type has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In Managed Extensions, a reference class type object is declared by using the ISO-C++ pointer syntax, with an optional use of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword to the left of the star (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>). For example, here are a variety of reference class type object declarations under the Managed Extensions syntax:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Under the new syntax, you declare a reference class type object by using a new declarative token (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) referred to formally as a *tracking handle* and more informally as a *hat*. (The tracking adjective means that a reference type sits in the CLR heap, and can therefore transparently move locations during garbage collection heap compaction. A tracking handle is transparently updated during runtime. Two similar concepts are the *tracking reference* (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), and the *interior pointer* (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>), discussed in [Value Type Semantics](../vs140/value-type-semantics.md).  
  
 The primary reasons to move the declarative syntax away from a reuse of the ISO-C++ pointer syntax are as follows:  
  
-   The use of the pointer syntax did not permit overloaded operators to be directly applied to a reference object. Rather, one had to call the operator by using its internal name, such as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> instead of  the more intuitive <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
-   A number of pointer operations, such as casting and pointer arithmetic, not permitted for objects stored on a garbage collected heap. The notion of a tracking handle better captures the nature of a CLR reference type.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> modifier on a tracking handle is unnecessary and is not supported. The use of the object itself is not changed; it still accesses members through the pointer member selection operator (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>). For example, here is the previous Managed Extensions code sample translated into the new syntax:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Dynamic Allocation of an Object on the CLR Heap  
 In Managed Extensions, the existence of two <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> expressions to allocate between the native and managed heap was largely transparent. In almost all instances, the compiler is able to use the context to determine whether to allocate memory from the native or managed heap. For example,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When you do not want the contextual heap allocation, you could direct the compiler with either the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keyword. In the new syntax, the separate nature of the two new expressions is made explicit with the introduction of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword. For example, the previous three declarations look as follows in the new syntax:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Here is the Managed Extensions initialization of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> members declared in the previous section:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Here is the same initialization recast to the new syntax. Note that the hat is not required for the reference type when it is the target of a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> expression.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## A Tracking Reference to No Object  
 In the new syntax, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> no longer represents a null address but is treated as an integer, the same as <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. A new special token represents a null value for a tracking reference. For example, in Managed Extensions, we initialize a reference type to address no object as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 In the new syntax, any initialization or assignment of a value type to an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> causes an implicit boxing of that value type. In the new syntax, both <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are initialized to addressed boxed Int32 objects holding the values 0 and 1, respectively. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Therefore, in order to perform the explicit initialization, assignment, and comparison of a tracking handle to null, use a new keyword, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  The correct revision of the original example looks as follows:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This complicates somewhat the porting of existing code into the new syntax. For example, consider the following value class declaration:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Here, both <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> are CLR reference types. The initialization of these two members to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> in the constructor cannot remain unchanged in the transition to the new syntax. Rather, they must be changed to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Similarly, tests against those members comparing them to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> must also be changed to compare the members to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Here is the Managed Extensions syntax:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Here is the revision, replacing each <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> instance with a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. The translation tool helps in this transformation by automating many if not all occurrences, including use of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> macro.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is converted into any pointer or tracking handle type but is not promoted to an integral type. For example, in the following set of initializations, the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is valid only as an initial value to the first two.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Similarly, given an overloaded set of methods such as the following:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An invocation with <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> literal, such as the following,  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 is ambiguous because the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> matches both a tracking handle and a pointer, and there is no preference given to one type over the other. (This situation requires an explicit cast in order to disambiguate.)  
  
 An invocation with <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> exactly matches instance (3):  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 because <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is of type integer. Were <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> not present, the call would unambiguously match <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> through a standard conversion. The matching rules give precedence of an exact match over a standard conversion. In the absence of an exact match, a standard conversion is given precedence over an implicit boxing of a value type. That is why there is no ambiguity.  
  
## See Also  
 [The Managed Types](../vs140/managed-types--c---cl-.md)   
 [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)   
 [^ (Handle to Object on Managed Heap)](../vs140/handle-to-object-operator--^----c---component-extensions-.md)   
 [nullptr](../vs140/nullptr---c---component-extensions-.md)