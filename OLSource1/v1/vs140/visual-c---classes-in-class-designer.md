---
title: "Visual C++ Classes in Class Designer"
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
  - "vs.classdesigner.inheritancelinelabel"
helpviewer_keywords: 
  - "Class Designer [Visual Studio], classes"
ms.assetid: 75e56f8c-11ef-42a3-b7ec-3d2cf25c581b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual C++ Classes in Class Designer
Class Designer supports C++ classes and visualizes native C++ classes in the same way as Visual Basic and Visual C# class shapes, except that C++ classes can have multiple inheritance relationships. You can expand the class shape to show more fields and methods in the class or collapse it to conserve space.  
  
> [!NOTE]
>  Class Designer does not support unions (a special type of class in which the memory allocated is only the amount necessary for the union's largest data member).  
  
## Simple Inheritance  
 When you drag more than one class onto a class diagram, and the classes have a class inheritance relationship, an arrow connects them. The arrow points in the direction of the base class. For example, when the following classes are displayed in a class diagram, an arrow connects them, pointing from B to A:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also drag only class B to the class diagram, right-click the class shape for B, and then click **Show Base Classes**. This displays its base class: A.  
  
## Multiple Inheritance  
 Class Designer supports the visualization of multiple-class inheritance relationships. *Multiple inheritance* is used when a derived class has attributes of more than one base class. Following is an example of multiple inheritance:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When you drag more than one class onto the class diagram, and the classes have a multiple-class inheritance relationship, an arrow connects them. The arrow points in the direction of the base classes.  
  
 Right-clicking a class shape and then clicking **Show Base Classes** displays the base classes for the selected class.  
  
> [!NOTE]
>  The **Show Derived Classes** command is not supported for C++ code. You can display derived classes by going to Class View, expanding the type node, expanding the **Derived Types** subfolder, and then dragging those types onto the class diagram.  
  
 For more information about multiple-class inheritance, see [(NOTINBUILD) Multiple Inheritance](assetId:///3b74185e-2beb-4e29-8684-441e51d2a2ca) and [Multiple Base Classes](../vs140/multiple-base-classes.md).  
  
## Abstract Classes  
 Class Designer supports abstract classes (also named "abstract base classes"). These are classes that you never instantiate, but from which you can derive other classes. Using an example from "Multiple Inheritance" earlier in this document, you might instantiate the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class as individual objects as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 However, you might not intend to instantiate the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class as individual objects. You might intend only to derive other types of animal classes from it, for example, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. In that case, you would declare the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class as an abstract base class.  
  
 To declare a class as abstract, you can use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword. Members marked as abstract, or included in an abstract class, are virtual and must be implemented by classes that derive from the abstract class.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can also declare a class as abstract by including at least one pure virtual function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When you display these declarations in a Class Diagram, the class name <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and its pure virtual function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are in displayed in italic in an abstract class shape, together with the notation **Abstract Class**. Notice that the abstract class type shape is the same as that of a regular class, except that its border is a dotted line.  
  
 A class derived from an abstract base class must override each pure virtual function in the base class, or the derived class cannot be instantiated. So, for example, if you derive a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must override the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When you display this code in a Class Diagram, Class Designer draws an inheritance line from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Anonymous Classes  
 Class Designer supports anonymous classes. *Anonymous class types* are classes declared without an identifier. They cannot have a constructor or destructor, cannot be passed as arguments to functions, and cannot be returned as return values from functions. You can use an anonymous class to replace a class name with a typedef name, as in the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Structures can also be anonymous. Class Designer displays anonymous classes and structures the same as it displays the respective type. Although you can declare and display anonymous classes and structures, Class Designer will not use the tag name that you specify. It will use the name that Class View generates. The class or structure appears in Class View and Class Designer as an element called **__unnamed**.  
  
 For more information about anonymous classes, see [Anonymous Class Types](../vs140/anonymous-class-types.md).  
  
## Template Classes  
 Class Designer supports the visualization of template classes. Nested declarations are supported. The following table shows some typical declarations.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
  
 The following table shows some examples of partial specialization.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
  
 The following table shows some examples of inheritance in partial specialization.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>\<br />\<br /> Template Class\<br />\<br /> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> (points to Class A)\<br />\<br /> <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> (points to Class A)|  
  
 The following table shows some examples of partial specialization template functions.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>\<br />\<br /> func\<T, U> (+ 1 overload)|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>\<br />\<br /> Template Class\<br />\<br /> <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>\<br />\<br /> Template Class\<br />\<br /> (B is contained within class A under **Nested Types**)|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> -> C\<int>\<br />\<br /> <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
  
 The following table shows some examples of template inheritance.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> ->B\<br />\<br /> <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> (B is contained within class C under **Nested Types**)\<br />\<br /> <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>\<br />\<br /> Template Class|  
  
 The following table shows some examples of canonical specialized class connection.  
  
|Code element|Class Designer view|  
|------------------|-------------------------|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> ->C\<int>\<br />\<br /> <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>\<br />\<br /> Template Class\<br />\<br /> <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>\<br />\<br /> Class\<br />\<br /> ->C\<float>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>\<br />\<br /> min \<T>|  
  
## See Also  
 [Working with Visual C++ Code in Class Designer](../vs140/working-with-visual-c---code--class-designer-.md)   
 [Classes, Structures, and Unions](../vs140/classes-and-structs--c---.md)   
 [Anonymous Class Types](../vs140/anonymous-class-types.md)   
 [(NOTINBUILD) Multiple Inheritance](assetId:///3b74185e-2beb-4e29-8684-441e51d2a2ca)   
 [Multiple Base Classes](../vs140/multiple-base-classes.md)   
 [Templates](../vs140/templates--c---.md)