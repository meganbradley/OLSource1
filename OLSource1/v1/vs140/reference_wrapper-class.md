---
title: "reference_wrapper Class"
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
  - "std.tr1.reference_wrapper"
  - "tr1.reference_wrapper"
  - "reference_wrapper"
  - "tr1::reference_wrapper"
  - "xrefwrap/std::tr1::reference_wrapper"
  - "std::tr1::reference_wrapper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference_wrapper class"
  - "reference_wrapper class [TR1]"
ms.assetid: 90b8ed62-e6f1-44ed-acc7-9619bd58865a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reference_wrapper Class
Wraps a reference.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is copy constructible and assignable, and holds a pointer that points to an object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 A specialization <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and the nested type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is:  
  
 a function type or pointer to function type taking one argument of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and returning <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; or  
  
 a pointer to a member function <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> represents the member function's cv-qualifiers; the type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; or  
  
 a class type that is derived from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 A specialization <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the nested type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and the nested type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is:  
  
 a function type or pointer to function type taking two arguments of types <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and returning <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>; or  
  
 a pointer to a member function <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> represents the member function's cv-qualifiers; the type <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>; or  
  
 a class type that is derived from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Constructors  
  
|||  
|-|-|  
|[reference_wrapper::reference_wrapper](#reference_wrapper__reference_wrapper)|Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[reference_wrapper::result_type](#reference_wrapper__result_type)|The weak result type of the wrapped reference.|  
|[reference_wrapper::type](#reference_wrapper__type)|The type of the wrapped reference.|  
  
### Member Functions  
  
|||  
|-|-|  
|[reference_wrapper::get](#reference_wrapper__get)|Obtains the wrapped reference.|  
  
### Operators  
  
|||  
|-|-|  
|[reference_wrapper::operator Ty&](#reference_wrapper__operator_ty_amp_)|Gets a pointer to the wrapped reference.|  
|[reference_wrapper::operator()](#reference_wrapper__operator__)|Calls the wrapped reference.|  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
##  \<a name="reference_wrapper__get">\</a>  reference_wrapper::get  
 Obtains the wrapped reference.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **i = 1**  
**rwi = 1**  
**i = -1**    
##  \<a name="reference_wrapper__operator_ty_amp_">\</a>  reference_wrapper::operator Ty&amp;  
 Gets a pointer to the wrapped reference.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **i = 1**  
**(int)rwi = 1**    
##  \<a name="reference_wrapper__operator__">\</a>  reference_wrapper::operator()  
 Calls the wrapped reference.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The type of the Nth call argument.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The Nth call argument.  
  
### Remarks  
 The template member operator returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **rwi(3) = -3**    
##  \<a name="reference_wrapper__reference_wrapper">\</a>  reference_wrapper::reference_wrapper  
 Constructs a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The type to wrap.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The value to wrap.  
  
### Remarks  
 The constructor sets the stored value <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **i = 1**  
**rwi = 1**  
**i = -1**    
##  \<a name="reference_wrapper__result_type">\</a>  reference_wrapper::result_type  
 The weak result type of the wrapped reference.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for the weak result type of a wrapped function.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **val = -3**    
##  \<a name="reference_wrapper__type">\</a>  reference_wrapper::type  
 The type of the wrapped reference.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The typedef is a synonym for the template argument <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **i = 1**  
**rwi = 1**    
## See Also  
 [cref](../vs140/-functional--functions.md#cref_function)   
 [ref](../vs140/-functional--functions.md#ref_function)