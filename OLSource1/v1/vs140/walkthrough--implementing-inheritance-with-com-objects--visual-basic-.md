---
title: "Walkthrough: Implementing Inheritance with COM Objects (Visual Basic)"
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
  - "inheritance, COM reusability"
  - "base classes, COM reusability"
  - "inheritance, walkthroughs"
  - "derived classes, COM reusability"
ms.assetid: f8e7263a-de13-48d1-b67c-ca1adf3544d9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Implementing Inheritance with COM Objects (Visual Basic)
You can derive Visual Basic classes from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> classes in COM objects, even those created in earlier versions of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. The properties and methods of classes inherited from COM objects can be overridden or overloaded just as properties and methods of any other base class can be overridden or overloaded. Inheritance from COM objects is useful when you have an existing class library that you do not want to recompile.  
  
 The following procedure shows how to use Visual Basic 6.0 to create a COM object that contains a class, and then use it as a base class.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To build the COM object that is used in this walkthrough  
  
1.  In Visual Basic 6.0, open a new ActiveX DLL project. A project named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is created. It has a class named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  In the **Project Explorer**, right-click **Project1**, and then click **Project1 Properties**. The **Project Properties** dialog box is displayed.  
  
3.  On the **General** tab of the **Project Properties** dialog box, change the project name by typing <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the **Project Name** field.  
  
4.  In the **Project Explorer**, right-click <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and then click **Properties**. The **Properties** window for the class is displayed.  
  
5.  Change the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
6.  In the **Project Explorer**, right-click <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then click **View Code**. The **Code Editor** is displayed.  
  
7.  Add a local variable to hold the property value:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
8.  Add Property <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and Property <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property procedures:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
9. Add a function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
10. Create and register the COM object by clicking **Make ComObject1.dll** on the **File** menu.  
  
    > [!NOTE]
    >  Although you can also expose a class created with [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] as a COM object, it is not a true COM object and cannot be used in this walkthrough. For details, see [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md).  
  
## Interop Assemblies  
 In the following procedure, you will create an interop assembly, which acts as a bridge between unmanaged code (such as a COM object) and the managed code [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] uses. The interop assembly that [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] creates handles many of the details of working with COM objects, such as *interop marshaling*, the process of packaging parameters and return values into equivalent data types as they move to and from COM objects. The reference in the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] application points to the interop assembly, not the actual COM object.  
  
#### To use a COM object with Visual Basic 2005 and later versions  
  
1.  Open a new [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Windows Application project.  
  
2.  On the **Project** menu, click **Add Reference**.  
  
     The **Add Reference** dialog box is displayed.  
  
3.  On the **COM** tab, double-click <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in the **Component Name** list and click **OK**.  
  
4.  On the **Project** menu, click **Add New Item**.  
  
     The **Add New Item** dialog box is displayed.  
  
5.  In the **Templates** pane, click **Class**.  
  
     The default file name, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, appears in the **Name** field. Change this field to MathClass.vb and click **Add**. This creates a class named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and displays its code.  
  
6.  Add the following code to the top of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to inherit from the COM class.  
  
     [!code[VbVbalrInterop#31](../vs140/codesnippet/VisualBasic/walkthrough--implementing-inheritance-with-com-objects--visual-basic-_1.vb)]  
  
7.  Overload the public method of the base class by adding the following code to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>:  
  
     [!code[VbVbalrInterop#32](../vs140/codesnippet/VisualBasic/walkthrough--implementing-inheritance-with-com-objects--visual-basic-_2.vb)]  
  
8.  Extend the inherited class by adding the following code to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>:  
  
     [!code[VbVbalrInterop#33](../vs140/codesnippet/VisualBasic/walkthrough--implementing-inheritance-with-com-objects--visual-basic-_3.vb)]  
  
 The new class inherits the properties of the base class in the COM object, overloads a method, and defines a new method to extend the class.  
  
#### To test the inherited class  
  
1.  Add a button to your startup form, and then double-click it to view its code.  
  
2.  In the button's <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> event handler procedure, add the following code to create an instance of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and call the overloaded methods:  
  
     [!code[VbVbalrInterop#34](../vs140/codesnippet/VisualBasic/walkthrough--implementing-inheritance-with-com-objects--visual-basic-_4.vb)]  
  
3.  Run the project by pressing F5.  
  
 When you click the button on the form, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method is first called with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> data type numbers, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] chooses the appropriate method from the base class. The second call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is directed to the overload method from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The third call calls the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method, which extends the class. The property in the base class is set, and the value is displayed.  
  
## Next Steps  
 You may have noticed that the overloaded <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function appears to have the same data type as the method inherited from the base class of the COM object. This is because the arguments and parameters of the base class method are defined as 16-bit integers in Visual Basic 6.0, but they are exposed as 16-bit integers of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in later versions of Visual Basic. The new function accepts 32-bit integers, and overloads the base class function.  
  
 When working with COM objects, make sure that you verify the size and data types of parameters. For example, when you are using a COM object that accepts a Visual Basic 6.0 collection object as an argument, you cannot provide a collection from a later version of Visual Basic.  
  
 Properties and methods inherited from COM classes can be overridden, meaning that you can declare a local property or method that replaces a property or method inherited from a base COM class. The rules for overriding inherited COM properties are similar to the rules for overriding other properties and methods with the following exceptions:  
  
-   If you override any property or method inherited from a COM class, you must override all the other inherited properties and methods.  
  
-   Properties that use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameters cannot be overridden.  
  
## See Also  
 [COM Interoperability in .NET Framework Applications](../vs140/com-interoperability-in-.net-framework-applications--visual-basic-.md)   
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Short Data Type](../vs140/short-data-type--visual-basic-.md)