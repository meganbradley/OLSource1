---
title: "CAdapt Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL.CAdapt"
  - "ATL.CAdapt<T>"
  - "ATL::CAdapt"
  - "ATL::CAdapt<T>"
  - "CAdapt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "address-of operator"
  - "adapter objects"
  - "& operator, address-of operator"
  - "CAdapt class"
ms.assetid: 0bb695a5-72fe-43d1-8f39-7e4da6e34765
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAdapt Class
This template is used to wrap classes that redefine the address-of operator to return something other than the address of the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The adapted type.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAdapt::CAdapt](../vs140/cadapt--cadapt.md)|The constructor.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAdapt::operator const T&](../vs140/cadapt--operator-const-t-.md)|Returns a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> reference to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[CAdapt::operator T&](../vs140/cadapt--operator-t-.md)|Returns a reference to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[CAdapt::operator <](../vs140/cadapt--operator--.md)|Compares an object of the adapted type with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[CAdapt::operator =](../vs140/cadapt--operator-=.md)|Assigns an object of the adapted type to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[CAdapt::operator ==](../vs140/cadapt--operator-==.md)|Compares an object of the adapted type with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAdapt::m_T](../vs140/cadapt--m_t.md)|The data being adapted.|  
  
## Remarks  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a simple template used to wrap classes that redefine the address-of operator ( <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) to return something other than the address of the object. Examples of such classes include ATL's <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> classes, and the compiler COM support class, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. These classes all redefine the address-of operator to return the address of one of their data members (a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in the case of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and an interface pointer in the case of the other classes).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>'s primary role is to hide the address-of operator defined by class <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, yet still retain the characteristics of the adapted class. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> fulfils this role by holding a public member, [m_T](../vs140/cadapt--m_t.md), of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and by defining conversion operators, comparison operators, and a copy constructor to allow specializations of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to be treated as if they are objects of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The adapter class <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is useful because some container-style classes expect to be able to obtain the addresses of their contained objects using the address-of operator. The redefinition of the address-of operator can confound this requirement, typically causing compilation errors and preventing the use of the non-adapted type with classes that expect it to "just work". <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> provides a way around those problems.  
  
 Typically, you will use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> when you want to store <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects in a container-style class. This was most commonly necessary for C++ Standard Library containers prior to support for the C++11 Standard, but C++11 Standard Library containers automatically work with types that have overloaded <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The Standard Library achieves this by internally using [std::addressof()](../vs140/addressof.md) to get the true addresses of objects.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
##  \<a name="cadapt__cadapt">\</a>  CAdapt::CAdapt  
 The constructors allow an adapter object to be default constructed, copied from an object of the adapted type, or copied from another adapter object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A variable of the type being adapted to be copied into the newly constructed adapter object.  
  
 *rSrCA*  
 An adapter object whose contained data should be copied into the newly constructed adapter object.  
  
##  \<a name="cadapt__m_t">\</a>  CAdapt::m_T  
 Holds the data being adapted.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This **public** data member can be accessed directly or indirectly with [operator const T&](../vs140/cadapt--operator-const-t-.md) and [operator T&](../vs140/cadapt--operator-t-.md).  
  
##  \<a name="cadapt__operator_const_t_amp_">\</a>  CAdapt::operator const T&amp;  
 Returns a **const** reference to the [m_T](../vs140/cadapt--m_t.md) member, allowing the adapter object to be treated as if it were an object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A **const** reference to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="cadapt__operator_t_amp_">\</a>  CAdapt::operator T&amp;  
 Returns a reference to the [m_T](../vs140/cadapt--m_t.md) member, allowing the adapter object to be treated as if it were an object of type <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A reference to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
##  \<a name="cadapt__operator__lt_">\</a>  CAdapt::operator &lt;  
 Compares an object of the adapted type with [m_T](../vs140/cadapt--m_t.md).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A reference to the object to be compared.  
  
### Return Value  
 The result of the comparison between <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="cadapt__operator__eq">\</a>  CAdapt::operator =  
 The assignment operator assigns the argument, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, to the data member [m_T](../vs140/cadapt--m_t.md) and returns the current adapter object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A reference to an object of the adapted type to be copied.  
  
### Return Value  
 A reference to the current object.  
  
##  \<a name="cadapt__operator__eq_eq">\</a>  CAdapt::operator ==  
 Compares an object of the adapted type with [m_T](../vs140/cadapt--m_t.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A reference to the object to be compared.  
  
### Return Value  
 The result of the comparison between <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)