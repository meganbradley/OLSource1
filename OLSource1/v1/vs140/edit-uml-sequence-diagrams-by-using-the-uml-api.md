---
title: "Edit UML sequence diagrams by using the UML API"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML activity diagrams, programming"
ms.assetid: 8cdd0203-85ef-4c62-9abc-da4cb26fa504
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Edit UML sequence diagrams by using the UML API
An interaction is a sequence of messages between a set of lifelines. An interaction is displayed on a UML sequence diagram.  
  
 For full details of the API, see \<xref:Microsoft.VisualStudio.Uml.Interactions*?displayProperty=fullName>.  
  
 For a more general introduction to writing commands and gesture handlers for UML diagrams, see [How to: Add Commands and Gestures to a Modeling Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
## Basic Code  
  
### Namespace imports  
 You must include the following <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you are creating menu commands and gesture handlers, you will also need:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information, see [How to Add Commands and Gestures to a Modeling Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
### Getting the context  
 If you are editing an interaction as part of a command or gesture handler in a sequence diagram, you can obtain a reference to the context. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Generated and UML Sequence Diagrams  
 There are two kinds of sequence diagrams: those that are manually created in a UML modeling project, and those that were generated from program code. Use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property to discover which sequence diagram you have.  
  
> [!NOTE]
>  This property returns false only for sequence diagrams generated from code using Visual Studio 2013 and earlier. This includes code-generated sequence diagrams migrated from 2013 and earlier. This version of Visual Studio doesn't support generating new sequence diagrams.  
  
 For example, if you want to make a menu command that is only visible on UML sequence diagrams, then the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method could include the following statement:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 On a generated sequence diagram, lifelines, messages, and other elements are mostly the same as on a UML sequence diagram. In a UML model, the Model Store has a root, which is the Model that owns all the other elements. But a generated interaction exists in its own Model Store, which has a null root:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## To create and display an Interaction  
 Create the interaction as a child of a package or model.  
  
 For example, if you are developing a command that might be performed on a blank sequence diagram, you should always begin by checking whether the interaction exists.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Updating an Interaction and its Layout  
 When you update an Interaction, always end your operation by updating its layout using one of the following methods:  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> adjusts the positions of shapes that have recently been inserted or moved, and their neighboring shapes.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> redraws the whole diagram. You can use the parameter to specify repositioning of the lifelines, the messages, or both.  
  
 This is particularly important when you insert new elements or move existing elements. They will not be in the correct positions on the diagram until you have performed one of these operations. You only need to call one of these operations once at the end of a series of changes.  
  
 To avoid bemusing the user who performs an undo after your command, use an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to enclose your changes and the final <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operations. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 To use an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, you must make this declaration in your class:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For more information, see [How to Link Model Updates using Transactions](../vs140/link-uml-model-updates-by-using-transactions.md).  
  
## Building an Interaction  
  
### To create lifelines  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A lifeline represents a connectable element, that is, an instance of a type. For example, if the interaction is used to show how a component delegates incoming messages to its internal parts, the lifelines can represent the ports and parts of the component:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Alternatively, if the interaction shows an arbitrary set of objects, you can create a property or other <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in the interaction itself:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 As a further alternative, you can set the name and type of a lifeline without linking it to a connectable element:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### To create messages  
 To create a message, you must identify insertion points on the source and target lifelines. For example:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 To create a message that has an undefined source or undefined target:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 There are several messages that you can use to identify insertion points at all the key points on a lifeline:  
  
|Method on ILifeline|Use it to insert at this point|  
|-------------------------|------------------------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The top of the lifeline.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|The bottom of the lifeline.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|A point immediately after the specified message.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The point can be either on the lifeline, or on a parent execution specification block.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A point following an Interaction Use.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|A point following a Combined Fragment.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|The top of an execution block.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The top of an operand of a combined fragment.|  
  
 When you create messages, take care to avoid defining a message that would cross over another message.  
  
### To Create Combined Fragments and Interaction Uses  
 You can create combined fragments and Interaction Uses by specifying an insertion point on each lifeline that must be covered by the element. Take care to avoid specifying a set of points that would cross over an existing message or fragment.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 You can also create a combined fragment that covers an existing set of messages. The messages must all be sourced at the same lifeline or execution block.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A combined fragment is always created with a single operand. To create a new operand, you must specify the existing operand that you want to insert before or after, and whether you want to insert after it or before it:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Troubleshooting  
 Shapes will appear in incorrect positions if changes are not completed with an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> operation.  
  
 Most other problems are caused by insertion points being misaligned, so that new messages or fragments would have to cross over others. The symptoms can be that no change is performed, or an exception is thrown. The exception might not be thrown until the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> operation is performed.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Uml.Interactions*?displayProperty=fullName>   
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [How to Add Commands and Gestures to UML Diagrams](../vs140/define-a-menu-command-on-a-modeling-diagram.md)   
 [How to Define a Toolbox Item](../vs140/define-a-custom-modeling-toolbox-item.md)   
 [How to use validation constraints](../vs140/define-validation-constraints-for-uml-models.md)   
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)