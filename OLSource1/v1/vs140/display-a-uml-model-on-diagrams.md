---
title: "Display a UML model on diagrams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API"
ms.assetid: adf1f1f2-2ad9-4ade-82de-c6a5194ab471
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Display a UML model on diagrams
In the program code for an extension to Visual Studio, you can control how model elements are displayed on diagrams. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
 In this topic:  
 -   [To display an element on a diagram](#Display)  
  
-   [Accessing the shapes that represent an element](#GetShapes)  
  
-   [Moving and resizing shapes](#Moving)  
  
-   [To remove a shape from a diagram](#Removing)  
  
-   [Opening and creating diagrams](#Opening)  
  
-   [Example: Command for Aligning Shapes](#AlignCommand)  
  
##  \<a name="Display">\</a> To display an element on a diagram  
 When you create an element such as a use case or an action, the user can see it in UML Model Explorer, but it does not always automatically appear in a diagram. In some cases, you must write code to display it. The following table summarizes the alternatives.  
  
|Type of element|For example|To display this, your code must|  
|---------------------|-----------------|-------------------------------------|  
|Classifier|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Create associated shapes on specified diagrams. You can create any number of shapes for each classifier.\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<br />\<br /> Set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for a shape at the top level of the diagram.\<br />\<br /> To display one shape inside another:\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **Note:**  If you perform Display inside an **ILinkedUndo** transaction, the method sometimes returns no <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. But the shape is correctly created, and is accessible using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|Child of Classifier|Attribute, Operation,\<br />\<br /> Part, Port|Automatic - no code required.\<br />\<br /> It is displayed as part of the parent.|  
|Behavior|Interaction (Sequence),\<br />\<br /> Activity|Bind the behavior to an appropriate diagram.\<br />\<br /> Each behavior can be bound to at most one diagram at a time.\<br />\<br /> For example:\<br />\<br /> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|Child of behavior|Lifelines, messages, actions, object nodes|Automatic - no code required.\<br />\<br /> It is displayed if the parent is bound to a diagram.|  
|Relationship|Association, generalization, flow, dependency|Automatic - no code required.\<br />\<br /> It is displayed on every diagram on which both ends are displayed.|  
  
##  \<a name="GetShapes">\</a> Accessing the shapes that represent an element  
 The shape that represents an element belongs to the types:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> *ElementType* <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 where *ElementType* is a type of the model element such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|All the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> that represent this element in open diagrams.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|All the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> that represent this element on a particular diagram.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> that the shape represents. You would normally cast it to a subclass of IElement.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> that contains the shape.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The shape that contains <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For example, a port shape is contained within a component shape.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Shapes contained within an <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The shapes contained within an <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> that represent elements of the specified type, such as <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Cast a generic <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to a strongly typed <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Cast a shape from one parameterized shape type to another.|  
  
##  \<a name="Moving">\</a> Moving and resizing shapes  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Move or resize a shape.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Activate the window and scroll the diagram so that all the given shapes are visible. The shapes must all be on the diagram. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is true, the diagram will be scaled if necessary so that all of the shapes are visible.|  
  
 For an example, see [Defining an Alignment Command](#AlignCommand).  
  
##  \<a name="Removing">\</a> To remove a shape from a diagram  
 You can delete shapes of some types of element without deleting the element.  
  
|Model Element|To remove the shape|  
|-------------------|-------------------------|  
|A classifier: a class, interface, enumeration, actor, use case or component|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|A behavior: interaction or activity|You can delete the diagram from the project. Use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to get the path.\<br />\<br /> This does not delete the behavior from the model.|  
|Any other shape|You cannot explicitly delete other shapes from a diagram. The shape will automatically disappear if the element is deleted from the model, or if the parent shape is removed from the diagram.|  
  
##  \<a name="Opening">\</a> Opening and creating diagrams  
  
### To access the user's current diagram from a command or gesture extension  
 Declare this imported property in your class:  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
 In a method, access the diagram:  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  An instance of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> (and its subtypes such as <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>) is valid only within the command you are processing. It is not recommended to keep an <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object in a variable that persists while control is returned to the user.  
  
 For more information, see [How to Add Commands and Gestures to a UML Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
### To obtain a list of open diagrams  
 A list of diagrams that are currently open in the project:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## To access the diagrams in a project  
 The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] API can be used to open and create modeling projects and diagrams.  
  
 Notice the cast from <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Instances of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> and its subtypes are not valid after you return control to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 You can also obtain the model store from a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="AlignCommand">\</a> Example: Command for Aligning Shapes  
 The following code implements a menu command that aligns shapes neatly. The user must first place two or more shapes in approximate alignment, either vertically or horizontally. Then the align command can be used to align their centers.  
  
 To make the command available, add this code to a menu command project, and then deploy the resulting extension to your users. For more information, see [How to Define a Menu Command](../vs140/define-a-menu-command-on-a-modeling-diagram.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [How to: Navigate the UML Model](../vs140/navigate-the-uml-model.md)   
 [Sample: Align Shapes on a Diagram menu command](http://go.microsoft.com/fwlink/?LinkId=213809)   
 [Sample: Creating Elements, Shapes and Stereotypes](http://go.microsoft.com/fwlink/?LinkId=213811)