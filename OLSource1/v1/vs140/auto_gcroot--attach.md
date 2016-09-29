---
title: "auto_gcroot::attach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "auto_gcroot.attach"
  - "auto_gcroot::attach"
  - "msclr::auto_gcroot::attach"
  - "msclr.auto_gcroot.attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_gcroot::attach"
ms.assetid: 996ede65-bcb5-41f2-bfbf-507f8a578241
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::attach
Attach `auto_gcroot` to an object.  
  
## Syntax  
  
```  
auto_gcroot<_element_type> & attach(  
   _element_type _right  
);  
auto_gcroot<_element_type> & attach(  
   auto_gcroot<_element_type> & _right  
);  
template<typename _other_type>  
auto_gcroot<_element_type> & attach(  
   auto_gcroot<_other_type> & _right  
);  
```  
  
#### Parameters  
 `_right`  
 The object to attach, or an `auto_gcroot` containing the object to attach.  
  
## Return Value  
 The current `auto_gcroot`.  
  
## Remarks  
 If `_right` is an `auto_gcroot`, it releases ownership of its object before the object is attached to the current `auto_gcroot`.  
  
## Example  
  
```  
// msl_auto_gcroot_attach.cpp  
// compile with: /clr  
#include <msclr\auto_gcroot.h>  
  
using namespace System;  
using namespace msclr;  
  
ref class ClassA {  
protected:     
   String^ m_s;  
public:  
   ClassA( String^ s ) : m_s( s ) {  
      Console::WriteLine( "in ClassA constructor:" + m_s );  
   }  
   ~ClassA() {  
      Console::WriteLine( "in ClassA destructor:" + m_s );  
   }  
  
   virtual void PrintHello() {  
      Console::WriteLine( "Hello from {0} A!", m_s );  
   }  
};  
  
ref class ClassB : ClassA {  
public:  
   ClassB( String ^ s) : ClassA( s ) {}  
   virtual void PrintHello() new {  
      Console::WriteLine( "Hello from {0} B!", m_s );  
   }  
};  
  
int main() {  
   auto_gcroot<ClassA^> a( gcnew ClassA( "first" ) );  
   a->PrintHello();  
   a.attach( gcnew ClassA( "second" ) ); // attach same type  
   a->PrintHello();  
   ClassA^ ha = gcnew ClassA( "third" );  
   a.attach( ha ); // attach raw handle  
   a->PrintHello();  
   auto_gcroot<ClassB^> b( gcnew ClassB("fourth") );  
   b->PrintHello();  
   a.attach( b ); // attach derived type  
   a->PrintHello();  
}  
```  
  
 **in ClassA constructor:first**  
**Hello from first A!**  
**in ClassA constructor:second**  
**in ClassA destructor:first**  
**Hello from second A!**  
**in ClassA constructor:third**  
**in ClassA destructor:second**  
**Hello from third A!**  
**in ClassA constructor:fourth**  
**Hello from fourth B!**  
**in ClassA destructor:third**  
**Hello from fourth A!**  
**in ClassA destructor:fourth**   
## Requirements  
 **Header file** <msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::operator=](../vs140/auto_gcroot--operator=.md)   
 [auto_gcroot::release](../vs140/auto_gcroot--release.md)