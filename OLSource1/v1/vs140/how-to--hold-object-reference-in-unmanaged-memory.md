---
title: "How to: Hold Object Reference in Unmanaged Memory"
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
  - object references, in native functions
  - objects [C++], reference in native functions
  - references, to objects in native functions
  - gcroot keyword [C++], object reference in native function
ms.assetid: a61eb8ce-3982-477d-8d3d-2173fd57166d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Hold Object Reference in Unmanaged Memory
You can use gcroot.h, which wraps <xref:System.Runtime.InteropServices.GCHandle?qualifyHint=False>, to hold a CLR object reference in unmanaged memory. Alternatively, you can use `GCHandle` directly.  
  
## Example  
  
```  
// hold_object_reference.cpp  
// compile with: /clr  
#include "gcroot.h"  
using namespace System;  
  
#pragma managed  
class StringWrapper {  
  
private:  
   gcroot<String ^ > x;  
  
public:  
   StringWrapper() {  
      String ^ str = gcnew String("ManagedString");  
      x = str;  
   }  
  
   void PrintString() {  
      String ^ targetStr = x;  
      Console::WriteLine("StringWrapper::x == {0}", targetStr);  
   }  
};  
#pragma unmanaged  
int main() {  
   StringWrapper s;  
   s.PrintString();  
}  
```  
  
 **StringWrapper::x == ManagedString**   
## Example  
 `GCHandle` gives you a means to hold a managed object reference in unmanaged memory.  You use the <xref:System.Runtime.InteropServices.GCHandle.Alloc?qualifyHint=False> method to create an opaque handle to a managed object and <xref:System.Runtime.InteropServices.GCHandle.Free?qualifyHint=False> to release it. Also, the <xref:System.Runtime.InteropServices.GCHandle.Target?qualifyHint=False> method allows you to obtain the object reference back from the handle in managed code.  
  
```  
// hold_object_reference_2.cpp  
// compile with: /clr  
using namespace System;  
using namespace System::Runtime::InteropServices;  
  
#pragma managed  
class StringWrapper {  
   IntPtr m_handle;  
public:  
   StringWrapper() {  
      String ^ str = gcnew String("ManagedString");  
      m_handle = static_cast<IntPtr>(GCHandle::Alloc(str));  
   }  
   ~StringWrapper() {  
      static_cast<GCHandle>(m_handle).Free();  
   }  
  
   void PrintString() {  
      String ^ targetStr = safe_cast< String ^ >(static_cast<GCHandle>(m_handle).Target);  
      Console::WriteLine("StringWrapper::m_handle == {0}", targetStr);  
   }  
};  
  
#pragma unmanaged  
int main() {  
   StringWrapper s;   
   s.PrintString();  
}  
```  
  
 **StringWrapper::m_handle == ManagedString**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)