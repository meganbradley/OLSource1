---
title: "Versioning with the Override and New Keywords (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "C# language, versioning"
  - "C# language, override and new"
ms.assetid: 88247d07-bd0d-49e9-a619-45ccbbfdf0c5
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Versioning with the Override and New Keywords (C# Programming Guide)
The C# language is designed so that versioning between [base](../vs140/base--csharp-reference-.md) and derived classes in different libraries can evolve and maintain backward compatibility. This means, for example, that the introduction of a new member in a base [class](../vs140/class--csharp-reference-.md) with the same name as a member in a derived class is completely supported by C# and does not lead to unexpected behavior. It also means that a class must explicitly state whether a method is intended to override an inherited method, or whether a method is a new method that hides a similarly named inherited method.  
  
 In C#, derived classes can contain methods with the same name as base class methods.  
  
-   The base class method must be defined [virtual](../vs140/virtual--csharp-reference-.md).  
  
-   If the method in the derived class is not preceded by [new](../vs140/new--csharp-reference-.md) or [override](../vs140/override--csharp-reference-.md) keywords, the compiler will issue a warning and the method will behave as if the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword were present.  
  
-   If the method in the derived class is preceded with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword, the method is defined as being independent of the method in the base class.  
  
-   If the method in the derived class is preceded with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword, objects of the derived class will call that method instead of the base class method.  
  
-   The base class method can be called from within the derived class using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword.  
  
-   The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keywords can also be applied to properties, indexers, and events.  
  
 By default, C# methods are not virtual. If a method is declared as virtual, any class inheriting the method can implement its own version. To make a method virtual, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> modifier is used in the method declaration of the base class. The derived class can then override the base virtual method by using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword or hide the virtual method in the base class by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword. If neither the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword nor the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is specified, the compiler will issue a warning and the method in the derived class will hide the method in the base class.  
  
 To demonstrate this in practice, assume for a moment that Company A has created a class named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which your program uses. The following is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideInheritance#27](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_1.cs)]  
  
 Your company uses this class, and you use it to derive your own class, adding a new method:  
  
 [!code[csProgGuideInheritance#28](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_2.cs)]  
  
 Your application is used without problems, until Company A releases a new version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which resembles the following code:  
  
 [!code[csProgGuideInheritance#29](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_3.cs)]  
  
 The new version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> now contains a method named <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Initially, nothing occurs. The new version is still binary compatible with the old version. Any software that you have deployed will continue to work, even if the new class is installed on those computer systems. Any existing calls to the method <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> will continue to reference your version, in your derived class.  
  
 However, as soon as you recompile your application by using the new version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, you will receive a warning from the compiler, CS0108. This warning informs you that you have to consider how you want your <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method to behave in your application.  
  
 If you want your method to override the new base class method, use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword:  
  
 [!code[csProgGuideInheritance#30](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_4.cs)]  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> keyword makes sure that any objects derived from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will use the derived class version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Objects derived from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> can still access the base class version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> by using the base keyword:  
  
 [!code[csProgGuideInheritance#44](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_5.cs)]  
  
 If you do not want your method to override the new base class method, the following considerations apply. To avoid confusion between the two methods, you can rename your method. This can be time-consuming and error-prone, and just not practical in some cases. However, if your project is relatively small, you can use Visual Studio's Refactoring options to rename the method. For more information, see [Refactoring Classes and Types](../vs140/refactoring-classes-and-types--class-designer-.md).  
  
 Alternatively, you can prevent the warning by using the keyword <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in your derived class definition:  
  
 [!code[csProgGuideInheritance#31](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_6.cs)]  
  
 Using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> keyword tells the compiler that your definition hides the definition that is contained in the base class. This is the default behavior.  
  
## Override and Method Selection  
 When a method is named on a class, the C# compiler selects the best method to call if more than one method is compatible with the call, such as when there are two methods with the same name, and parameters that are compatible with the parameter passed. The following methods would be compatible:  
  
 [!code[csProgGuideInheritance#32](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_7.cs)]  
  
 When <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is called on an instance of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the C# compiler will first try to make the call compatible with the versions of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> declared originally on <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. Override methods are not considered as declared on a class, they are new implementations of a method declared on a base class. Only if the C# compiler cannot match the method call to an original method on <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> will it try to match the call to an overridden method with the same name and compatible parameters. For example:  
  
 [!code[csProgGuideInheritance#33](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_8.cs)]  
  
 Because the variable <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> can be converted to a double implicitly, the C# compiler calls <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. There are two ways to avoid this. First, avoid declaring new methods with the same name as virtual methods. Second, you can instruct the C# compiler to call the virtual method by making it search the base class method list by casting the instance of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Because the method is virtual, the implementation of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> will be called. For example:  
  
 [!code[csProgGuideInheritance#34](../vs140/codesnippet/CSharp/versioning-with-the-override-and-new-keywords--csharp-programming-guide-_9.cs)]  
  
 For more examples of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, see [Knowing When to Use Override and New Keywords (C# Programming Guide)](../vs140/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Inheritance (C# Programming Guide)](../vs140/inheritance--csharp-programming-guide-.md)