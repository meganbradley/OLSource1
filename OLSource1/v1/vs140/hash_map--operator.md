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
  
 Inserts an element into a `hash_map` with a specified key value.  
  
## Syntax  
  
```  
Type& operator[](const Key& _Key);  
Type& operator[](Key&& _Key);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Key`|The key value of the element that is to be inserted.|  
  
## Return Value  
 A reference to the data value of the inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 `operator[]` may be used to insert elements into a `hash_map m` using  
  
 `m[_Key] = DataValue`;  
  
 where DataValue is the value of the `mapped_type` of the element with a key value of `_Key`.  
  
 When using `operator[]` to insert elements, the returned reference does not indicate whether an insertion is changing a preexisting element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
```  
// hash_map_op_ref.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
#include <string>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   typedef pair <const int, int> cInt2Int;  
   hash_map <int, int> hm1;  
   hash_map <int, int> :: iterator pIter;  
  
   // Insert a data value of 10 with a key of 1  
   // into a hash_map using the operator[] member function  
   hm1[ 1 ] = 10;  
  
   // Compare other ways to insert objects into a hash_map  
   hm1.insert ( hash_map <int, int> :: value_type ( 2, 20 ) );  
   hm1.insert ( cInt2Int ( 3, 30 ) );  
  
   cout  << "The keys of the mapped elements are:";  
   for ( pIter = hm1.begin( ) ; pIter != hm1.end( ) ; pIter++ )  
      cout << " " << pIter -> first;  
   cout << "." << endl;  
  
   cout  << "The values of the mapped elements are:";  
   for ( pIter = hm1.begin( ) ; pIter != hm1.end( ) ; pIter++ )  
      cout << " " << pIter -> second;  
   cout << "." << endl;  
  
   // If the key already exists, operator[]  
   // changes the value of the datum in the element  
   hm1[ 2 ] = 40;  
  
   // operator[] will also insert the value of the data  
   // type's default constructor if the value is unspecified  
   hm1[5];  
  
   cout  << "The keys of the mapped elements are now:";  
   for ( pIter = hm1.begin( ) ; pIter != hm1.end( ) ; pIter++ )  
      cout << " " << pIter -> first;  
   cout << "." << endl;  
  
   cout  << "The values of the mapped elements are now:";  
   for ( pIter = hm1.begin( ) ; pIter != hm1.end( ) ; pIter++ )  
      cout << " " << pIter -> second;  
   cout << "." << endl;  
  
   // opperator[] will also insert by moving a key  
   hash_map <string, int> hm2;  
   string str("a");  
   hm2[move(str)] = 1;  
   cout << "The moved key is " << hm2.begin()->first  
      << ", with value " << hm2.begin()->second << endl;  
}  
```  
  
## Output  
  
```  
The keys of the mapped elements are: 1 2 3.  
The values of the mapped elements are: 10 20 30.  
The keys of the mapped elements are now: 1 2 3 5.  
The values of the mapped elements are now: 10 40 30 0.  
The moved key is a, with value 1.  
```  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)