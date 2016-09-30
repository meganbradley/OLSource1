---
title: "hash_map::operator"
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
  - "hash_map.operator[]"
  - "[]"
  - "std::hash_map::operator[]"
  - "operator[]"
  - "hash_map::operator[]"
  - "stdext.hash_map.operator[]"
  - "stdext::hash_map::operator[]"
  - "std.hash_map.operator[]"
  - "hash_map/stdext::hash_map::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], hash_map objects"
  - "operator[], hash_map objects"
  - "[] operator, with specific standard C++ objects"
ms.assetid: 44d40599-2032-423b-bfd1-597c9ffc8840
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::operator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element into a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with a specified key value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The key value of the element that is to be inserted.|  
  
## Return Value  
 A reference to the data value of the inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> may be used to insert elements into a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> using  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>;  
  
 where DataValue is the value of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> of the element with a key value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 When using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to insert elements, the returned reference does not indicate whether an insertion is changing a preexisting element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)