---
title: "make_shared (&lt;memory&gt;)"
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
  - "std.make_shared"
  - "memory/std::make_shared"
  - "make_shared"
  - "std::make_shared"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_shared function"
ms.assetid: 6d6015b9-ad9a-4c06-93ce-b07cf6193d23
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_shared (&lt;memory&gt;)
Creates and returns a `shared_ptr` that points to the allocated objects that are constructed from zero or more arguments by using the default allocator. Allocates and constructs both an object of the specified type and a `shared_ptr` to manage shared ownership of the object, and returns the `shared_ptr`.  
  
## Syntax  
  
```  
template<class Type, class... Types>  
    shared_ptr<Type> make_shared(  
        Types&&... _Args  
    );  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Args`|Zero or more constructor arguments. The function infers which constructor overload to invoke based on the arguments that are provided.|  
  
## Property Value/Return Value  
 Returns a `shared_ptr` that points to the allocated and constructed object.  
  
## Remarks  
 Use `make_shared` as a simple and more efficient way to create an object and a `shared_ptr` to manage shared access to the object at the same time. Semantically, these two statements are equivalent:  
  
```cpp  
   auto sp = std::shared_ptr<Example>(new Example(argument));  
   auto msp = std::make_shared<Example>(argument);  
```  
  
 However, the first statement makes two allocations, and if the allocation of the `shared_ptr` fails after the allocation of the `Example` object has succeeded, then the unnamed `Example` object is leaked. The statement that uses `make_shared` is simpler because there's only one function call involved. It's more efficient because the library can make a single allocation for both the object and the smart pointer. This is both faster and leads to less memory fragmentation, and there is no chance of an exception on one allocation but not the other. Performance is improved by better locality for code that references the object and updates the reference counts in the smart pointer.  
  
 Consider using [make_unique](../vs140/make_unique.md) if you do not need shared access to the object. Use [allocate_shared](../vs140/allocate_shared.md) if you need to specify a custom allocator for the object. You can't use `make_shared` if your object requires a custom deleter, because there is no way to pass the deleter as an argument.  
  
 The following example shows how to create shared pointers to a type by invoking specific constructor overloads.  
  
## Example  
  
```cpp  
// stl_make_shared.cpp  
// Compile by using: cl /W4 /EHsc stl_make_shared.cpp  
#include <iostream>  
#include <string>  
#include <memory>  
#include <vector>  
  
class Song {  
public:  
   std::wstring title_;  
   std::wstring artist_;  
  
   Song(std::wstring title, std::wstring artist) : title_(title), artist_(artist) {}  
   Song(std::wstring title) : title_(title), artist_(L"Unknown") {}  
};  
  
void CreateSharedPointers() {  
   // Okay, but less efficient to have separate allocations for  
   // Song object and shared_ptr control block.    
   auto song = new Song(L"Ode to Joy", L"Beethoven");  
   std::shared_ptr<Song> sp0(song);  
  
   // Use make_shared function when possible. Memory for control block  
   // and Song object are allocated in the same call:    
   auto sp1 = std::make_shared<Song>(L"Yesterday", L"The Beatles");  
   auto sp2 = std::make_shared<Song>(L"Blackbird", L"The Beatles");  
  
   // make_shared infers which constructor to use based on the arguments.  
   auto sp3 = std::make_shared<Song>(L"Greensleeves");  
  
   // The playlist vector makes copies of the shared_ptr pointers.  
   std::vector<std::shared_ptr<Song>> playlist;  
   playlist.push_back(sp0);  
   playlist.push_back(sp1);  
   playlist.push_back(sp2);  
   playlist.push_back(sp3);  
   playlist.push_back(sp1);  
   playlist.push_back(sp2);  
   for (auto&& sp : playlist) {  
      std::wcout << L"Playing " << sp->title_ <<   
         L" by " << sp->artist_ << L", use count: " <<   
         sp.use_count() << std::endl;  
   }  
}  
  
int main() {  
   CreateSharedPointers();  
}  
```  
  
 The example produces this output:  
  
 **Playing Ode to Joy by Beethoven, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**  
**Playing Greensleeves by Unknown, use count: 2**  
**Playing Yesterday by The Beatles, use count: 3**  
**Playing Blackbird by The Beatles, use count: 3**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)