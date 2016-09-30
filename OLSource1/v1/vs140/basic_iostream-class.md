---
title: "basic_iostream Class"
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
  - "istream/std::basic_iostream"
  - "std.basic_iostream"
  - "basic_iostream"
  - "std::basic_iostream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_iostream class"
ms.assetid: 294b680b-eb49-4066-8db2-6d52dac9d6e3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_iostream Class
A stream class that can do both input and output.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template class describes an object that controls insertions, through its base class [basic_ostream](../vs140/basic_ostream-class.md)< <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>>, and extractions, through its base class [basic_istream](../vs140/basic_istream-class.md)< <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>>. The two objects share a common virtual base class [basic_ios](../vs140/basic_ios-class.md)< <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>>. They also manage a common stream buffer, with elements of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, whose character traits are determined by the class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The constructor initializes its base classes through <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>( **strbuf**) and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>( **strbuf**).  
  
### Constructors  
  
|||  
|-|-|  
|[basic_iostream](#basic_iostream__basic_iostream)|Create a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Member Functions  
  
|||  
|-|-|  
|[swap](#basic_iostream__swap)|Exchanges the contents of the provided <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object for the contents of this object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator=](#basic_iostream__operator_eq)|Assigns the value of a specified <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object to this object. This is a move assignment involving an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that does not leave a copy behind.|  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
##  \<a name="basic_iostream__basic_iostream">\</a>  basic_iostream::basic_iostream  
 Create a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that is used to construct a new <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first constructor initializes the base objects by way of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 The second constructor initializes the base objects by calling move <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_iostream__operator_eq">\</a>  basic_iostream::operator=  
 Assign the value of a specified <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object to this object. This is a move assignment involving an <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> that does not leave a copy behind.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> reference to a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object to assign from.  
  
### Remarks  
 The member operator calls swap <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="basic_iostream__swap">\</a>  basic_iostream::swap  
 Exchanges the contents of the provided <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object for the contents of this object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object to swap.  
  
### Remarks  
 The member function calls swap <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)