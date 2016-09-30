---
title: "How to: Make a Type-Safe Collection"
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
  - "serializing collection-class elements"
  - "collection classes, type safety"
  - "SerializeElements function"
  - "collection classes, template-based"
  - "serialization [C++], collection classes"
  - "collection classes, deriving from nontemplate"
ms.assetid: 7230b2db-4283-4083-b098-eb231bf5b89e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Make a Type-Safe Collection
This article explains how to make type-safe collections for your own data types. Topics include:  
  
-   [Using template-based classes for type safety](#_core_using_template.2d.based_classes_for_type_safety)  
  
-   [Implementing helper functions](#_core_implementing_helper_functions)  
  
-   [Using nontemplate collection classes](#_core_using_nontemplate_collection_classes)  
  
 The Microsoft Foundation Class Library provides predefined type-safe collections based on C++ templates. Because they are templates, these classes help provide type safety and ease of use without the type-casting and other extra work involved in using a nontemplate class for this purpose. The MFC sample [COLLECT](../vs140/visual-c---samples.md) demonstrates the use of template-based collection classes in an MFC application. In general, use these classes any time you write new collections code.  
  
##  \<a name="_core_using_template.2d.based_classes_for_type_safety">\</a> Using Template-Based Classes for Type Safety  
  
#### To use template-based classes  
  
1.  Declare a variable of the collection class type. For example:  
  
     [!code[NVC_MFCCollections#7](../vs140/codesnippet/CPP/how-to--make-a-type-safe-collection_1.cpp)]  
  
2.  Call the member functions of the collection object. For example:  
  
     [!code[NVC_MFCCollections#8](../vs140/codesnippet/CPP/how-to--make-a-type-safe-collection_2.cpp)]  
  
3.  If necessary, implement the [helper functions](../vs140/collection-class-helpers.md) and [SerializeElements](../vs140/serializeelements.md). For information on implementing these functions, see [Implementing Helper Functions](#_core_implementing_helper_functions).  
  
 This example shows the declaration of a list of integers. The first parameter in step 1 is the type of data stored as elements of the list. The second parameter specifies how the data is to be passed to and returned from member functions of the collection class, such as **Add** and <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
##  \<a name="_core_implementing_helper_functions">\</a> Implementing Helper Functions  
 The template-based collection classes <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> use five global helper functions that you can customize as needed for your derived collection class. For information on these helper functions, see [Collection Class Helpers](../vs140/collection-class-helpers.md) in the *MFC Reference*. Implementation of the serialization function is necessary for most uses of the template-based collection classes.  
  
###  \<a name="_core_serializing_elements">\</a> Serializing Elements  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> classes call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to store collection elements to or read them from an archive.  
  
 The default implementation of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> helper function does a bitwise write from the objects to the archive, or a bitwise read from the archive to the objects, depending on whether the objects are being stored in or retrieved from the archive. Override <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if this action is not appropriate.  
  
 If your collection stores objects derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and you use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> macro in the implementation of the collection element class, you can take advantage of the serialization functionality built into <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCCollections#9](../vs140/codesnippet/CPP/how-to--make-a-type-safe-collection_3.cpp)]  
  
 The overloaded insertion operators for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (or an override of that function) for each **CPerson** object.  
  
##  \<a name="_core_using_nontemplate_collection_classes">\</a> Using Nontemplate Collection Classes  
 MFC also supports the collection classes introduced with MFC version 1.0. These classes are not based on templates. They can be used to contain data of the supported types <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, **UINT**, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. You can use these predefined collections (such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) to hold collections of any objects derived from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. MFC also provides other predefined collections to hold primitive types such as **UINT** and void pointers (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>*). In general, however, it is often useful to define your own type-safe collections to hold objects of a more specific class and its derivatives. Note that doing so with the collection classes not based on templates is more work than using the template-based classes.  
  
 There are two ways to create type-safe collections with the nontemplate collections:  
  
1.  Use the nontemplate collections, with type casting if necessary. This is the easier approach.  
  
2.  Derive from and extend a nontemplate type-safe collection.  
  
#### To use the nontemplate collections with type casting  
  
1.  Use one of the nontemplate classes, such as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, directly.  
  
     For example, you can create a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and add any 32-bit values to it, then retrieve them. There is nothing more to do. You just use the predefined functionality.  
  
     You can also use a predefined collection, such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, to hold any objects derived from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> collection is defined to hold pointers to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. When you retrieve an object from the list, you may have to cast the result to the proper type since the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> functions return pointers to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. For example, if you store <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects in a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> collection, you have to cast a retrieved element to be a pointer to a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object. The following example uses a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> collection to hold <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects:  
  
     [!code[NVC_MFCCollections#10](../vs140/codesnippet/CPP/how-to--make-a-type-safe-collection_4.cpp)]  
  
     This technique of using a predefined collection type and casting as necessary may be adequate for many of your collection needs. If you need further functionality or more type safety, use a template-based class, or follow the next procedure.  
  
#### To derive and extend a nontemplate type-safe collection  
  
1.  Derive your own collection class from one of the predefined nontemplate classes.  
  
     When you derive your class, you can add type-safe wrapper functions to provide a type-safe interface to existing functions.  
  
     For example, if you derived a list from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to hold <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects, you might add the wrapper functions <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, as shown below.  
  
     [!code[NVC_MFCCollections#11](../vs140/codesnippet/CPP/how-to--make-a-type-safe-collection_5.h)]  
  
     These wrapper functions provide a type-safe way to add and retrieve <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> objects from the derived list. You can see that for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function, you are simply encapsulating the type casting.  
  
     You can also add new functionality by defining new functions that extend the capabilities of the collection rather than just wrapping existing functionality in type-safe wrappers. For example, the article [Deleting All Objects in a CObject Collection](../vs140/deleting-all-objects-in-a-cobject-collection.md) describes a function to delete all the objects contained in a list. This function could be added to the derived class as a member function.  
  
## See Also  
 [Collections](../vs140/collections.md)