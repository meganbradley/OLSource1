---
title: "static_cast Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "static_cast Operator"
f1_keywords: 
  - "static_cast"
  - "static_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "static_cast keyword [C++]"
ms.assetid: 1f7c0c1c-b288-476c-89d6-0e2ceda5c293
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# static_cast Operator
Converts an *expression* to the type of *type-id,* based only on the types that are present in the expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In standard C++, no run-time type check is made to help ensure the safety of the conversion. In C++/CX, a compile time and runtime check are performed. For more information, see [Casting (C++/CX)](assetId:///5247f6c7-6a0a-4021-97c9-21c868bd9455).  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator can be used for operations such as converting a pointer to a base class to a pointer to a derived class. Such conversions are not always safe.  
  
 In general you use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when you want to convert numeric data types such as enums to ints or ints to floats, and you are certain of the data types involved in the conversion. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> conversions are not as safe as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> conversions, because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does no run-time type check, while <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does. A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to an ambiguous pointer will fail, while a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns as if nothing were wrong; this can be dangerous. Although <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> conversions are safer, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> only works on pointers or references, and the run-time type check is an overhead. For more information, see [dynamic_cast Operator](../vs140/dynamic_cast-operator.md).  
  
 In the example that follows, the line <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not safe because <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can have fields and methods that are not in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. However, the line <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a safe conversion because <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> always contains all of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In contrast to [dynamic_cast](../vs140/dynamic_cast-operator.md), no run-time check is made on the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> conversion of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The object pointed to by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> may not be an object of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, in which case the use of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> could be disastrous. For instance, calling a function that is a member of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class, but not the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class, could result in an access violation.  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> operators move a pointer throughout a class hierarchy. However, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> relies exclusively on the information provided in the cast statement and can therefore be unsafe. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> really points to an object of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> will get the same value. They will also get the same value if <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> points to an object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and not to the complete <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class, then <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> will know enough to return zero. However, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> relies on the programmer's assertion that <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> points to an object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and simply returns a pointer to that supposed <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
 Consequently, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> can do the inverse of implicit conversions, in which case the results are undefined. It is left to the programmer to verify that the results of a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> conversion are safe.  
  
 This behavior also applies to types other than class types. For instance, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> can be used to convert from an int to a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. However, the resulting <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> may not have enough bits to hold the entire <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> value. Again, it is left to the programmer to verify that the results of a<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> conversion are safe.  
  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> operator can also be used to perform any implicit conversion, including standard conversions and user-defined conversions. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> operator can explicitly convert an integral value to an enumeration type. If the value of the integral type does not fall within the range of enumeration values, the resulting enumeration value is undefined.  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> operator converts a null pointer value to the null pointer value of the destination type.  
  
 Any expression can be explicitly converted to type void by the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> operator. The destination void type can optionally include the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> attribute.  
  
 The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> operator cannot cast away the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> attributes. See [const_cast Operator](../vs140/const_cast-operator.md) for information on removing these attributes.  
  
 Due to the danger of performing unchecked casts on top of a relocating garbage collector, the use of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> should only be in performance-critical code when you are certain it will work correctly. If you must use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> in release mode, substitute it with [safe_cast](../vs140/safe_cast--c---component-extensions-.md) in your debug builds to ensure success.  
  
## See Also  
 [Casting Operators](../vs140/casting-operators.md)   
 [Keywords](../vs140/keywords--c---.md)