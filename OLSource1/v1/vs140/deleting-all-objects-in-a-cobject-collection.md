---
title: "Deleting All Objects in a CObject Collection"
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
  - "objects [C++], deleting in collections"
  - "objects in CObject collections, deleting"
  - "CObject class, deleting in collection"
  - "collection classes, deleting all objects"
  - "CObject class collection"
  - "objects in CObject collections"
  - "collection classes, shared objects"
ms.assetid: 81d2c1d5-a0a5-46e1-8ab9-82b45cf7afd2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deleting All Objects in a CObject Collection
This article explains how to delete all objects in a collection (without deleting the collection object itself).  
  
 To delete all the objects in a collection of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>s (or of objects derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>), you use one of the iteration techniques described in the article [Accessing All Members of a Collection](../vs140/accessing-all-members-of-a-collection.md) to delete each object in turn.  
  
> [!CAUTION]
>  Objects in collections can be shared. That is, the collection keeps a pointer to the object, but other parts of the program may also have pointers to the same object. You must be careful not to delete an object that is shared until all the parts have finished using the object.  
  
 This article shows you how to delete the objects in:  
  
-   [A list](#_core_to_delete_all_objects_in_a_list_of_pointers_to_cobject)  
  
-   [An array](#_core_to_delete_all_elements_in_an_array)  
  
-   [A map](#_core_to_delete_all_elements_in_a_map)  
  
#### To delete all objects in a list of pointers to CObject  
  
1.  Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to iterate through the list.  
  
2.  Use the **delete** operator to delete each object as it is encountered in the iteration.  
  
3.  Call the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function to remove all elements from the list after the objects associated with those elements have been deleted.  
  
 The following example shows how to delete all objects from a list of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects. Each object in the list is a pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that was originally allocated on the heap.  
  
 [!code[NVC_MFCCollections#17](../vs140/codesnippet/CPP/deleting-all-objects-in-a-cobject-collection_1.cpp)]  
  
 The last function call, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, is a list member function that removes all elements from the list. The member function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> removes a single element.  
  
 Notice the difference between deleting an element's object and removing the element itself. Removing an element from the list merely removes the list's reference to the object. The object still exists in memory. When you delete an object, it ceases to exist and its memory is reclaimed. Thus, it is important to remove an element immediately after the element's object has been deleted so that the list won't try to access objects that no longer exist.  
  
#### To delete all elements in an array  
  
1.  Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and integer index values to iterate through the array.  
  
2.  Use the **delete** operator to delete each element as it is encountered in the iteration.  
  
3.  Call the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function to remove all elements from the array after they have been deleted.  
  
     The code for deleting all elements of an array is as follows:  
  
     [!code[NVC_MFCCollections#18](../vs140/codesnippet/CPP/deleting-all-objects-in-a-cobject-collection_2.cpp)]  
  
 As with the list example above, you can call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to remove all elements in an array or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to remove an individual element.  
  
#### To delete all elements in a map  
  
1.  Use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to iterate through the array.  
  
2.  Use the **delete** operator to delete the key and/or value for each map element as it is encountered in the iteration.  
  
3.  Call the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function to remove all elements from the map after they have been deleted.  
  
     The code for deleting all elements of a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> collection is as follows. Each element in the map has a string as the key and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object (derived from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) as the value.  
  
     [!code[NVC_MFCCollections#19](../vs140/codesnippet/CPP/deleting-all-objects-in-a-cobject-collection_3.cpp)]  
  
 You can call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to remove all elements in a map or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to remove an individual element with the specified key.  
  
## See Also  
 [Accessing All Members of a Collection](../vs140/accessing-all-members-of-a-collection.md)