---
title: "Statements in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "variables [Visual Basic], declaring"
  - "colons (:)"
  - "constants, defining"
  - "underlines"
  - "constants, statements"
  - "blue underline"
  - "procedures, statements"
  - "variables [Visual Basic], assigning"
  - "line breaks, in code"
  - "executable statements"
  - "variables [Visual Basic], defining"
  - "statements [Visual Basic], about statements"
ms.assetid: fcfdee1a-82b7-4846-98f7-9ca3f5160089
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Statements in Visual Basic
A statement in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is a complete instruction. It can contain keywords, operators, variables, constants, and expressions. Each statement belongs to one of the following categories:  
  
-   **Declaration Statements**, which name a variable, constant, or procedure, and can also specify a data type.  
  
-   **Executable Statements**, which initiate actions. These statements can call a method or function, and they can loop or branch through blocks of code. Executable statements include **Assignment Statements**, which assign a value or expression to a variable or constant.  
  
 This topic describes each category. Also, this topic describes how to combine multiple statements on a single line and how to continue a statement over multiple lines.  
  
## Declaration Statements  
 You use declaration statements to name and define procedures, variables, properties, arrays, and constants. When you declare a programming element, you can also define its data type, access level, and scope. For more information, see [Declared Element Characteristics](../vs140/declared-element-characteristics--visual-basic-.md).  
  
 The following example contains three declarations.  
  
 [!code[VbVbalrStatements#80](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_1.vb)]  
  
 The first declaration is the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement. Together with its matching <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement, it declares a procedure named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. It also specifies that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which means that any code that can refer to it can call it.  
  
 The second declaration is the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, which declares the constant <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, specifying the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> data type and a value of 33.  
  
 The third declaration is the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement, which declares the variable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The data type is a specific object, namely an object created from the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class. You can declare a variable to be of any elementary data type or of any object type that is exposed in the application you are using.  
  
### Initial Values  
 When the code containing a declaration statement runs, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] reserves the memory required for the declared element. If the element holds a value, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] initializes it to the default value for its data type. For more information, see "Behavior" in [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).  
  
 You can assign an initial value to a variable as part of its declaration, as the following example illustrates.  
  
 [!code[VbVbalrStatements#81](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_2.vb)]  
  
 If a variable is an object variable, you can explicitly create an instance of its class when you declare it by using the [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) keyword, as the following example illustrates.  
  
 [!code[VbVbalrStatements#82](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_3.vb)]  
  
 Note that the initial value you specify in a declaration statement is not assigned to a variable until execution reaches its declaration statement. Until that time, the variable contains the default value for its data type.  
  
## Executable Statements  
 An executable statement performs an action. It can call a procedure, branch to another place in the code, loop through several statements, or evaluate an expression. An assignment statement is a special case of an executable statement.  
  
 The following example uses an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> control structure to run different blocks of code based on the value of a variable. Within each block of code, a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> loop runs a specified number of times.  
  
 [!code[VbVbalrStatements#83](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_4.vb)]  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement in the preceding example checks the value of the parameter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If the value is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, it calls the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If the value is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, it calls the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> control structure ends with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> loop within each block calls the appropriate method a number of times equal to the value of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.  
  
## Assignment Statements  
 Assignment statements carry out assignment operations, which consist of taking the value on the right side of the assignment operator (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>) and storing it in the element on the left, as in the following example.  
  
 [!code[VbVbalrStatements#73](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_5.vb)]  
  
 In the preceding example, the assignment statement stores the literal value 42 in the variable <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Eligible Programming Elements  
 The programming element on the left side of the assignment operator must be able to accept and store a value. This means it must be a variable or property that is not [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md), or it must be an array element. In the context of an assignment statement, such an element is sometimes called an *lvalue*, for "left value."  
  
 The value on the right side of the assignment operator is generated by an expression, which can consist of any combination of literals, constants, variables, properties, array elements, other expressions, or function calls. The following example illustrates this.  
  
 [!code[VbVbalrStatements#74](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_6.vb)]  
  
 The preceding example adds the value held in variable <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the value held in variable <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and then adds the value returned by the call to function <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The total value of this expression is then stored in variable <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Data Types in Assignment Statements  
 In addition to numeric values, the assignment operator can also assign <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> values, as the following example illustrates.  
  
 [!code[VbVbalrStatements#75](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_7.vb)]  
  
 You can also assign <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> values, using either a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> literal or a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> expression, as the following example illustrates.  
  
 [!code[VbVbalrStatements#76](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_8.vb)]  
  
 Similarly, you can assign appropriate values to programming elements of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> data type. You can also assign an object instance to an element declared to be of the class from which that instance is created.  
  
### Compound Assignment Statements  
 *Compound assignment statements* first perform an operation on an expression before assigning it to a programming element. The following example illustrates one of these operators, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, which increments the value of the variable on the left side of the operator by the value of the expression on the right.  
  
 [!code[VbVbalrStatements#77](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_9.vb)]  
  
 The preceding example adds 1 to the value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and then stores that new value in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. It is a shorthand equivalent of the following statement:  
  
 [!code[VbVbalrStatements#78](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_10.vb)]  
  
 A variety of compound assignment operations can be performed using operators of this type. For a list of these operators and more information about them, see [Assignment Operators](../vs140/assignment-operators--visual-basic-.md).  
  
 The concatenation assignment operator (<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>) is useful for adding a string to the end of already existing strings, as the following example illustrates.  
  
 [!code[VbVbalrStatements#79](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_11.vb)]  
  
### Type Conversions in Assignment Statements  
 The value you assign to a variable, property, or array element must be of a data type appropriate to that destination element. In general, you should try to generate a value of the same data type as that of the destination element. However, some types can be converted to other types during assignment.  
  
 For information on converting between data types, see [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md). In brief, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] automatically converts a value of a given type to any other type to which it widens. A *widening conversion* is one in that always succeeds at run time and does not lose any data. For example, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] converts an <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> when appropriate, because <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> widens to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For more information, see [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
 *Narrowing conversions* (those that are not widening) carry a risk of failure at run time, or of data loss. You can perform a narrowing conversion explicitly by using a type conversion function, or you can direct the compiler to perform all conversions implicitly by setting <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. For more information, see [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md).  
  
## Putting Multiple Statements on One Line  
 You can have multiple statements on a single line separated by the colon (<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>) character. The following example illustrates this.  
  
 [!code[VbVbalrStatements#70](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_12.vb)]  
  
 Though occasionally convenient, this form of syntax makes your code hard to read and maintain. Thus, it is recommended that you keep one statement to a line.  
  
## Continuing a Statement over Multiple Lines  
 A statement usually fits on one line, but when it is too long, you can continue it onto the next line using a line-continuation sequence, which consists of a space followed by an underscore character (<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>) followed by a carriage return. In the following example, the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> executable statement is continued over two lines.  
  
 [!code[VbVbalrStatements#71](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_13.vb)]  
  
### Implicit Line Continuation  
 In many cases, you can continue a statement on the next consecutive line without using the underscore character (_). The following table lists the syntax elements that implicitly continue the statement on the next line of code.  
  
|||  
|-|-|  
|Syntax element|Example|  
|After a comma (<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>).|[!code[VbVbalrLineContinuation#1](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_14.vb)]|  
|After an open parenthesis (<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>) or before a closing parenthesis (<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>).|[!code[VbVbalrLineContinuation#2](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_15.vb)]|  
|After an open curly brace (<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) or before a closing curly brace (<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>).|[!code[VbVbalrLineContinuation#3](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_16.vb)]\<br />\<br /> For more information, see [Object Initializers: Named and Anonymous Types](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md) or [Collection Initializers Overview](../vs140/collection-initializers--visual-basic-.md).|  
|After an open embedded expression (<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>) or before the close of an embedded expression (<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>) within an XML literal.|[!code[VbVbalrLineContinuation#4](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_17.vb)]\<br />\<br /> For more information, see [Embedded Expressions In XML](../vs140/embedded-expressions-in-xml--visual-basic-.md).|  
|After the concatenation operator (<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>).|[!code[VbVbcnConventions#9](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_18.vb)]\<br />\<br /> For more information, see [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md).|  
|After assignment operators (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>).|[!code[VbVbalrLineContinuation#5](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_19.vb)]\<br />\<br /> For more information, see [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md).|  
|After binary operators (<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>) within an expression.|[!code[VbVbalrLineContinuation#7](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_20.vb)]\<br />\<br /> For more information, see [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md).|  
|After the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> operators.|[!code[VbVbalrLineContinuation#8](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_21.vb)]\<br />\<br /> For more information, see [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md).|  
|After a member qualifier character (<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>) and before the member name. However, you must include a line-continuation character (_) following a member qualifier character when you are using the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> statement or supplying values in the initialization list for a type. Consider breaking the line after the assignment operator (for example, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>) when you are using <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> statements or object initialization lists.|[!code[VbVbalrLineContinuation#5](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_19.vb)]\<br />[!code[VbVbalrLineContinuation#14](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_22.vb)]\<br />\<br /> For more information, see [With...End With Statement (Visual Basic)](../vs140/with...end-with-statement--visual-basic-.md) or [Object Initializers: Named and Anonymous Types](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md).|  
|After an XML axis property qualifier (<CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>). However, you must include a line-continuation character (_) when you specify a member qualifier when you are using the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> keyword.|[!code[VbVbalrLineContinuation#9](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_23.vb)]\<br />\<br /> For more information, see [XML Axis Properties](../vs140/xml-axis-properties--visual-basic-.md).|  
|After a less-than sign (<) or before a greater-than sign (<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>) when you specify an attribute. Also after a greater-than sign (<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>) when you specify an attribute. However, you must include a line-continuation character (_) when you specify assembly-level or module-level attributes.|[!code[VbVbalrLineContinuation#10](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_24.vb)]\<br />\<br /> For more information, see [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md).|  
|Before and after query operators (<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>). You cannot break a line between the keywords of query operators that are made up of multiple keywords (<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>).|[!code[VbVbalrLineContinuation#11](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_25.vb)]\<br />\<br /> For more information, see [Queries (Visual Basic)](../vs140/queries--visual-basic-.md).|  
|After the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> keyword in a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> statement.|[!code[VbVbalrLineContinuation#12](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_26.vb)]\<br />\<br /> For more information, see [For Each...Next Statement (Visual Basic)](../vs140/for-each...next-statement--visual-basic-.md).|  
|After the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> keyword in a collection initializer.|[!code[VbVbalrLineContinuation#13](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_27.vb)]\<br />\<br /> For more information, see [Collection Initializers Overview (Visual Basic)](../vs140/collection-initializers--visual-basic-.md).|  
  
## Adding Comments  
 Source code is not always self-explanatory, even to the programmer who wrote it. To help document their code, therefore, most programmers make liberal use of embedded comments. Comments in code can explain a procedure or a particular instruction to anyone reading or working with it later. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] ignores comments during compilation, and they do not affect the compiled code.  
  
 Comment lines begin with an apostrophe (<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>) or <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> followed by a space. They can be added anywhere in code, except within a string. To append a comment to a statement, insert an apostrophe or <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> after the statement, followed by the comment. Comments can also go on their own separate line. The following example demonstrates these possibilities.  
  
 [!code[VbVbalrStatements#72](../vs140/codesnippet/VisualBasic/statements-in-visual-basic_28.vb)]  
  
## Checking Compilation Errors  
 If, after you type a line of code, the line is displayed with a wavy blue underline (an error message may appear as well), there is a syntax error in the statement. You must find out what is wrong with the statement (by looking in the task list, or hovering over the error with the mouse pointer and reading the error message) and correct it. Until you have fixed all syntax errors in your code, your program will fail to compile correctly.  
  
## Related Sections  
  
|||  
|-|-|  
|Term|Definition|  
|[Assignment Operators](../vs140/assignment-operators--visual-basic-.md)|Provides links to language reference pages covering assignment operators such as <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.|  
|[Operators and Expressions in Visual Basic](../vs140/operators-and-expressions-in-visual-basic.md)|Shows how to combine elements with operators to yield new values.|  
|[How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md)|Shows how to break a single statement into multiple lines and how to place multiple statements on the same line.|  
|[How to: Label Statements](../vs140/how-to--label-statements--visual-basic-.md)|Shows how to label a line of code.|