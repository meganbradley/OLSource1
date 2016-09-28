---
title: "reverse_iterator::operator-&gt;"
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
  - "reverse_iterator.operator->"
  - "reverse_iterator::operator->"
  - "std::reverse_iterator::operator->"
  - "std.reverse_iterator.operator->"
  - "iterator/std::reverse_iterator::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-> operator"
  - "-> operator, with specific objects"
  - "operator->"
ms.assetid: 1f1b6550-2d02-4dab-a2dd-1beead429c74
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator::operator-&gt;
Returns a pointer to the element addressed by the `reverse_iterator`.  
  
## Syntax  
  
```  
  
pointer operator->( ) const;  
  
```  
  
## Return Value  
 A pointer to the element addressed by the `reverse_iterator`.  
  
## Remarks  
 The operator returns **&\*\*this**.  
  
## Example  
  
```  
// reverse_iterator_ptrto.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <algorithm>  
#include <vector>  
#include <utility>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   typedef vector<pair<int,int> > pVector;  
   pVector vec;  
   vec.push_back(pVector::value_type(1,2));  
   vec.push_back(pVector::value_type(3,4));  
   vec.push_back(pVector::value_type(5,6));  
  
   pVector::iterator pvIter;  
   cout << "The vector vec of integer pairs is:\n( ";  
   for ( pvIter = vec.begin ( ) ; pvIter != vec.end ( ); pvIter++)  
      cout << "( " << pvIter -> first << ", " << pvIter -> second << ") ";  
   cout << ")" << endl << endl;  
  
   pVector::reverse_iterator rpvIter;  
   cout << "The vector vec reversed is:\n( ";  
   for ( rpvIter = vec.rbegin( ) ; rpvIter != vec.rend( ); rpvIter++ )  
      cout << "( " << rpvIter -> first << ", " << rpvIter -> second << ") ";  
   cout << ")" << endl << endl;  
  
   pVector::iterator pos = vec.begin ( );  
   pos++;  
   cout << "The iterator pos points to:\n( " << pos -> first << ", "   
   << pos -> second << " )" << endl << endl;  
  
   pVector::reverse_iterator rpos (pos);   
  
   // Use operator -> with return type: why type int and not int*?  
   int fint = rpos -> first;  
   int sint = rpos -> second;  
  
   cout << "The reverse_iterator rpos points to:\n( " << fint << ", "   
   << sint << " )" << endl;  
}  
```  
  
 **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The reverse_iterator rpos points to:**  
**( 1, 2 )**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [reverse_iterator Class](../vs140/reverse_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)