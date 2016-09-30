---
title: "Event Statement"
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
  - "vb.Event"
  - "vb.Custom"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Event statement"
  - "declaring events, syntax"
  - "Public keyword, Event statements"
  - "Custom keyword"
  - "declarations, events"
  - "event keyword [Visual Basic]"
  - "WithEvents keyword, Event statements"
  - "events [Visual Basic], declaring"
  - "ByVal keyword, Event statements"
  - "events [Visual Basic], custom"
  - "ByRef keyword, Event statements"
  - "declaring user-defined events"
ms.assetid: 306ff8ed-74dd-4b6a-bd2f-e91b17474042
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event Statement
Declares a user-defined event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Part|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional. List of attributes that apply to this event. Multiple attributes are separated by commas. You must enclose the [Attribute List](../vs140/attribute-list--visual-basic-.md) in angle brackets ("<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>" and "<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>").|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. Specifies what code can access the event. Can be one of the following:\<br />\<br /> -   [Public](../vs140/public--visual-basic-.md)—any code that can access the element that declares it can access it.\<br />-   [Protected](../vs140/protected--visual-basic-.md)—only code within its class or a derived class can access it.\<br />-   [Friend](../vs140/friend--visual-basic-.md)—only code in the same assembly can access it.\<br />-   [Private](../vs140/private--visual-basic-.md)—only code in the element that declares it can access it.\<br />\<br /> You can specify <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to enable access from code in the event's class, a derived class, or the same assembly.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional. Specifies that this event is not associated with a specific instance of a class or structure.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. Indicates that this event redeclares and hides an identically named programming element, or set of overloaded elements, in a base class. You can shadow any kind of declared element with any other kind.\<br />\<br /> A shadowed element is unavailable from within the derived class that shadows it, except from where the shadowing element is inaccessible. For example, if a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element shadows a base-class element, code that does not have permission to access the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element accesses the base-class element instead.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required. Name of the event; follows standard variable naming conventions.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional. List of local variables that represent the parameters of this event. You must enclose the [Parameter List](../vs140/parameter-list--visual-basic-.md) in parentheses.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional. Indicates that this event implements an event of an interface.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Required if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is supplied. List of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> procedures being implemented. Multiple procedures are separated by commas:\<br />\<br /> *implementedprocedure* [ , *implementedprocedure* ... ]\<br />\<br /> Each <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has the following syntax and parts:\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> -   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> - Required. Name of an interface that this procedure's containing class or structure is implementing.\<br />-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> - Required. Name by which the procedure is defined in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. This does not have to be the same as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the name that this procedure is using to implement the defined procedure.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Required. Events declared as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> must define custom <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> accessors.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Optional. The name of a delegate that specifies the event-handler signature.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Required. Declares an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> accessor, which specifies the statements to execute when an event handler is added, either explicitly by using the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement or implicitly by using the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> clause.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Required. Terminates the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Required. Parameter name.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Required. Declares a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> accessor, which specifies the statements to execute when an event handler is removed using the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Required. Terminates the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Required. Declares a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> accessor, which specifies the statements to execute when the event is raised using the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement. Typically, this invokes a list of delegates maintained by the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> accessors.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Required. Terminates the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> block.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Required. List of parameters that matches the parameters required by the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> delegate. You must enclose the [Parameter List](../vs140/parameter-list--visual-basic-.md) in parentheses.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Optional. Statements that contain the bodies of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> methods.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Required. Terminates the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> block.|  
  
## Remarks  
 Once the event has been declared, use the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> statement to raise the event. A typical event might be declared and raised as shown in the following fragments:  
  
 [!code[VbVbalrEvents#13](../vs140/codesnippet/VisualBasic/event-statement_1.vb)]  
  
> [!NOTE]
>  You can declare event arguments just as you do arguments of procedures, with the following exceptions: events cannot have named arguments, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> arguments, or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> arguments. Events do not have return values.  
  
 To handle an event, you must associate it with an event handler subroutine using either the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> statement. The signatures of the subroutine and the event must match. To handle a shared event, you must use the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> statement.  
  
 You can use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> only at module level. This means the *declaration context* for an event must be a class, structure, module, or interface, and cannot be a source file, namespace, procedure, or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 In most circumstances, you can use the first syntax in the Syntax section of this topic for declaring events. However, some scenarios require that you have more control over the detailed behavior of the event. The last syntax in the Syntax section of this topic, which uses the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> keyword, provides that control by enabling you to define custom events. In a custom event, you specify exactly what occurs when code adds or removes an event handler to or from the event, or when code raises the event. For examples, see [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md) and [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md).  
  
## Example  
 The following example uses events to count down seconds from 10 to 0. The code illustrates several of the event-related methods, properties, and statements. This includes the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> statement.  
  
 The class that raises an event is the event source, and the methods that process the event are the event handlers. An event source can have multiple handlers for the events it generates. When the class raises the event, that event is raised on every class that has elected to handle events for that instance of the object.  
  
 The example also uses a form (<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>) with a button (<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>) and a text box (<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>). When you click the button, the first text box displays a countdown from 10 to 0 seconds. When the full time (10 seconds) has elapsed, the first text box displays "Done".  
  
 The code for <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> specifies the initial and terminal states of the form. It also contains the code executed when events are raised.  
  
 To use this example, open a new Windows Forms project. Then add a button named <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and a text box named <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> to the main form, named <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>. Then right-click the form and click **View Code** to open the code editor.  
  
 Add a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> variable to the declarations section of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> class:  
  
 [!code[VbVbalrEvents#14](../vs140/codesnippet/VisualBasic/event-statement_2.vb)]  
  
 Add the following code to the code for <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. Replace any duplicate procedures that may exist, such as <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrEvents#15](../vs140/codesnippet/VisualBasic/event-statement_3.vb)]  
  
 Press F5 to run the previous example, and click the button labeled **Start**. The first text box starts to count down the seconds. When the full time (10 seconds) has elapsed, the first text box displays "Done".  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> method does not process events in the same way the form does. To enable the form to handle the events directly, you can use multithreading. For more information, see [Threading (C# and Visual Basic)](../vs140/threading--csharp-and-visual-basic-.md).  
  
## See Also  
 [RaiseEvent Statement](../vs140/raiseevent-statement.md)   
 [Implements Statement](../vs140/implements-statement.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)   
 [AddHandler Statement](../vs140/addhandler-statement.md)   
 [RemoveHandler Statement](../vs140/removehandler-statement.md)   
 [Handles](../vs140/handles-clause--visual-basic-.md)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [How to: Declare Events That Conserve Memory Use](../vs140/how-to--declare-custom-events-to-conserve-memory--visual-basic-.md)   
 [How to: Declare Events That Avoid Blocking](../vs140/how-to--declare-custom-events-to-avoid-blocking--visual-basic-.md)   
 [Shared](../vs140/shared--visual-basic-.md)   
 [Shadows](../vs140/shadows--visual-basic-.md)