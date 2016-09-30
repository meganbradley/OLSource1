---
title: "property  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "property_cpp"
  - "property"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property keyword [C++]"
ms.assetid: cc79d2b2-f013-4d81-8252-eece97a18704
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# property  (C++ Component Extensions)
Declares a *property*, which is a member function that behaves and is accessed like a data member or an array element.  
  
## All Runtimes  
 You can declare one of the following types of properties.  
  
 *simple property*  
 By default, creates a *set accessor* that assigns the property value, a *get accessor* that retrieves the property value, and a compiler-generated private data member that contains the property value.  
  
 *property block*  
 Use this to create user-defined get and/or set accessors. The property is read/write if both the get and set accessors are defined, read-only if only the get accessor is defined, and write-only if only the set accessor is defined.  
  
 You must explicitly declare a data member to contain the property value.  
  
 *indexed property*  
 A property block that you can use to get and set a property value that is specified by one or more indexes.  
  
 You can create an indexed property that has either a user-defined property name or a *default* property name. The name of a default index property is the name of the class in which the property is defined. To declare a default property, specify the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword instead of a property name.  
  
 You must explicitly declare a data member to contain the property value. For an indexed property, the data member is typically an array or a collection.  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The data type of the property value, and consequently the property itself.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The name of the property.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An access qualifier. Valid qualifiers are <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The get or set accessors need not agree on the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> qualifier, but they must agree on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> qualifier.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An inheritance qualifier. Valid qualifiers are <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A comma-delimited list of one or more indexes. Each index consists of an index type, and an optional identifier that can be used in the property method body.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The value to assign to the property in a set operation, or retrieve in a get operation.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The property method body of the set or get accessor. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to access the underlying property data member, or as parameters in user-defined processing.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 For more information, see [Properties (C++/CX)](http://msdn.microsoft.com/library/windows/apps/hh755807.aspx).  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Syntax**  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *modifier*  
 A modifier that can be used on either a property declaration or a get/set accessor method. Possible values are <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 *type*  
 The type of the value that is represented by the property.  
  
 *property_name*  
 Parameter(s) for the raise method; must match the signature of the delegate.  
  
 *index_list*  
 A comma-delimited list of one or more indexes, specified in square brackets (the subscript operator, ([])). For each index, specify a type and optionally an identifier that can be used in the property method body.  
  
 **Remarks**  
  
 The first syntax example shows a *simple property*, which implicitly declares both a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method. The compiler automatically creates a private field to store the value of the property.  
  
 The second syntax example shows a *property block*, which explicitly declares both a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method.  
  
 The third syntax example shows a customer-defined *index property*. An index property takes parameters in addition to the value to be set or retrieved. You must specify a name for the property. Unlike a simple property, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and/or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> methods of an index property must be explicitly defined, and you must specify a name for the property.  
  
 The fourth syntax example shows a *default* property, which provides array-like access to an instance of the type. The keyword, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, serves only to specify a default property. The name of the default property is the name of the type in which the property is defined.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keyword can appear in a class, interface, or value type. A property can have a get function (read-only), a set function (write-only), or both (read-write).  
  
 A property name cannot match the name of the managed class that contains it. The return type of the getter function must match the type of the last parameter of a corresponding setter function.  
  
 To client code, a property has the appearance of an ordinary data member, and can be written to or read from by using the same syntax as a data member.  
  
 The get and set methods need not agree on the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> modifier.  
  
 The accessibility of the get and set method can differ.  
  
 The definition of a property method can appear outside the class body, just like an ordinary method.  
  
 The get and the set method for a property shall agree on the **static** modifier.  
  
 A property is scalar if its get and set methods fit the following description:  
  
-   The get method has no parameters, and has return type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
-   The set method has a parameter of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and return type **void**.  
  
 There shall be only one scalar property declared in a scope with the same identifier. Scalar properties cannot be overloaded.  
  
 When a property data member is declared, the compiler injects a data member—sometimes referred to as the "backing store"—in the class. However, the name of the data member is of a form such that you cannot reference the member in the source as if it were an actual data member of the containing class. Use ildasm.exe to view the metadata for your type and see the compiler-generated name for the property's backing store.  
  
 Different accessibility is allowed for the accessor methods in a property block.  That is, the set method can be public and the get method can be private.  However, it is an error for an accessor method to have a less restrictive accessibility than what is on the declaration of the property itself.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a context-sensitive keyword.  For more information, see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md).  
  
 For more information about properties, see  
  
-   [Indexed Properties](../vs140/how-to--use-indexed-properties.md)  
  
-   [Static Properties](../vs140/how-to--declare-and-use-static-properties.md)  
  
-   [Virtual Properties](../vs140/how-to--declare-and-use-virtual-properties.md)  
  
-   [Multidimensional Properties](../vs140/how-to--use-multidimensional-properties.md)  
  
-   [Overloading Property Accessor Methods](../vs140/how-to--overload-property-accessor-methods.md)  
  
-   [How to: Declare Abstract and Sealed Properties](../vs140/how-to--declare-abstract-and-sealed-properties.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 The following example shows the declaration and use of a property data member and a property block.  It also shows that a property accessor can be defined out of class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **test**   
 **21**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)