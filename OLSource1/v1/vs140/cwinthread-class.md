---
title: "CWinThread Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CWinThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "worker threads"
  - "threading [MFC], safety"
  - "CWinThread class"
  - "threading [MFC], creating threads"
ms.assetid: 10cdc294-4057-4e76-ac7c-a8967a89af0b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread Class
Represents a thread of execution within an application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWinThread::CWinThread](#cwinthread__cwinthread)|Constructs a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CWinThread::CreateThread](#cwinthread__createthread)|Starts execution of a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[CWinThread::ExitInstance](#cwinthread__exitinstance)|Override to clean up when your thread terminates.|  
|[CWinThread::GetMainWnd](#cwinthread__getmainwnd)|Retrieves a pointer to the main window for the thread.|  
|[CWinThread::GetThreadPriority](#cwinthread__getthreadpriority)|Gets the priority of the current thread.|  
|[CWinThread::InitInstance](#cwinthread__initinstance)|Override to perform thread instance initialization.|  
|[CWinThread::IsIdleMessage](#cwinthread__isidlemessage)|Checks for special messages.|  
|[CWinThread::OnIdle](#cwinthread__onidle)|Override to perform thread-specific idle-time processing.|  
|[CWinThread::PostThreadMessage](#cwinthread__postthreadmessage)|Posts a message to another <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CWinThread::PreTranslateMessage](#cwinthread__pretranslatemessage)|Filters messages before they are dispatched to the Windows functions                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934).|  
|[CWinThread::ProcessMessageFilter](#cwinthread__processmessagefilter)|Intercepts certain messages before they reach the application.|  
|[CWinThread::ProcessWndProcException](#cwinthread__processwndprocexception)|Intercepts all unhandled exceptions thrown by the thread's message and command handlers.|  
|[CWinThread::PumpMessage](#cwinthread__pumpmessage)|Contains the thread's message loop.|  
|[CWinThread::ResumeThread](#cwinthread__resumethread)|Decrements a thread's suspend count.|  
|[CWinThread::Run](#cwinthread__run)|Controlling function for threads with a message pump. Override to customize the default message loop.|  
|[CWinThread::SetThreadPriority](#cwinthread__setthreadpriority)|Sets the priority of the current thread.|  
|[CWinThread::SuspendThread](#cwinthread__suspendthread)|Increments a thread's suspend count.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CWinThread::operator HANDLE](#cwinthread__operator_handle)|Retrieves the handle of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CWinThread::m_bAutoDelete](#cwinthread__m_bautodelete)|Specifies whether to destroy the object at thread termination.|  
|[CWinThread::m_hThread](#cwinthread__m_hthread)|Handle to the current thread.|  
|[CWinThread::m_nThreadID](#cwinthread__m_nthreadid)|ID of the current thread.|  
|[CWinThread::m_pActiveWnd](#cwinthread__m_pactivewnd)|Pointer to the main window of the container application when an OLE server is in-place active.|  
|[CWinThread::m_pMainWnd](#cwinthread__m_pmainwnd)|Holds a pointer to the application's main window.|  
  
## Remarks  
 The main thread of execution is usually provided by an object derived from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Additional <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects allow multiple threads within a given application.  
  
 There are two general types of threads that <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> supports: worker threads and user-interface threads. Worker threads have no message pump: for example, a thread that performs background calculations in a spreadsheet application. User-interface threads have a message pump and process messages received from the system. [CWinApp](../vs140/cwinapp-class.md) and classes derived from it are examples of user-interface threads. Other user-interface threads can also be derived directly from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 Objects of class <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> typically exist for the duration of the thread. If you wish to modify this behavior, set [m_bAutoDelete](#cwinthread__m_bautodelete) to **FALSE**.  
  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class is necessary to make your code and MFC fully thread-safe. Thread-local data used by the framework to maintain thread-specific information is managed by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects. Because of this dependence on <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to handle thread-local data, any thread that uses MFC must be created by MFC. For example, a thread created by the run-time function [_beginthread, _beginthreadex](../vs140/_beginthread--_beginthreadex.md) cannot use any MFC APIs.  
  
 To create a thread, call [AfxBeginThread](../vs140/afxbeginthread.md). There are two forms, depending on whether you want a worker or user-interface thread. If you want a user-interface thread, pass to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> a pointer to the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> of your <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>-derived class. If you want to create a worker thread, pass to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> a pointer to the controlling function and the parameter to the controlling function. For both worker threads and user-interface threads, you can specify optional parameters that modify priority, stack size, creation flags, and security attributes. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> will return a pointer to your new <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
 Instead of calling <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, you can construct a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>-derived object and then call <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. This two-stage construction method is useful if you want to reuse the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object between successive creation and terminations of thread executions.  
  
 For more information on <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, see the articles [Multithreading with C++ and MFC](../vs140/multithreading-with-c---and-mfc.md), [Multithreading: Creating User-Interface Threads](../vs140/multithreading--creating-user-interface-threads.md), [Multithreading: Creating Worker Threads](../vs140/multithreading--creating-worker-threads.md), and [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cwinthread__createthread">\</a>  CWinThread::CreateThread  
 Creates a thread to execute within the address space of the calling process.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies an additional flag that controls the creation of the thread. This flag can contain one of two values:  
  
-   **CREATE_SUSPENDED** Start the thread with a suspend count of one. Use **CREATE_SUSPENDED** if you want to initialize any member data of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object, such as [m_bAutoDelete](#cwinthread__m_bautodelete) or any members of your derived class, before the thread starts running. Once your initialization is complete, use the [CWinThread::ResumeThread](#cwinthread__resumethread) to start the thread running. The thread will not execute until <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is called.  
  
-   **0** Start the thread immediately after creation.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the size in bytes of the stack for the new thread. If **0**, the stack size defaults to the same size as that of the process's primary thread.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Points to a                                 [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies the security attributes for the thread.  
  
### Return Value  
 Nonzero if the thread is created successfully; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to create a thread object and execute it in one step. Use <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> if you want to reuse the thread object between successive creation and termination of thread executions.  
  
##  \<a name="cwinthread__cwinthread">\</a>  CWinThread::CWinThread  
 Constructs a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 To begin the thread's execution, call the [CreateThread](#cwinthread__createthread) member function. You will usually create threads by calling [AfxBeginThread](../vs140/afxbeginthread.md), which will call this constructor and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
##  \<a name="cwinthread__exitinstance">\</a>  CWinThread::ExitInstance  
 Called by the framework from within a rarely overridden [Run](#cwinthread__run) member function to exit this instance of the thread, or if a call to [InitInstance](#cwinthread__initinstance) fails.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The thread's exit code; 0 indicates no errors, and values greater than 0 indicate an error. This value can be retrieved by calling                         [GetExitCodeThread](http://msdn.microsoft.com/library/windows/desktop/ms683190).  
  
### Remarks  
 Do not call this member function from anywhere but within the **Run** member function. This member function is used only in user-interface threads.  
  
 The default implementation of this function deletes the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object if [m_bAutoDelete](#cwinthread__m_bautodelete) is **TRUE**. Override this function if you wish to perform additional clean-up when your thread terminates. Your implementation of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> should call the base class's version after your code is executed.  
  
##  \<a name="cwinthread__getmainwnd">\</a>  CWinThread::GetMainWnd  
 If your application is an OLE server, call this function to retrieve a pointer to the active main window of the application instead of directly referring to the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> member of the application object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 This function returns a pointer to one of two types of windows. If your thread is part of an OLE server and has an object that is in-place active inside an active container, this function returns the [CWinApp::m_pActiveWnd](../vs140/cwinapp-class.md#cwinapp__m_pactivewnd) data member of the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
 If there is no object that is in-place active within a container or your application is not an OLE server, this function returns the [m_pMainWnd](#cwinthread__m_pmainwnd) data member of your thread object.  
  
### Remarks  
 For user-interface threads, this is equivalent to directly referring to the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> member of your application object.  
  
 If your application is not an OLE server, then calling this function is equivalent to directly referring to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> member of your application object.  
  
 Override this function to modify the default behavior.  
  
##  \<a name="cwinthread__getthreadpriority">\</a>  CWinThread::GetThreadPriority  
 Gets the current thread priority level of this thread.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The current thread priority level within its priority class. The value returned will be one of the following, listed from highest priority to lowest:  
  
-   **THREAD_PRIORITY_TIME_CRITICAL**  
  
-   **THREAD_PRIORITY_HIGHEST**  
  
-   **THREAD_PRIORITY_ABOVE_NORMAL**  
  
-   **THREAD_PRIORITY_NORMAL**  
  
-   **THREAD_PRIORITY_BELOW_NORMAL**  
  
-   **THREAD_PRIORITY_LOWEST**  
  
-   **THREAD_PRIORITY_IDLE**  
  
 For more information on these priorities, see                         [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cwinthread__initinstance">\</a>  CWinThread::InitInstance  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> must be overridden to initialize each new instance of a user-interface thread.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if initialization is successful; otherwise 0.  
  
### Remarks  
 Typically, you override <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to perform tasks that must be completed when a thread is first created.  
  
 This member function is used only in user-interface threads. Perform initialization of worker threads in the controlling function passed to [AfxBeginThread](../vs140/afxbeginthread.md).  
  
##  \<a name="cwinthread__isidlemessage">\</a>  CWinThread::IsIdleMessage  
 Override this function to keep **OnIdle** from being called after specific messages are generated.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Points to the current message being processed.  
  
### Return Value  
 Nonzero if <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> should be called after processing message; otherwise 0.  
  
### Remarks  
 The default implementation does not call **OnIdle** after redundant mouse messages and messages generated by blinking carets.  
  
 If an application has created a short timer, **OnIdle** will be called frequently, causing performance problems. To improve such an application's performance, override <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> in the application's <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>-derived class to check for <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> messages as follows:  
  
 [!code[NVC_MFCDocView#189](../vs140/codesnippet/CPP/cwinthread-class_1.cpp)]  
  
 Handling <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> in this fashion will improve performance of applications that use short timers.  
  
##  \<a name="cwinthread__m_bautodelete">\</a>  CWinThread::m_bAutoDelete  
 Specifies whether the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object should be automatically deleted at thread termination.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> data member is a public variable of type **BOOL**.  
  
 The value of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> does not affect how the underlying thread handle is closed. The thread handle is always closed when the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object is destroyed.  
  
##  \<a name="cwinthread__m_hthread">\</a>  CWinThread::m_hThread  
 Handle to the thread attached to this <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> data member is a public variable of type <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. It is only valid if underlying thread currently exists.  
  
##  \<a name="cwinthread__m_nthreadid">\</a>  CWinThread::m_nThreadID  
 ID of the thread attached to this <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The **m_nThreadID** data member is a public variable of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. It is only valid if underlying thread currently exists.  
  
### Example  
  See the example for [AfxGetThread](../vs140/afxgetthread.md).  
  
##  \<a name="cwinthread__m_pactivewnd">\</a>  CWinThread::m_pActiveWnd  
 Use this data member to store a pointer to your thread's active window object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The Microsoft Foundation Class Library will automatically terminate your thread when the window referred to by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is closed. If this thread is the primary thread for an application, the application will also be terminated. If this data member is **NULL**, the active window for the application's <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object will be inherited. <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is a public variable of type **CWnd\***.  
  
 Typically, you set this member variable when you override <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>. In a worker thread, the value of this data member is inherited from its parent thread.  
  
##  \<a name="cwinthread__m_pmainwnd">\</a>  CWinThread::m_pMainWnd  
 Use this data member to store a pointer to your thread's main window object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The Microsoft Foundation Class Library will automatically terminate your thread when the window referred to by <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is closed. If this thread is the primary thread for an application, the application will also be terminated. If this data member is **NULL**, the main window for the application's <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object will be used to determine when to terminate the thread. <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is a public variable of type **CWnd\***.  
  
 Typically, you set this member variable when you override <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>. In a worker thread, the value of this data member is inherited from its parent thread.  
  
##  \<a name="cwinthread__onidle">\</a>  CWinThread::OnIdle  
 Override this member function to perform idle-time processing.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A counter incremented each time <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is called when the thread's message queue is empty. This count is reset to 0 each time a new message is processed. You can use the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> parameter to determine the relative length of time the thread has been idle without processing a message.  
  
### Return Value  
 Nonzero to receive more idle processing time; 0 if no more idle processing time is needed.  
  
### Remarks  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is called in the default message loop when the thread's message queue is empty. Use your override to call your own background idle-handler tasks.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> should return 0 to indicate that no additional idle processing time is required. The <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> parameter is incremented each time <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is called when the message queue is empty and is reset to 0 each time a new message is processed. You can call your different idle routines based on this count.  
  
 The default implementation of this member function frees temporary objects and unused dynamic link libraries from memory.  
  
 This member function is used only in user-interface threads.  
  
 Because the application cannot process messages until <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> returns, do not perform lengthy tasks in this function.  
  
##  \<a name="cwinthread__operator_handle">\</a>  CWinThread::operator HANDLE  
 Retrieves the handle of the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 If successful, the handle of the thread object; otherwise, **NULL**.  
  
### Remarks  
 Use the handle to directly call Windows APIs.  
  
##  \<a name="cwinthread__postthreadmessage">\</a>  CWinThread::PostThreadMessage  
 Called to post a user-defined message to another <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 ID of the user-defined message.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 First message parameter.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Second message parameter.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The posted message is mapped to the proper message handler by the message map macro <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When calling the Windows                             [PostThreadMessage](http://msdn.microsoft.com/library/windows/desktop/ms644946) function within an MFC application, the MFC message handlers are not called. For more information, see the Knowledge Base article, "PRB: MFC Message Handler Not Called with PostThreadMessage()" (Q142415).  
  
##  \<a name="cwinthread__pretranslatemessage">\</a>  CWinThread::PreTranslateMessage  
 Override this function to filter window messages before they are dispatched to the Windows functions                 [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                 [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Points to a [MSG](../vs140/msg-structure.md) structure containing the message to process.  
  
### Return Value  
 Nonzero if the message was fully processed in <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> and should not be processed further. Zero if the message should be processed in the normal way.  
  
### Remarks  
 This member function is used only in user-interface threads.  
  
##  \<a name="cwinthread__processmessagefilter">\</a>  CWinThread::ProcessMessageFilter  
 The framework's hook function calls this member function to filter and respond to certain Windows messages.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies a hook code. This member function uses the code to determine how to process <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A pointer to a Windows [MSG](../vs140/msg-structure.md) structure.  
  
### Return Value  
 Nonzero if the message is processed; otherwise 0.  
  
### Remarks  
 A hook function processes events before they are sent to the application's normal message processing.  
  
 If you override this advanced feature, be sure to call the base-class version to maintain the framework's hook processing.  
  
##  \<a name="cwinthread__processwndprocexception">\</a>  CWinThread::ProcessWndProcException  
 The framework calls this member function whenever the handler does not catch an exception thrown in one of your thread's message or command handlers.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *e*  
 Points to an unhandled exception.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Points to a [MSG](../vs140/msg-structure.md) structure containing information about the windows message that caused the framework to throw an exception.  
  
### Return Value  
 –1 if a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> exception is generated; otherwise 0.  
  
### Remarks  
 Do not call this member function directly.  
  
 The default implementation of this member function handles only exceptions generated from the following messages:  
  
|Command|Action|  
|-------------|------------|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|Fail.|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|Validate the affected window, thus preventing another <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> message from being generated.|  
  
 Override this member function to provide global handling of your exceptions. Call the base functionality only if you wish to display the default behavior.  
  
 This member function is used only in threads that have a message pump.  
  
##  \<a name="cwinthread__pumpmessage">\</a>  CWinThread::PumpMessage  
 Contains the thread's message loop.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> contains the thread's message loop. **PumpMessage** is called by <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> to pump the thread's messages. You can call <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> directly to force messages to be processed, or you can override <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> to change its default behavior.  
  
 Calling <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> directly and overriding its default behavior is recommended for advanced users only.  
  
##  \<a name="cwinthread__resumethread">\</a>  CWinThread::ResumeThread  
 Called to resume execution of a thread that was suspended by the [SuspendThread](#cwinthread__suspendthread) member function, or a thread created with the **CREATE_SUSPENDED** flag.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The thread's previous suspend count if successful; <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> otherwise. If the return value is zero, the current thread was not suspended. If the return value is one, the thread was suspended, but is now restarted. Any return value greater than one means the thread remains suspended.  
  
### Remarks  
 The suspend count of the current thread is reduced by one. If the suspend count is reduced to zero, the thread resumes execution; otherwise the thread remains suspended.  
  
##  \<a name="cwinthread__run">\</a>  CWinThread::Run  
 Provides a default message loop for user-interface threads.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> value that is returned by the thread. This value can be retrieved by calling                         [GetExitCodeThread](http://msdn.microsoft.com/library/windows/desktop/ms683190).  
  
### Remarks  
 **Run** acquires and dispatches Windows messages until the application receives a                         [WM_QUIT](http://msdn.microsoft.com/library/windows/desktop/ms632641) message. If the thread's message queue currently contains no messages, **Run** calls <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> to perform idle-time processing. Incoming messages go to the [PreTranslateMessage](#cwinthread__pretranslatemessage) member function for special processing and then to the Windows function                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) for standard keyboard translation. Finally, the                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows function is called.  
  
 **Run** is rarely overridden, but you can override it to implement special behavior.  
  
 This member function is used only in user-interface threads.  
  
##  \<a name="cwinthread__setthreadpriority">\</a>  CWinThread::SetThreadPriority  
 This function sets the priority level of the current thread within its priority class.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Specifies the new thread priority level within its priority class. This parameter must be one of the following values, listed from highest priority to lowest:  
  
-   **THREAD_PRIORITY_TIME_CRITICAL**  
  
-   **THREAD_PRIORITY_HIGHEST**  
  
-   **THREAD_PRIORITY_ABOVE_NORMAL**  
  
-   **THREAD_PRIORITY_NORMAL**  
  
-   **THREAD_PRIORITY_BELOW_NORMAL**  
  
-   **THREAD_PRIORITY_LOWEST**  
  
-   **THREAD_PRIORITY_IDLE**  
  
 For more information on these priorities, see                         [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero if function was successful; otherwise 0.  
  
### Remarks  
 It can only be called after [CreateThread](#cwinthread__createthread) successfully returns.  
  
##  \<a name="cwinthread__suspendthread">\</a>  CWinThread::SuspendThread  
 Increments the current thread's suspend count.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The thread's previous suspend count if successful; <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 If any thread has a suspend count above zero, that thread does not execute. The thread can be resumed by calling the [ResumeThread](#cwinthread__resumethread) member function.  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp](../vs140/cwinapp-class.md)   
 [CCmdTarget](../vs140/ccmdtarget-class.md)