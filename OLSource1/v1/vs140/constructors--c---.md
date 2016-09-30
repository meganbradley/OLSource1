---
title: "Constructors (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "constructors [C++]"
  - "objects [C++], creating"
  - "instance constructors"
ms.assetid: 3e9f7211-313a-4a92-9584-337452e061a9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constructors (C++)
A constructor is a kind of member function that initializes an instance of its class. A constructor has the same name as the class and no return value. A constructor can have any number of parameters and a class may have any number of overloaded constructors. Constructors may have any accessibility, public, protected or private. If you don't define any constructors, the compiler will generate a default constructor that takes no parameters; you can override this behavior by declaring a default constructor as deleted.  
  
## In this topic  
  
-   [Order of Construction](#order_of_construction)  
  
-   [Member Lists](../vs140/constructors--c---.md#member_lists)  
  
-   [Explicit Constructors](../vs140/constructors--c---.md#explicit_constructors)  
  
-   [Default Constructors](../vs140/constructors--c---.md#default_constructors)  
  
-   [Copy and Move Constructors](../vs140/constructors--c---.md#copy_and_move_constructors)  
  
-   [Explicitly Defaulted and Deleted Constructors](../vs140/constructors--c---.md#explicitly_defaulted_and_deleted_constructors)  
  
-   [Constructors in Derived Classes](../vs140/constructors--c---.md#constructors_in_derived_classes)  
  
-   [Constructors for Classes That Have Multiple Inheritance](../vs140/constructors--c---.md#constructors_for_classes_that_have_multiple_inheritance)  
  
-   [Virtual Functions in Constructors](../vs140/constructors--c---.md#virtual_functions_in_constructors)  
  
-   [Constructors and Composite Classes](../vs140/constructors--c---.md#constructors_in_composite_classes)  
  
-   [Delegating Constructors](../vs140/constructors--c---.md#delegating_constructors)  
  
-   [Inheriting constructors (C++11)](../vs140/constructors--c---.md#inheriting_constructors)  
  
-   [Rules for Declaring Constructors](../vs140/constructors--c---.md#rules_for_declaring_constructors)  
  
-   Default and Copy Constructors  
  
-   [Explicitly invoking constructors](../vs140/constructors--c---.md#explicitly_invoking_constructors)  
  
##  \<a name="order_of_construction">\</a> Order of Construction  
 A constructor performs its work in this order:  
  
1.  It calls base class and member constructors in the order of declaration.  
  
2.  If the class is derived from virtual base classes, it initializes the object's virtual base pointers.  
  
3.  If the class has or inherits virtual functions, it initializes the object's virtual function pointers. Virtual function pointers point to the class's virtual function table to enable correct binding of virtual function calls to code.  
  
4.  It executes any code in its function body.  
  
 The following example shows the order in which base class and member constructors are called in the constructor for a derived class. First, the base constructor is called, then the base-class members are initialized in the order in which they appear in the class declaration, and then the derived constructor is called.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Here's the output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If a constructor throws an exception, the order of destruction is the reverse of the order of construction:  
  
1.  The code in the body of the constructor function is unwound.  
  
2.  Base class and member objects are destroyed, in the reverse order of declaration.  
  
3.  If the constructor is non-delegating, all fully-constructed base class objects and members are destroyed. However, because the object itself is not fully constructed, the destructor is not run.  
  
##  \<a name="member_lists">\</a> Member Lists  
 Initialize class members from constructor arguments by using a member initializer list. This method uses *direct initialization*, which is more efficient than using assignment operators inside the constructor body.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Create a Box object:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="explicit_constructors">\</a> Explicit Constructors  
 If a class has a constructor with a single parameter, or if all parameters except one have a default value, the parameter type can be implicitly converted to the class type. For example, if the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class has a constructor like this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 It is possible to initialize a Box like this:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Or pass an int to a function that takes a Box:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Such conversions can be useful in some cases, but more often they can lead to subtle but serious errors in your code. As a general rule, you should use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword on a constructor (and user-defined operators) to prevent this kind of implicit type conversion:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 When the constructor is explicit, this line causes a compiler error: <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  For more information, see [User-Defined Type Conversions (C++)](../vs140/user-defined-type-conversions--c---.md).  
  
##  \<a name="default_constructors">\</a> Default Constructors  
 *Default constructors* have no parameters; they follow slightly different rules:  
  
 Default constructors are one of the *special member functions*; if no constructors are declared in a class, the compiler provides a default constructor:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 When you call a default constructor and try to use parentheses, a warning is issued:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 This is an example of the Most Vexing Parse problem. Because the example expression can be interpreted either as the declaration of a function or as the invocation of a default constructor, and because C++ parsers favor declarations over other things, the expression is treated as a function declaration. For more information, see [Most Vexing Parse](http://en.wikipedia.org/wiki/Most_vexing_parse).  
  
 If any non-default constructors are declared, the compiler does not provide a default constructor:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 If a class has no default constructor, an array of objects of that class cannot be constructed by using square-bracket syntax alone. For example, given the previous code block, an array of Boxes cannot be declared like this:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 However, you can use a set of initializer lists to initialize an array of Boxes:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="copy_and_move_constructors">\</a> Copy and Move Constructors  
 A *copy constructor* is a special member function that takes as input a reference to an object of the same type, and makes a copy of it. For more information, see [Copy Constructors and Copy Assignment Operators (C++)](../vs140/copy-constructors-and-copy-assignment-operators--c---.md). A move is also a special member function constructor moves ownership of an existing object to a new variable without copying the original data. For more information, see  [Move Constructors and Move Assignment Operators (C++)](assetId:///1442de5f-37a5-42a1-83a6-ec9cfe0414db) and  [How to: Write a Move Constructor](../vs140/move-constructors-and-move-assignment-operators--c---.md).  
  
##  \<a name="explicitly_defaulted_and_deleted_constructors">\</a> Explicitly Defaulted and Deleted Constructors  
 You can explicitly default copy constructors, default constructors, move constructors, copy assignment operators, move assignment operators, and destructors. You can explicitly delete all of the special member functions. For more information, see [Explicitly Defaulted and Deleted Functions](../vs140/explicitly-defaulted-and-deleted-functions.md).  
  
##  \<a name="constructors_in_derived_classes">\</a> Constructors in Derived Classes  
 A derived class constructor always calls a base class constructor, so that it can rely on completely constructed base classes before any extra work is done. The base class constructors are called in order of derivation—for example, if ClassA is derived from ClassB, which is derived from ClassC, the ClassC constructor is called first, then the ClassB constructor, then the ClassA constructor.  
  
 If a base class does not have a default constructor, you must supply the base class constructor parameters in the derived class constructor:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Constructors for Classes That Have Multiple Inheritance  
 If a class is derived from multiple base classes, the base class constructors are invoked in the order in which they are listed in the declaration of the derived class:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 You should expect the following output:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="virtual_functions_in_constructors">\</a> Virtual Functions in Constructors  
 We recommend that you be careful when you call virtual functions in constructors. Because the base class constructor is always invoked before the derived class constructor, the function that's called in the base constructor is the base class version, not the derived class version. In the following example, constructing a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> causes the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> implementation of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to execute before the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> constructor causes the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> implementation of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to execute:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Here's the output:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="constructors_in_composite_classes">\</a> Constructors and Composite Classes  
 Classes that contain class-type members are known as *composite classes*. When a class-type member of a composite class is created, the constructor is called before the class's own constructor. When a contained class lacks a default constructor, you must use an initialization list in the constructor of the composite class. In the earlier <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> example, if you change the type of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member variable to a new <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> class, you must call both the base class constructor and initialize the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> variable in the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> constructor:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="delegating_constructors">\</a> Delegating Constructors  
 A *delegating constructor* calls a different constructor in the same class to do some of the work of initialization. In the following example, the derived class has three constructors—the second constructor delegates to the first, and the third constructor delegates to the second:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Here's the output:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The object created by the constructors is fully initialized as soon as any constructor is finished. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> succeeds, but <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> fails and the destructor is called.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Output:  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 For more information, see [Uniform Initialization and Delegating Constructors](../vs140/uniform-initialization-and-delegating-constructors.md).  
  
##  \<a name="inheriting_constructors">\</a> Inheriting constructors (C++11)  
 A derived class can inherit the constructors from a direct base class by using a using declaration as shown in the following example:  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The using statement brings into scope all constructors from the base class except those that have an identical signature to constructors in the derived class. In general, it is best to use inheriting constructors when the derived class declares no new data members or constructors.  
  
 A class template can inherit all the constructors from a type argument if that type specifies a base class:  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A deriving class cannot inherit from multiple base classes if those base classes have constructors that have an identical signature.  
  
##  \<a name="rules_for_declaring_constructors">\</a> Rules for Declaring Constructors  
 A constructor has the same name as its class. Any number of constructors can be declared, subject to the rules of overloaded functions. (For more information, see [Overloading](../vs140/overloading---c---.md).)  
  
 The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> may be empty.  
  
 C++ defines two special kinds of constructors, default and copy constructors, described in the following table.  
  
### Default and Copy Constructors  
  
|Kind of Construction|Arguments|Purpose|  
|--------------------------|---------------|-------------|  
|Default constructor|Can be called with no arguments|Construct a default object of the class type|  
|Copy constructor|Can accept a single argument of reference to same class type|Copy objects of the class type|  
  
 Default constructors can be called with no arguments. However, you can declare a default constructor with an argument list, provided all arguments have defaults. Similarly, copy constructors must accept a single argument of reference to the same class type. More arguments can be supplied, provided all subsequent arguments have defaults.  
  
 If you do not supply any constructors, the compiler attempts to generate a default constructor. If you do not supply a copy constructor, the compiler attempts to generate one. These compiler-generated constructors are considered public member functions. An error is generated if you specify a copy constructor with a first argument that is an object and not a reference.  
  
 A compiler-generated default constructor sets up the object (initializes vftables and vbtables, as described previously), and it calls the default constructors for base classes and members, but it takes no other action. Base class and member constructors are called only if they exist, are accessible, and are unambiguous.  
  
 A compiler-generated copy constructor sets up a new object and performs a memberwise copy of the contents of the object to be copied. If base class or member constructors exist, they are called; otherwise, bitwise copying is performed.  
  
 If all base and member classes of a class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> have copy constructors that accept a **const** argument, the compiler-generated copy constructor accepts a single argument of type **const** <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>**&**. Otherwise, the compiler-generated copy constructor accepts a single argument of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>**&**.  
  
 You can use a constructor to initialize a **const** or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object, but the constructor itself cannot be declared as **const** or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The only legal storage class for a constructor is **inline**; use of any other storage-class modifier, including the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> keyword, with a constructor causes a compiler error.  
  
 The stdcall calling convention is used on static member functions and global functions declared with the **__stdcall** keyword, and that do not use a variable argument list. When you use the **__stdcall** keyword on a non-static member function, such as a constructor, the compiler will use the thiscall calling convention."  
  
 Constructors of base classes are not inherited by derived classes. When an object of derived class type is created, it is constructed starting with the base class components; then it moves to the derived class components. The compiler uses each base class's constructor as that part of the complete object is initialized (except in cases of virtual derivation, as described in [Initializing Base Classes](../vs140/initializing-base-classes.md)).  
  
##  \<a name="explicitly_invoking_constructors">\</a> Explicitly invoking constructors  
 Constructors can be explicitly called in a program to create objects of a given type. For example, to create two <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects that describe the ends of a line, the following code can be written:  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Two objects of type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> are created, passed to the function <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, and destroyed at the end of the expression (the function call).  
  
 Another context in which a constructor is explicitly called is in an initialization:  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is created and initialized using the constructor that accepts two arguments of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 Objects that are created by calling constructors explicitly, as in the preceding two examples, are unnamed and have a lifetime of the expression in which they are created. This is discussed in greater detail in [Temporary Objects](../vs140/temporary-objects.md).  
  
 It is usually safe to call any member function from within a constructor because the object has been completely set up (virtual tables have been initialized and so on) prior to the execution of the first line of user code. However, it is potentially unsafe for a member function to call a virtual member function for an abstract base class during construction or destruction.  
  
 Constructors can call virtual functions. When virtual functions are called, the function invoked is the function defined for the constructor's own class (or inherited from its bases). The following example shows what happens when a virtual function is called from within a constructor:  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 When the preceding program is run, the declaration <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> causes the following sequence of events:  
  
1.  The constructor for class <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) is called.  
  
2.  Prior to entering the body of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> class's constructor, the constructor for class <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>) is called.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> calls the function <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, which is a virtual function. Ordinarily, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> would be called because the object <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. Because the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function is a constructor, the object is not yet of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> type, and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is called.  
  
## See Also  
 [Special Member Functions](../vs140/special-member-functions--c---.md)