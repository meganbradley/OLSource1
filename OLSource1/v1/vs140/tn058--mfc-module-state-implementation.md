---
title: "TN058: MFC Module State Implementation"
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
  - "vc.mfc.implementation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "thread state [C++]"
  - "module states [C++], managing state data"
  - "TN058"
  - "MFC [C++], managing state data"
  - "module states [C++], switching"
  - "DLLs [C++], module states"
  - "process state [C++]"
ms.assetid: 72f5b36f-b3da-4009-a144-24258dcd2b2f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN058: MFC Module State Implementation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This technical note describes the implementation of MFC "module state" constructs. An understanding of the module state implementation is critical for using the MFC shared DLLs from a DLL (or OLE in-process server).  
  
 Before reading this note, refer to "Managing the State Data of MFC Modules" in [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md). This article contains important usage information and overview information on this subject.  
  
## Overview  
 There are three kinds of MFC state information: Module State, Process State, and Thread State. Sometimes these state types can be combined. For example, MFC's handle maps are both module local and thread local. This allows two different modules to have different maps in each of their threads.  
  
 Process State and Thread State are similar. These data items are things that have traditionally been global variables, but have need to be specific to a given process or thread for proper Win32s support or for proper multithreading support. Which category a given data item fits in depends on that item and its desired semantics with regard to process and thread boundaries.  
  
 Module State is unique in that it can contain either truly global state or state that is process local or thread local. In addition, it can be switched quickly.  
  
## Module State Switching  
 Each thread contains a pointer to the "current" or "active" module state (not surprisingly, the pointer is part of MFC's thread local state). This pointer is changed when the thread of execution passes a module boundary, such as an application calling into an OLE Control or DLL, or an OLE Control calling back into an application.  
  
 The current module state is switched by calling **AfxSetModuleState**. For the most part, you will never deal directly with the API. MFC, in many cases, will call it for you (at WinMain, OLE entry-points, **AfxWndProc**, etc.). This is done in any component you write by statically linking in a special **WndProc**, and a special <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) that knows which module state should be current. You can see this code by looking at DLLMODUL.CPP or APPMODUL.CPP in the MFC\SRC directory.  
  
 It is rare that you want to set the module state and then not set it back. Most of the time you want to "push" your own module state as the current one and then, after you are done, "pop" the original context back. This is done by the macro [AFX_MANAGE_STATE](../vs140/afx_manage_state.md) and the special class **AFX_MAINTAIN_STATE**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has special features for supporting module state switching. In particular, a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the root class used for OLE automation and OLE COM entry points. Like any other entry point exposed to the system, these entry points must set the correct module state. How does a given <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> know what the "correct" module state should be? The answer is that it "remembers" what the "current" module state is when it is constructed, such that it can set the current module state to that "remembered" value when it is later called. As a result, the module state that a given <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is associated with is the module state that was current when the object was constructed. Take a simple example of loading an INPROC server, creating an object, and calling its methods.  
  
1.  The DLL is loaded by OLE using **LoadLibrary**.  
  
2.  **RawDllMain** is called first. It sets the module state to the known static module state for the DLL. For this reason **RawDllMain** is statically linked to the DLL.  
  
3.  The constructor for the class factory associated with our object is called. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and as a result, it remembers in which module state it was instantiated. This is important — when the class factory is asked to create objects, it knows now what module state to make current.  
  
4.  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called to obtain the class factory. MFC searches the class factory list associated with this module and returns it.  
  
5.  **COleObjectFactory::XClassFactory2::CreateInstance** is called. Before creating the object and returning it, this function sets the module state to the module state that was current in step 3 (the one that was current when the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> was instantiated). This is done inside of [METHOD_PROLOGUE](../vs140/method_prologue.md).  
  
6.  When the object is created, it too is a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> derivative and in the same way <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> remembered which module state was active, so does this new object. Now the object knows which module state to switch to whenever it is called.  
  
7.  The client calls a function on the OLE COM object it received from its <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> call. When the object is called it uses <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to switch the module state just like <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does.  
  
 As you can see, the module state is propagated from object to object as they are created. It is important to have the module state set appropriately. If it is not set, your DLL or COM object may interact poorly with an MFC application that is calling it, or may be unable to find its own resources, or may fail in other miserable ways.  
  
 Note that certain kinds of DLLs, specifically "MFC Extension" DLLs do not switch the module state in their **RawDllMain** (actually, they usually don't even have a **RawDllMain**). This is because they are intended to behave "as if" they were actually present in the application that uses them. They are very much a part of the application that is running and it is their intention to modify that application's global state.  
  
 OLE Controls and other DLLs are very different. They do not want to modify the calling application's state; the application that is calling them may not even be an MFC application and so there may be no state to modify. This is the reason that module state switching was invented.  
  
 For exported functions from a DLL, such as one that launches a dialog box in your DLL, you need to add the following code to the beginning of the function:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This swaps the current module state with the state returned from [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md) until the end of the current scope.  
  
 Problems with resources in DLLs will occur if the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> macro is not used. By default, MFC uses the resource handle of the main application to load the resource template. This template is actually stored in the DLL. The root cause is that MFC's module state information has not been switched by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> macro. The resource handle is recovered from MFC's module state. Not switching the module state causes the wrong resource handle to be used.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does not need to be put in every function in the DLL. For example, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> can be called by the MFC code in the application without <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> because MFC automatically shifts the module state before <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and then switches it back after <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns. The same is true for all message map handlers. Regular DLLs actually have a special master window procedure that automatically switches the module state before routing any message.  
  
## Process Local Data  
 Process local data would not be of such great concern had it not been for the difficulty of the Win32s DLL model. In Win32s all DLLs share their global data, even when loaded by multiple applications. This is very different from the "real" Win32 DLL data model, where each DLL gets a separate copy of its data space in each process that attaches to the DLL. To add to the complexity, data allocated on the heap in a Win32s DLL is in fact process specific (at least as far as ownership goes). Consider the following data and code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Consider what happens if the above code is in located in a DLL and that DLL is loaded by two processes A and B (it could, in fact, be two instances of the same application). A calls <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. As a result, memory is allocated for the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> data in the context of process A. Keep in mind that the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> itself is global and is visible to both A and B. Now B calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. B will be able to see the data that A set. This is because Win32s offers no protection between processes like Win32 does. That is the first problem; in many cases it is not desirable to have one application affect global data that is considered to be owned by a different application.  
  
 There are additional problems as well. Let's say that A now exits. When A exits, the memory used by the '<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>' string is made available for the system — that is, all memory allocated by process A is freed automatically by the operating system. It is not freed because the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> destructor is being called; it hasn't been called yet. It is freed simply because the application which allocated it has left the scene. Now if B called <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, it may not get valid data. Some other application may have used that memory for something else.  
  
 Clearly a problem exists. MFC 3.x used a technique called thread-local storage (TLS). MFC 3.x would allocate a TLS index that under Win32s really acts as a process-local storage index, even though it is not called that and then would reference all data based on that TLS index. This is similar to the TLS index that was used to store thread-local data on Win32 (see below for more information on that subject). This caused every MFC DLL to utilize at least two TLS indices per process. When you account for loading many OLE Control DLLs (OCXs), you quickly run out of TLS indices (there are only 64 available). In addition, MFC had to place all this data in one place, in a single structure. It was not very extensible and was not ideal with regard to its use of TLS indices.  
  
 MFC 4.x addresses this with a set of class templates you can "wrap" around the data that should be process local. For example, the problem mentioned above could be fixed by writing:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 MFC implements this in two steps. First, there is a layer on top of the Win32 **Tls\*** APIs (**TlsAlloc**, **TlsSetValue**, **TlsGetValue**, etc.) which use only two TLS indexes per process, no matter how many DLLs you have. Second, the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> template is provided to access this data. It overrides operator-> which is what allows the intuitive syntax you see above. All objects that are wrapped by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> must be derived from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> provides a lower-level allocator (**LocalAlloc**/**LocalFree**) and a virtual destructor such that MFC can automatically destroy the process local objects when the process is terminated. Such objects can have a custom destructor if additional cleanup is required. The above example doesn't require one, since the compiler will generate a default destructor to destroy the embedded <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 There are other interesting advantages to this approach. Not only are all <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects destroyed automatically, they are not constructed until they are needed. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> will instantiate the associated object the first time it is called, and no sooner. In the example above, that means that the '<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>' string will not be constructed until the first time **SetGlobalString** or **GetGlobalString** is called. In some instances, this can help decrease DLL startup time.  
  
## Thread Local Data  
 Similar to process local data, thread local data is used when the data must be local to a given thread. That is, you need a separate instance of the data for each thread that accesses that data. This can many times be used in lieu of extensive synchronization mechanisms. If the data does not need to be shared by multiple threads, such mechanisms can be expensive and unnecessary. Suppose we had a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object (much like the sample above). We can make it thread local by wrapping it with a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> template:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> was called from two different threads, each would "shuffle" the string in different ways without interfering with the other. This is because there is actually a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> instance per thread instead of just one global instance.  
  
 Note how a reference is used to capture the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> address once instead of once per loop iteration. The loop code could have been written with <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> everywhere '<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>' is used, but the code would be much slower in execution. It is best to cache a reference to the data when such references occur in loops.  
  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class template uses the same mechanisms that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> does and the same implementation techniques.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)