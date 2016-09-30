---
title: "Option Strict Statement"
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
  - "vb.Strict"
  - "vb.OptionStrict"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Strict keyword"
  - "Option Strict statement"
  - "conversions, implicit"
  - "late binding"
  - "implicit conversions"
ms.assetid: 5883e0c1-a920-4274-8e46-b0ff047eaee5
caps.latest.revision: 53
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict Statement
Restricts implicit data type conversions to only widening conversions, disallows late binding, and disallows implicit typing that results in an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. Enables <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> checking.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. Disables <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> checking.|  
  
## Remarks  
 When <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> appears in a file, the following conditions cause a compile-time error:  
  
-   Implicit narrowing conversions  
  
-   Late binding  
  
-   Implicit typing that results in an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type  
  
> [!NOTE]
>  In the warning configurations that you can set on the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md), there are three settings that correspond to the three conditions that cause a compile-time error. For information about how to use these settings, see [To set warning configurations in the IDE](../vs140/option-strict-statement.md#conditions) later in this topic.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement turns off error and warning checking for all three conditions, even if the associated IDE settings specify to turn on these errors or warnings. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement turns on error and warning checking for all three conditions, even if the associated IDE settings specify to turn off these errors or warnings.  
  
 If used, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement must appear before any other code statements in a file.  
  
 When you set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, Visual Basic checks that data types are specified for all programming elements. Data types can be specified explicitly, or specified by using local type inference. Specifying data types for all your programming elements is recommended, for the following reasons:  
  
-   It enables IntelliSense support for your variables and parameters. This enables you to see their properties and other members as you type code.  
  
-   It enables the compiler to perform type checking. Type checking helps you find statements that can fail at run time because of type conversion errors. It also identifies calls to methods on objects that do not support those methods.  
  
-   It speeds up the execution of code. One reason for this is that if you do not specify a data type for a programming element, the Visual Basic compiler assigns it the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type. Compiled code might have to convert back and forth between <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and other data types, which reduces performance.  
  
## Implicit Narrowing Conversion Errors  
 Implicit narrowing conversion errors occur when there is an implicit data type conversion that is a narrowing conversion.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] can convert many data types to other data types. Data loss can occur when the value of one data type is converted to a data type that has less precision or a smaller capacity. A run-time error occurs if such a narrowing conversion fails. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> ensures compile-time notification of these narrowing conversions so that you can avoid them. For more information, see [Implicit and Explicit Conversions (Visual Basic)](../vs140/implicit-and-explicit-conversions--visual-basic-.md) and [Widening and Narrowing Conversions (Visual Basic)](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
 Conversions that can cause errors include implicit conversions that occur in expressions. For more information, see the following topics:  
  
-   [+ Operator (Visual Basic)](../vs140/--operator--visual-basic-.md)  
  
-   [+= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-.md)  
  
-   [\ Operator (Visual Basic)](../vs140/--operator--visual-basic-2.md)  
  
-   [/= Operator (Visual Basic)](../vs140/-=-operator--visual-basic-1.md)  
  
-   [Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md)  
  
 When you concatenate strings by using the [& Operator (Visual Basic)](../vs140/--operator--visual-basic-.md), all conversions to the strings are considered to be widening. So these conversions do not generate an implicit narrowing conversion error, even if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is on.  
  
 When you call a method that has an argument that has a data type different from the corresponding parameter, a narrowing conversion causes a compile-time error if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is on. You can avoid the compile-time error by using a widening conversion or an explicit conversion.  
  
 Implicit narrowing conversion errors are suppressed at compile-time for conversions from the elements in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> collection to the loop control variable. This occurs even if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is on. For more information, see the "Narrowing Conversions" section in [For Each…Next Statement](../vs140/for-each...next-statement--visual-basic-.md).  
  
## Late Binding Errors  
 An object is late bound when it is assigned to a property or method of a variable that is declared to be of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Early and Late Binding (Visual Basic)](../vs140/early-and-late-binding--visual-basic-.md).  
  
## Implicit Object Type Errors  
 Implicit object type errors occur when an appropriate type cannot be inferred for a declared variable, so a type of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is inferred. This primarily occurs when you use a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement to declare a variable without using an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is off. For more information, see [Option Infer Statement](../vs140/option-infer-statement.md) and the [Visual Basic Language Specification](../vs140/visual-basic-language-specification.md).  
  
 For method parameters, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause is optional if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is off. However, if any one parameter uses an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> clause, they all must use it. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is on, the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause is required for every parameter definition.  
  
 If you declare a variable without using an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> clause and set it to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the variable has a type of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. No compile-time error occurs in this case when <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is on and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is on. An example of this is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Default Data Types and Values  
 The following table describes the results of various combinations of specifying the data type and initializer in a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).  
  
|||||  
|-|-|-|-|  
|Data type specified?|Initializer specified?|Example|Result|  
|No|No|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is off (the default), the variable is set to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.\<br />\<br /> If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is on, a compile-time error occurs.|  
|No|Yes|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is on (the default), the variable takes the data type of the initializer. See [Local Type Inference (Visual Basic)](../vs140/local-type-inference--visual-basic-.md).\<br />\<br /> If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is off and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is off, the variable takes the data type of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.\<br />\<br /> If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is off and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is on, a compile-time error occurs.|  
|Yes|No|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|The variable is initialized to the default value for the data type. For more information, see [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md).|  
|Yes|Yes|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|If the data type of the initializer is not convertible to the specified data type, a compile-time error occurs.|  
  
## When an Option Strict Statement Is Not Present  
 If the source code does not contain an <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement, the **Option strict** setting on the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md) is used. The **Compile Page** has settings that provide additional control over the conditions that generate an error.  
  
 If you are using the command-line compiler, you can use the [/optionstrict](../vs140/-optionstrict.md) compiler option to specify a setting for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### To set Option Strict in the IDE  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
1.  In **Solution Explorer**, select a project. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).  
  
2.  On the **Compile** tab, set the value in the **Option Strict** box.  
  
###  \<a name="conditions">\</a> To set warning configurations in the IDE  
 When you use the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md) instead of an <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> statement, you have additional control over the conditions that generate errors. The **Warning configurations** section of the **Compile Page** has settings that correspond to the three conditions that cause a compile-time error when <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is on. Following are these settings:  
  
-   **Implicit conversion**  
  
-   **Late binding; call could fail at run time**  
  
-   **Implicit type; object assumed**  
  
 When you set **Option Strict** to **On**, all three of these warning configuration settings are set to **Error**. When you set **Option Strict** to **Off**, all three settings are set to **None**.  
  
 You can individually change each warning configuration setting to **None**, **Warning**, or **Error**. If all three warning configuration settings are set to **Error**, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> appears in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> box. If all three are set to **None**, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> appears in this box. For any other combination of these settings, **(custom)** appears.  
  
### To set the Option Strict default setting for new projects  
 When you create a project, the **Option Strict** setting on the **Compile** tab is set to the **Option Strict** setting in the **Options** dialog box.  
  
 To set <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> in this dialog box, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Projects and Solutions**, and then click **VB Defaults**. The initial default setting in **VB Defaults** is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
### To set Option Strict on the command line  
 Include the [/optionstrict](../vs140/-optionstrict.md) compiler option in the **vbc** command.  
  
## Example  
 The following examples demonstrate compile-time errors caused by implicit type conversions that are narrowing conversions. This category of errors corresponds to the **Implicit conversion** condition on the **Compile Page**.  
  
 [!code[VbVbalrStatements#161](../vs140/codesnippet/VisualBasic/option-strict-statement_1.vb)]  
  
## Example  
 The following example demonstrates a compile-time error caused by late binding. This category of errors corresponds to the **Late binding; call could fail at run time** condition on the **Compile Page**.  
  
 [!code[VbVbalrStatements#162](../vs140/codesnippet/VisualBasic/option-strict-statement_2.vb)]  
  
## Example  
 The following examples demonstrate errors caused by variables that are declared with an implicit type of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. This category of errors corresponds to the **Implicit type; object assumed** condition on the **Compile Page**.  
  
 [!code[VbVbalrStatements#163](../vs140/codesnippet/VisualBasic/option-strict-statement_3.vb)]  
  
 [!code[VbVbalrStatements#164](../vs140/codesnippet/VisualBasic/option-strict-statement_4.vb)]  
  
## See Also  
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions (Visual Basic)](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)   
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)   
 [Type Conversion Functions (Visual Basic)](../vs140/type-conversion-functions--visual-basic-.md)   
 [How to: Access Members of an Object (Visual Basic)](../vs140/how-to--access-members-of-an-object--visual-basic-.md)   
 [Embedded Expressions in XML (Visual Basic)](../vs140/embedded-expressions-in-xml--visual-basic-.md)   
 [Relaxed Delegate Conversion (Visual Basic)](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Late Binding in Office Solutions](assetId:///80b0d23e-df68-4ea9-a02b-238aee8ca9c0)   
 [/optionstrict](../vs140/-optionstrict.md)   
 [Visual Basic Defaults, Projects, Options Dialog Box](../vs140/visual-basic-defaults--projects--options-dialog-box.md)