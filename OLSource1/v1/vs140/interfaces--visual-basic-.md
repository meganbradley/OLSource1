---
title: "Interfaces (Visual Basic)"
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
  - "Visual Basic code, interfaces"
  - "interfaces, Visual Basic"
  - "interfaces"
  - "interfaces [Visual Basic]"
ms.assetid: 61b06674-12c9-430b-be68-cc67ecee1f5b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interfaces (Visual Basic)
*Interfaces* define the properties, methods, and events that classes can implement. Interfaces allow you to define features as small groups of closely related properties, methods, and events; this reduces compatibility problems because you can develop enhanced implementations for your interfaces without jeopardizing existing code. You can add new features at any time by developing additional interfaces and implementations.  
  
 There are several other reasons why you might want to use interfaces instead of class inheritance:  
  
-   Interfaces are better suited to situations in which your applications require many possibly unrelated object types to provide certain functionality.  
  
-   Interfaces are more flexible than base classes because you can define a single implementation that can implement multiple interfaces.  
  
-   Interfaces are better in situations in which you do not have to inherit implementation from a base class.  
  
-   Interfaces are useful when you cannot use class inheritance. For example, structures cannot inherit from classes, but they can implement interfaces.  
  
## Declaring Interfaces  
 Interface definitions are enclosed within the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statements. Following the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement, you can add an optional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement that lists one or more inherited interfaces. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements must precede all other statements in the declaration except comments. The remaining statements in the interface definition should be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statements. Interfaces cannot contain any implementation code or statements associated with implementation code, such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 In a namespace, interface statements are <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by default, but they can also be explicitly declared as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Interfaces defined within classes, modules, interfaces, and structures are <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> by default, but they can also be explicitly declared as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword can be applied to all interface members. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword can be applied to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statements declared in an interface definition. In addition, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statements can have the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> modifiers. None of the other modifiers—<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>—are allowed. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 For example, the following code defines an interface with one function, one property, and one event.  
  
 [!code[VbVbalrOOP#17](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_1.vb)]  
  
## Implementing Interfaces  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] reserved word <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is used in two ways. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> statement signifies that a class or structure implements an interface. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> keyword signifies that a class member or structure member implements a specific interface member.  
  
### Implements Statement  
 If a class or structure implements one or more interfaces, it must include the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> statement immediately after the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> statement. The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statement requires a comma-separated list of interfaces to be implemented by a class. The class or structure must implement all interface members using the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> keyword.  
  
### Implements Keyword  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> keyword requires a comma-separated list of interface members to be implemented. Generally, only a single interface member is specified, but you can specify multiple members. The specification of an interface member consists of the interface name, which must be specified in an implements statement within the class; a period; and the name of the member function, property, or event to be implemented. The name of a member that implements an interface member can use any legal identifier, and it is not limited to the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> convention used in earlier versions of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
 For example, the following code shows how to declare a subroutine named <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> that implements a method of an interface:  
  
 [!code[VbVbalrOOP#69](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_2.vb)]  
  
 The parameter types and return types of the implementing member must match the interface property or member declaration in the interface. The most common way to implement an element of an interface is with a member that has the same name as the interface, as shown in the previous example.  
  
 To declare the implementation of an interface method, you can use any attributes that are legal on instance method declarations, including <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> attribute is not legal since it defines a class rather than an instance method.  
  
 Using <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, you can also write a single method that implements multiple methods defined in an interface, as in the following example:  
  
 [!code[VbVbalrOOP#70](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_3.vb)]  
  
 You can use a private member to implement an interface member. When a private member implements a member of an interface, that member becomes available by way of the interface even though it is not available directly on object variables for the class.  
  
### Interface Implementation Examples  
 Classes that implement an interface must implement all its properties, methods, and events.  
  
 The following example defines two interfaces. The second interface, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, inherits <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and defines an additional property and method.  
  
 [!code[VbVbalrOOP#39](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_4.vb)]  
  
 The next example implements <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the interface defined in the previous example:  
  
 [!code[VbVbalrOOP#40](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_5.vb)]  
  
 The final example implements <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, including a method inherited from <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>:  
  
 [!code[VbVbalrOOP#41](../vs140/codesnippet/VisualBasic/interfaces--visual-basic-_6.vb)]  
  
 You can implement a readonly property with a readwrite property (that is, you do not have to declare it readonly in the implementing class).  Implementing an interface promises to implement at least the members that the interface declares, but you can offer more functionality, such as allowing your property to be writable.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Walkthrough: Creating and Implementing Interfaces](../vs140/walkthrough--creating-and-implementing-interfaces--visual-basic-.md)|Provides a detailed procedure that takes you through the process of defining and implementing your own interface.|  
|[Variance in Generic Interfaces (C# and Visual Basic)](../vs140/variance-in-generic-interfaces--csharp-and-visual-basic-.md)|Discusses covariance and contravariance in generic interfaces and provides a list of variant generic interfaces in the .NET Framework.|