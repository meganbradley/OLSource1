---
title: "Overloaded Properties and Methods (Visual Basic)"
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
  - "properties [Visual Basic], overloading"
  - "methods [Visual Basic], overloading"
  - "shadowing"
  - "names, multiple procedures with same"
  - "procedures, mulltiples with same name"
  - "classes [Visual Basic], properties"
  - "classes [Visual Basic], methods"
  - "method overloading"
  - "Overloads keyword, overloaded members"
ms.assetid: b686fb97-e7d7-4001-afaa-6650cba08f0d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overloaded Properties and Methods (Visual Basic)
Overloading is the creation of more than one procedure, instance constructor, or property in a class with the same name but different argument types.  
  
## Overloading Usage  
 Overloading is especially useful when your object model dictates that you employ identical names for procedures that operate on different data types. For example, a class that can display several different data types could have <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedures that look like this:  
  
 [!code[VbVbalrOOP#64](../vs140/codesnippet/VisualBasic/overloaded-properties-and-methods--visual-basic-_1.vb)]  
  
 Without overloading, you would need to create distinct names for each procedure, even though they do the same thing, as shown next:  
  
 [!code[VbVbalrOOP#65](../vs140/codesnippet/VisualBasic/overloaded-properties-and-methods--visual-basic-_2.vb)]  
  
 Overloading makes it easier to use properties or methods because it provides a choice of data types that can be used. For example, the overloaded <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method discussed previously can be called with any of the following lines of code:  
  
 [!code[VbVbalrOOP#66](../vs140/codesnippet/VisualBasic/overloaded-properties-and-methods--visual-basic-_3.vb)]  
  
 At run time, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] calls the correct procedure based on the data types of the parameters you specify.  
  
## Overloading Rules  
 You create an overloaded member for a class by adding two or more properties or methods with the same name. Except for overloaded derived members, each overloaded member must have different parameter lists, and the following items cannot be used as a differentiating feature when overloading a property or procedure:  
  
-   Modifiers, such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, that apply to a member, or parameters of the member.  
  
-   Names of parameters  
  
-   Return types of procedures  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is optional when overloading, but if any overloaded member uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword, then all other overloaded members with the same name must also specify this keyword.  
  
 Derived classes can overload inherited members with members that have identical parameters and parameter types, a process known as *shadowing by name and signature*. If the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is used when shadowing by name and signature, the derived class's implementation of the member will be used instead of the implementation in the base class, and all other overloads for that member will be available to instances of the derived class.  
  
 If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword is omitted when overloading an inherited member with a member that has identical parameters and parameter types, then the overloading is called *shadowing by name*. Shadowing by name replaces the inherited implementation of a member, and it makes all other overloads unavailable to instances of the derived class and its decedents.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifiers cannot both be used with the same property or method.  
  
### Example  
 The following example creates overloaded methods that accept either a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> representation of a dollar amount and return a string containing the sales tax.  
  
##### To use this example to create an overloaded method  
  
1.  Open a new project and add a class named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
2.  Add the following code to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class.  
  
     [!code[VbVbalrOOP#67](../vs140/codesnippet/VisualBasic/overloaded-properties-and-methods--visual-basic-_4.vb)]  
  
3.  Add the following procedure to your form.  
  
     [!code[VbVbalrOOP#68](../vs140/codesnippet/VisualBasic/overloaded-properties-and-methods--visual-basic-_5.vb)]  
  
4.  Add a button to your form and call the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> procedure from the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> event of the button.  
  
5.  Run the project and click the button on the form to test the overloaded <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> procedure.  
  
 At run time, the compiler chooses the appropriate overloaded function that matches the parameters being used. When you click the button, the overloaded method is called first with a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter that is a string and the message, "Price is a String. Tax is $5.12" is displayed. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is called with a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value the second time and the message, "Price is a Decimal. Tax is $5.12" is displayed.  
  
## See Also  
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [ByVal](../vs140/byval--visual-basic-.md)   
 [ByRef](../vs140/byref--visual-basic-.md)   
 [Overloads](../vs140/overloads--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)