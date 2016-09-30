---
title: "Visual C++ Typedefs in Class Designer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.classdesigner.typedef"
  - "vs.classdesigner.aliasofline"
helpviewer_keywords: 
  - "Class Designer [Visual Studio], typedefs"
ms.assetid: c1984108-71fc-4d3a-b4d4-3eac2c6b4ebf
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual C++ Typedefs in Class Designer
Typedef statements create one or more layers of indirection between a name and its underlying type. The Class Designer supports C++ typedef types, which are declared with the keyword <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, for example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can then use this type to declare an instance:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 Although you can declare a typedef without a name, Class Designer will not use the tag name that you specify; it will use the name that Class View generates. For example, the following declaration is valid, but it appears in Class View and Class Designer as an object named **__unnamed**:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type, see [(NOTINBUILD)typedef Specifier](assetId:///cc96cf26-ba93-4179-951e-695d1f5fdcf1).  
  
 A C++ typedef shape has the shape of the type specified in the typedef. For example, if the source declares <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the shape has rounded corners and the label **Class**. For <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the shape has square corners and the label **Struct**.  
  
 Classes and structures can have nested typedefs declared within them; therefore, class and structure shapes can show nested typedef declarations as nested shapes.  
  
 Typedef shapes support the **Show as Association** and **Show as Collection Association** commands on the context menu.  
  
 The following are some examples of typdef types that the Class Designer supports:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 *name* : *type*  
  
 typedef  
  
 Draws an association line connecting to type *name*, if possible.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 typedef  
  
 Typedef for function pointers. No association line is drawn.  
  
 Class Designer does not display a typedef if its source type is a function pointer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 typedef  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 Class  
  
 Draws an association line pointing from the source type shape to the target type shape.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 Class  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 typedef  
  
 Right-clicking a typedef shape and clicking **Show As Association** displays the typedef or class and an **Alias of** line joining the two shapes (similar to an association line).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 typedef  
  
 Same as above.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 Class  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 typedef  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 Class  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a nested typedef shape.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>Class  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 typedef  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 typedef  
  
 -> B  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 Class  
  
 -> MyB  
  
 Class Designer does not support displaying this kind of relationship by using a context menu command.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 Class  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 typedef  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
 Class  
  
 -> MyIntVect  
  
## See Also  
 [Working with Visual C++ Code in Class Designer](../vs140/working-with-visual-c---code--class-designer-.md)   
 [(NOTINBUILD)typedef Specifier](assetId:///cc96cf26-ba93-4179-951e-695d1f5fdcf1)