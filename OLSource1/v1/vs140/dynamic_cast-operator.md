---
title: "dynamic_cast Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "dynamic_cast"
  - "dynamic_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dynamic_cast keyword [C++]"
ms.assetid: f380ada8-6a18-4547-93c9-63407f19856b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dynamic_cast Operator
Converts the operand <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to an object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be a pointer or a reference to a previously defined class type or a "pointer to void". The type of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be a pointer if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a pointer, or an l-value if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a reference.  
  
 See [static_cast](../vs140/static_cast-operator.md) for an explanation of the difference between static and dynamic casting conversions, and when it is appropriate to use each.  
  
 There are two breaking changes in the behavior of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> in managed code:  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a pointer to the underlying type of a boxed enum will fail at runtime, returning 0 instead of the converted pointer.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will no longer throw an exception when <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is an interior pointer to a value type, with the cast failing at runtime.  The cast will now return the 0 pointer value instead of throwing.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a pointer to an unambiguous accessible direct or indirect base class of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, a pointer to the unique subobject of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is the result. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This type of conversion is called an "upcast" because it moves a pointer up a class hierarchy, from a derived class to a class it is derived from. An upcast is an implicit conversion.  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is void*, a run-time check is made to determine the actual type of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The result is a pointer to the complete object pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not void*, a run-time check is made to see if the object pointed to by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> can be converted to the type pointed to by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 If the type of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a base class of the type of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, a run-time check is made to see if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> actually points to a complete object of the type of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If this is true, the result is a pointer to a complete object of the type of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This type of conversion is called a "downcast" because it moves a pointer down a class hierarchy, from a given class to a class derived from it.  
  
 In cases of multiple inheritance, possibilities for ambiguity are introduced. Consider the class hierarchy shown in the following figure.  
  
 For CLR types, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> results in either a no-op if the conversion can be performed implicitly, or an MSIL <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> instruction, which performs a dynamic check and returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if the conversion fails.  
  
 The following sample uses <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to determine if a class is an instance of particular type:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 ![Class hierarchy that shows multiple inheritance](../vs140/media/vc39011.gif "vc39011")  
Class Hierarchy Showing Multiple Inheritance  
  
 A pointer to an object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> can be safely cast to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. However, if <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is cast to point to an <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object, which instance of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> would result? This would result in an ambiguous casting error. To get around this problem, you can perform two unambiguous casts. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Further ambiguities can be introduced when you use virtual base classes. Consider the class hierarchy shown in the following figure.  
  
 ![Class hierarchy that shows virtual base classes](../vs140/media/vc39012.gif "vc39012")  
Class Hierarchy Showing Virtual Base Classes  
  
 In this hierarchy, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is a virtual base class. See [Virtual Base Classes](../vs140/virtual-base-classes.md) for the definition of a virtual base class. Given an instance of class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and a pointer to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> subobject, a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to a pointer to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> will fail due to ambiguity. You must first cast back to the complete <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object, then work your way back up the hierarchy, in an unambiguous manner, to reach the correct <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
 Consider the class hierarchy shown in the following figure.  
  
 ![Class hierarchy that shows duplicate base classes](../vs140/media/vc39013.gif "vc39013")  
Class Hierarchy Showing Duplicate Base Classes  
  
 Given an object of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and a pointer to the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> subobject, to navigate from the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> subobject to the left-most <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> subobject, three conversions can be made. You can perform a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> conversion from the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> pointer to an <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> pointer, then a conversion (either <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> or an implicit conversion) from <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, and finally an implicit conversion from <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> operator can also be used to perform a "cross cast." Using the same class hierarchy, it is possible to cast a pointer, for example, from the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> subobject to the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> subobject, as long as the complete object is of type <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 Considering cross casts, it is actually possible to do the conversion from a pointer to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to a pointer to the left-most <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> subobject in just two steps. You can perform a cross cast from <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, then an implicit conversion from <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A null pointer value is converted to the null pointer value of the destination type by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 When you use <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> cannot be safely converted to type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, the run-time check causes the cast to fail. For example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The value of a failed cast to pointer type is the null pointer. A failed cast to reference type throws a [bad_cast Exception](../vs140/bad_cast-exception.md).   If <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> does not point to or reference a valid object, a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> exception is thrown.  
  
 See [typeid](../vs140/typeid-operator.md) for an explanation of the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> exception.  
  
## Example  
 The following sample creates the base class (struct A) pointer, to an object (struct C).  This, plus the fact there are virtual functions, enables runtime polymorphism.  
  
 The sample also calls a non-virtual function in the hierarchy.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **in C**  
**test2 in B**  
**in GlobalTest**  
**Can't cast to C**   
## See Also  
 [Casting Operators](../vs140/casting-operators.md)   
 [Keywords](../vs140/keywords--c---.md)