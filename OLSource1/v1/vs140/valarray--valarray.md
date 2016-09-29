---
title: "valarray::valarray"
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
  - "std::valarray::valarray"
  - "valarray/std::valarray::valarray"
  - "valarray"
  - "std.valarray.valarray"
  - "valarray::valarray"
  - "valarray.valarray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "valarray class, constructor"
  - "valarray method"
ms.assetid: 02fe09e6-4e9c-4c19-a950-287f335392ca
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::valarray
Constructs a valarray of a specific size or with elements of a specific value or as a copy of another valarray or subset of another valarray.  
  
## Syntax  
  
```  
valarray( );  
explicit valarray(  
   size_t Count  
);  
valarray(  
   const Type& Val,   
   size_t Count  
);  
valarray(  
   const Type* Ptr,   
   size_t Count  
);  
valarray(  
   const valarray<Type>& Right  
);  
valarray(  
   const slice_array<Type>& SliceArray  
);  
valarray(  
   const gslice_array<Type>& GsliceArray  
);  
valarray(  
   const mask_array<Type>& MaskArray  
);  
valarray(  
   const indirect_array<Type>& IndArray  
);  
valarray(  
   valarray<Type>&& Right  
);  
valarray(  
    initializer_list<Type> IList  
);  
```  
  
#### Parameters  
 `Count`  
 The number of elements to be in the valarray.  
  
 `Val`  
 The value to be used in initializing the elements in the valarray.  
  
 `Ptr`  
 Pointer to the values to be used to initialize the elements in the valarray.  
  
 `Right`  
 An existing valarray to initialize the new valarray.  
  
 `SliceArray`  
 A slice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 `GsliceArray`  
 A gslice_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 `MaskArray`  
 A mask_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 `IndArray`  
 A indirect_array whose element values are to be used in initializing the elements of the valarray being constructed.  
  
 `IList`  
 The initializer_list containing the elements to copy.  
  
## Remarks  
 The first (default) constructor initializes the object to an empty array. The next three constructors each initialize the object to an array of `Count` elements as follows:  
  
-   For explicit `valarray(size_t Count)`, each element is initialized with the default constructor.  
  
-   For `valarray(const Type& Val, Count)`, each element is initialized with `Val`.  
  
-   For `valarray(const Type* Ptr, Count)`, the element at position `I` is initialized with `Ptr`[`I`].  
  
 Each remaining constructor initializes the object to a valarray<Type\> object determined by the subset specified in the argument.  
  
 The last constructor is the same as the next to last, but with an [rvalue reference](../vs140/rvalue-reference-declarator----.md).  
  
## Example  
  
```  
// valarray_ctor.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    int i;  
  
    // The second member function  
    valarray<int> va(10);  
    for (auto i : va){  
        va[i] = 2 * (i + 1);  
    }  
  
    cout << "The operand valarray va is:\n(";  
    for (auto i : va) {  
        cout << " " << va[i];  
    }  
    cout << " )" << endl;  
  
    slice Slice(2, 4, 3);  
  
    // The fifth member function  
    valarray<int> vaSlice = va[Slice];  
  
    cout << "The new valarray initialized from the slice is vaSlice ="  
        << "\nva[slice( 2, 4, 3)] = (";  
    for (int i = 0; i < 3; i++) {  
        cout << " " << vaSlice[i];  
    }  
    cout << " )" << endl;  
  
    valarray<int> va2{{ 1, 2, 3, 4 }};  
    for (auto& v : va2){  
        cout << v << " ";  
    }  
    cout << endl;  
}  
  
```  
  
 **The operand valarray va is:( 0 2 2 2 2 2 2 2 2 2 )The new valarray initialized from the slice is vaSlice =va[slice( 2, 4, 3)] = ( 0 0 0 )1 2 3 4**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)