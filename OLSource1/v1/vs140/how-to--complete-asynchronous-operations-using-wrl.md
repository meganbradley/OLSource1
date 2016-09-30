---
title: "How to: Complete Asynchronous Operations Using WRL"
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
ms.assetid: 02173eae-731b-49bc-b412-f1f69388b99d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Complete Asynchronous Operations Using WRL
This document shows how to use the [!INCLUDE[cppwrl](../vs140/includes/cppwrl_md.md)] ([!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)]) to start asynchronous operations and perform work when the operations complete.  
  
 This document shows two examples. The first example starts an asynchronous timer and waits for the timer to expire. In this example, you specify the asynchronous action when you create the timer object. The second example runs a background worker thread. This example shows how to work with a [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] method that returns an `IAsyncInfo` interface. The [Callback](../vs140/callback-function--windows-runtime-c---template-library-.md) function is an important part of both examples because it enables them to specify an event handler to process the results of the asynchronous operations.  
  
 For a more basic example that creates an instance of that component and retrieves a property value, see [How to: Load and Use a Windows Runtime Component (WRL)](../vs140/how-to--activate-and-use-a-windows-runtime-component-using-wrl.md).  
  
> [!TIP]
>  These examples use lambda expressions to define the callbacks. You can also use function objects (functors), function pointers, or [std::function](../vs140/function-class.md) objects. For more information about C++ lambda expressions, see [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md).  
  
## Example: Working with a Timer  
 The following steps start an asynchronous timer and wait for the timer to expire. The complete example follows.  
  
> [!WARNING]
>  Although you typically use the [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)] in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, this example uses a console app for illustration. Functions such as `wprintf_s` are not available from a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app. For more information about the types and functions that you can use in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, see [CRT functions not supported by /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx) and [Win32 and COM for Windows Store apps](http://msdn.microsoft.com/library/windows/apps/br205757.aspx).  
  
1.  Include (`#include`) any required [!INCLUDE[wrt](../vs140/includes/wrt_md.md)], [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)], or standard C++ library headers.  
  
     [!code[wrl-consume-async#2](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_1.cpp)]  
  
     Windows.System.Threading.h declares the types that are required to use an asynchronous timer.  
  
     We recommend that you utilize the `using namespace` directive in your .cpp file to make the code more readable.  
  
2.  Initialize the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
     [!code[wrl-consume-async#3](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_2.cpp)]  
  
3.  Create an activation factory for the `ABI::Windows::System::Threading::IThreadPoolTimer` interface.  
  
     [!code[wrl-consume-async#4](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_3.cpp)]  
  
     The [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] uses fully-qualified names to identify types. The `RuntimeClass_Windows_System_Threading_ThreadPoolTimer` parameter is a string that's provided by the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] and contains the required runtime class name.  
  
4.  Create an [Event](../vs140/event-class--windows-runtime-c---template-library-.md) object that synchronizes the timer callback to the main app.  
  
     [!code[wrl-consume-async#5](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_4.cpp)]  
  
    > [!NOTE]
    >  This event is for demonstration only as part of a console app. This example uses the event to ensure that an async operation completes before the app exits. In most apps, you typically don’t wait for async operations to complete.  
  
5.  Create an `IThreadPoolTimer` object that expires after two seconds. Use the `Callback` function to create the event handler (an `ABI::Windows::System::Threading::ITimerElapsedHandler` object).  
  
     [!code[wrl-consume-async#6](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_5.cpp)]  
  
6.  Print a message to the console and wait for the timer callback to complete. All `ComPtr` and RAII objects leave scope and are released automatically.  
  
     [!code[wrl-consume-async#7](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_6.cpp)]  
  
 Here is the complete example:  
  
 [!code[wrl-consume-async#1](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_7.cpp)]  
  
### Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named `wrl-consume-async.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe wrl-consume-async.cpp runtimeobject.lib**  
  
## Example: Working with a Background Thread  
 The following steps start a worker thread and define the action that's performed by that thread. The complete example follows.  
  
> [!TIP]
>  This example demonstrates how to work with the `ABI::Windows::Foundation::IAsyncAction` interface. You can apply this pattern to any interface that implements `IAsyncInfo`: `IAsyncAction`, `IAsyncActionWithProgress`, `IAsyncOperation`, and`IAsyncOperationWithProgress`.  
  
1.  Include (`#include`) any required [!INCLUDE[wrt](../vs140/includes/wrt_md.md)], [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)], or standard C++ library headers.  
  
     [!code[wrl-consume-asyncOp#2](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_8.cpp)]  
  
     Windows.System.Threading.h declares the types that are required to use a worker thread.  
  
     We recommend that you use the `using namespace` directive in your .cpp file to make the code more readable.  
  
2.  Initialize the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
     [!code[wrl-consume-asyncOp#3](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_9.cpp)]  
  
3.  Create an activation factory for the `ABI::Windows::System::Threading::IThreadPoolStatics` interface.  
  
     [!code[wrl-consume-asyncOp#4](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_10.cpp)]  
  
4.  Create an [Event](../vs140/event-class--windows-runtime-c---template-library-.md) object that synchronizes completion of the worker thread to the main app.  
  
     [!code[wrl-consume-asyncOp#5](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_11.cpp)]  
  
    > [!NOTE]
    >  This event is for demonstration only as part of a console app. This example uses the event to ensure that an async operation completes before the app exits. In most apps, you typically don’t wait for async operations to complete.  
  
5.  Call the `IThreadPoolStatics::RunAsync` method to create a worker thread. Use the `Callback` function to define the action.  
  
     [!code[wrl-consume-asyncOp#6](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_12.cpp)]  
  
     The `IsPrime` function is defined in the complete example that follows.  
  
6.  Print a message to the console and wait for the thread to complete. All `ComPtr` and RAII objects leave scope and are released automatically.  
  
     [!code[wrl-consume-asyncOp#7](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_13.cpp)]  
  
 Here is the complete example:  
  
 [!code[wrl-consume-asyncOp#1](../vs140/codesnippet/CPP/how-to--complete-asynchronous-operations-using-wrl_14.cpp)]  
  
### Compiling the Code  
 To compile the code, copy it and then paste it in a Visual Studio project, or paste it in a file that is named `wrl-consume-asyncOp.cpp` and then run the following command in a Visual Studio Command Prompt window.  
  
 **cl.exe wrl-consume-asyncOp.cpp runtimeobject.lib**  
  
## See Also  
 [Windows Runtime C++ Template Library](../vs140/windows-runtime-c---template-library--wrl-.md)