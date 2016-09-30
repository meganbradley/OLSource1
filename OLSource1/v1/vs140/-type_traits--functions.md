---
title: "&lt;type_traits&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: dce4492f-f3e4-4d5e-bdb4-5875321254ec
caps.latest.revision: 13
---
# &lt;type_traits&gt; functions
||||  
|-|-|-|  
|[is_assignable](#is_assignable)|[is_copy_assignable](#is_copy_assignable)|[is_copy_constructible](#is_copy_constructible)|  
|[is_default_constructible](#is_default_constructible)|[is_move_assignable](#is_move_assignable)|[is_move_constructible](#is_move_constructible)|  
|[is_nothrow_move_assignable](#is_nothrow_move_assignable)|[is_trivially_copy_assignable](#is_trivially_copy_assignable)|[is_trivially_move_assignable](#is_trivially_move_assignable)|  
|[is_trivially_move_constructible](#is_trivially_move_constructible)|  
  
##  \<a name="is_assignable">\</a>  is_assignable  
 Tests whether a value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type can be assigned to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 To  
 The type of the object that receives the assignment.  
  
 From  
 The type of the object that provides the value.  
  
### Remarks  
 The unevaluated expression <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must be well-formed. Both <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must be complete types, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or arrays of unknown bound.  
  
##  \<a name="is_copy_assignable">\</a>  is_copy_assignable  
 Tests whether type has can be copied on assignment.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a class that has a copy assignment operator, otherwise it holds false. Equivalent to is_assignable\<Ty&, const Ty&>.  
  
##  \<a name="is_copy_constructible">\</a>  is_copy_constructible  
 Tests if type has a copy constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a class that has a copy constructor, otherwise it holds false.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **is_copy_constructible\<Copyable> == true**  
**is_copy_constructible\<NotCopyable > == false**    
##  \<a name="is_default_constructible">\</a>  is_default_constructible  
 Tests if a type has a default constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a class type that has a default constructor, otherwise it holds false. This is equivalent to the predicate <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be a complete type, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or an array of unknown bound.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **is_default_constructible\<Simple> == true**  
**is_default_constructible\<Simple2> == false**    
##  \<a name="is_move_assignable">\</a>  is_move_assignable  
 Tests if the type can be move assigned.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 A type is move assignable if an rvalue reference to the type can be assigned to a reference to the type. The type predicate is equivalent to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. Move assignable types include referenceable scalar types and class types that have either compiler-generated or user-defined move assignment operators.  
  
##  \<a name="is_move_constructible">\</a>  is_move_constructible  
 Tests whether the type has a move constructor.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 T  
 The type to be evaluated  
  
### Remarks  
 A type predicate that evaluates to true if the type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> can be constructed by using a move operation. This predicate is equivalent to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="is_nothrow_move_assignable">\</a>  is_nothrow_move_assignable  
 Tests whether type has a [nothrow](../vs140/nothrow--c---.md) move assignment operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> has a nothrow move assignment operator, otherwise it holds false.  
  
##  \<a name="is_trivially_copy_assignable">\</a>  is_trivially_copy_assignable  
 Tests whether the type has a trivial copy assignment operator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is a class that has a trivial copy assignment operator, otherwise it holds false.  
  
 An assignment constructor for a class <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is trivial if it is implicitly provided, the class <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> has no virtual functions, the class <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> has no virtual bases, the classes of all the non-static data members of class type have trivial assignment operators, and the classes of all the non-static data members of type array of class have trivial assignment operators.  
  
##  \<a name="is_trivially_move_assignable">\</a>  is_trivially_move_assignable  
 Tests whether the type has a trivial move assignment operator.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a class that has a trivial move assignment operator, otherwise it holds false.  
  
 A move assignment operator for a class <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is trivial if:  
  
 it is implicitly provided  
  
 the class <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> has no virtual functions  
  
 the class <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> has no virtual bases  
  
 the classes of all the non-static data members of class type have trivial move assignment operators  
  
 the classes of all the non-static data members of type array of class have trivial move assignment operators  
  
##  \<a name="is_trivially_move_constructible">\</a>  is_trivially_move_constructible  
 Tests if type has trivial move constructor.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The type to query.  
  
### Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is a class that has a trivial move constructor, otherwise it holds false.  
  
 A move constructor for a class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is trivial if:  
  
 it is implicitly declared  
  
 its parameter types are equivalent to those of an implicit declaration  
  
 the class <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> has no virtual functions  
  
 the class <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> has no virtual bases  
  
 the class has no volatile non-static data members  
  
 all the direct bases of the class <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> have trivial move constructors  
  
 the classes of all the non-static data members of class type have trivial move constructors  
  
 the classes of all the non-static data members of type array of class have trivial move constructors  
  
## See Also  
 [&lt;type_traits&gt;](../vs140/-type_traits-.md)