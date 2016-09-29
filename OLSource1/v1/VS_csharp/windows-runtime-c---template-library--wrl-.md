---
title: "Windows Runtime C++ Template Library (WRL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: b915afce-553b-44a7-b8dc-0ab601758eb0
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Runtime C++ Template Library (WRL)
The [!INCLUDE[cppwrl](../VS_csharp/includes/cppwrl_md.md)] ([!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)]) is a template library that provides a low-level way to author and use [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] components.  
  
## Benefits  
 The [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] enables you to more easily implement and consume Component Object Model (COM) components. It provides housekeeping techniques like reference-counting to manage the lifetime of objects and testing `HRESULT` values to determine whether an operation succeeded or failed. To successfully use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)], you must carefully follow these rules and techniques.  
  
 The [!INCLUDE[cppwrt](../VS_csharp/includes/cppwrt_md.md)] ([!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)]) is a high-level, language-based way to use [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] components. Both the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] and [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)] simplify the writing of code for the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] by automatically performing housekeeping tasks on your behalf.  
  
 The [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] and [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)] provide different benefits. Here are some reasons you might want to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] instead of [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)]:  
  
-   [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] adds little abstraction over the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] Application Binary Interface (ABI), giving you the ability to control the underlying code to better create or consume [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] APIs.  
  
-   [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)] represents COM `HRESULT` values as exceptions. If you’ve inherited a code base that uses COM, or one that doesn’t use exceptions, you might find that the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] is a more natural way to work with the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] because you don't have to use exceptions.  
  
    > [!NOTE]
    >  The [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] uses `HRESULT` values and does not throw exceptions. In addition, the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] uses smart pointers and the RAII pattern to help guarantee that objects are destroyed correctly when your application code throws an exception. For more info about smart pointers and RAII, see [Smart Pointers (Modern C++)](../VS_csharp/smart-pointers--modern-c---.md) and [Objects Own Resources (RAII)](../VS_csharp/objects-own-resources--raii-.md).  
  
-   The purpose and design of the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] is inspired by the Active Template Library (ATL), which is a set of template-based C++ classes that simplify the programming of COM objects. Because [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] uses standard C++ to wrap the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)], you can more easily port and interact with many existing COM components written in ATL to the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]. If you already know ATL, you might find that [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] programming is easier.  
  
## Getting Started  
 Here are some resources that can help you get working with the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] right away.  
  
 [The Windows Runtime Library (WRL)](http://channel9.msdn.com/Events/Windows-Camp/Developing-Windows-8-Metro-style-apps-in-Cpp/The-Windows-Runtime-Library-WRL-)  
 In this Channel 9 video, learn more about how the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] helps you write [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] apps and how to author and consume [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] components.  
  
 [How to: Activate and use a Windows Runtime Component (WRL)](../VS_csharp/how-to--activate-and-use-a-windows-runtime-component-using-wrl.md)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to initialize the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] and activate and use a [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] component.  
  
 [How to: Complete Async Operations (WRL)](../VS_csharp/how-to--complete-asynchronous-operations-using-wrl.md)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to start asynchronous operations and perform work when the operations complete.  
  
 [How to: Handle Events (WRL)](../VS_csharp/how-to--handle-events-using-wrl.md)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to subscribe to and handle the events of a [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] object.  
  
 [Walkthrough: Creating a Basic Windows Runtime Component (WRL)](../VS_csharp/walkthrough--creating-a-basic-windows-runtime-component-using-wrl.md)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to create a basic [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] component that adds two numbers. Also demonstrates how to raise events and use the component from a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app that uses JavaScript.  
  
 [Walkthrough: Creating a Windows Store app using WRL and Media Foundation](../VS_csharp/walkthrough--creating-a-windows-store-app-using-wrl-and-media-foundation.md)  
 Learn how to create a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app that uses [Microsoft Media Foundation](http://msdn.microsoft.com/library/windows/apps/ms694197).  
  
 [How to: Create a Classic COM Component Using WRL](../VS_csharp/how-to--create-a-classic-com-component-using-wrl.md)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to create a basic COM component and a basic way to register and consume the COM component from a desktop app.  
  
 [How to: Instantiate WRL Components Directly](../VS_csharp/how-to--instantiate-wrl-components-directly.md)  
 Learn how to use the [Microsoft::WRL::Make](../VS_csharp/make-function.md) and [Microsoft::WRL::Details::MakeAndInitialize](../VS_csharp/makeandinitialize-function.md) functions to instantiate a component from the module that defines it.  
  
 [How to: Use winmdidl.exe to create IDL files from windows metadata](../VS_csharp/how-to--use-winmdidl.exe-and-midlrt.exe-to-create-.h-files-from-windows-metadata.md)  
 Shows how to consume custom Windows Runtime components from WRL by creating an IDL file from the .winmd metadata.  
  
 [Walkthrough: Connecting Using Tasks and XML HTTP Request (IXHR2)](../VS_csharp/walkthrough--connecting-using-tasks-and-xml-http-requests.md)  
 Shows how to use the [IXMLHTTPRequest2](assetId:///bbc11c4a-aecf-4d6d-8275-3e852e309908) and [IXMLHTTPRequest2Callback](assetId:///aa4b3f4c-6e28-458b-be25-6cce8865fc71) interfaces together with tasks to send HTTP GET and POST requests to a web service in a [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app.  
  
 [Bing Maps Trip Optimizer sample](http://code.msdn.microsoft.com/Bing-Maps-trip-optimizer-c4e037f7)  
 Uses the `HttpRequest` class that's defined in [Walkthrough: Connecting Using Tasks and XML HTTP Request (IXHR2)](../VS_csharp/walkthrough--connecting-using-tasks-and-xml-http-requests.md) in the context of a complete [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] app.  
  
 [Creating a Windows Runtime DLL component with C++ sample](http://code.msdn.microsoft.com/windowsapps/Creating-a-Windows-Runtime-6c399797)  
 Shows how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to create an in-process DLL component and consume it from C++/CX, JavaScript, and C#.  
  
 [DirectX marble maze game sample](http://code.msdn.microsoft.com/windowsapps/DirectX-Marble-Maze-Game-e4806345)  
 Demonstrates how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to manage the lifetime of COM components such as DirectX and Media Foundation in the context of a complete 3-D game.  
  
 [Sending toast notifications from desktop apps sample](http://code.msdn.microsoft.com/windowsdesktop/Sending-toast-notifications-71e230a2)  
 Demonstrates how to use the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to work with toast notifications from a desktop app.  
  
## [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] Compared to ATL  
 [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] resembles the Active Template Library (ATL) because you can use it to create small, fast COM objects. [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] and ATL also share concepts such as definition of objects in modules, explicit registration of interfaces, and open creation of objects by using factories. You might be comfortable with [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] if you're familiar with ATL.  
  
 [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] supports the COM functionality that is required for [!INCLUDE[win8_appname_long](../VS_csharp/includes/win8_appname_long_md.md)] apps. Therefore, it differs from the ATL because it omits direct support for COM features such as:  
  
-   aggregation  
  
-   stock implementations  
  
-   dual interfaces (`IDispatch`)  
  
-   standard enumerator interfaces  
  
-   connection points  
  
-   tear-off interfaces  
  
-   OLE embedding  
  
-   ActiveX controls  
  
-   COM+  
  
## Concepts  
 [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] provides types that represent a few basic concepts. The following sections describe those types.  
  
### ComPtr  
 [ComPtr](../VS_csharp/comptr-class.md) is a *smart pointer* type that represents the interface that's specified by the template parameter. Use `ComPtr` to declare a variable that can access the members of an object that's derived from the interface. `ComPtr` automatically maintains a reference count for the underlying interface pointer and releases the interface when the reference count goes to zero.  
  
### RuntimeClass  
 [RuntimeClass](../VS_csharp/runtimeclass-class.md) represents an instantiated class that inherits a set of specified interfaces. A `RuntimeClass` object can provide a combination of support for one or more [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] COM interfaces, or a weak reference to a component.  
  
### Module  
 [Module](../VS_csharp/module-class.md) represents a collection of related objects. A `Module` object manages class factories, which create objects, and registration, which enables other applications to use an object.  
  
### Callback  
 The [Callback](../VS_csharp/callback-function--windows-runtime-c---template-library-.md) function creates an object whose member function is an event handler (a callback method). Use the `Callback` function to write asynchronous operations.  
  
### EventSource  
 [EventSource](../VS_csharp/eventsource-class.md) is used to manage *delegate* event handlers. Use [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] to implement a delegate, and use `EventSource` to add, remove, and invoke delegates.  
  
### AsyncBase  
 [AsyncBase](../VS_csharp/asyncbase-class.md) provides virtual methods that represent the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] asynchronous programming model. Override the members in this class to create a custom class that can start, stop, or check the progress of an asynchronous operation.  
  
### FtmBase  
 [FtmBase](../VS_csharp/ftmbase-class.md) represents a free-threaded marshaler object. `FtmBase` creates a global interface table (GIT), and helps manage marshaling and proxy objects.  
  
### WeakRef  
 [WeakRef](../VS_csharp/weakref-class.md) is a smart-pointer type that represents a *weak reference*, which references an object that might or might not be accessible. A `WeakRef` object can be used by only the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)], and not by classic COM.  
  
 A `WeakRef` object typically represents an object whose existence is controlled by an external thread or application. For example, a `WeakRef` object can reference a file object. When the file is open, the `WeakRef` is valid and the referenced file is accessible. But when the file is closed, the `WeakRef` is invalid and the file is not accessible.  
  
## Related Topics  
  
|||  
|-|-|  
|[Class Library Project Template (WRL)](../VS_csharp/wrl-class-library-project-template.md)|Describes how to access the WRL Class Library project template. This template helps simplify the task of using Visual Studio to create [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] components.|  
|[Key APIs by Category (WRL)](../VS_csharp/key-wrl-apis-by-category.md)|Highlights the primary [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)] types, functions, and macros.|  
|[Reference (WRL)](../VS_csharp/wrl-reference.md)|Contains reference information for the [!INCLUDE[cppwrl_short](../VS_csharp/includes/cppwrl_short_md.md)].|  
|[Quick Reference (Windows Runtime and Visual C++)](http://go.microsoft.com/fwlink/?LinkId=229180)|Briefly describes the [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)] features that support the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].|  
|[Using Windows Runtime Components in Visual C++](http://go.microsoft.com/fwlink/?LinkId=229155)|Shows how to use [!INCLUDE[cppwrt_short](../VS_csharp/includes/cppwrt_short_md.md)] to create a basic [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] component.|