---
title: "Collections"
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
  - "MFC, collections"
  - "arrays [C++], classes"
  - "MFC collection classes"
  - "shapes, collection"
  - "collection classes, MFC"
  - "collections, about collections"
  - "array templates"
  - "collection classes, template-based"
  - "collection classes, about collection classes"
  - "collection classes, maps"
  - "collection classes, arrays"
  - "shapes"
  - "collection classes, lists"
  - "collection classes, shapes"
ms.assetid: 02586e4c-851d-41d0-a722-feb11c17c74c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections
The Microsoft Foundation Class Library provides collection classes to manage groups of objects. These classes are of two types:  
  
-   [Collection classes created from C++ templates](#_core_the_template.2d.based_collection_classes)  
  
-   [Collection classes not created from templates](#_core_the_collection_classes_not_based_on_templates)  
  
> [!NOTE]
>  If your code already uses nontemplate collection classes, you can continue to use them. If you write new type-safe collection classes for your own data types, we recommend that you use the newer template-based classes.  
  
##  \<a name="_core_collection_shapes">\</a> Collection Shapes  
 A collection class is characterized by its "shape" and by the types of its elements. The shape refers to the way the objects are organized and stored by the collection. MFC provides three basic collection shapes: lists, arrays, and maps (also known as dictionaries). You can pick the collection shape that is most suited to your particular programming problem.  
  
 Each of the three provided collection shapes is described briefly later in this topic. To compare the features of the shapes to help you decide which is best for your program, see [Recommendations for Choosing a Collection Class](../vs140/recommendations-for-choosing-a-collection-class.md).  
  
-   List  
  
     The list class provides an ordered, nonindexed list of elements, implemented as a doubly linked list. A list has a "head" and a "tail," and adding or removing elements from the head or tail, or inserting or deleting elements in the middle, is very fast.  
  
-   Array  
  
     The array class provides a dynamically sized, ordered, and integer-indexed array of objects.  
  
-   Map (also known as a dictionary)  
  
     A map is a collection that associates a key object with a value object.  
  
##  \<a name="_core_the_template.2d.based_collection_classes">\</a> The Template-Based Collection Classes  
 The easiest way to implement a type-safe collection that contains objects of any type is to use one of the MFC template-based classes. For examples of these classes, see the MFC sample [COLLECT](../vs140/visual-c---samples.md).  
  
 The following table lists the MFC template-based collection classes.  
  
### Collection Template Classes  
  
|Collection contents|Arrays|Lists|Maps|  
|-------------------------|------------|-----------|----------|  
|Collections of objects of any type|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|Collections of pointers to objects of any type|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
  
##  \<a name="_core_the_collection_classes_not_based_on_templates">\</a> The Collection Classes Not Based on Templates  
 If your application already uses MFC nontemplate classes, you can continue to use them. However, for new collections, we recommend that you use the template-based classes. The following table lists the MFC collection classes that are not based on templates.  
  
### Nontemplate Collection Classes  
  
|Arrays|Lists|Maps|  
|------------|-----------|----------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>||<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>||<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>||<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>||<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
 The Characteristics of MFC Collection Classes table in [Recommendations for Choosing a Collection Class](../vs140/recommendations-for-choosing-a-collection-class.md) describes the MFC collection classes in terms of these characteristics (other than shape):  
  
-   Whether the class uses C++ templates  
  
-   Whether the elements stored in the collection can be serialized  
  
-   Whether the elements stored in the collection can be dumped for diagnostics  
  
-   Whether the collection is type-safe  
  
### What do you want to do?  
  
#### General Collection-Class Tasks  
  
-   [Recommendations for Choosing a Collection Class](../vs140/recommendations-for-choosing-a-collection-class.md)  
  
-   [How to: Make a Type-Safe Collection](../vs140/how-to--make-a-type-safe-collection.md)  
  
-   [Creating Stack and Queue Collections](../vs140/creating-stack-and-queue-collections.md)  
  
-   [CArray::Add](../vs140/carray--add.md)  
  
#### Template-Based Collection-Class Tasks  
  
-   [Template-Based Classes](../vs140/template-based-classes.md)  
  
#### Accessing the Members of a Collection (Template-Based or Not)  
  
-   [Accessing All Members of a Collection](../vs140/accessing-all-members-of-a-collection.md)  
  
-   [Deleting All Objects in a CObject Collection](../vs140/deleting-all-objects-in-a-cobject-collection.md)  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)