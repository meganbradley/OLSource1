---
title: "TN016: Using C++ Multiple Inheritance with MFC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.inheritance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN016"
  - "MI (Multiple Inheritance)"
  - "multiple inheritance, MFC support for"
ms.assetid: 4ee27ae1-1410-43a5-b111-b6af9b84535d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN016: Using C++ Multiple Inheritance with MFC
This note describes how to use multiple inheritance (MI) with the Microsoft Foundation Classes. The use of MI is not required with MFC. MI is not used in any MFC classes and is not required to write a class library.  
  
 The following subtopics describe how MI affects the use of common MFC idioms as well as covering some of the restrictions of MI. Some of these restrictions are general C++ restrictions. Others are imposed by the MFC architecture.  
  
 At the end of this technical note you will find a complete MFC application that uses MI.  
  
## CRuntimeClass  
 The persistence and dynamic object creation mechanisms of MFC use the [CRuntimeClass](../vs140/cruntimeclass-structure.md) data structure to uniquely identify classes. MFC associates one of these structures with each dynamic and/or serializable class in your application. These structures are initialized when the application starts by using a special static object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The current implementation of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not support MI runtime type information. This does not mean you cannot use MI in your MFC application. However, you will have certain responsibilities when you work with objects that have more than one base class.  
  
 The [CObject::IsKindOf](../vs140/cobject--iskindof.md) method will not correctly determine the type of an object if it has multiple base classes. Therefore, you cannot use [CObject](../vs140/cobject-class.md) as a virtual base class, and all calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member functions such as [CObject::Serialize](../vs140/cobject--serialize.md) and [CObject::operator new](../vs140/cobject--operator-new.md) must have scope qualifiers so that C++ can disambiguate the appropriate function call. When a program uses MI within MFC, the class that contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> base class needs to be the left-most class in the list of base classes.  
  
 An alternative is to use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operator. Casting an object with MI to one of its base classes will force the compiler to use the functions in the supplied base class. For more information, see [dynamic_cast Operator](../vs140/dynamic_cast-operator.md).  
  
## CObject - The Root of all Classes  
 All significant classes derive directly or indirectly from class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> does not have any member data, but it does have some default functionality. When you use MI, you will typically inherit from two or more <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-derived classes. The following example illustrates how a class can inherit from a [CFrameWnd](../vs140/cframewnd-class.md) and a [CObList](../vs140/coblist-class.md):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this case <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is included two times. This means that you need a way to disambiguate any reference to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> methods or operators. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and [operator delete](../vs140/cobject--operator-delete.md) are two operators that must be disambiguated. As another example, the following code causes an error at compile time:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Reimplementing CObject Methods  
 When you create a new class that has two or more <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> derived base classes, you should reimplement the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> methods that you want other people to use. Operators <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are mandatory and [Dump](../vs140/cobject--dump.md) is recommended. The following example reimplements the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operators and the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Virtual Inheritance of CObject  
 It might seem that virtually inheriting <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> would solve the problem of function ambiguity, but that is not the case. Because there is no member data in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, you do not need virtual inheritance to prevent multiple copies of a base class member data. In the first example that was shown earlier, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> virtual method is still ambiguous because it is implemented differently in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The best way to remove ambiguity is to follow the recommendations presented in the previous section.  
  
## CObject::IsKindOf and Run-Time Typing  
 The run-time typing mechanism supported by MFC in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> uses the macros <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. These macros can perform a run-time type check to guarantee safe downcasts.  
  
 These macros support only a single base class and will work in a limited way for multiply inherited classes. The base class you specify in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> should be the first (or left-most) base class. This placement will enable you to do type checking for the left-most base class only. The run-time type system will know nothing about additional base classes. In the following example, the run-time systems will do type checking against <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, but will know nothing about <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## CWnd and Message Maps  
 For the MFC message map system to work correctly, there are two additional requirements:  
  
-   There must be only one <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>-derived base class.  
  
-   The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>-derived base class must be the first (or left-most) base class.  
  
 Here are some examples that will not work:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## A Sample Program using MI  
 The following sample is a stand-alone application that consists of one class derived from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and [CWinApp](../vs140/cwinapp-class.md). We do not recommend that you structure an application in this manner, but this is an example of the smallest MFC application that has one class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)