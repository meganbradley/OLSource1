---
title: "Generic Classes (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Generic Classes (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], generic"
  - "generic classes [C++], about generic classes"
  - "data types [C++], generic"
  - "generic classes"
  - "generics [C++], declaring generic classes"
ms.assetid: 0beb99e1-1ec4-4fee-9836-ce9657d67a3a
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic Classes (C++-CLI)
A generic class is declared using the following form:  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the above syntax, the following terms are used:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (optional)  
 Additional declarative information. For more information on attributes and attribute classes, see Attributes.  
  
 *class-key*  
 Either <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 *type-parameter-identifier(s)*,  
 Comma-separated list of identifiers specifying the names of the type parameters.  
  
 *constraint-clauses*  
 A list (not comma-separated) of **where** clauses specifying the constraints for the type parameters. Takes the form:  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  *type-parameter-identifier*  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  *constraint-list*  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 *constraint-list*  
 *class-or-interface*[<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> *...*]  
  
 *accessibility-modifiers*  
 Accessibility modifiers for the generic class. For the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)], the only allowed modifier is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For the common language runtime, the allowed modifiers are <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 *identifier*  
 The name of the generic class, any valid C++ identifier.  
  
 *modifiers* (optional)  
 Allowed modifiers include <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and **abstract**.  
  
 *base-list*  
 A list that contains the one base class and any implemented interfaces, all separated by commas.  
  
 *class-body*  
 The body of the class, containing fields, member functions, etc.  
  
 *declarators*  
 Declarations of any variables of this type. For example: <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>*identifier*[<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> ...]  
  
 You can declare generic classes such as these (note that the keyword **class** may be used instead of **typename**). In this example, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are unknown types that are specified at the point where the type. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a constructed type of the generic type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. A number of different constructed types can be constructed from a single generic type. Constructed types constructed from generic classes are treated like any other ref class type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Both value types (either built-in types such as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or user-defined value types) and reference types may be used as a generic type argument. The syntax within the generic definition is the same regardless. Syntactically, the unknown type is treated as if it were a reference type. However, the runtime is able to determine that if the type actually used is a value type and substitute the appropriate generated code for direct access to members. Value types used as generic type arguments are not boxed and so do not suffer the performance penalty associated with boxing. The syntax used within the body of the generic should be **T^** and '**->**' instead of '**.**'. Any use of [gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md) for the type parameter will be appropriately interpreted by the runtime as the simple creation of a value type if the type argument is a value type.  
  
 You can also declare a generic class with [Constraints](../vs140/constraints-on-generic-type-parameters--c---cli-.md) on the types that can be used for the type parameter. In the following example any type used for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> must implement the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> interface. Attempting to use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, for example, which does not implement <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, would produce a compile-time error because the type argument does not satisfy the constraint.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Generic classes in the same namespace cannot be overloaded by only changing the number or the types of type parameters. However, if each class lives in a different namespace, they can be overloaded. For example, consider the following two classes, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, in the namespaces <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. The two classes can then be overloaded in a third namespace C:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The base class and base interfaces cannot be type parameters. However, the base class can involve the type parameter as an argument, as in the following case:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Constructors and destructors are executed once for each object instance (as usual); static constructors are executed once for each constructed type.  
  
## Fields in Generic Classes  
 This section demonstrates the use of instance and static fields in generic classes.  
  
### Instance Variables  
 Instance variables of a generic class can have types and variable initializers that include any type parameters from the enclosing class.  
  
## Example  
 In the following example, three different instances of the generic class, MyClass\<ItemType>, are created by using the appropriate type arguments (<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, **double**, and **string**).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Integer field = 123**  
**Double field = 1.23**  
**String field = ABC**   
## Static Variables  
 On the creation of a new generic type, new instances of any static variables are created and any static constructor for that type is executed.  
  
 Static variables can use any type parameters from the enclosing class.  
  
## Example  
 The following example demonstrates using static fields and a static constructor within a generic class.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Static constructor called.**  
**Static constructor called.**  
**Static constructor called.**  
**Test1**   
## Methods in Generic Classes  
 Methods in generic classes can be generic themselves; non-generic methods will be implicitly parameterized by the class type parameter.  
  
 The following special rules apply to methods within generic classes:  
  
-   Methods in generic classes can use type parameters as parameters, return types, or local variables.  
  
-   Methods in generic classes can use open or closed constructed types as parameters, return types, or local variables.  
  
### Non-Generic Methods in Generic Classes  
 Methods in generic classes that have no additional type parameters are usually referred to as non-generic although they are implicitly parameterized by the enclosing generic class.  
  
 The signature of a non-generic method can include one or more type parameters of the enclosing class, either directly or in an open constructed type. For example:  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 The body of such methods can also use these type parameters.  
  
## Example  
 The following example declares a non-generic method, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, inside a generic class, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. The method uses the class type parameter <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> in its signature in an open constructed type.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Name: Jeff Smith**  
**Amount: $123.00\*\***   
## Generic Methods in Generic Classes  
 You can declare generic methods in both generic and non-generic classes. For example:  
  
## Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The non-generic method is still generic in the sense that it is parameterized by the class's type parameter, but it has no additional type parameters.  
  
 All types of methods in generic classes can be generic, including static, instance, and virtual methods.  
  
## Example  
 The following example demonstrates declaring and using generic methods within generic classes:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **MyMethod returned: 12**  
**MyMethod returned: Hello #1**  
**MyMethod returned: Hello World!**   
## Using Nested Types in Generic Classes  
 Just as with ordinary classes, you can declare other types inside a generic class. The nested class declaration is implicitly parameterized by the type parameters of the outer class declaration. Thus, a distinct nested class is defined for each constructed outer type. For example, in the declaration,  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type Outer\<int>::Inner is not the same as the type Outer\<double>::Inner.  
  
 As with generic methods in generic classes, additional type parameters can be defined for the nested type. If you use the same type parameter names in the inner and outer class, the inner type parameter will hide the outer type parameter.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Since there is no way to refer to the outer type parameter, the compiler will produce a warning in this situation.  
  
 When constructed nested generic types are named, the type parameter for the outer type is not included in the type parameter list for the inner type, even though the inner type is implicitly parameterized by the outer type's type parameter. In the above case, a name of a constructed type would be Outer\<int>::Inner\<string>.  
  
 The following example demonstrates building and reading a linked list using nested types in generic classes.  
  
## Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 **Building the list:**  
**0.1**  
**0.2**  
**0.3**  
**0.4**  
**0.5**  
**Reading nodes:**  
**0.5**  
**0.4**  
**0.3**  
**0.2**  
**0.1**   
## Properties, Events, Indexers and Operators in Generic Classes  
  
-   Properties, events, indexers and operators can use the type parameters of the enclosing generic class as return values, parameters, or local variables, such as when <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is a type parameter of a class:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   Properties, events, indexers and operators cannot themselves be parameterized.  
  
## Example  
 This example shows declarations of an instance property within a generic class.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 **John, 234**   
## Example  
 The next example shows a generic class with an event.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
## Generic Structs  
 The rules for declaring and using generic structs are the same as those for generic classes, except for the differences noted in in the Visual C++ language reference.  
  
## Example  
 The following example declares a generic struct, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, with one field, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and assigns values of different types (<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, **double**, **String^**) to this field.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 **The field is assigned the integer value: 123**  
**The field is assigned the double value: 0.123**  
**The field is assigned the string: Hello Generics!**   
## See Also  
 [Generics (C++)](../vs140/generics---c---component-extensions-.md)