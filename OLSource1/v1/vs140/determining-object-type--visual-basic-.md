---
title: "Determining Object Type (Visual Basic)"
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
  - "classes [Visual Basic], discovering which an object belongs to"
  - "types [Visual Basic], determining Visual Basic object types"
  - "object variables, testing values"
  - "TypeOf...Is expression, object type at run time"
  - "TypeName function"
  - "objects [Visual Basic], type determining"
ms.assetid: d95e7ad1-cd63-41d6-9a28-d7a1380d49c1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Determining Object Type (Visual Basic)
Generic object variables (that is, variables you declare as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) can hold objects from any class. When using variables of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, you may need to take different actions based on the class of the object; for example, some objects might not support a particular property or method. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides two means of determining which type of object is stored in an object variable: the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function and the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator.  
  
## TypeName and TypeOf…Is  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function returns a string and is the best choice when you need to store or display the class name of an object, as shown in the following code fragment:  
  
 [!code[VbVbalrOOP#92](../vs140/codesnippet/VisualBasic/determining-object-type--visual-basic-_1.vb)]  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator is the best choice for testing an object's type, because it is much faster than an equivalent string comparison using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The following code fragment uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> within an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement:  
  
 [!code[VbVbalrOOP#93](../vs140/codesnippet/VisualBasic/determining-object-type--visual-basic-_2.vb)]  
  
 A word of caution is due here. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if an object is of a specific type, or is derived from a specific type. Almost everything you do with [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] involves objects, which include some elements not normally thought of as objects, such as strings and integers. These objects are derived from and inherit methods from \<xref:System.Object*>. When passed an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and evaluated with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The following example reports that the parameter <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is both an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrOOP#94](../vs140/codesnippet/VisualBasic/determining-object-type--visual-basic-_3.vb)]  
  
 The following example uses both <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to determine the type of object passed to it in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedure calls <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with three different kinds of controls.  
  
#### To run the example  
  
1.  Create a new Windows Application project and add a \<xref:System.Windows.Forms.Button*> control, a \<xref:System.Windows.Forms.CheckBox*> control, and a \<xref:System.Windows.Forms.RadioButton*> control to the form.  
  
2.  From the button on your form, call the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure.  
  
3.  Add the following code to your form:  
  
     [!code[VbVbalrOOP#95](../vs140/codesnippet/VisualBasic/determining-object-type--visual-basic-_4.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.TypeName*>   
 [Calling a Property or Method Using a String Name](../vs140/calling-a-property-or-method-using-a-string-name--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [String Data Type](../vs140/string-data-type--visual-basic-.md)   
 [Integer Data Type](../vs140/integer-data-type--visual-basic-.md)