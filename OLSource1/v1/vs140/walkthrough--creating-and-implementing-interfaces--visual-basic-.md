---
title: "Walkthrough: Creating and Implementing Interfaces (Visual Basic)"
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
  - "interfaces, walkthroughs"
  - "interfaces, testing"
  - "interface implementation, walkthrough"
  - "interfaces, creating"
ms.assetid: ded82af2-9f52-4232-98ef-fe458180f112
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating and Implementing Interfaces (Visual Basic)
Interfaces describe the characteristics of properties, methods, and events, but leave the implementation details up to structures or classes.  
  
 This walkthrough demonstrates how to declare and implement an interface.  
  
> [!NOTE]
>  This walkthrough doesn't provide information about how to create a user interface.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To define an interface  
  
1.  Open a new [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Windows Application project.  
  
2.  Add a new module to the project by clicking **Add Module** on the **Project** menu.  
  
3.  Name the new module <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and click **Add**. The code for the new module is displayed.  
  
4.  Define an interface named <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> within <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by typing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> between the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statements, and then pressing ENTER. The **Code Editor** indents the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword and adds an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement to form a code block.  
  
5.  Define a property, method, and event for the interface by placing the following code between the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statements:  
  
     [!code[VbVbalrOOP#98](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_1.vb)]  
  
## Implementation  
 You may notice that the syntax used to declare interface members is different from the syntax used to declare class members. This difference reflects the fact that interfaces cannot contain implementation code.  
  
#### To implement the interface  
  
1.  Add a class named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by adding the following statement to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, after the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement but before the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement, and then pressing ENTER:  
  
     [!code[VbVbalrOOP#99](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_2.vb)]  
  
     If you are working within the integrated development environment, the **Code Editor** supplies a matching <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement when you press ENTER.  
  
2.  Add the following <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which names the interface the class implements:  
  
     [!code[VbVbalrOOP#100](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_3.vb)]  
  
     When listed separately from other items at the top of a class or structure, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement indicates that the class or structure implements an interface.  
  
     If you are working within the integrated development environment, the **Code Editor** implements the class members required by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> when you press ENTER, and you can skip the next step.  
  
3.  If you are not working within the integrated development environment, you must implement all the members of the interface <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Add the following code to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to implement <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>:  
  
     [!code[VbVbalrOOP#101](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_4.vb)]  
  
     The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement names the interface and interface member being implemented.  
  
4.  Complete the definition of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> by adding a private field to the class that stored the property value:  
  
     [!code[VbVbalrOOP#102](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_5.vb)]  
  
     Return the value of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> from the property get accessor.  
  
     [!code[VbVbalrOOP#103](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_6.vb)]  
  
     Set the value of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in the property set accessor.  
  
     [!code[VbVbalrOOP#104](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_7.vb)]  
  
5.  Complete the definition of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> by adding the following code.  
  
     [!code[VbVbalrOOP#105](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_8.vb)]  
  
#### To test the implementation of the interface  
  
1.  Right-click the startup form for your project in the **Solution Explorer**, and click **View Code**. The editor displays the class for your startup form. By default, the startup form is called <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
2.  Add the following <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> field to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class:  
  
     [!code[VbVbalrOOP#120](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_9.vb)]  
  
     By declaring <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class can handle its events.  
  
3.  Add the following event handler to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class to handle events raised by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>:  
  
     [!code[VbVbalrOOP#106](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_10.vb)]  
  
4.  Add a subroutine named <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class to test the implementation class:  
  
     [!code[VbVbalrOOP#107](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_11.vb)]  
  
     The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> procedure creates an instance of the class that implements <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, assigns that instance to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> field, sets a property, and runs a method through the interface.  
  
5.  Add code to call the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> procedure from the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> procedure of your startup form:  
  
     [!code[VbVbalrOOP#108](../vs140/codesnippet/VisualBasic/walkthrough--creating-and-implementing-interfaces--visual-basic-_12.vb)]  
  
6.  Run the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> procedure by pressing F5. The message "Prop1 was set to 9" is displayed. After you click OK, the message "The X parameter for Method1 is 5" is displayed. Click OK, and the message "The event handler caught the event" is displayed.  
  
## See Also  
 [Implements Statement](../vs140/implements-statement.md)   
 [Interfaces](../vs140/interfaces--visual-basic-.md)   
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)   
 [Event Statement](../vs140/event-statement.md)