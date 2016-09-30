---
title: "CStringData Class"
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
  - "CStringData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringData class"
  - "shared classes, CStringData"
ms.assetid: 4e31b5ca-3dbe-4fd5-b692-8211fbfb2593
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringData Class
This class represents the data of a string object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddRef](#cstringdata__addref)|Increments the reference count of the string data object.|  
|[data](#cstringdata__data)|Retrieves the character data of a string object.|  
|[IsLocked](#cstringdata__islocked)|Determines if the buffer of the associated string object is locked.|  
|[IsShared](#cstringdata__isshared)|Determines if the buffer of the associated string object is currently shared.|  
|[Lock](#cstringdata__lock)|Locks the buffer of the associated string object.|  
|[Release](#cstringdata__release)|Releases the specified string object.|  
|[Unlock](#cstringdata__unlock)|Unlocks the buffer of the associated string object.|  
  
### Data Members  
  
|||  
|-|-|  
|[nAllocLength](#cstringdata__nalloclength)|Length of allocated data in                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>s (not including terminating null)|  
|[nDataLength](#cstringdata__ndatalength)|Length of currently used data in                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>s (not including terminating null)|  
|[nRefs](#cstringdata__nrefs)|The current reference count of the object.|  
|[pStringMgr](#cstringdata__pstringmgr)|A pointer to the string manager of this string object.|  
  
## Remarks  
 This class should only be used by developers implementing custom string managers. For more information on custom string managers, see                 [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md)  
  
 This class encapsulates various types of information and data associated with a higher string object, such as                 [CStringT](../vs140/cstringt-class.md),                 [CSimpleStringT](../vs140/csimplestringt-class.md), or                 [CFixedStringT](../vs140/cfixedstringt-class.md) objects. Every higher string object contains a pointer to its associated                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, allowing multiple string objects to point to the same string data object. This relationship is represented by the reference count (                <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) of the                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  In certain cases, a string type (such as                     **CFixedString**) will not share a string data object with more than one higher string object. For more information on this, see                     [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
 This data is composed of:  
  
-   The memory manager (of type                         [IAtlStringMgr](../vs140/iatlstringmgr-class.md)) of the string.  
  
-   The current length (                        [nDataLength](#cstringdata__ndatalength)) of the string.  
  
-   The allocated length (                        [nAllocLength](#cstringdata__nalloclength)) of the string. For performance reasons, this can differ from the current string length  
  
-   The current reference count (                        [nRefs](#cstringdata__nrefs)) of the                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object. This value is used in determining how many string objects are sharing the same                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
-   The actual character buffer (                        [data](#cstringdata__data)) of the string.  
  
    > [!NOTE]
    >  The actual character buffer of the string object is allocated by the string manager and is appended to the                             <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
##  \<a name="cstringdata__addref">\</a>  CStringData::AddRef  
 Increments the reference count of the string object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Increments the reference count of the string object.  
  
> [!NOTE]
>  Do not call this method on a string with a negative reference count, since a negative count indicates that the string buffer is locked.  
  
##  \<a name="cstringdata__data">\</a>  CStringData::data  
 Returns a pointer to the character buffer of a string object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the character buffer of the string object.  
  
### Remarks  
 Call this function to return the current character buffer of the associated string object.  
  
> [!NOTE]
>  This buffer is not allocated by the                             <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object but by the string manager when needed. When allocated, the buffer is appended to the string data object.  
  
##  \<a name="cstringdata__islocked">\</a>  CStringData::IsLocked  
 Determines if the character buffer is locked.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns                         **true** if the buffer is locked; otherwise                         **false**.  
  
### Remarks  
 Call this function to determine if the character buffer of a string object is currently locked.  
  
##  \<a name="cstringdata__isshared">\</a>  CStringData::IsShared  
 Determines if the character buffer is shared.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns                         **true** if the buffer is shared; otherwise                         **false**.  
  
### Remarks  
 Call this function to determine if the character buffer of a string data object is currently shared among multiple string objects.  
  
##  \<a name="cstringdata__lock">\</a>  CStringData::Lock  
 Locks the character buffer of the associated string object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Call this function to lock the character buffer of the string data object. Locking and unlocking is used when direct access to the character buffer is required by the developer. A good example of locking is demonstrated by the                         [LockBuffer](../vs140/csimplestringt-class.md#csimplestringt__lockbuffer) and                         [UnlockBuffer](../vs140/csimplestringt-class.md#csimplestringt__unlockbuffer) methods of                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  A character buffer can only be locked if the buffer is not shared among higher string objects.  
  
##  \<a name="cstringdata__nalloclength">\</a>  CStringData::nAllocLength  
 Length of the allocated character buffer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Stores the length of the allocated data buffer in                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>s (not including terminating null).  
  
##  \<a name="cstringdata__ndatalength">\</a>  CStringData::nDataLength  
 Current length of the string object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Stores the length of currently used data in                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>s (not including terminating null).  
  
##  \<a name="cstringdata__nrefs">\</a>  CStringData::nRefs  
 Reference count of the string data object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Stores the reference count of the string data object. This count indicates the number of higher string objects that are associated with the string data object. A negative value indicates that the string data object is currently locked.  
  
##  \<a name="cstringdata__pstringmgr">\</a>  CStringData::pStringMgr  
 The memory manager of the associated string object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Stores the memory manager for the associated string object. For more information on memory managers and strings, see                         [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
##  \<a name="cstringdata__release">\</a>  CStringData::Release  
 Decrements the reference count of the string data object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Call this function to decrement the reference count, freeing the                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure if the reference count hits zero. This is commonly done when a string object is deleted, and therefore no longer needs to reference the string data object.  
  
 For example, the following code would call                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> for the string data object associated with                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>:  
  
 [!code[NVC_ATLMFC_Utilities#104](../vs140/codesnippet/CPP/cstringdata-class_1.cpp)]  
  
##  \<a name="cstringdata__unlock">\</a>  CStringData::Unlock  
 Unlocks the character buffer of the associated string object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Call this function to unlock the character buffer of the string data object. Once a buffer is unlocked, it is shareable and can be reference counted.  
  
> [!NOTE]
>  Each call to                             <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> must be matched by a corresponding call to                             <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 Locking and unlocking is used when the developer must ensure that the string data not be shared. A good example of locking is demonstrated by the                         [LockBuffer](../vs140/csimplestringt-class.md#csimplestringt__lockbuffer) and                         [UnlockBuffer](../vs140/csimplestringt-class.md#csimplestringt__unlockbuffer) methods of                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)