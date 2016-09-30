---
title: "ATL Copy Policy Classes"
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
  - "data [C++], ATL"
  - "classes [C++], copy policy"
  - "copy policy classes [C++]"
  - "_Copy class"
  - "_CopyInterface class"
ms.assetid: 06704b68-d318-4c5d-a65b-71457fe9d00d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Copy Policy Classes
Copy policy classes are [utility classes](../vs140/utility-classes.md) used to initialize, copy, and delete data. Copy policy classes allow you to define copy semantics for any type of data, and to define conversions between different data types.  
  
 ATL uses copy policy classes in its implementations of the following templates:  
  
-   [CComEnumImpl](../vs140/ccomenumimpl-class.md)  
  
-   [IEnumOnSTLImpl](../vs140/ienumonstlimpl-class.md)  
  
-   [ICollectionOnSTLImpl](../vs140/icollectiononstlimpl-class.md)  
  
 By encapsulating the information needed to copy or convert data in a copy policy class that can be passed as a template argument, the ATL developers have provided for extreme reusability of these classes. For example, if you need to implement a collection using any arbitrary data type, all you need to provide is the appropriate copy policy; you never have to touch the code that implements the collection.  
  
## Definition  
 By definition, a class that provides the following static functions is a copy policy class:  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 You can replace the types <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and *SourceType* with arbitrary data types for each copy policy.  
  
> [!NOTE]
>  Although you can define copy policy classes for any arbitrary data types, use of the classes in ATL code should limit the types that make sense. For example, when using a copy policy class with ATL's collection or enumerator implementations, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be a type that can be used as a parameter in a COM interface method.  
  
 Use **init** to initialize data, **copy** to copy data, and **destroy** to free the data. The precise meaning of initialization, copying, and destruction are the domain of the copy policy class and will vary depending on the data types involved.  
  
 There are two requirements on the use and implementation of a copy policy class:  
  
-   The first parameter to **copy** must only receive a pointer to data that you have previously initialized using **init**.  
  
-   **destroy** must only ever receive a pointer to data that you have previously initialized using **init** or copied via **copy**.  
  
## Standard Implementations  
 ATL provides two copy policy classes in the form of the **_Copy** and **_CopyInterface** template classes:  
  
-   The **_Copy** class allows homogeneous copying only (not conversion between data types) since it only offers a single template parameter to specify both <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and *SourceType*. The generic implementation of this template contains no initialization or destruction code and uses <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to copy the data. ATL also provides specializations of **_Copy** for **VARIANT**, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, **OLEVERB**, and **CONNECTDATA** data types.  
  
-   The **_CopyInterface** class provides an implementation for copying interface pointers following standard COM rules. Once again this class allows only homogeneous copying, so it uses simple assignment and a call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to perform the copy.  
  
## Custom Implementations  
 Typically, you'll need to define your own copy policy classes for heterogeneous copying (that is, conversion between data types). For some examples of custom copy policy classes, look at the files VCUE_Copy.h and VCUE_CopyString.h in the [ATLCollections](../vs140/visual-c---samples.md) sample. These files contain two template copy policy classes, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, plus a number of specializations of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> for different data types.  
  
### GenericCopy  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> allows you to specify the *SourceType* and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> as template arguments. Here's the most general form of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class from VCUE_Copy.h:  
  
 [!code[NVC_ATL_COM#30](../vs140/codesnippet/CPP/atl-copy-policy-classes_1.h)]  
  
 VCUE_Copy.h also contains the following specializations of this class: <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. VCUE_CopyString.h contains specializations for copying from **std::string**s: <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. You could enhance <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> by providing further specializations of your own.  
  
### MapCopy  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> assumes that the data being copied is stored into an STL-style map, so it allows you to specify the type of map in which the data is stored and the destination type. The implementation of the class just uses the typedefs supplied by the *MapType* class to determine the type of the source data and to call the appropriate <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class. No specializations of this class are needed.  
  
 [!code[NVC_ATL_COM#31](../vs140/codesnippet/CPP/atl-copy-policy-classes_2.h)]  
  
## See Also  
 [Implementing an STL-Based Collection](../vs140/implementing-an-stl-based-collection.md)   
 [ATLCollections Sample](../vs140/visual-c---samples.md)