---
title: "map::operator[]"
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
  - "map/std::map::operator[]"
  - "std.map.operator[]"
  - "[]"
  - "operator[]"
  - "map.operator[]"
  - "map::operator[]"
  - "std::map::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], map objects"
  - "operator [], map objects"
  - "[] operator, with specific standard C++ objects"
ms.assetid: ede1bf3e-49f8-493b-ac1c-42b7019f4acb
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# map::operator[]
Inserts an element into a map with a specified key value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The key value of the element that is to be inserted.|  
  
## Return Value  
 A reference to the data value of the inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> may be used to insert elements into a map <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the value of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of the element with a key value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 When using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The keys of the mapped elements are: 1 2 3.**  
**The values of the mapped elements are: 10 20 30.**  
**The keys of the mapped elements are now: 1 2 3 5.**  
**The values of the mapped elements are now: 10 40 30 0.**  
**c2[move(str)] == 0**  
**c2["abc"] == 1**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)