---
title: "MFC Debugging Techniques"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxEnableMemoryTracking"
  - "CMemoryState"
  - "delayFreeMemDF"
  - "checkAlwaysMemDF"
  - "vs.debug.mfc"
  - "vs.debug.objects.dump"
  - "vs.debug.memory.dump"
  - "allocMemDF"
  - "afxMemDF"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "debugging [MFC]"
ms.assetid: b154fc31-5e90-4734-8cbd-58dd9fe1f750
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Debugging Techniques
If you are debugging an MFC program, these debugging techniques may be useful.  
  
##  \<a name="BKMK_In_this_topic">\</a> In this topic  
 [AfxDebugBreak](#BKMK_AfxDebugBreak)  
  
 [The TRACE macro](#BKMK_The_TRACE_macro)  
  
 [Memory leak detection in MFC](#BKMK_Memory_leak_detection_in_MFC)  
  
-   [Tracking memory allocations](#BKMK_Tracking_memory_allocations)  
  
-   [Enabling memory diagnostics](#BKMK_Enabling_memory_diagnostics)  
  
-   [Taking memory snapshots](#BKMK_Taking_memory_snapshots)  
  
-   [Viewing memory statistics](#BKMK_Viewing_memory_statistics)  
  
-   [Taking object dumps](#BKMK_Taking_object_dumps)  
  
    -   [Interpreting memory dumps](#BKMK_Interpreting_memory_dumps)  
  
    -   [Customizing object dumps](#BKMK_Customizing_object_dumps)  
  
     [Reducing the size of an MFC Debug build](#BKMK_Reducing_the_size_of_an_MFC_Debug_build)  
  
    -   [Building an MFC app with debug information for selected modules](#BKMK_Building_an_MFC_app_with_debug_information_for_selected_modules)  
  
##  \<a name="BKMK_AfxDebugBreak">\</a> AfxDebugBreak  
 MFC provides a special [AfxDebugBreak](../vs140/afxdebugbreak--mfc-.md) function for hard-coding breakpoints in source code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 On Intel platforms, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> produces the following code, which breaks in source code rather than kernel code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 On other platforms, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> merely calls <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Be sure to remove <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statements when you create a release build or use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to surround them.  
  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_The_TRACE_macro">\</a> The TRACE macro  
 To display messages from your program in the debugger [Output window](../vs140/output-window.md), you can use the [ATLTRACE](../vs140/atltrace--atl-.md) macro or the MFC [TRACE](../vs140/trace.md) macro. Like [assertions](../vs140/c-c---assertions.md), the trace macros are active only in the Debug version of your program and disappear when compiled in the Release version.  
  
 The following examples show some of the ways you can use the **TRACE** macro. Like <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the **TRACE** macro can handle a number of arguments.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The TRACE macro appropriately handles both char* and wchar_t\* parameters. The following examples demonstrate the use of the TRACE macro together with different types of string parameters.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information on the **TRACE** macro, see [Diagnostic Services](../vs140/diagnostic-services.md).  
  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_Memory_leak_detection_in_MFC">\</a> Detecting memory leaks in MFC  
 MFC provides classes and functions for detecting memory that is allocated but never deallocated.  
  
###  \<a name="BKMK_Tracking_memory_allocations">\</a> Tracking memory allocations  
 In MFC, you can use the macro [DEBUG_NEW](../vs140/debug_new.md) in place of the **new** operator to help locate memory leaks. In the Debug version of your program, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keeps track of the file name and line number for each object that it allocates. When you compile a Release version of your program, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> resolves to a simple **new** operation without the file name and line number information. Thus, you pay no speed penalty in the Release version of your program.  
  
 If you do not want to rewrite your entire program to use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in place of **new**, you can define this macro in your source files:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When you do an [object dump](#BKMK_Taking_object_dumps), each object allocated with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> will show the file and line number where it was allocated, allowing you to pinpoint the sources of memory leaks.  
  
 The Debug version of the MFC framework uses <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> automatically, but your code does not. If you want the benefits of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, you must use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> explicitly or **#define new** as shown above.  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Enabling_memory_diagnostics">\</a> Enabling memory diagnostics  
 Before you can use the memory diagnostics facilities, you must enable diagnostic tracing.  
  
 **To enable or disable memory diagnostics**  
  
-   Call the global function [AfxEnableMemoryTracking](../vs140/afxenablememorytracking.md) to enable or disable the diagnostic memory allocator. Because memory diagnostics are on by default in the debug library, you will typically use this function to temporarily turn them off, which increases program execution speed and reduces diagnostic output.  
  
 **To select specific memory diagnostic features with afxMemDF**  
  
-   If you want more precise control over the memory diagnostic features, you can selectively turn individual memory diagnostic features on and off by setting the value of the MFC global variable [afxMemDF](../vs140/afxmemdf.md). This variable can have the following values as specified by the enumerated type **afxMemDF**.  
  
    |Value|Description|  
    |-----------|-----------------|  
    |**allocMemDF**|Turn on diagnostic memory allocator (default).|  
    |**delayFreeMemDF**|Delay freeing memory when calling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> until program exits. This will cause your program to allocate the maximum possible amount of memory.|  
    |**checkAlwaysMemDF**|Call [AfxCheckMemory](../vs140/afxcheckmemory.md) every time memory is allocated or freed.|  
  
     These values can be used in combination by performing a logical-OR operation, as shown here:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Taking_memory_snapshots">\</a> Taking memory snapshots  
  
1.  Create a [CMemoryState](assetId:///8fade6e9-c6fb-4b2a-8565-184a912d26d2) object and call the [CMemoryState::Checkpoint](../vs140/cmemorystate--checkpoint.md) member function. This creates the first memory snapshot.  
  
2.  After your program performs its memory allocation and deallocation operations, create another <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object and call <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> for that object. This gets a second snapshot of memory usage.  
  
3.  Create a third <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object and call its [CMemoryState::Difference](../vs140/cmemorystate--difference.md) member function, supplying as arguments the two previous <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> objects. If there is a difference between the two memory states, the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function returns a nonzero value. This indicates that some memory blocks have not been deallocated.  
  
     This example shows what the code looks like:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Notice that the memory-checking statements are bracketed by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>[_DEBUG](../vs140/_debug.md)/ **#endif** blocks so that they are compiled only in Debug versions of your program.  
  
     Now that you know a memory leak exists, you can use another member function, [CMemoryState::DumpStatistics](../vs140/cmemorystate--dumpstatistics.md) that will help you locate it.  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Viewing_memory_statistics">\</a> Viewing memory statistics  
 The [CMemoryState::Difference](../vs140/cmemorystate--difference.md) function looks at two memory-state objects and detects any objects not deallocated from the heap between the beginning and end states. After you have taken memory snapshots and compared them using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, you can call [CMemoryState::DumpStatistics](../vs140/cmemorystate--dumpstatistics.md) to get information about the objects that have not been deallocated.  
  
 Consider the following example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A sample dump from the example looks like this:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Free blocks are blocks whose deallocation is delayed if <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> was set to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 Ordinary object blocks, shown on the second line, remain allocated on the heap.  
  
 Non-object blocks include arrays and structures allocated with <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. In this case, four non-object blocks were allocated on the heap but not deallocated.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> gives the maximum memory used by the program at any time.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> gives the total amount of memory used by the program.  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Taking_object_dumps">\</a> Taking object dumps  
 In an MFC program, you can use [CMemoryState::DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md) to dump a description of all objects on the heap that have not been deallocated. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> dumps all objects allocated since the last [CMemoryState::Checkpoint](../vs140/cmemorystate--checkpoint.md). If no <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> call has taken place, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> dumps all objects and nonobjects currently in memory.  
  
> [!NOTE]
>  Before you can use MFC object dumping, you must [enable diagnostic tracing](../vs140/mfc-debugging-techniques.md#BKMK_Enabling_Memory_Diagnostics).  
  
> [!NOTE]
>  MFC automatically dumps all leaked objects when your program exits, so you do not need to create code to dump objects at that point.  
  
 The following code tests for a memory leak by comparing two memory states and dumps all objects if a leak is detected.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The contents of the dump look like this:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The numbers in braces at the beginning of most lines specify the order in which the objects were allocated. The most recently allocated object has the highest number and appears at the top of the dump.  
  
 To get the maximum amount of information out of an object dump, you can override the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> member function of any <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>-derived object to customize the object dump.  
  
 You can set a breakpoint on a particular memory allocation by setting the global variable <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to the number shown in the braces. If you rerun the program the debugger will break execution when that allocation takes place. You can then look at the call stack to see how your program got to that point.  
  
 The C run-time library has a similar function, [_CrtSetBreakAlloc](../vs140/_crtsetbreakalloc.md), that you can use for C run-time allocations.  
  
 [In this topic](#BKMK_In_this_topic)  
  
####  \<a name="BKMK_Interpreting_memory_dumps">\</a> Interpreting memory dumps  
 Look at this object dump in more detail:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The program that generated this dump had only two explicit allocations—one on the stack and one on the heap:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> constructor takes three arguments that are pointers to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, which are used to initialize <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> member variables. In the memory dump, you can see the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object along with three nonobject blocks (3, 4, and 5). These hold the characters for the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> member variables and will not be deleted when the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object destructor is invoked.  
  
 Block number 2 is the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object itself. <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> represents the address of the block and is followed by the contents of the object, which were output by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>::<CodeContentPlaceHolder>61\</CodeContentPlaceHolder> when called by [DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md).  
  
 You can guess that block number 1 is associated with the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> frame variable because of its sequence number and size, which matches the number of characters in the frame <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> variable. Variables allocated on the frame are automatically deallocated when the frame goes out of scope.  
  
 **Frame Variables**  
  
 In general, you should not worry about heap objects associated with frame variables because they are automatically deallocated when the frame variables go out of scope. To avoid clutter in your memory diagnostic dumps, you should position your calls to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> so that they are outside the scope of frame variables. For example, place scope brackets around the previous allocation code, as shown here:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 With the scope brackets in place, the memory dump for this example is as follows:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 **Nonobject Allocations**  
  
 Notice that some allocations are objects (such as <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>) and some are nonobject allocations. "Nonobject allocations" are allocations for objects not derived from <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> or allocations of primitive C types such as <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, or **long**. If the **CObject-**derived class allocates additional space, such as for internal buffers, those objects will show both object and nonobject allocations.  
  
 **Preventing Memory Leaks**  
  
 Notice in the code above that the memory block associated with the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> frame variable has been deallocated automatically and does not show up as a memory leak. The automatic deallocation associated with scoping rules takes care of most memory leaks associated with frame variables.  
  
 For objects allocated on the heap, however, you must explicitly delete the object to prevent a memory leak. To clean up the last memory leak in the previous example, delete the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object allocated on the heap, as follows:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [In this topic](#BKMK_In_this_topic)  
  
####  \<a name="BKMK_Customizing_object_dumps">\</a> Customizing object dumps  
 When you derive a class from [CObject](../vs140/cobject-class.md), you can override the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> member function to provide additional information when you use [DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md) to dump objects to the [Output window](../vs140/output-window.md).  
  
 The <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> function writes a textual representation of the object's member variables to a dump context ([CDumpContext](../vs140/cdumpcontext-class.md)). The dump context is similar to an I/O stream. You can use the append operator (**<<**) to send data to a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 When you override the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> function, you should first call the base class version of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> to dump the contents of the base class object. Then output a textual description and value for each member variable of your derived class.  
  
 The declaration of the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> function looks like this:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Because object dumping only makes sense when you are debugging your program, the declaration of the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> function is bracketed with an **#ifdef _DEBUG / #endif** block.  
  
 In the following example, the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> function first calls the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> function for its base class. It then writes a short description of each member variable along with the member's value to the diagnostic stream.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 You must supply a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> argument to specify where the dump output will go. The Debug version of MFC supplies a predefined <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object named <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> that sends output to the debugger.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 [In this topic](#BKMK_In_this_topic)  
  
##  \<a name="BKMK_Reducing_the_size_of_an_MFC_Debug_build">\</a> Reducing the size of an MFC Debug build  
 The debug information for a large MFC application can take up a lot of disk space. You can use one of these procedures to reduce the size:  
  
1.  Rebuild the MFC libraries using the [/Z7, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md) option, instead of **/Z7**. These options build a single program database (PDB) file that contains debug information for the entire library, reducing redundancy and saving space.  
  
2.  Rebuild the MFC libraries without debug information (no [/Z7, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md) option). In this case, the lack of debug information will prevent you from using most debugger facilities within the MFC library code, but because the MFC libraries are already thoroughly debugged, this may not be a problem.  
  
3.  Build your own application with debug information for selected modules only as described below.  
  
 [In this topic](#BKMK_In_this_topic)  
  
###  \<a name="BKMK_Building_an_MFC_app_with_debug_information_for_selected_modules">\</a> Building an MFC app with debug information for selected modules  
 Building selected modules with the MFC debug libraries enables you to use stepping and the other debug facilities in those modules. This procedure makes use of both the Debug and Release modes of the Visual C++ makefile, thus necessitating the changes described in the following steps (and also making a "rebuild all" necessary when a full Release build is required).  
  
1.  In Solution Explorer, select the project.  
  
2.  From the **View** menu, select **Property Pages**.  
  
3.  First, you will create a new project configuration.  
  
    1.  In the **\<Project> Property Pages** dialog box, click the **Configuration Manager** button.  
  
    2.  In the [Configuration Manager dialog box](assetId:///fa182dca-282e-4ae5-bf37-e155344ca18b), locate your project in the grid. In the **Configuration** column, select **\<New...>**.  
  
    3.  In the [New Project Configuration dialog box](assetId:///cca616dc-05a6-4fe3-bdc1-40c72a66f2be), type a name for your new configuration, such as "Partial Debug", in the **Project Configuration Name** box.  
  
    4.  In the **Copy Settings from** list, choose **Release**.  
  
    5.  Click **OK** to close the **New Project Configuration**dialog box.  
  
    6.  Close the **Configuration Manager** dialog box.  
  
4.  Now, you will set options for the entire project.  
  
    1.  In the **Property Pages** dialog box, under the **Configuration Properties** folder, select the **General** category.  
  
    2.  In the project settings grid, expand **Project Defaults** (if necessary).  
  
    3.  Under **Project Defaults**, find **Use of MFC**. The current setting appears in the right column of the grid. Click on the current setting and change it to **Use MFC in a Static Library**.  
  
    4.  In the left pane of the **Properties Pages** dialog box, open the **C/C++** folder and select **Preprocessor**. In the properties grid, find **Preprocessor Definitions** and replace "NDEBUG" with "_DEBUG".  
  
    5.  In the left pane of the **Properties Pages** dialog box, open the **Linker** folder and select the **Input** Category. In the properties grid, find **Additional Dependencies**. In the **Additional Dependencies** setting, type "NAFXCWD.LIB" and "LIBCMT."  
  
    6.  Click **OK** to save the new build options and close the **Property Pages** dialog box.  
  
5.  From the **Build** menu, select **Rebuild**. This removes all debug information from your modules but does not affect the MFC library.  
  
6.  Now you must add debug information back to selected modules in your application. Remember that you can set breakpoints and perform other debugger functions only in modules you have compiled with debug information. For each project file in which you want to include debug information, carry out the following steps:  
  
    1.  In Solution Explorer, open the **Source Files** folder located under your project.  
  
    2.  Select the file you want to set debug information for.  
  
    3.  From the **View** menu, select **Property Pages**.  
  
    4.  In the **Property Pages** dialog box, under the **Configuration Settings** folder, open the **C/C++** folder then select the **General** category.  
  
    5.  In the properties grid, find **Debug Information Format.**  
  
    6.  Click the **Debug Information Format** settings and select the desired option (usually **/ZI**) for debug information.  
  
    7.  If you are using an application wizard-generated application or have precompiled headers, you have to turn off the precompiled headers or recompile them before compiling the other modules. Otherwise, you will receive warning C4650 and error message C2855. You can turn off precompiled headers by changing the **Create/Use Precompiled Headers** setting in the **\<Project> Properties** dialog box (**Configuration Properties** folder, **C/C++** subfolder, **Precompiled Headers** category).  
  
7.  From the **Build** menu, select **Build** to rebuild project files that are out of date.  
  
 As an alternative to the technique described in this topic, you can use an external makefile to define individual options for each file. In that case, to link with the MFC debug libraries, you must define the [_DEBUG](../vs140/_debug.md) flag for each module. If you want to use MFC release libraries, you must define NDEBUG. For more information on writing external makefiles, see the [NMAKE Reference](../vs140/running-nmake.md).  
  
 [In this topic](#BKMK_In_this_topic)  
  
## See Also  
 [Debugging Visual C++](../vs140/debugging-native-code.md)