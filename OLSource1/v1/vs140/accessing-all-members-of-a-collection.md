---
title: "Accessing All Members of a Collection"
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
  - "enumerations [MFC]"
  - "enumerating collections"
  - "collections, accessing"
  - "collection classes, accessing members"
  - "arrays [C++], iterating"
  - "iteration, collections"
  - "member access, collections"
  - "list collection iterations"
  - "MFC collection classes, accessing members"
  - "collections, looping through"
  - "loop structures, looping through collections"
ms.assetid: 7bbae518-062e-4393-81f9-b22abd2e5f59
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing All Members of a Collection
The MFC array collection classes — both template-based and not — use indexes to access their elements. The MFC list and map collection classes — both template-based and not — use an indicator of type **POSITION** to describe a given position within the collection. To access one or more members of these collections, you first initialize the position indicator and then repeatedly pass that position to the collection and ask it to return the next element. The collection is not responsible for maintaining state information about the progress of the iteration. That information is kept in the position indicator. But, given a particular position, the collection is responsible for returning the next element.  
  
 The following procedures show how to iterate over the three main types of collections provided with MFC:  
  
-   [Iterating an array](#_core_to_iterate_an_array)  
  
-   [Iterating a list](#_core_to_iterate_a_list)  
  
-   [Iterating a map](#_core_to_iterate_a_map)  
  
### To iterate an array  
  
1.  Use sequential index numbers with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function:  
  
     [!code[NVC_MFCCollections#12](../vs140/codesnippet/CPP/accessing-all-members-of-a-collection_1.cpp)]  
  
     This example uses a typed pointer array that contains pointers to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects. The array is derived from class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, one of the nontemplate predefined classes. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. For typed pointer collection classes — arrays or lists — the first parameter specifies the base class; the second parameter specifies the type to store.  
  
     The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class also overloads the **[ ]** operator so that you can use the customary array-subscript syntax to access elements of an array. An alternative to the statement in the body of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop above is  
  
     [!code[NVC_MFCCollections#13](../vs140/codesnippet/CPP/accessing-all-members-of-a-collection_2.cpp)]  
  
     This operator exists in both **const** and non-**const** versions. The **const** version, which is invoked for **const** arrays, can appear only on the right side of an assignment statement.  
  
### To iterate a list  
  
1.  Use the member functions <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to work your way through the list:  
  
     [!code[NVC_MFCCollections#14](../vs140/codesnippet/CPP/accessing-all-members-of-a-collection_3.cpp)]  
  
     This example uses a typed pointer list to contain pointers to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects. The list declaration resembles the one for the array in the procedure [To iterate an array](#_core_to_iterate_an_array) but is derived from class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
### To iterate a map  
  
1.  Use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to get to the beginning of the map and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to repeatedly get the next key and value from the map, as shown by the following example:  
  
     [!code[NVC_MFCCollections#15](../vs140/codesnippet/CPP/accessing-all-members-of-a-collection_4.cpp)]  
  
     This example uses a simple map template (rather than a typed pointer collection) that uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keys and stores pointers to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects. When you use access functions such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the class provides pointers to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects. If you use one of the nontemplate map collections instead, you must cast the returned <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> pointer to a pointer to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  For nontemplate maps, the compiler requires a reference to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pointer in the last parameter to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. On input, you must cast your pointers to that type, as shown in the next example.  
  
     The template solution is simpler and helps provide better type safety. The nontemplate code is more complicated, as you can see here:  
  
     [!code[NVC_MFCCollections#16](../vs140/codesnippet/CPP/accessing-all-members-of-a-collection_5.cpp)]  
  
 For more information, see [Deleting All Objects in a CObject Collection](../vs140/deleting-all-objects-in-a-cobject-collection.md).  
  
## See Also  
 [Collections](../vs140/collections.md)