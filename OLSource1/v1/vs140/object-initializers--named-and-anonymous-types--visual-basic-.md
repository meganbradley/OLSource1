---
title: "Object Initializers: Named and Anonymous Types (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ObjectInitializer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "object initializers [Visual Basic]"
  - "anonymous types [Visual Basic], object initializers"
  - "initializing properties [Visual Basic]"
  - "initializers [Visual Basic]"
  - "named types [Visual Basic]"
ms.assetid: e2df3807-a70f-49dd-ac94-f1e07f472b1b
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object Initializers: Named and Anonymous Types (Visual Basic)
Object initializers enable you to specify properties for a complex object by using a single expression. They can be used to create instances of named types and of anonymous types.  
  
## Declarations  
 Declarations of instances of named and anonymous types can look almost identical, but their effects are not the same. Each category has abilities and restrictions of its own. The following example shows a convenient way to declare and initialize an instance of a named class, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, by using an object initializer list. Notice that the name of the class is specified after the keyword <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrObjectInit#1](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_1.vb)]  
  
 An anonymous type has no usable name. Therefore an instantiation of an anonymous type cannot include a class name.  
  
 [!code[VbVbalrObjectInit#2](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_2.vb)]  
  
 The requirements and results of the two declarations are not the same. For <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class that has a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property must already exist, and the declaration creates an instance of that class. For <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the compiler defines a new class that has one property, a string called <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and creates a new instance of that class.  
  
## Named Types  
 Object initializers provide a simple way to call the constructor of a type and then set the values of some or all properties in a single statement. The compiler invokes the appropriate constructor for the statement: the default constructor if no arguments are presented, or a parameterized constructor if one or more arguments are sent. After that, the specified properties are initialized in the order in which they are presented in the initializer list.  
  
 Each initialization in the initializer list consists of the assignment of an initial value to a member of the class. The names and data types of the members are determined when the class is defined. In the following examples, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class must exist, and must have members named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that can accept string values.  
  
 [!code[VbVbalrObjectInit#3](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_3.vb)]  
  
 Alternatively, you can obtain the same result by using the following code:  
  
 [!code[VbVbalrObjectInit#4](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_4.vb)]  
  
 Each of these declarations is equivalent to the following example, which creates a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object by using the default constructor, and then specifies initial values for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> properties by using a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement.  
  
 [!code[VbVbalrObjectInit#5](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_5.vb)]  
  
 If the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class contains a parameterized constructor that enables you to send in a value for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, for example, you can also declare and initialize a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object in the following ways:  
  
 [!code[VbVbalrObjectInit#6](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_6.vb)]  
  
 You do not have to initialize all properties, as the following code shows.  
  
 [!code[VbVbalrObjectInit#7](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_7.vb)]  
  
 However, the initialization list cannot be empty. Uninitialized properties retain their default values.  
  
### Type Inference with Named Types  
 You can shorten the code for the declaration of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> by combining object initializers and local type inference. This enables you to omit the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause in the variable declaration. The data type of the variable is inferred from the type of the object that is created by the assignment. In the following example, the type of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrObjectInit#8](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_8.vb)]  
  
### Remarks About Named Types  
  
-   A class member cannot be initialized more than one time in the object initializer list. The declaration of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> causes an error.  
  
     [!code[VbVbalrObjectInit#9](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_9.vb)]  
  
-   A member can be used to initialize itself or another field. If a member is accessed before it has been initialized, as in the following declaration for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the default value will be used. Remember that when a declaration that uses an object initializer is processed, the first thing that happens is that the appropriate constructor is invoked. After that, the individual fields in the initializer list are initialized. In the following examples, the default value for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is assigned for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and an initialized value is assigned in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrObjectInit#10](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_10.vb)]  
  
     The following example uses the parameterized constructor from <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to declare and initialize <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrObjectInit#11](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_11.vb)]  
  
-   Object initializers can be nested. In the following example, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a class that has two properties, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class has an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> property that is an instance of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
     [!code[VbVbalrObjectInit#12](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_12.vb)]  
  
-   The initialization list cannot be empty.  
  
-   The instance being initialized cannot be of type Object.  
  
-   Class members being initialized cannot be shared members, read-only members, constants, or method calls.  
  
-   Class members being initialized cannot be indexed or qualified. The following examples raise compiler errors:  
  
     <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
## Anonymous Types  
 Anonymous types use object initializers to create instances of new types that you do not explicitly define and name. Instead, the compiler generates a type according to the properties you designate in the object initializer list. Because the name of the type is not specified, it is referred to as an *anonymous type*. For example, compare the following declaration to the earlier one for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrObjectInit#13](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_13.vb)]  
  
 The only difference syntactically is that no name is specified after <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> for the data type. However, what happens is quite different. The compiler defines a new anonymous type that has two properties, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and creates an instance of it with the specified values. Type inference determines the types of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> in the example to be strings.  
  
> [!CAUTION]
>  The name of the anonymous type is generated by the compiler, and may vary from compilation to compilation. Your code should not use or rely on the name of an anonymous type.  
  
 Because the name of the type is not available, you cannot use an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> clause to declare <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. Its type must be inferred. Without using late binding, this limits the use of anonymous types to local variables.  
  
 Anonymous types provide critical support for [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries. For more information about the use of anonymous types in queries, see [Anonymous Types](../vs140/anonymous-types--visual-basic-.md) and [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md).  
  
### Remarks About Anonymous Types  
  
-   Typically, all or most of the properties in an anonymous type declaration will be key properties, which are indicated by typing the keyword <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> in front of the property name.  
  
     [!code[VbVbalrObjectInit#14](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_14.vb)]  
  
     For more information about key properties, see [Key](../vs140/key--visual-basic-.md).  
  
-   Like named types, initializer lists for anonymous type definitions must declare at least one property.  
  
     [!code[VbVbalrObjectInit#2](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_2.vb)]  
  
-   When an instance of an anonymous type is declared, the compiler generates a matching anonymous type definition. The names and data types of the properties are taken from the instance declaration, and are included by the compiler in the definition. The properties are not named and defined in advance, as they would be for a named type. Their types are inferred. You cannot specify the data types of the properties by using an <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> clause.  
  
-   Anonymous types can also establish the names and values of their properties in several other ways. For example, an anonymous type property can take both the name and the value of a variable, or the name and value of a property of another object.  
  
     [!code[VbVbalrObjectInit#15](../vs140/codesnippet/VisualBasic/object-initializers--named-and-anonymous-types--visual-basic-_15.vb)]  
  
     For more information about the options for defining properties in anonymous types, see [How to: Infer Property Names and Types in Anonymous Types](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md).  
  
## See Also  
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Anonymous types](../vs140/anonymous-types--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [How to: Infer Property Names and Types in Anonymous Types](../vs140/how-to--infer-property-names-and-types-in-anonymous-type-declarations--visual-basic-.md)   
 [Key](../vs140/key--visual-basic-.md)   
 [How to: Declare an Object by Using an Object Initializer](../vs140/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-.md)