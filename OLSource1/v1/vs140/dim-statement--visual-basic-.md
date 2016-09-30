---
title: "Dim Statement (Visual Basic)"
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
  - "vb.Dim"
  - "Dim"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Public keyword, in Dim statement"
  - "Dim statement"
  - "fixed-length strings, declaring"
  - "variables [Visual Basic], declaring"
  - "WithEvents keyword, Dim statement"
  - "dynamic arrays, Dim statement"
  - "variables [Visual Basic], initializing"
  - "{} braces"
  - "fields, as member variables"
  - "declarations, dynamic arrays"
  - "member variables"
  - "default values"
  - "data types [Visual Basic], assigning"
  - "braces {}"
  - "As keyword, in Dim statement"
  - "arrays [Visual Basic], declaring"
  - "New keyword, Dim statement"
  - "To keyword, in Dim statement"
  - "storage, allocating"
  - "local variables"
  - "declaration statements"
  - "Dim statement, syntax"
  - "variables [Visual Basic], member and local"
ms.assetid: fae3eca1-f0b2-4400-994b-7aa58a848448
caps.latest.revision: 76
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dim Statement (Visual Basic)
Declares and allocates storage space for one or more variables.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     Optional. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
    -   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
     Optional. See [Shared](../vs140/shared--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
     Optional. See [Static](../vs140/static--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
     Optional. See [ReadOnly](../vs140/readonly--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     Optional. Specifies that these are object variables that refer to instances of a class that can raise events. See [WithEvents](../vs140/withevents--visual-basic-.md).  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
     Required. List of variables being declared in this statement.  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
     Each <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> has the following syntax and parts:  
  
     <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>{<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
    |||  
    |-|-|  
    |Part|Description|  
    |<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Required. Name of the variable. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
    |<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Optional. List of bounds of each dimension of an array variable.|  
    |<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Optional. Creates a new instance of the class when the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement runs.|  
    |<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Optional. Data type of the variable.|  
    |<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Optional. Introduces the object initializer list.|  
    |<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional. The name of a property in the class you are making an instance of.|  
    |<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Required after <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> =. The expression that is evaluated and assigned to the property name.|  
    |<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional if <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is not specified. Expression that is evaluated and assigned to the variable when it is created.|  
  
## Remarks  
 The Visual Basic compiler uses the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statement to determine the variable's data type and other information, such as what code can access the variable. The following example declares a variable to hold an <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can specify any data type or the name of an enumeration, structure, class, or interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For a reference type, you use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> keyword to create a new instance of the class or structure that is specified by the data type. If you use <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, you do not use an initializer expression. Instead, you supply arguments, if they are required, to the constructor of the class from which you are creating the variable.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can declare a variable in a procedure, block, class, structure, or module. You cannot declare a variable in a source file, namespace, or interface. For more information, see [Declaration Contexts and Default Access Levels (Visual Basic)](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 A variable that is declared at module level, outside any procedure, is a *member variable* or *field*. Member variables are in scope throughout their class, structure, or module. A variable that is declared at procedure level is a *local variable*. Local variables are in scope only within their procedure or block.  
  
 The following access modifiers are used to declare variables outside a procedure: <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> keyword is optional and usually omitted if you specify any of the following modifiers: <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is on (the default), the compiler requires a declaration for every variable you use. For more information, see [Option Explicit Statement (Visual Basic)](../vs140/option-explicit-statement--visual-basic-.md).  
  
## Specifying an Initial Value  
 You can assign a value to a variable when it is created. For a value type, you use an *initializer* to supply an expression to be assigned to the variable. The expression must evaluate to a constant that can be calculated at compile time.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If an initializer is specified and a data type is not specified in an <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> clause, *type inference* is used to infer the data type from the initializer. In the following example, both <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> are strongly typed as integers. In the second declaration, type inference infers the type from the value 3.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type inference applies at the procedure level. It does not apply outside a procedure in a class, structure, module, or interface. For more information about type inference, see [Option Infer Statement](../vs140/option-infer-statement.md) and [Local Type Inference (Visual Basic)](../vs140/local-type-inference--visual-basic-.md).  
  
 For information about what happens when a data type or initializer is not specified, see [Default Data Types and Values](../vs140/dim-statement--visual-basic-.md#default) later in this topic.  
  
 You can use an *object initializer* to declare instances of named and anonymous types. The following code creates an instance of a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> class and uses an object initializer to initialize properties.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For more information about object initializers, see [How to: Declare an Object by Using an Object Initializer (Visual Basic)](../vs140/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-.md), [Object Initializers: Named and Anonymous Types](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md), and [Anonymous Types](../vs140/anonymous-types--visual-basic-.md).  
  
## Declaring Multiple Variables  
 You can declare several variables in one declaration statement, specifying the variable name for each one, and following each array name with parentheses. Multiple variables are separated by commas.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 If you declare more than one variable with one <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> clause, you cannot supply an initializer for that group of variables.  
  
 You can specify different data types for different variables by using a separate <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> clause for each variable you declare. Each variable takes the data type specified in the first <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> clause encountered after its <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> part.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Arrays  
 You can declare a variable to hold an *array*, which can hold multiple values. To specify that a variable holds an array, follow its <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> immediately with parentheses. For more information about arrays, see [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
 You can specify the lower and upper bound of each dimension of an array. To do this, include a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> inside the parentheses. For each dimension, the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> specifies the upper bound and optionally the lower bound. The lower bound is always zero, whether you specify it or not. Each index can vary from zero through its upper bound value.  
  
 The following two statements are equivalent. Each statement declares an array of 21 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> elements. When you access the array, the index can vary from 0 through 20.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The following statement declares a two-dimensional array of type <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The array has 4 rows (3 + 1) of 6 columns (5 + 1) each. Note that an upper bound represents the highest possible value for the index, not the length of the dimension. The length of the dimension is the upper bound plus one.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An array can have from 1 to 32 dimensions.  
  
 You can leave all the bounds blank in an array declaration. If you do this, the array has the number of dimensions you specify, but it is uninitialized. It has a value of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> until you initialize at least some of its elements. The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> statement must specify bounds either for all dimensions or for no dimensions.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 If the array has more than one dimension, you must include commas between the parentheses to indicate the number of dimensions.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 You can declare a *zero-length array* by declaring one of the array's dimensions to be -1. A variable that holds a zero-length array does not have the value <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Zero-length arrays are required by certain common language runtime functions. If you try to access such an array, a runtime exception occurs. For more information, see [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
 You can initialize the values of an array by using an array literal. To do this, surround the initialization values with braces (<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 For multidimensional arrays, the initialization for each separate dimension is enclosed in braces in the outer dimension. The elements are specified in row-major order.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 For more information about array literals, see [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md).  
  
##  \<a name="default">\</a> Default Data Types and Values  
 The following table describes the results of various combinations of specifying the data type and initializer in a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> statement.  
  
|||||  
|-|-|-|-|  
|Data type specified?|Initializer specified?|Example|Result|  
|No|No|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|If [Option Strict](../vs140/option-strict-statement.md) is off (the default), the variable is set to <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.\<br />\<br /> If <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> is on, a compile-time error occurs.|  
|No|Yes|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|If [Option Infer](../vs140/option-infer-statement.md) is on (the default), the variable takes the data type of the initializer. See [Local Type Inference (Visual Basic)](../vs140/local-type-inference--visual-basic-.md).\<br />\<br /> If <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is off and <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is off, the variable takes the data type of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.\<br />\<br /> If <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is off and <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> is on, a compile-time error occurs.|  
|Yes|No|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|The variable is initialized to the default value for the data type. See the table later in this section.|  
|Yes|Yes|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|If the data type of the initializer is not convertible to the specified data type, a compile-time error occurs.|  
  
 If you specify a data type but do not specify an initializer, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] initializes the variable to the default value for its data type. The following table shows the default initialization values.  
  
|||  
|-|-|  
|Data type|Default value|  
|All numeric types (including <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>)|0|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Binary 0|  
|All reference types (including <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, and all arrays)|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|12:00 AM of January 1 of the year 1 (01/01/0001 12:00:00 AM)|  
  
 Each element of a structure is initialized as if it were a separate variable. If you declare the length of an array but do not initialize its elements, each element is initialized as if it were a separate variable.  
  
## Static Local Variable Lifetime  
 A <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> local variable has a longer lifetime than that of the procedure in which it is declared. The boundaries of the variable's lifetime depend on where the procedure is declared and whether it is <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
||||  
|-|-|-|  
|Procedure declaration|Variable initialized|Variable stops existing|  
|In a module|The first time the procedure is called|When your program stops execution|  
|In a class or structure, procedure is <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|The first time the procedure is called either on a specific instance or on the class or structure itself|When your program stops execution|  
|In a class or structure, procedure isn't <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|The first time the procedure is called on a specific instance|When the instance is released for garbage collection (GC)|  
  
## Attributes and Modifiers  
 You can apply attributes only to member variables, not to local variables. An attribute contributes information to the assembly's metadata, which is not meaningful for temporary storage such as local variables.  
  
 At module level, you cannot use the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> modifier to declare member variables. At procedure level, you cannot use <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, or any access modifiers to declare local variables.  
  
 You can specify what code can access a variable by supplying an <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>. Class and module member variables (outside any procedure) default to private access, and structure member variables default to public access. You can adjust their access levels with the access modifiers. You cannot use access modifiers on local variables (inside a procedure).  
  
 You can specify <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> only on member variables, not on local variables inside a procedure. If you specify <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, the data type of the variable must be a specific class type, not <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>. You cannot declare an array with <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. For more information about events, see [Events (Visual Basic)](../vs140/events--visual-basic-.md).  
  
> [!NOTE]
>  Code outside a class, structure, or module must qualify a member variable's name with the name of that class, structure, or module. Code outside a procedure or block cannot refer to any local variables within that procedure or block.  
  
## Releasing Managed Resources  
 The .NET Framework garbage collector disposes of managed resources without any extra coding on your part. However, you can force the disposal of a managed resource instead of waiting for the garbage collector.  
  
 If a class holds onto a particularly valuable and scarce resource (such as a database connection or file handle), you might not want to wait until the next garbage collection to clean up a class instance that's no longer in use. A class may implement the \<xref:System.IDisposable*> interface to provide a way to release resources before a garbage collection. A class that implements that interface exposes a <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> method that can be called to force valuable resources to be released immediately.  
  
 The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> statement automates the process of acquiring a resource, executing a set of statements, and then disposing of the resource. However, the resource must implement the \<xref:System.IDisposable*> interface. For more information, see [Using Statement (Visual Basic)](../vs140/using-statement--visual-basic-.md).  
  
## Example  
 The following example declares variables by using the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> statement with various options.  
  
 [!code[VbVbalrStatements#141](../vs140/codesnippet/VisualBasic/dim-statement--visual-basic-_1.vb)]  
  
## Example  
 The following example lists the prime numbers between 1 and 30. The scope of local variables is described in code comments.  
  
 [!code[VbVbalrStatements#142](../vs140/codesnippet/VisualBasic/dim-statement--visual-basic-_2.vb)]  
  
## Example  
 In the following example, the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> variable is declared at the class level. The <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> keyword is used to declare the variable. The variable can be accessed by any procedure in the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> class.  
  
 [!code[VbVbalrStatements#144](../vs140/codesnippet/VisualBasic/dim-statement--visual-basic-_3.vb)]  
  
 [!code[VbVbalrStatements#145](../vs140/codesnippet/VisualBasic/dim-statement--visual-basic-_4.vb)]  
  
## See Also  
 [Const Statement](../vs140/const-statement--visual-basic-.md)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)   
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)   
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [Object Initializers: Named and Anonymous Types](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [How to: Declare an Object by Using an Object Initializer](../vs140/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)