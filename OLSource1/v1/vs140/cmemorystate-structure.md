---
title: "CMemoryState Structure"
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
  - "CMemoryState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemoryState structure"
  - "memory leaks, detecting"
  - "detecting memory leaks"
ms.assetid: 229d9de7-a6f3-4cc6-805b-5a9d9b1bfe1d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemoryState Structure
Provides a convenient way to detect memory leaks in your program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMemoryState::CMemoryState](#cmemorystate__cmemorystate)|Constructs a class-like structure that controls memory checkpoints.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMemoryState::Checkpoint](#cmemorystate__checkpoint)|Obtains a snapshot (checkpoint) of the current memory state.|  
|[CMemoryState::Difference](#cmemorystate__difference)|Computes the difference between two objects of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[CMemoryState::DumpAllObjectsSince](#cmemorystate__dumpallobjectssince)|Dumps a summary of all currently allocated objects since a previous checkpoint.|  
|[CMemoryState::DumpStatistics](#cmemorystate__dumpstatistics)|Prints memory allocation statistics for a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a structure and does not have a base class.  
  
 A "memory leak" occurs when memory for an object is allocated on the heap but not deallocated when it is no longer required. Such memory leaks can eventually lead to out-of-memory errors. There are several ways to allocate and deallocate memory in your program:  
  
-   Using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>/ **free** family of functions from the run-time library.  
  
-   Using the Windows API memory management functions, **LocalAlloc**/ **LocalFree** and **GlobalAlloc**/ **GlobalFree**.  
  
-   Using the C++ **new** and **delete** operators.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> diagnostics only help detect memory leaks caused when memory allocated using the **new** operator is not deallocated using **delete**. The other two groups of memory-management functions are for non-C++ programs, and mixing them with **new** and **delete** in the same program is not recommended. An additional macro, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, is provided to replace the **new** operator when you need file and line-number tracking of memory allocations. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is used whenever you would normally use the **new** operator.  
  
 As with other diagnostics, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> diagnostics are only available in debug versions of your program. A debug version must have the **_DEBUG** constant defined.  
  
 If you suspect your program has a memory leak, you can use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, **Difference**, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions to discover the difference between the memory state (objects allocated) at two different points in program execution. This information can be useful in determining whether a function is cleaning up all the objects it allocates.  
  
 If simply knowing where the imbalance in allocation and deallocation occurs does not provide enough information, you can use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function to dump all objects allocated since the previous call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This dump shows the order of allocation, the source file and line where the object was allocated (if you are using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for allocation), and the derivation of the object, its address, and its size. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> also calls each object's <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function to provide information about its current state.  
  
 For more information about how to use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and other diagnostics, see [Debugging MFC Applications](../vs140/mfc-debugging-techniques.md).  
  
> [!NOTE]
>  Declarations of objects of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and calls to member functions should be bracketed by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> directives. This causes memory diagnostics to be included only in debugging builds of your program.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cmemorystate__checkpoint">\</a>  CMemoryState::Checkpoint  
 Takes a snapshot summary of memory and stores it in this <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> member functions [Difference](#cmemorystate__difference) and [DumpAllObjectsSince](#cmemorystate__dumpallobjectssince) use this snapshot data.  
  
### Example  
  See the example for the [CMemoryState](#cmemorystate__cmemorystate) constructor.  
  
##  \<a name="cmemorystate__cmemorystate">\</a>  CMemoryState::CMemoryState  
 Constructs an empty <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object that must be filled in by the [Checkpoint](#cmemorystate__checkpoint) or [Difference](#cmemorystate__difference) member function.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
  [!code[NVC_MFC_Utilities#18](../vs140/codesnippet/CPP/cmemorystate-structure_1.cpp)]  
  
##  \<a name="cmemorystate__difference">\</a>  CMemoryState::Difference  
 Compares two <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects, then stores the difference into this <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *oldState*  
 The initial memory state as defined by a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> checkpoint.  
  
 *newState*  
 The new memory state as defined by a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> checkpoint.  
  
### Return Value  
 Nonzero if the two memory states are different; otherwise 0.  
  
### Remarks  
 [Checkpoint](#cmemorystate__checkpoint) must have been called for each of the two memory-state parameters.  
  
### Example  
  See the example for the [CMemoryState](#cmemorystate__cmemorystate) constructor.  
  
##  \<a name="cmemorystate__dumpallobjectssince">\</a>  CMemoryState::DumpAllObjectsSince  
 Calls the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function for all objects of a type derived from class <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> that were allocated (and are still allocated) since the last [Checkpoint](#cmemorystate__checkpoint) call for this <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Calling <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> with an uninitialized <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object will dump out all objects currently in memory.  
  
### Example  
  See the example for the [CMemoryState](#cmemorystate__cmemorystate) constructor.  
  
##  \<a name="cmemorystate__dumpstatistics">\</a>  CMemoryState::DumpStatistics  
 Prints a concise memory statistics report from a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object that is filled by the [Difference](#cmemorystate__difference) member function.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The report, which is printed on the [afxDump](../vs140/afxdump--cdumpcontext-in-mfc-.md) device, shows the following:  
  
 A sample report gives information on the number (or amount) of:  
  
-   free blocks  
  
-   normal blocks  
  
-   CRT blocks  
  
-   ignore blocks  
  
-   client blocks  
  
-   maximum memory used by the program at any one time (in bytes)  
  
-   total memory currently used by the program (in bytes)  
  
 Free blocks are the number of blocks whose deallocation was delayed if <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> was set to **delayFreeMemDF**. For more information, see [afxMemDF](../vs140/afxmemdf.md), in the "MFC Macros and Globals" section. See [Types of Blocks on the Debug Heap](assetId:///db2e7f62-0679-4b39-a23f-26f2c2f407c5) for more information on these block types.  
  
### Example  
  The following code should be placed in                                 *projname*App.cpp. Define the following global variables:  
  
 [!code[NVC_MFC_Utilities#40](../vs140/codesnippet/CPP/cmemorystate-structure_2.cpp)]  
  
 In the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function, add the line:  
  
 [!code[NVC_MFC_Utilities#41](../vs140/codesnippet/CPP/cmemorystate-structure_3.cpp)]  
  
 Add a handler for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function and use the following code:  
  
 [!code[NVC_MFC_Utilities#42](../vs140/codesnippet/CPP/cmemorystate-structure_4.cpp)]  
  
 You can now run the program in Debug mode to see the output of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> function.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)