---
title: "transform"
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
  - "locale/std::collate::transform"
  - "std::collate::transform"
  - "collate.transform"
  - "std::transform"
  - "transform"
  - "std.collate.transform"
  - "collate::transform"
  - "algorithm/std::transform"
  - "std.transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform function"
  - "transform"
  - "transform method"
ms.assetid: 99396865-54fb-47dd-a661-38ce03467854
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# transform
Applies a specified function object to each element in a source range or to a pair of elements from two source ranges and copies the return values of the function object into a destination range.  
  
## Syntax  
  
```  
  
      template<class InputIterator, class OutputIterator, class UnaryFunction>  
   OutputIterator transform(  
      InputIterator _First1,   
      InputIterator _Last1,   
      OutputIterator _Result,  
      UnaryFunction _Func  
   );  
template<class InputIterator1, class InputIterator2, class OutputIterator,  
   class BinaryFunction>  
   OutputIterator transform(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      OutputIterator _Result,  
      BinaryFunction _Func  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the position of the first element in the first source range to be operated on.  
  
 `_Last1`  
 An input iterator addressing the position one past the final element in the first source range operated on.  
  
 `_First2`  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 `_Result`  
 An output iterator addressing the position of the first element in the destination range.  
  
 `_Func`  
 User-defined unary function object used in the first version of the algorithm that is applied to each element in the first source range or A user-defined (UD) binary function object used in the second version of the algorithm that is applied pairwise, in a forward order, to the two source ranges.  
  
## Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position must be reachable from the first by incrementation. The destination range must be large enough to contain the transformed source range.  
  
 If `_Result` is set equal to `_First1` in the first version of the algorithm*,* then the source and destination ranges will be the same and the sequence will be modified in place. But the `_Result` may not address a position within the range [`_First1` +1, `_Last1`).  
  
 The complexity is linear with at most (`_Last1` – `_First1`) comparisons.  
  
## Example  
  
```  
// alg_transform.cpp  
// compile with: /EHsc  
#include <vector>  
#include <algorithm>  
#include <functional>  
#include <iostream>  
  
// The function object multiplies an element by a Factor  
template <class Type>  
class MultValue  
{  
   private:  
      Type Factor;   // The value to multiply by  
   public:  
      // Constructor initializes the value to multiply by  
      MultValue ( const Type& _Val ) : Factor ( _Val ) {  
      }  
  
      // The function call for the element to be multiplied  
      Type operator ( ) ( Type& elem ) const   
      {  
         return elem * Factor;  
      }  
};  
  
int main( )  
{  
   using namespace std;  
   vector <int> v1, v2 ( 7 ), v3 ( 7 );  
   vector <int>::iterator Iter1, Iter2 , Iter3;  
  
   // Constructing vector v1  
   int i;  
   for ( i = -4 ; i <= 2 ; i++ )  
   {  
      v1.push_back(  i );  
   }  
  
   cout << "Original vector  v1 = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Modifying the vector v1 in place  
   transform (v1.begin ( ) , v1.end ( ) , v1.begin ( ) , MultValue<int> ( 2 ) );  
   cout << "The elements of the vector v1 multiplied by 2 in place gives:"  
        << "\n v1mod = ( " ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << " ";  
   cout << ")." << endl;  
  
   // Using transform to multiply each element by a factor of 5  
   transform ( v1.begin ( ) , v1.end ( ) , v2.begin ( ) , MultValue<int> ( 5 ) );  
  
   cout << "Multiplying the elements of the vector v1mod\n "  
        <<  "by the factor 5 & copying to v2 gives:\n v2 = ( " ;  
   for ( Iter2 = v2.begin( ) ; Iter2 != v2.end( ) ; Iter2++ )  
      cout << *Iter2 << " ";  
   cout << ")." << endl;  
  
   // The second version of transform used to multiply the   
   // elements of the vectors v1mod & v2 pairwise  
   transform ( v1.begin ( ) , v1.end ( ) ,  v2.begin ( ) , v3.begin ( ) ,   
      multiplies <int> ( ) );  
  
   cout << "Multiplying elements of the vectors v1mod and v2 pairwise "  
        <<  "gives:\n v3 = ( " ;  
   for ( Iter3 = v3.begin( ) ; Iter3 != v3.end( ) ; Iter3++ )  
      cout << *Iter3 << " ";  
   cout << ")." << endl;  
}  
```  
  
 **Original vector  v1 = ( -4 -3 -2 -1 0 1 2 ).**  
**The elements of the vector v1 multiplied by 2 in place gives:**  
 **v1mod = ( -8 -6 -4 -2 0 2 4 ).**  
**Multiplying the elements of the vector v1mod**  
 **by the factor 5 & copying to v2 gives:**  
 **v2 = ( -40 -30 -20 -10 0 10 20 ).**  
**Multiplying elements of the vectors v1mod and v2 pairwise gives:**  
 **v3 = ( 320 180 80 20 0 20 80 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)