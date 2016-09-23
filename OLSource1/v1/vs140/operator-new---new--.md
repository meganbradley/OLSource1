---
title: "operator new (&lt;new&gt;)"
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
  - std::new
  - std.operator new
  - std.new
  - new/std::new
  - std::operator new
dev_langs: 
  - C++
helpviewer_keywords: 
  - new operator
  - operator new
ms.assetid: 2476d0f9-59df-485c-981e-ba9f7ee83507
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator new (&lt;new&gt;)
The function called by a new-expression to allocate storage for individual objects.  
  
## Syntax  
  
```  
  
      void* operator new(  
   std::size_t _Count  
) throw(bad_alloc);  
void* operator new(  
   std::size_t _Count,          
   const std::nothrow_t&  
) throw( );  
void* operator new(  
   std::size_t _Count,   
   void* _Ptr  
) throw( );  
```  
  
#### Parameters  
 `_Count`  
 The number of bytes of storage to be allocated.  
  
 `_Ptr`  
 The pointer to be returned.  
  
## Return Value  
 A pointer to the lowest byte address of the newly-allocated storage. Or `_Ptr.`  
  
## Remarks  
 The first function is called by a new expression to allocate `_Count` bytes of storage suitably aligned to represent any object of that size. The program can define an alternate function with this function signature that replaces the default version defined by the Standard C++ Library and so is replaceable.  
  
 The required behavior is to return a nonnull pointer only if storage can be allocated as requested. Each such allocation yields a pointer to storage disjoint from any other allocated storage. The order and contiguity of storage allocated by successive calls is unspecified. The initial stored value is unspecified. The returned pointer points to the start (lowest byte address) of the allocated storage. If count is zero, the value returned does not compare equal to any other value returned by the function.  
  
 The default behavior is to execute a loop. Within the loop, the function first attempts to allocate the requested storage. Whether the attempt involves a call to `malloc`(**size_t**) is unspecified. If the attempt is successful, the function returns a pointer to the allocated storage. Otherwise, the function calls the designated [new handler](../vs140/new_handler.md). If the called function returns, the loop repeats. The loop terminates when an attempt to allocate the requested storage is successful or when a called function does not return.  
  
 The required behavior of a new handler is to perform one of the following operations:  
  
-   Make more storage available for allocation and then return.  
  
-   Call either **abort** or **exit**(`int`).  
  
-   Throw an object of type **bad_alloc.**  
  
 The default behavior of a [new handler](../vs140/new_handler.md) is to throw an object of type `bad_alloc`. A null pointer designates the default new handler.  
  
 The order and contiguity of storage allocated by successive calls to `operator new`(**size_t**) is unspecified, as are the initial values stored there.  
  
 The second function is called by a placement new expression to allocate `_Count` bytes of storage suitably aligned to represent any object of that size. The program can define an alternate function with this function signature that replaces the default version defined by the Standard C++ Library and so is replaceable.  
  
 The default behavior is to return `operator new`(`_Count`) if that function succeeds. Otherwise, it returns a null pointer.  
  
 The third function is called by a placement **new** expression, of the form **new** (*args*) T. Here, *args* consists of a single object pointer. This can be useful for constructing an object at a known address. The function returns *_Ptr*.  
  
 To free storage allocated by `operator new`, call [operator delete](../vs140/operator-delete---new--.md).  
  
 For information on throwing or nonthrowing behavior of new, see [The new and delete Operators](../vs140/new-and-delete-operators.md).  
  
## Example  
  
```  
// new_op_new.cpp  
// compile with: /EHsc  
#include<new>  
#include<iostream>  
  
using namespace std;  
  
class MyClass   
{  
public:   
   MyClass( )  
   {  
      cout << "Construction MyClass." << this << endl;  
   };  
  
   ~MyClass( )  
   {  
      imember = 0; cout << "Destructing MyClass." << this << endl;  
   };  
   int imember;  
};  
  
int main( )   
{  
   // The first form of new delete  
   MyClass* fPtr = new MyClass;  
   delete fPtr;  
  
   // The second form of new delete  
   MyClass* fPtr2 = new( nothrow ) MyClass;  
   delete fPtr2;  
  
   // The third form of new delete  
   char x[sizeof( MyClass )];  
   MyClass* fPtr3 = new( &x[0] ) MyClass;  
   fPtr3 -> ~MyClass();  
   cout << "The address of x[0] is : " << ( void* )&x[0] << endl;  
}  
```  
  
## Example Output  
  
```  
Construction MyClass.000B3F30  
Destructing MyClass.000B3F30  
Construction MyClass.000B3F30  
Destructing MyClass.000B3F30  
Construction MyClass.0023FC60  
Destructing MyClass.0023FC60  
The address of x[0] is : 0023FC60  
```  
  
## Requirements  
 **Header:** <new\>  
  
 **Namespace:** std  
  
## See Also  
 [new operator](../vs140/new-operator--stl-samples-.md)   
 [nothrow_t Class](../vs140/nothrow_t-structure.md)   
 [operator delete (<new\>)](../vs140/operator-delete---new--.md)