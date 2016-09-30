---
title: "Auto-Implemented Properties (Visual Basic)"
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
  - "vb.AutoProperty"
  - "vb.AutoImplementedProperty"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "properties [Visual Basic], auto-implemented"
  - "properties, auto-implemented [Visual Basic]"
  - "auto-implemented properties [Visual Basic]"
ms.assetid: 5c669f0b-cf95-4b4e-ae84-9cc55212ca87
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Auto-Implemented Properties (Visual Basic)
*Auto-implemented properties* enable you to quickly specify a property of a class without having to write code to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> the property. When you write code for an auto-implemented property, the Visual Basic compiler automatically creates a private field to store the property variable in addition to creating the associated <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> procedures.  
  
 With auto-implemented properties, a property, including a default value, can be declared in a single line. The following example shows three property declarations.  
  
 [!code[VbVbalrAutoImplementedProperties#1](../vs140/codesnippet/VisualBasic/auto-implemented-properties--visual-basic-_1.vb)]  
  
 An auto-implemented property is equivalent to a property for which the property value is stored in a private field. The following code example shows an auto-implemented property.  
  
 [!code[VbVbalrAutoImplementedProperties#5](../vs140/codesnippet/VisualBasic/auto-implemented-properties--visual-basic-_2.vb)]  
  
 The following code example shows the equivalent code for the previous auto-implemented property example.  
  
 [!code[VbVbalrAutoImplementedProperties#2](../vs140/codesnippet/VisualBasic/auto-implemented-properties--visual-basic-_3.vb)]  
  
 The following code show implementing readonly properties:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can assign to the property with initialization expressions as shown in the example, or you can assign to the properties in the containing type’s constructor.  You can assign to the backing fields of readonly properties at any time.  
  
## Backing Field  
 When you declare an auto-implemented property, Visual Basic automatically creates a hidden private field called the *backing field* to contain the property value. The backing field name is the auto-implemented property name preceded by an underscore (_). For example, if you declare an auto-implemented property named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the backing field is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If you include a member of your class that is also named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you produce a naming conflict and Visual Basic reports a compiler error.  
  
 The backing field also has the following characteristics:  
  
-   The access modifier for the backing field is always <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, even when the property itself has a different access level, such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   If the property is marked as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the backing field also is shared.  
  
-   Attributes specified for the property do not apply to the backing field.  
  
-   The backing field can be accessed from code within the class and from debugging tools such as the Watch window. However, the backing field does not show in an IntelliSense word completion list.  
  
## Initializing an Auto-Implemented Property  
 Any expression that can be used to initialize a field is valid for initializing an auto-implemented property. When you initialize an auto-implemented property, the expression is evaluated and passed to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure for the property. The following code examples show some auto-implemented properties that include initial values.  
  
 [!code[VbVbalrAutoImplementedProperties#3](../vs140/codesnippet/VisualBasic/auto-implemented-properties--visual-basic-_4.vb)]  
  
 You cannot initialize an auto-implemented property that is a member of an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or one that is marked <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 When you declare an auto-implemented property as a member of a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, you can only initialize the auto-implemented property if it is marked as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 When you declare an auto-implemented property as an array, you cannot specify explicit array bounds. However, you can supply a value by using an array initializer, as shown in the following examples.  
  
 [!code[VbVbalrAutoImplementedProperties#4](../vs140/codesnippet/VisualBasic/auto-implemented-properties--visual-basic-_5.vb)]  
  
## Property Definitions That Require Standard Syntax  
 Auto-implemented properties are convenient and support many programming scenarios. However, there are situations in which you cannot use an auto-implemented property and must instead use standard, or *expanded*, property syntax.  
  
 You have to use expanded property-definition syntax if you want to do any one of the following:  
  
-   Add code to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> procedure of a property, such as code to validate incoming values in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> procedure. For example, you might want to verify that a string that represents a telephone number contains the required number of numerals before setting the property value.  
  
-   Specify different accessibility for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> procedure. For example, you might want to make the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
-   Create properties that are <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
-   Use parameterized properties (including <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> properties). You must declare an expanded property in order to specify a parameter for the property, or to specify additional parameters for the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> procedure.  
  
-   Place an attribute on the backing field, or change the access level of the backing field.  
  
-   Provide XML comments for the backing field.  
  
## Expanding an Auto-Implemented Property  
 If you have to convert an auto-implemented property to an expanded property that contains a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> procedure, the Visual Basic Code Editor can automatically generate the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> procedures and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement for the property. The code is generated if you put the cursor on a blank line following the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement, type a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> (for <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) or an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) and press ENTER. The Visual Basic Code Editor automatically generates the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> procedure for read-only and write-only properties when you press ENTER at the end of a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [How to: Declare and Call a Default Property in Visual Basic](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md)   
 [WriteOnly](../vs140/writeonly--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)