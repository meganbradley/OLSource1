---
title: "Multiple Base Classes"
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
  - "base classes, multiple"
  - "derived classes, multiple bases"
  - "multiple inheritance, class declaration"
  - "multiple base classes"
ms.assetid: a30c69fe-401c-4a87-96a0-e0da70c7c740
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multiple Base Classes
As described in [Multiple Inheritance](assetId:///3b74185e-2beb-4e29-8684-441e51d2a2ca), a class can be derived from more than one base class. In a multiple-inheritance model (where classes are derived from more than one base class), the base classes are specified using the *base-list* grammar element (see the Grammar section in [Overview](../vs140/overview-of-derived-classes.md)). For example, the class declaration for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, can be specified:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The order in which base classes are specified is not significant except in certain cases where constructors and destructors are invoked. In these cases, the order in which base classes are specified affects the following:  
  
-   The order in which initialization by constructor takes place. If your code relies on the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> portion of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to be initialized before the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> part, the order of specification is significant. Initialization takes place in the order the classes are specified in the *base-list*.  
  
-   The order in which destructors are invoked to clean up. Again, if a particular "part" of the class must be present when the other part is being destroyed, the order is significant. Destructors are called in the reverse order of the classes specified in the *base-list*.  
  
    > [!NOTE]
    >  The order of specification of base classes can affect the memory layout of the class. Do not make any programming decisions based on the order of base members in memory.  
  
 When specifying the *base-list*, you cannot specify the same class name more than once. However, it is possible for a class to be an indirect base to a derived class more than once.  
  
## Virtual base classes  
 Because a class can be an indirect base class to a derived class more than once, C++ provides a way to optimize the way such base classes work. Virtual base classes offer a way to save space and avoid ambiguities in class hierarchies that use multiple inheritance.  
  
 Each nonvirtual object contains a copy of the data members defined in the base class. This duplication wastes space and requires you to specify which copy of the base class members you want whenever you access them.  
  
 When a base class is specified as a virtual base, it can act as an indirect base more than once without duplication of its data members. A single copy of its data members is shared by all the base classes that use it as a virtual base.  
  
 When declaring a virtual base class, the **virtual** keyword appears in the base lists of the derived classes.  
  
 Consider the class hierarchy in the following figure, which illustrates a simulated lunch line.  
  
 ![Graph of simulated lunch line](../vs140/media/vc38xp1.gif "vc38XP1")  
Simulated Lunch-Line Graph  
  
 In the figure, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the base class for both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. However, when both classes are combined to form <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the following problem arises: the new class contains two subobjects of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, one from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and the other from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The following figure shows the conceptual memory layout (the actual memory layout might be optimized).  
  
 ![Simulated lunch&#45;line object](../vs140/media/vc38xp2.gif "vc38XP2")  
Simulated Lunch-Line Object  
  
 Note that there are two <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> subobjects in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. The following code declares <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to be a virtual base class:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> keyword ensures that only one copy of the subobject <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is included (see the following figure).  
  
 ![Simulated lunch&#45;line object, virtual base classes](../vs140/media/vc38xp3.gif "vc38XP3")  
Simulated Lunch-Line Object with Virtual Base Classes  
  
 A class can have both a virtual component and a nonvirtual component of a given type. This happens in the conditions illustrated in the following figure.  
  
 ![Virtual and nonvirtual components of a class](../vs140/media/vc38xp4.gif "vc38XP4")  
Virtual and Nonvirtual Components of the Same Class  
  
 In the figure, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> as a virtual base class. However, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> specifies <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> as a base class, not a virtual base class. Therefore, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> has two subobjects of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>: one from the inheritance path that includes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and one from the path that includes <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This is illustrated in the following figure.  
  
 ![Virtual & nonvirtual inheritance in object layout](../vs140/media/vc38xp5.gif "vc38XP5")  
Object Layout with Virtual and Nonvirtual Inheritance  
  
> [!NOTE]
>  Virtual inheritance provides significant size benefits when compared with nonvirtual inheritance. However, it can introduce extra processing overhead.  
  
 If a derived class overrides a virtual function that it inherits from a virtual base class, and if a constructor or a destructor for the derived base class calls that function using a pointer to the virtual base class, the compiler may introduce additional hidden "vtordisp" fields into the classes with virtual bases. The /vd0 compiler option suppresses the addition of the hidden vtordisp constructor/destructor displacement member. The /vd1 compiler option, the default, enables them where they are necessary. Turn off vtordisps only if you are sure that all class constructors and destructors call virtual functions virtually.  
  
 The /vd compiler option affects an entire compilation module. Use the **vtordisp** pragma to suppress and then reenable vtordisp fields on a class-by-class basis:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Name ambiguities  
 Multiple inheritance introduces the possibility for names to be inherited along more than one path. The class-member names along these paths are not necessarily unique. These name conflicts are called "ambiguities."  
  
 Any expression that refers to a class member must make an unambiguous reference. The following example shows how ambiguities develop:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Given the preceding class declarations, code such as the following is ambiguous because it is unclear whether <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> refers to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Consider the preceding example. Because the name <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a member of both class <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and class <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the compiler cannot discern which <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> designates the function to be called. Access to a member is ambiguous if it can refer to more than one function, object, type, or enumerator.  
  
 The compiler detects ambiguities by performing tests in this order:  
  
1.  If access to the name is ambiguous (as just described), an error message is generated.  
  
2.  If overloaded functions are unambiguous, they are resolved. (For more information about function overloading ambiguity, see [Argument Matching](../vs140/argument-matching.md).)  
  
3.  If access to the name violates member-access permission, an error message is generated. (For more information, see [Member-Access Control](../vs140/member-access-control--c---.md).)  
  
 When an expression produces an ambiguity through inheritance, you can manually resolve it by qualifying the name in question with its class name. To make the preceding example compile properly with no ambiguities, use code such as:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
> [!NOTE]
>  When <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is declared, it has the potential to cause errors when <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is referenced in the scope of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. No error is issued, however, until an unqualified reference to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is actually made in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>'s scope.  
  
### Dominance  
 It is possible for more than one name (function, object, or enumerator) to be reached through an inheritance graph. Such cases are considered ambiguous with nonvirtual base classes. They are also ambiguous with virtual base classes, unless one of the names "dominates" the others.  
  
 A name dominates another name if it is defined in both classes and one class is derived from the other. The dominant name is the name in the derived class; this name is used when an ambiguity would otherwise have arisen, as shown in the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Ambiguous conversions  
 Explicit and implicit conversions from pointers or references to class types can cause ambiguities. The next figure, Ambiguous Conversion of Pointers to Base Classes, shows the following:  
  
-   The declaration of an object of type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
-   The effect of applying the address-of operator (**&**) to that object. Note that the address-of operator always supplies the base address of the object.  
  
-   The effect of explicitly converting the pointer obtained using the address-of operator to the base-class type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. Note that coercing the address of the object to type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> does not always provide the compiler with enough information as to which subobject of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to select; in this case, two subobjects exist.  
  
 ![Ambiguous conversion of pointers to base classes](../vs140/media/vc38xt1.gif "vc38XT1")  
Ambiguous Conversion of Pointers to Base Classes  
  
 The conversion to type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> (pointer to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) is ambiguous because there is no way to discern which subobject of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is the correct one. Note that you can avoid the ambiguity by explicitly specifying which subobject you mean to use, as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Ambiguities and virtual base classes  
 If virtual base classes are used, functions, objects, types, and enumerators can be reached through multiple-inheritance paths. Because there is only one instance of the base class, there is no ambiguity when accessing these names.  
  
 The following figure shows how objects are composed using virtual and nonvirtual inheritance.  
  
 ![Virtual derivation and nonvirtual derivation](../vs140/media/vc38xr1.gif "vc38XR1")  
Virtual vs. Nonvirtual Derivation  
  
 In the figure, accessing any member of class <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> through nonvirtual base classes causes an ambiguity; the compiler has no information that explains whether to use the subobject associated with <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or the subobject associated with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. However, when <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is specified as a virtual base class, there is no question which subobject is being accessed.  
  
## See Also  
 [Inheritance](../vs140/inheritance---c---.md)