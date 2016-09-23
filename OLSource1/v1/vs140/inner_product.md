---
title: "inner_product"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - inner_product
dev_langs: 
  - C++
helpviewer_keywords: 
  - inner_product function
ms.assetid: 5b14ed8f-a284-442e-863c-7106e670fa5a
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# inner_product
Computes the sum of the element-wise product of two ranges and adds it to a specified initial value or computes the result of a generalized procedure where the sum and product binary operations are replaced by other specified binary operations.  
  
## Syntax  
  
```  
  
      template<class InputIterator1, class InputIterator2, class Type>  
   Type inner_product(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      Type _Val  
   );  
  
template<class InputIterator1, class InputIterator2, class Type,  
   class BinaryOperation1, class BinaryOperation2>  
   Type inner_product(  
      InputIterator1 _First1,   
      InputIterator1 _Last1,  
      InputIterator2 _First2,   
      Type _Val,   
      BinaryOperation1 _Binary_op1,   
      BinaryOperation2 _Binary_op2  
   );  
```  
  
#### Parameters  
 `_First1`  
 An input iterator addressing the first element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 `_Last1`  
 An input iterator addressing the last element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 `_First2`  
 An input iterator addressing the first element in the second range whose inner product or generalized inner product with the first range is to be computed.  
  
 `_Val`  
 An initial value to which the inner product or generalized inner product between the ranges is to be added.  
  
 *_Binary_op1*  
 The binary operation that replaces the inner product operation of sum applied to the element-wise products in the generalization of the inner product.  
  
 *_Binary_op2*  
 The binary operation that replaces the inner product element-wise operation of multiply in the generalization of the inner product.  
  
## Return Value  
 The first member function returns the sum of the element-wise products and adds to it the specified initial value. So for ranges of values *a*i and *b*i, it returns:  
  
 `_Val` + ( *a*1 \* *b*1 ) + ( *a*2 \* *b*2 ) +  
  
 by iteratively replacing `_Val` with `_Val` + (\**a*i \* **b*i ).  
  
 The second member function returns:  
  
 `_Val` _*Binary_op1* ( *a*1 \_*Binary_op2* *b*1 ) \_*Binary_op1* ( *a*2 \_*Binary_op2* *b*2 ) \_*Binary_op1*  
  
 by iteratively replacing `_Val` with `_Val` _*Binary_op1* (\**a*i \_*Binary_op2* **b*i ).  
  
## Remarks  
 The initial value ensures that there will be a well-defined result when the range is empty, in which case `_Val` is returned. The binary operations do not need to be associative or commutative. The range must be valid and the complexity is linear with the size of the range. The return type of the binary operator must be convertible to **Type** to ensure closure during the iteration.  
  
## Example  
  
```  
// numeric_inner_prod.cpp  
// compile with: /EHsc  
#include <vector>  
#include <list>  
#include <numeric>  
#include <functional>  
#include <iostream>  
  
int main()  
{  
   using namespace std;  
  
   vector <int> v1, v2(7), v3(7);  
   vector <int>::iterator iter1, iter2, iter3;  
  
   int i;  
   for (i = 1; i <= 7; i++)  
   {  
      v1.push_back(i);  
   }  
  
   cout << "The original vector v1 is:\n ( " ;  
   for (iter1 = v1.begin(); iter1 != v1.end(); iter1++)  
      cout << *iter1 << " ";  
   cout << ")." << endl;  
  
   list <int> l1, l2(7);  
   list <int>::iterator lIter1, lIter2;  
  
   int t;  
   for (t = 1; t <= 7; t++)  
   {  
      l1.push_back(t);  
   }  
  
   cout << "The original list l1 is:\n ( " ;  
   for (lIter1 = l1.begin(); lIter1 != l1.end(); lIter1++)  
      cout << *lIter1 << " ";  
   cout << ")." << endl;  
  
   // The first member function for the inner product  
   int inprod;  
   inprod = inner_product(v1.begin(), v1.end(), l1.begin(), 0);  
  
   cout << "The inner_product of the vector v1 and the list l1 is: "  
        << inprod << "." << endl;  
  
   // Constructing a vector of partial inner_products between v1 & l1  
   int j = 0, parinprod;  
   for (iter1 = v1.begin(); iter1 != v1.end(); iter1++) {  
      parinprod = inner_product(v1.begin(), iter1 + 1, l1.begin(), 0);  
      v2[j] = parinprod;  
      j++;  
   }  
  
   cout << "Vector of partial inner_products between v1 & l1 is:\n ( " ;  
   for (iter2 = v2.begin(); iter2 != v2.end(); iter2++)  
      cout << *iter2 << " ";  
   cout << ")." << endl << endl;  
  
   // The second member function used to compute  
   // the product of the element-wise sums  
   int inprod2;  
   inprod2 = inner_product (v1.begin(), v1.end(),  
      l1.begin(), 1, multiplies<int>(), plus<int>());  
  
   cout << "The sum of the element-wise products of v1 and l1 is: "  
        << inprod2 << "." << endl;  
  
   // Constructing a vector of partial sums of element-wise products  
   int k = 0, parinprod2;  
   for (iter1 = v1.begin(); iter1 != v1.end(); iter1++)  
   {  
      parinprod2 =  
         inner_product(v1.begin(), iter1 + 1, l1.begin(), 1,  
         multiplies<int>(), plus<int>());  
      v3[k] = parinprod2;  
      k++;  
   }  
  
   cout << "Vector of partial sums of element-wise products is:\n ( " ;  
   for (iter3 = v3.begin(); iter3 != v3.end(); iter3++)  
      cout << *iter3 << " ";  
   cout << ")." << endl << endl;  
}  
```  
  
## Output  
  
```  
The original vector v1 is:  
 ( 1 2 3 4 5 6 7 ).  
The original list l1 is:  
 ( 1 2 3 4 5 6 7 ).  
The inner_product of the vector v1 and the list l1 is: 140.  
Vector of partial inner_products between v1 & l1 is:  
 ( 1 5 14 30 55 91 140 ).  
  
The sum of the element-wise products of v1 and l1 is: 645120.  
Vector of partial sums of element-wise products is:  
 ( 2 8 48 384 3840 46080 645120 ).  
```  
  
## Requirements  
 **Header:** <numeric\>  
  
 **Namespace:** std  
  
## See Also  
 [inner_product](../vs140/inner_product--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)