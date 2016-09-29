---
title: "ios_base::register_callback"
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
  - "std::ios_base::register_callback"
  - "register_callback"
  - "ios_base::register_callback"
  - "ios_base.register_callback"
  - "std.ios_base.register_callback"
  - "xiosbase/std::ios_base::register_callback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "register_callback"
  - "register_callback method"
ms.assetid: b4b053d7-8c17-4589-b91b-b35fab27f8d5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::register_callback
Specifies a callback function.  
  
## Syntax  
  
```  
  
      void register  
      _  
      callback(  
   event_callback pfn,  
   int idx  
);  
```  
  
#### Parameters  
 `pfn`  
 Pointer to the callback function.  
  
 `idx`  
 A user-defined number.  
  
## Remarks  
 The member function pushes the pair `{``pfn`, `idx``}` onto the stored callback stack [callback stack](../vs140/ios_base-class.md). When a callback event **ev** is reported, the functions are called, in reverse order of registry, by the expression (**\***`pfn`)(**ev**,``**\*this**,```idx`).  
  
## Example  
  
```  
// ios_base_register_callback.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
using namespace std;  
  
void callback1( ios_base::event e, ios_base& stream, int arg )   
{  
   cout << "in callback1" << endl;  
   switch ( e )   
   {  
      case ios_base::erase_event:  
         cout << "an erase event" << endl;  
         break;  
      case ios_base::imbue_event:  
         cout << "an imbue event" << endl;  
         break;  
      case ios_base::copyfmt_event:  
         cout << "an copyfmt event" << endl;  
         break;  
   };  
}  
  
void callback2( ios_base::event e, ios_base& stream, int arg )   
{  
   cout << "in callback2" << endl;  
   switch ( e )   
   {  
      case ios_base::erase_event:  
         cout << "an erase event" << endl;  
         break;  
      case ios_base::imbue_event:  
         cout << "an imbue event" << endl;  
         break;  
      case ios_base::copyfmt_event:  
         cout << "an copyfmt event" << endl;  
         break;  
   };  
}  
  
int main( )   
{  
   // Make sure the imbue will not throw an exception  
   // assert( setlocale( LC_ALL, "german" )!=NULL );  
  
   cout.register_callback( callback1, 0 );  
   cin.register_callback( callback2, 0 );  
  
   try   
   {  
      // If no exception because the locale's not found,  
      // generate an imbue_event on callback1  
      cout.imbue(locale("german"));  
   }  
   catch(...)   
   {  
      cout << "exception" << endl;  
   }  
  
   // This will  
   // (1) erase_event on callback1  
   // (2) copyfmt_event on callback2  
   cout.copyfmt(cin);  
  
   // We get two erase events from callback2 at the end because   
// both cin and cout have callback2 registered when cin and cout  
   // are destroyed at the end of program.  
}  
```  
  
 **in callback1**  
**an imbue event**  
**in callback1**  
**an erase event**  
**in callback2**  
**an copyfmt event**  
**in callback2**  
**an erase event**  
**in callback2**  
**an erase event**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)