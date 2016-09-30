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
  
```  
  
      Type& operator[](const Key& _Key);  
Type& operator0-(  
    Key&& _Key  
);  
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
  
 `operator[]` may be used to insert elements into a map `m` using `m[_Key] = DataValue;` where `DataValue` is the value of the `mapped_type` of the element with a key value of `_Key`.  
  
 When using `operator[]` to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
```  
// map_op_insert.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
#include <string>  
  
int main( )  
{  
   using namespace std;  
   typedef pair <const int, int> cInt2Int;  
   map <int, int> m1;  
   map <int, int> :: iterator pIter;  
  
   // Insert a data value of 10 with a key of 1  
   // into a map using the operator[] member function  
   m1[ 1 ] = 10;  
  
   // Compare other ways to insert objects into a map  
   m1.insert ( map <int, int> :: value_type ( 2, 20 ) );  
   m1.insert ( cInt2Int ( 3, 30 ) );  
  
   cout  << "The keys of the mapped elements are:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> first;  
   cout << "." << endl;  
  
   cout  << "The values of the mapped elements are:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> second;  
   cout << "." << endl;  
  
   // If the key already exists, operator[]  
   // changes the value of the datum in the element  
   m1[ 2 ] = 40;  
  
   // operator[] will also insert the value of the data  
   // type's default constructor if the value is unspecified  
   m1[5];  
  
   cout  << "The keys of the mapped elements are now:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> first;  
   cout << "." << endl;  
  
   cout  << "The values of the mapped elements are now:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> second;  
   cout << "." << endl;  
  
// insert by moving key  
    map<string, int> c2;  
    string str("abc");  
    cout << "c2[move(str)] == " << c2[move(str)] << endl;  
    cout << "c2["abc"] == " << c2["abc"] << endl;  
  
    return (0);   
}  
```  
  
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