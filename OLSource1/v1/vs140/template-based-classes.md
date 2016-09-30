---
title: "Template-Based Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "type-safe collections"
  - "CTypedPtrList class, template-based classes"
  - "arrays [C++], classes"
  - "arrays [C++], pointers"
  - "typed pointers, collections of"
  - "arrays [C++], template-based"
  - "CArray class, template-based classes"
  - "simple template-based collections"
  - "simple array collection classes"
  - "typed pointers"
  - "collections, typed-pointer"
  - "CList class, template-based classes"
  - "collection classes, template-based"
  - "CTypedPtrMap class, template-based classes"
  - "pointers, collections of typed"
  - "CTypedPtrArray class, template-based classes"
  - "MFC collection classes, template-based"
  - "template-based collection classes"
  - "simple list collection classes"
ms.assetid: c69fc95b-c8f6-4a99-abed-517c9898ef0c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template-Based Classes
This article explains the type-safe template-based collection classes in MFC version 3.0 and later. Using these templates to create type-safe collections is more convenient and helps provide type safety more effectively than using the collection classes not based on templates.  
  
 MFC predefines two categories of template-based collections:  
  
-   [Simple array, list, and map classes](#_core_using_simple_array.2c_.list.2c_.and_map_templates)  
  
     <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   [Arrays, lists, and maps of typed pointers](#_core_using_typed.2d.pointer_collection_templates)  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The simple collection classes are all derived from class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, so they inherit the serialization, dynamic creation, and other properties of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The typed pointer collection classes require you to specify the class you derive from — which must be one of the nontemplate pointer collections predefined by MFC, such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Your new collection class inherits from the specified base class, and the new class's member functions use encapsulated calls to the base class members to enforce type safety.  
  
 For more information about C++ templates, see [Templates](../vs140/templates--c---.md) in the *C++ Language Reference*.  
  
##  \<a name="_core_using_simple_array.2c_.list.2c_.and_map_templates">\</a> Using Simple Array, List, and Map Templates  
 To use the simple collection templates, you need to know what kind of data you can store in these collections and what parameters to use in your collection declarations.  
  
###  \<a name="_core_simple_array_and_list_usage">\</a> Simple Array and List Usage  
 The simple array and list classes, [CArray](../vs140/carray-class.md) and [CList](../vs140/clist-class.md), take two parameters: *TYPE* and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. These classes can store any data type, which you specify in the *TYPE* parameter:  
  
-   Fundamental C++ data types, such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and **float**  
  
-   C++ structures and classes  
  
-   Other types that you define  
  
 For convenience and efficiency, you can use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter to specify the type of function arguments. Typically, you specify <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as a reference to the type you named in the *TYPE* parameter. For example:  
  
 [!code[NVC_MFCCollections#1](../vs140/codesnippet/CPP/template-based-classes_1.cpp)]  
  
 The first example declares an array collection, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, that contains <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>s. The second example declares a list collection, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, that stores <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects. Certain member functions of the collection classes take arguments whose type is specified by the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> template parameter. For example, the **Add** member function of class <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> takes an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument:  
  
 [!code[NVC_MFCCollections#2](../vs140/codesnippet/CPP/template-based-classes_2.cpp)]  
  
###  \<a name="_core_simple_map_usage">\</a> Simple Map Usage  
 The simple map class, [CMap](../vs140/cmap-class.md), takes four parameters: *KEY*, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, *VALUE*, and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Like the array and list classes, the map classes can store any data type. Unlike arrays and lists, which index and order the data they store, maps associate keys and values: You access a value stored in a map by specifying the value's associated key. The *KEY* parameter specifies the data type of the keys used to access data stored in the map. If the type of *KEY* is a structure or class, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter is typically a reference to the type specified in *KEY*. The *VALUE* parameter specifies the type of the items stored in the map. If the type of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a structure or class, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter is typically a reference to the type specified in *VALUE*. For example:  
  
 [!code[NVC_MFCCollections#3](../vs140/codesnippet/CPP/template-based-classes_3.cpp)]  
  
 The first example stores <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> values, accesses them by <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keys, and returns accessed <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> items by reference. The second example stores <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> values, accesses them by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> keys, and returns references to accessed items. This example might represent a simple address book, in which you look up persons by last name.  
  
 Because the *KEY* parameter is of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the *KEY_TYPE* parameter is of type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the keys are stored in the map as items of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> but are referenced in functions such as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> through pointers of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. For example:  
  
 [!code[NVC_MFCCollections#4](../vs140/codesnippet/CPP/template-based-classes_4.cpp)]  
  
##  \<a name="_core_using_typed.2d.pointer_collection_templates">\</a> Using Typed-Pointer Collection Templates  
 To use the typed-pointer collection templates, you need to know what kinds of data you can store in these collections and what parameters to use in your collection declarations.  
  
###  \<a name="_core_typed.2d.pointer_array_and_list_usage">\</a> Typed-Pointer Array and List Usage  
 The typed-pointer array and list classes, [CTypedPtrArray](../vs140/ctypedptrarray-class.md) and [CTypedPtrList](../vs140/ctypedptrlist-class.md), take two parameters: <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and *TYPE*. These classes can store any data type, which you specify in the *TYPE* parameter. They are derived from one of the nontemplate collection classes that stores pointers; you specify this base class in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For arrays, use either <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. For lists, use either <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 In effect, when you declare a collection based on, say <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, the new class not only inherits the members of its base class, but it also declares a number of additional type-safe member functions and operators that help provide type safety by encapsulating calls to the base class members. These encapsulations manage all necessary type conversion. For example:  
  
 [!code[NVC_MFCCollections#5](../vs140/codesnippet/CPP/template-based-classes_5.cpp)]  
  
 The first example declares a typed-pointer array, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, derived from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The array stores and returns pointers to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> objects (where <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is a class derived from <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>). You can call any <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> member function, or you can call the new type-safe <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> functions or use the type-safe **[ ]** operator.  
  
 The second example declares a typed-pointer list, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, derived from <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. The list stores and returns pointers to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> objects. A class based on <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is used for storing pointers to objects not derived from <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> has a number of type-safe member functions: <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
###  \<a name="_core_typed.2d.pointer_map_usage">\</a> Typed-Pointer Map Usage  
 The typed-pointer map class, [CTypedPtrMap](../vs140/ctypedptrmap-class.md), takes three parameters: <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, *KEY*, and *VALUE*. The <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> parameter specifies the class from which to derive the new class: <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, and so on. *KEY* is analogous to *KEY* in <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>: It specifies the type of the key used for lookups. *VALUE* is analogous to *VALUE* in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>: It specifies the type of object stored in the map. For example:  
  
 [!code[NVC_MFCCollections#6](../vs140/codesnippet/CPP/template-based-classes_6.cpp)]  
  
 The first example is a map based on **CMapPtrToPt**r — it uses <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> keys mapped to pointers to <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. You can look up a stored pointer by calling a type-safe <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> member function. You can use the **[ ]** operator to look up a stored pointer and add it if not found. And you can iterate the map using the type-safe <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> function. You can also call other member functions of class <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
 The second example is a map based on **CMapStringToO**b — it uses string keys mapped to stored pointers to <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> objects. You can use the same type-safe members described in the previous paragraph, or you can call members of class <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  If you specify a **class** or <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> type for the *VALUE* parameter, rather than a pointer or reference to the type, the class or structure must have a copy constructor.  
  
 For more information, see [How to Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md).  
  
## See Also  
 [Collections](../vs140/collections.md)