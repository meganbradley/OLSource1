---
title: "Using C++ Interop (Implicit PInvoke)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "blittable types [C++]"
  - "platform invoke [C++], implicit"
  - "interop [C++], features"
  - "data marshaling [C++], C++ Interop features"
  - "porting [C++], C++ native to .NET"
  - "COM interfaces [C++]"
  - "implicit platform invoke"
  - "examples [C++], interoperability"
  - "types [C++], blittable"
  - "marshaling [C++], C++ Interop features"
  - "platform invoke [C++], examples"
  - "interoperability [C++]"
  - "C++ Interop"
  - "interoperability [C++], Implicit PInvoke"
  - "C++, interop"
  - "C++ COM Interop"
  - ".NET [C++], porting C++ native to"
ms.assetid: 5f710bf1-88ae-4c4e-8326-b3f0b7c4c68a
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using C++ Interop (Implicit PInvoke)
Unlike other .NET languages, Visual C++ has interoperability support that allows managed and unmanaged code to exist in the same application and even in the same file (with the [managed, unmanaged](../VS_csharp/managed--unmanaged.md) pragmas). This allows Visual C++ developers to integrate .NET functionality into existing Visual C++ applications without disturbing the rest of the application.  
  
 You can also call unmanaged functions from a managed compiland using [dllexport, dllimport](../VS_csharp/dllexport--dllimport.md).  
  
 Implicit PInvoke is useful when you do not need to specify how function parameters will be marshaled, or any of the other details that can be specified when explicitly calling DllImportAttribute.  
  
 Visual C++ provides two ways for managed and unmanaged functions to interoperate:  
  
-   [Using Explicit PInvoke in C++ (Using the DllImport Attribute)](../VS_csharp/using-explicit-pinvoke-in-c----dllimport-attribute-.md)  
  
 Explicit PInvoke is supported by the .NET Framework and is available in most .NET languages. But as its name implies, C++ Interop is specific to Visual C++.  
  
## C++ Interop  
 C++ Interop is recommended over explicit PInvoke because it provides better type safety, is typically less tedious to implement, is more forgiving if the unmanaged API is modified, and makes performance enhancements possible that are not possible with explicit PInvoke. However, C++ Interop is not possible if the unmanaged source code is not available or when compiling with **/clr:safe** (see [Pure / Verifiable](../VS_csharp/pure-and-verifiable-code--c---cli-.md) for more information).  
  
## C++ COM Interop  
 The interoperability features supported by Visual C++ offer a particular advantage over other .NET languages when it comes to interoperating with COM components. Instead of being limited to the restrictions of the .NET Framework [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382), such as limited support for data types and the mandatory exposure of every member of every COM interface, C++ Interop allows COM components to be accessed at will and does not require separate interop assemblies. For more information, see [Using COM from .NET](assetId:///03976661-6278-4227-a6c1-3b3315502c15).  
  
## Blittable Types  
 For unmanaged APIs that use simple, intrinsic types (see [Blittable and Non-Blittable Types](assetId:///d03b050e-2916-49a0-99ba-f19316e5c1b3)), no special coding is required because these data types have the same representation in memory, but more complex data types require explicit data marshaling. For an example, see [How to: Call Native DLLs from Managed Code (P/Invoke)](../VS_csharp/how-to--call-native-dlls-from-managed-code-using-pinvoke.md).  
  
## Example  
  
```  
// vcmcppv2_impl_dllimp.cpp  
// compile with: /clr:pure user32.lib  
using namespace System::Runtime::InteropServices;  
  
// Implicit DLLImport specifying calling convention  
extern "C" int __stdcall MessageBeep(int);  
  
// explicit DLLImport needed here to use P/Invoke marshalling because  
// System::String ^ is not the type of the first parameter to printf  
[DllImport("msvcrt.dll", EntryPoint = "printf", CallingConvention = CallingConvention::Cdecl,  CharSet = CharSet::Ansi)]  
// or just  
// [DllImport("msvcrt.dll")]  
int printf(System::String ^, ...);   
  
int main() {  
   // (string literals are System::String by default)  
   printf("Begin beep\n");  
   MessageBeep(100000);  
   printf("Done\n");  
}  
```  
  
 **Begin beep**  
**Done**   
## In This Section  
  
-   [How to: Marshal ANSI Strings using C++ Interop](../VS_csharp/how-to--marshal-ansi-strings-using-c---interop.md)  
  
-   [How to: Marshal Unicode Strings using C++ Interop](../VS_csharp/how-to--marshal-unicode-strings-using-c---interop.md)  
  
-   [How to: Marshal COM Strings using C++ Interop](../VS_csharp/how-to--marshal-com-strings-using-c---interop.md)  
  
-   [How to: Marshal Structures using C++ Interop](../VS_csharp/how-to--marshal-structures-using-c---interop.md)  
  
-   [How to: Marshal Arrays using C++ Interop](../VS_csharp/how-to--marshal-arrays-using-c---interop.md)  
  
-   [How to: Marshal Callbacks and Delegates using C++ Interop](../VS_csharp/how-to--marshal-callbacks-and-delegates-by-using-c---interop.md)  
  
-   [How to: Marshal Embedded Pointers using C++ Interop](../VS_csharp/how-to--marshal-embedded-pointers-using-c---interop.md)  
  
-   [How to: Access Characters in a System::String](../VS_csharp/how-to--access-characters-in-a-system--string.md)  
  
-   [How to: Convert char * String to System::Byte Array](../VS_csharp/how-to--convert-char---string-to-system--byte-array.md)  
  
-   [How to: Convert System::String to wchar_t* or char\*](../VS_csharp/how-to--convert-system--string-to-wchar_t--or-char-.md)  
  
-   [How to: Convert System::String to Standard String](../VS_csharp/how-to--convert-system--string-to-standard-string.md)  
  
-   [How to: Convert Standard String to System::String](../VS_csharp/how-to--convert-standard-string-to-system--string.md)  
  
-   [How to: Obtain a Pointer to Byte Array](../VS_csharp/how-to--obtain-a-pointer-to-byte-array.md)  
  
-   [How to: Load Unmanaged Resources into a Byte Array](../VS_csharp/how-to--load-unmanaged-resources-into-a-byte-array.md)  
  
-   [How to: Modify Reference Class in a Native Function](../VS_csharp/how-to--modify-reference-class-in-a-native-function.md)  
  
-   [How to: Determine if an Image is Native or CLR](../VS_csharp/how-to--determine-if-an-image-is-native-or-clr.md)  
  
-   [How to: Add Native DLL to Global Assembly Cache](../VS_csharp/how-to--add-native-dll-to-global-assembly-cache.md)  
  
-   [How to: Hold Reference to Value Type in Native Type](../VS_csharp/how-to--hold-reference-to-value-type-in-native-type.md)  
  
-   [How to: Hold Object Reference in Native Function](../VS_csharp/how-to--hold-object-reference-in-unmanaged-memory.md)  
  
-   [How to: Detect /clr Compilation](../VS_csharp/how-to--detect--clr-compilation.md)  
  
-   [How to: Convert Between System::Guid and _GUID](../VS_csharp/how-to--convert-between-system--guid-and-_guid.md)  
  
-   [How to: Specify an out Parameter](../VS_csharp/how-to--specify-an-out-parameter.md)  
  
-   [How to: Use a Native Type in a /clr Compilation](../VS_csharp/how-to--use-a-native-type-in-a--clr-compilation.md)  
  
-   [How to: Declare Handles in Native Types](../VS_csharp/how-to--declare-handles-in-native-types.md)  
  
-   [How to: Wrap Native Class for Use by C#](../VS_csharp/how-to--wrap-native-class-for-use-by-csharp.md)  
  
 For information on using delegates in an interop scenario, see [delegate](../VS_csharp/delegate---c---component-extensions-.md).  
  
## See Also  
 [Platform Invocation Services](../VS_csharp/calling-native-functions-from-managed-code.md)