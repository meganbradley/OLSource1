---
title: "How to: Implement is and as C# Keywords (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
H1: "How to: Implement is and as C# Keywords (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "as C# keyword [C++]"
  - "is C# keyword [C++]"
ms.assetid: bc66c0d1-696b-480d-977c-5d9d1ad1ece6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement is and as C# Keywords (C++-CLI)
This topic shows how to implement the functionality of the `is` and `as` C# keywords in Visual C++.  
  
 For more information, see [is (C# Programmer's Reference)](../VS_csharp/is--csharp-reference-.md) and [as (C# Programmer's Reference)](../VS_csharp/as--csharp-reference-.md).  
  
## Example  
  
```  
// CS_is_as.cpp  
// compile with: /clr  
using namespace System;  
  
interface class I {  
public:  
   void F();  
};  
  
ref struct C : public I {  
   virtual void F( void ) { }  
};  
  
template < class T, class U >   
Boolean isinst(U u) {  
   return dynamic_cast< T >(u) != nullptr;  
}  
  
int main() {  
   C ^ c = gcnew C();  
   I ^ i = safe_cast< I ^ >(c);   // is (maps to castclass in IL)  
   I ^ ii = dynamic_cast< I ^ >(c);   // as (maps to isinst in IL)  
  
   // simulate 'as':  
   Object ^ o = "f";  
   if ( isinst< String ^ >(o) )  
      Console::WriteLine("o is a string");  
}  
```  
  
 **o is a string**   
## See Also  
 [Interoperability with other .NET languages in C++](../VS_csharp/interoperability-with-other-.net-languages--c---cli-.md)