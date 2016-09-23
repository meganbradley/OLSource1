---
title: "How to: Convert Between System::Guid and _GUID"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: get-started-article
dev_langs: 
  - C++
helpviewer_keywords: 
  - System::GUID
  - GUID, converting to System::GUID
  - System::GUID, converting to GUID
ms.assetid: 022c934c-3395-4f04-b498-85ad9bf8c646
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Convert Between System::Guid and _GUID
The following code sample shows how to convert between a <xref:System.Guid?qualifyHint=False> and a `_GUID`.  
  
## Example  
  
```  
// convert_guids.cpp  
// compile with: /clr  
#include <windows.h>  
#include <stdio.h>  
  
using namespace System;  
  
Guid FromGUID( _GUID& guid ) {  
   return Guid( guid.Data1, guid.Data2, guid.Data3,   
                guid.Data4[ 0 ], guid.Data4[ 1 ],   
                guid.Data4[ 2 ], guid.Data4[ 3 ],   
                guid.Data4[ 4 ], guid.Data4[ 5 ],   
                guid.Data4[ 6 ], guid.Data4[ 7 ] );  
}  
  
_GUID ToGUID( Guid& guid ) {  
   array<Byte>^ guidData = guid.ToByteArray();  
   pin_ptr<Byte> data = &(guidData[ 0 ]);  
  
   return *(_GUID *)data;  
}  
  
int main() {  
   _GUID ng = {0x11111111,0x2222,0x3333,0x44,0x55,0x55,0x55,0x55,0x55,0x55,0x55};  
   Guid mg;  
  
   Console::WriteLine( (mg = FromGUID( ng )).ToString() );  
   _GUID ng2 = ToGUID( mg );  
  
   printf_s(  "%x-%x-%x-", ng2.Data1, ng2.Data2, ng2.Data3 );  
   for (int i = 0 ; i < 8 ; i++) {  
      if (i == 2)  
         printf_s("-");  
      printf_s("%x", ng2.Data4[i]);  
   }  
   printf_s("\n");  
}  
```  
  
 **11111111-2222-3333-4455-555555555555**  
**11111111-2222-3333-4455-555555555555**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)