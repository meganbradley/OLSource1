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
  
##  <a name="_core_compiler_implementation_for_tls"></a> Compiler Implementation for TLS  
 **C++11:**  The `thread_local` storage class specifier is the recommended way to specify thread-local storage for objects and class members. For more information, see [Storage classes (C++)](../vs140/storage-classes--c---.md#thread_local).  
  
 Visual C++ also provides a Microsoft-specific attribute,  [thread](../vs140/thread.md), as extended storage class modifier. Use the `__declspec` keyword to declare a **thread** variable. For example, the following code declares an integer thread local variable and initializes it with a value:  
  
```  
__declspec( thread ) int tls_i = 1;  
```  
  
## Rules and limitations  
 The following guidelines must be observed when declaring statically bound thread local objects and variables. These guidelines apply both to [__declspec( thread )](../vs140/thread.md)and for the most part also to [thread_local](../vs140/storage-classes--c---.md#thread_local):  
  
-   The `thread` attribute can be applied only to class and data declarations and definitions. It cannot be used on function declarations or definitions. For example, the following code generates a compiler error:  
  
    ```  
  
    __declspec( thread )void func();     // This will generate an error.  
    ```  
  
-   The `thread` modifier might be specified only on data items with `static` extent. This includes global data objects (both `static` and `extern`), local static objects, and static data members of C++ classes. Automatic data objects cannot be declared with the `thread` attribute. The following code generates compiler errors:  
  
    ```  
  
    void func1()  
    {  
        __declspec( thread )int tls_i;            // This will generate an error.  
    }  
  
    int func2(__declspec( thread )int tls_i )    // This will generate an error.  
    {  
        return tls_i;  
    }  
    ```  
  
-   The declarations and the definition of a thread local object must all specify the `thread` attribute. For example, the following code generates an error:  
  
    ```  
    #define Thread  __declspec( thread )  
    extern int tls_i;        // This will generate an error, since the  
    int __declspec( thread )tls_i;        // declaration and definition differ.  
    ```  
  
-   The `thread` attribute cannot be used as a type modifier. For example, the following code generates a compiler error:  
  
    ```  
    char __declspec( thread ) *ch;        // Error  
    ```  
  
-   Because the declaration of C++ objects that use the `thread` attribute is permitted, the following two examples are semantically equivalent:  
  
    ```  
  
    __declspec( thread ) class B  
    {  
    // Code  
    } BObject;  // OK--BObject is declared thread local.  
  
    class B  
    {  
    // Code  
    };  
    __declspec( thread ) B BObject;  // OK--BObject is declared thread local.  
    ```  
  
-   The address of a thread local object is not considered constant, and any expression involving such an address is not considered a constant expression. In standard C, the effect of this is to forbid the use of the address of a thread local variable as an initializer for an object or pointer. For example, the following code is flagged as an error by the C compiler:  
  
    ```  
  
    __declspec( thread )int tls_i;  
    int *p = &tls_i;       //This will generate an error in C.  
    ```  
  
     This restriction does not apply in C++. Because C++ allows for dynamic initialization of all objects, you can initialize an object by using an expression that uses the address of a thread local variable. This is accomplished just like the construction of thread local objects. For example, the code shown earlier does not generate an error when it is compiled as a C++ source file. Note that the address of a thread local variable is valid only as long as the thread in which the address was taken still exists.  
  
-   Standard C allows for the initialization of an object or variable with an expression involving a reference to itself, but only for objects of nonstatic extent. Although C++ generally allows for such dynamic initialization of objects with an expression involving a reference to itself, this kind of initialization is not permitted with thread local objects. For example:  
  
    ```  
    __declspec( thread )int tls_i = tls_i;                // Error in C and C++   
    int j = j;                               // OK in C++, error in C  
    __declspec( thread )int tls_i = sizeof( tls_i )       // Legal in C and C++  
    ```  
  
     Note that a `sizeof` expression that includes the object being initialized does not represent a reference to itself and is enabled in both C and C++.  
  
     C++ does not allow such dynamic initialization of thread data because of possible future enhancements to the thread local storage facility.  
  
-   On Windows operating systems before [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], `__declspec`( thread ) has some limitations. If a DLL declares any data or object as `__declspec`( thread ), it can cause a protection fault if dynamically loaded. After the DLL is loaded with [LoadLibrary](http://msdn.microsoft.com/library/windows/desktop/ms684175), it causes system failure whenever the code references the `__declspec`( thread ) data. Because the global variable space for a thread is allocated at run time, the size of this space is based on a calculation of the requirements of the application plus the requirements of all the DLLs that are statically linked. When you use `LoadLibrary`, you cannot extend this space to allow for the thread local variables declared with `__declspec`( thread ). Use the TLS APIs, such as [TlsAlloc](http://msdn.microsoft.com/library/windows/desktop/ms686801), in your DLL to allocate TLS if the DLL might be loaded with `LoadLibrary`.  
  
## See Also  
 [Multithreading with C and Win32](../vs140/multithreading-with-c-and-win32.md)   
 [Rules and Limitations for TLS](../vs140/rules-and-limitations-for-tls.md)