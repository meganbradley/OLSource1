---
title: "operator new(&lt;new&gt;)"
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
  - std::operator new[]
  - new/std::new[]
  - std.operator new[]
  - std.new[]
  - std::new[]
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator new[]
  - new[] operator
ms.assetid: c98bb1c9-6d7f-42c2-8366-f2f3eeb71a31
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator new(&lt;new&gt;)
The allocation function called by a new expression to allocate storage for an array of objects.  
  
## Syntax  
  
```  
  
      void *operator new[](std::size_t _Count)  
   throw(std::bad_alloc);  
void *operator new[](std::size_t _Count,  
   const std::nothrow_t&) throw( );  
void *operator new[](std::size_t _Count,   
   void* _Ptr) throw( );  
```  
  
#### Parameters  
 `_Count`  
 The number of bytes of storage to be allocated for the array object.  
  
 `_Ptr`  
 The pointer to be returned.  
  
## Return Value  
 A pointer to the lowest byte address of the newly-allocated storage. Or `_Ptr.`  
  
## Remarks  
 The first function is called by a `new[]` expression to allocate `_Count` bytes of storage suitably aligned to represent any array object of that size or smaller. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The required behavior is the same as for [operator new](../vs140/operator-new---new--.md)(**size_t**). The default behavior is to return `operator new`(`_Count`).  
  
 The second function is called by a placement `new[]` expression to allocate `_Count` bytes of storage suitably aligned to represent any array object of that size. The program can define a function with this function signature that replaces the default version defined by the Standard C++ Library. The default behavior is to return **operator new**(`_Count`) if that function succeeds. Otherwise, it returns a null pointer.  
  
 The third function is called by a placement `new[]` expression, of the form **new** (*args*) **T**[**N**]. Here, *args* consists of a single object pointer. The function returns `_Ptr`.  
  
 To free storage allocated by `operator new[]`, call [operator delete&#91;&#93;](../vs140/operator-delete--new--.md).  
  
 For information on throwing or nonthrowing behavior of new, see [The new and delete Operators](../vs140/new-and-delete-operators.md).  
  
## Example  
  
```  
// new_op_alloc.cpp  
// compile with: /EHsc  
#include <new>  
#include <iostream>  
  
using namespace std;  
  
class MyClass {  
public:  
   MyClass() {  
      cout << "Construction MyClass." << this << endl;  
   };  
  
   ~MyClass() {  
      imember = 0; cout << "Destructing MyClass." << this << endl;  
      };  
   int imember;  
};  
  
int main() {  
   // The first form of new delete  
   MyClass* fPtr = new MyClass[2];  
   delete[ ] fPtr;  
  
   // The second form of new delete  
   char x[2 * sizeof( MyClass ) + sizeof(int)];  
  
   MyClass* fPtr2 = new( &x[0] ) MyClass[2];  
   fPtr2[1].~MyClass();  
   fPtr2[0].~MyClass();  
   cout << "The address of x[0] is : " << ( void* )&x[0] << endl;  
  
   // The third form of new delete  
   MyClass* fPtr3 = new( nothrow ) MyClass[2];  
   delete[ ] fPtr3;  
}  
```  
  
## Sample Output  
  
```  
Construction MyClass.00311AEC  
Construction MyClass.00311AF0  
Destructing MyClass.00311AF0  
Destructing MyClass.00311AEC  
Construction MyClass.0012FED4  
Construction MyClass.0012FED8  
Destructing MyClass.0012FED8  
Destructing MyClass.0012FED4  
The address of x[0] is : 0012FED0  
Construction MyClass.00311AEC  
Construction MyClass.00311AF0  
Destructing MyClass.00311AF0  
Destructing MyClass.00311AEC  
```  
  
## Requirements  
 **Header:** <new\>  
  
 **Namespace:** std  
  
## See Also  
 [nothrow_t Class](../vs140/nothrow_t-structure.md)   
 [operator delete&#91;&#93; (<new\>)](../vs140/operator-delete--new--.md)