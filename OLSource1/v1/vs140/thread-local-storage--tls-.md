---
title: "Thread Local Storage (TLS)"
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
  - "multithreading [C++], Thread Local Storage"
  - "TLS [C++]"
  - "threading [C++], Thread Local Storage"
  - "storing thread-specific data"
  - "thread attribute"
  - "Thread Local Storage [C++]"
ms.assetid: 80801907-d792-45ca-b776-df0cf2e9f197
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Thread Local Storage (TLS)
Thread Local Storage (TLS) is the method by which each thread in a given multithreaded process can allocate locations in which to store thread-specific data. Dynamically bound (run-time) thread-specific data is supported by way of the TLS API ([TlsAlloc](assetId:///TlsAlloc?qualifyHint=False&autoUpgrade=True),  [TlsGetValue](assetId:///TlsGetValue?qualifyHint=False&autoUpgrade=True),  [TlsSetValue](assetId:///TlsSetValue?qualifyHint=False&autoUpgrade=True), and [TlsFree](assetId:///TlsFree?qualifyHint=False&autoUpgrade=True)). For more information about how thread local storage is implemented on Windows, see [Thread Local Storage (Windows)](https://msdn.microsoft.com/en-us/library/windows/desktop/ms686749\(v=vs.85\).aspx).  Win32 and the Visual C++ compiler now support statically bound (load-time) per-thread data in addition to the existing API implementation.  
  
##  \<a name="_core_compiler_implementation_for_tls">\</a> Compiler Implementation for TLS  
 **C++11:**  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> storage class specifier is the recommended way to specify thread-local storage for objects and class members. For more information, see [Storage classes (C++)](../vs140/storage-classes--c---.md#thread_local).  
  
 Visual C++ also provides a Microsoft-specific attribute,  [thread](../vs140/thread.md), as extended storage class modifier. Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword to declare a **thread** variable. For example, the following code declares an integer thread local variable and initializes it with a value:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Rules and limitations  
 The following guidelines must be observed when declaring statically bound thread local objects and variables. These guidelines apply both to [__declspec( thread )](../vs140/thread.md)and for the most part also to [thread_local](../vs140/storage-classes--c---.md#thread_local):  
  
-   The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute can be applied only to class and data declarations and definitions. It cannot be used on function declarations or definitions. For example, the following code generates a compiler error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> modifier might be specified only on data items with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> extent. This includes global data objects (both <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>), local static objects, and static data members of C++ classes. Automatic data objects cannot be declared with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute. The following code generates compiler errors:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   The declarations and the definition of a thread local object must all specify the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute. For example, the following code generates an error:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute cannot be used as a type modifier. For example, the following code generates a compiler error:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   Because the declaration of C++ objects that use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute is permitted, the following two examples are semantically equivalent:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   The address of a thread local object is not considered constant, and any expression involving such an address is not considered a constant expression. In standard C, the effect of this is to forbid the use of the address of a thread local variable as an initializer for an object or pointer. For example, the following code is flagged as an error by the C compiler:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     This restriction does not apply in C++. Because C++ allows for dynamic initialization of all objects, you can initialize an object by using an expression that uses the address of a thread local variable. This is accomplished just like the construction of thread local objects. For example, the code shown earlier does not generate an error when it is compiled as a C++ source file. Note that the address of a thread local variable is valid only as long as the thread in which the address was taken still exists.  
  
-   Standard C allows for the initialization of an object or variable with an expression involving a reference to itself, but only for objects of nonstatic extent. Although C++ generally allows for such dynamic initialization of objects with an expression involving a reference to itself, this kind of initialization is not permitted with thread local objects. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     Note that a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> expression that includes the object being initialized does not represent a reference to itself and is enabled in both C and C++.  
  
     C++ does not allow such dynamic initialization of thread data because of possible future enhancements to the thread local storage facility.  
  
-   On Windows operating systems before [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>( thread ) has some limitations. If a DLL declares any data or object as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>( thread ), it can cause a protection fault if dynamically loaded. After the DLL is loaded with [LoadLibrary](http://msdn.microsoft.com/library/windows/desktop/ms684175), it causes system failure whenever the code references the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>( thread ) data. Because the global variable space for a thread is allocated at run time, the size of this space is based on a calculation of the requirements of the application plus the requirements of all the DLLs that are statically linked. When you use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, you cannot extend this space to allow for the thread local variables declared with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>( thread ). Use the TLS APIs, such as [TlsAlloc](http://msdn.microsoft.com/library/windows/desktop/ms686801), in your DLL to allocate TLS if the DLL might be loaded with <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## See Also  
 [Multithreading with C and Win32](../vs140/multithreading-with-c-and-win32.md)   
 [Rules and Limitations for TLS](../vs140/rules-and-limitations-for-tls.md)