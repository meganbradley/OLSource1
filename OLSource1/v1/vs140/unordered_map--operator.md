---
title: "unordered_map::operator"
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
  - "unordered_map/std::tr1::unordered_map::operator[]"
  - "tr1::unordered_map::operator[]"
  - "unordered_map::operator[]"
  - "operator[]"
  - "std::tr1::unordered_map::operator[]"
  - "std.tr1.unordered_map.operator[]"
  - "unordered_map.operator[]"
  - "tr1.unordered_map.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator [TR1]"
  - "operator[]"
ms.assetid: 4584d4af-72b4-48da-9f35-3100d54a9bb4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::operator
Finds or inserts an element with the specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The key value to find or insert.|  
  
## Return Value  
 A reference to the data value of the inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> may be used to insert elements into a map *m* using *m*[_*Key*] = <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the value of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of the element with a key value of \_*Key*.  
  
 When using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**c1['A'] == 0**  
**c1['a'] == 1**  
 **[c, 3] [b, 2] [A, 0] [a, 1]**  
**c2[move(str)] == 0**  
**c2["abc"] == 1**   
## Remarks  
 The member function determines the iterator <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as the return value of [insert](../vs140/unordered_map--insert.md)<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [value_type](../vs140/unordered_map--value_type.md)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. (It inserts an element with the specified key if no such element exists.) It then returns a reference to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::find](../vs140/unordered_map--find.md)   
 [unordered_map::insert](../vs140/unordered_map--insert.md)