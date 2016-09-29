---
title: "istreambuf_iterator::equal"
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
  - "istreambuf_iterator.equal"
  - "std.istreambuf_iterator.equal"
  - "equal"
  - "streambuf/std::istreambuf_iterator::equal"
  - "istreambuf_iterator::equal"
  - "std::istreambuf_iterator::equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal method"
ms.assetid: f274bd81-3052-4bf2-b595-31cab5550c27
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator::equal
Tests for equivalence between two input stream buffer iterators.  
  
## Syntax  
  
```  
bool equal(  
   const istreambuf_iterator<CharType, Traits>& _Right  
) const;  
```  
  
#### Parameters  
 `_Right`  
 The iterator for which to check for equality.  
  
## Return Value  
 **true** if both `istreambuf_iterator`s are end-of-stream iterators or if neither is an end-of-stream iterator; otherwise **false**.  
  
## Remarks  
 A range is defined by the `istreambuf_iterator` to the current position and the end-of-stream iterator, but since all non-end-of stream iterators are equivalent under the **equal** member function, it is not possible to define any subranges using `istreambuf_iterator`s. The `==` and `!=` operators have the same semantics.  
  
## Example  
  
```  
// istreambuf_iterator_equal.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   cout << "(Try the example: 'Hello world!'\n"  
        << " then an Enter key to insert into the output,\n"  
        << " & use a ctrl-Z Enter key combination to exit): ";  
  
   istreambuf_iterator<char> charReadIn1 ( cin );  
   istreambuf_iterator<char> charReadIn2 ( cin );  
  
   bool b1 = charReadIn1.equal ( charReadIn2 );  
  
   if (b1)  
      cout << "The iterators are equal." << endl;  
   else  
      cout << "The iterators are not equal." << endl;  
}  
```  
  
  **`Hello world!` `Hello world!`(Try the example: 'Hello world!'**  
 **then an Enter key to insert into the output,**  
 **& use a ctrl-Z Enter key combination to exit): Hello world!**  
**The iterators are equal.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)