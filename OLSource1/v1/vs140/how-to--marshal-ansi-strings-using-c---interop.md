---
title: "How to: Marshal ANSI Strings Using C++ Interop"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interop [C++], strings"
  - "ANSI [C++], marshaling strings"
  - "marshaling [C++], strings"
  - "C++ Interop, strings"
  - "data marshaling [C++], strings"
ms.assetid: 5eda2eb6-5140-40f0-82cf-7ce171fffb45
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal ANSI Strings Using C++ Interop
This topic demonstrates how ANSI strings can be passed using C++ Interop, but the .NET Framework <xref:System.String*> represents strings in Unicode format, so conversion to ANSI is an extra step. For interoperating with other string types, see the following topics:  
  
-   [How to: Marshal Unicode Strings using C++ Interop](../vs140/how-to--marshal-unicode-strings-using-c---interop.md)  
  
-   [How to: Marshal COM Strings using C++ Interop](../vs140/how-to--marshal-com-strings-using-c---interop.md)  
  
 The following code examples use the [managed, unmanaged](../vs140/managed--unmanaged.md) #pragma directives to implement managed and unmanaged functions in the same file, but these functions interoperate in the same manner if defined in separate files. Because files containing only unmanaged functions do not need to be compiled with [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md), they can retain their performance characteristics.  
  
## Example  
 The example demonstrates passing an ANSI string from a managed to an unmanaged function using [StringToHGlobalAnsi](assetId:///M:System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(System.String)?qualifyHint=False&autoUpgrade=True). This method allocates memory on the unmanaged heap and returns the address after performing the conversion. This means that no pinning is necessary (because memory on the GC heap is not being passed to the unmanaged function) and that the IntPtr returned from assetId:///M:System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(System.String)?qualifyHint=False&autoUpgrade=True must be explicitly released or a memory leak results.  
  
```  
// MarshalANSI1.cpp  
// compile with: /clr  
#include <iostream>  
#include <stdio.h>  
  
using namespace std;  
using namespace System;  
using namespace System::Runtime::InteropServices;  
  
#pragma unmanaged  
  
void NativeTakesAString(const char* p) {  
   printf_s("(native) received '%s'\n", p);  
}  
  
#pragma managed  
  
int main() {  
   String^ s = gcnew String("sample string");  
   IntPtr ip = Marshal::StringToHGlobalAnsi(s);  
   const char* str = static_cast<const char*>(ip.ToPointer());  
  
   Console::WriteLine("(managed) passing string...");  
   NativeTakesAString( str );  
  
   Marshal::FreeHGlobal( ip );  
}  
```  
  
## Example  
 The following example demonstrates the data marshaling required to access an ANSI string in a managed function that is called by an unmanaged function. The managed function, on receiving the native string, can either use it directly or convert it to a managed string using the [PtrToStringAnsi](assetId:///M:System.Runtime.InteropServices.Marshal.PtrToStringAnsi(System.IntPtr)?qualifyHint=False&autoUpgrade=True) method, as shown.  
  
```  
// MarshalANSI2.cpp  
// compile with: /clr  
#include <iostream>  
#include <vcclr.h>  
  
using namespace std;  
  
using namespace System;  
using namespace System::Runtime::InteropServices;  
  
#pragma managed  
  
void ManagedStringFunc(char* s) {  
   String^ ms = Marshal::PtrToStringAnsi(static_cast<IntPtr>(s));  
   Console::WriteLine("(managed): received '{0}'", ms);  
}  
  
#pragma unmanaged  
  
void NativeProvidesAString() {  
   cout << "(native) calling managed func...\n";  
   ManagedStringFunc("test string");  
}  
  
#pragma managed  
  
int main() {  
   NativeProvidesAString();  
}  
```  
  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)