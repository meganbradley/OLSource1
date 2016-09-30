---
title: "CMemFile Class"
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
  - "CMemFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "memory files"
  - "CMemFile class"
  - "temporary files, memory files"
ms.assetid: 20e86515-e465-4f73-b2ea-e49789d63165
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile Class
The [CFile](../vs140/cfile-class.md)-derived class that supports memory files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMemFile::CMemFile](#cmemfile__cmemfile)|Constructs a memory file object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMemFile::Attach](#cmemfile__attach)|Attaches a block of memory to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[CMemFile::Detach](#cmemfile__detach)|Detaches the block of memory from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns a pointer to the block of memory detached.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMemFile::Alloc](#cmemfile__alloc)|Override to modify memory allocation behavior.|  
|[CMemFile::Free](#cmemfile__free)|Override to modify memory deallocation behavior.|  
|[CMemFile::GrowFile](#cmemfile__growfile)|Override to modify behavior when growing a file.|  
|[CMemFile::Memcpy](#cmemfile__memcpy)|Override to modify memory copy behavior when reading and writing files.|  
|[CMemFile::Realloc](#cmemfile__realloc)|Override to modify memory reallocation behavior.|  
  
## Remarks  
 These memory files behave like disk files except that the file is stored in RAM rather than on disk. A memory file is useful for fast temporary storage or for transferring raw bytes or serialized objects between independent processes.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects can automatically allocate their own memory or you can attach your own memory block to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object by calling [Attach](#cmemfile__attach). In either case, memory for growing the memory file automatically is allocated in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>-sized increments if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not zero.  
  
 The memory block will automatically be deleted upon destruction of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object if the memory was originally allocated by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object; otherwise, you are responsible for deallocating the memory you attached to the object.  
  
 You can access the memory block through the pointer supplied when you detach it from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object by calling [Detach](#cmemfile__detach).  
  
 The most common use of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is to create a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object and use it by calling [CFile](../vs140/cfile-class.md) member functions. Note that creating a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> automatically opens it: you do not call [CFile::Open](../vs140/cfile-class.md#cfile__open), which is only used for disk files. Because <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> doesn't use a disk file, the data member <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not used and has no meaning.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member functions [Duplicate](../vs140/cfile-class.md#cfile__duplicate), [LockRange](../vs140/cfile-class.md#cfile__lockrange), and [UnlockRange](../vs140/cfile-class.md#cfile__unlockrange) are not implemented for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If you call these functions on a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object, you will get a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> uses the run-time library functions [malloc](../vs140/malloc.md), [realloc](../vs140/realloc.md), and [free](../vs140/free.md) to allocate, reallocate, and deallocate memory; and the intrinsic [memcpy](../vs140/memcpy--wmemcpy.md) to block copy memory when reading and writing. If you'd like to change this behavior or the behavior when <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> grows a file, derive your own class from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and override the appropriate functions.  
  
 For more information on <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, see the articles [Files in MFC](../vs140/files-in-mfc.md) and [Memory Management (MFC)](../vs140/memory-management.md) and see [File Handling](../vs140/file-handling.md) in the                 *Run-Time Library Reference*.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cmemfile__alloc">\</a>  CMemFile::Alloc  
 This function is called by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member functions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Number of bytes of memory to be allocated.  
  
### Return Value  
 A pointer to the memory block that was allocated, or **NULL** if the allocation failed.  
  
### Remarks  
 Override this function to implement custom memory allocation. If you override this function, you'll probably want to override [Free](#cmemfile__free) and [Realloc](#cmemfile__realloc) as well.  
  
 The default implementation uses the run-time library function [malloc](../vs140/malloc.md) to allocate memory.  
  
##  \<a name="cmemfile__attach">\</a>  CMemFile::Attach  
 Call this function to attach a block of memory to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Pointer to the buffer to be attached to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 An integer that specifies the size of the buffer in bytes.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The memory allocation increment in bytes.  
  
### Remarks  
 This causes <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to use the block of memory as the memory file.  
  
 If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> will set the file length to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. This means that the data in the memory block before it was attached to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> will be used as the file. Memory files created in this manner cannot be grown.  
  
 Since the file cannot be grown, be careful not to cause <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to attempt to grow the file. For example, don't call the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> overrides of [CFile:Write](../vs140/cfile-class.md#cfile__write) to write past the end or don't call [CFile:SetLength](../vs140/cfile-class.md#cfile__setlength) with a length longer than <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is greater than 0, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> will ignore the contents of the memory block you've attached. You'll have to write the contents of the memory file from scratch using the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> override of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. If you attempt to write past the end of the file or grow the file by calling the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> override of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> will grow the memory allocation in increments of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. Growing the memory allocation will fail if the memory block you pass to **Attach** wasn't allocated with a method compatible with [Alloc](#cmemfile__alloc). To be compatible with the default implementation of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, you must allocate the memory with the run-time library function [malloc](../vs140/malloc.md) or [calloc](../vs140/calloc.md).  
  
##  \<a name="cmemfile__cmemfile">\</a>  CMemFile::CMemFile  
 The first overload opens an empty memory file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The memory allocation increment in bytes.  
  
 *lpBuffe*r  
 Pointer to a buffer that receives information of the size <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 An integer that specifies the size of the file buffer, in bytes.  
  
### Remarks  
 Note that the file is opened by the constructor and that you should not call [CFile::Open](../vs140/cfile-class.md#cfile__open).  
  
 The second overload acts the same as if you used the first constructor and immediately called [Attach](#cmemfile__attach) with the same parameters. See **Attach** for details.  
  
### Example  
 [!code[NVC_MFCFiles#36](../vs140/codesnippet/CPP/cmemfile-class_1.cpp)]  
  
##  \<a name="cmemfile__detach">\</a>  CMemFile::Detach  
 Call this function to get a pointer to the memory block being used by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the memory block that contains the contents of the memory file.  
  
### Remarks  
 Calling this function also closes the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. You can reattach the memory block to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> by calling [Attach](#cmemfile__attach). If you want to reattach the file and use the data in it, you should call [CFile::GetLength](../vs140/cfile-class.md#cfile__getlength) to get the length of the file before calling **Detach**. Note that if you attach a memory block to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> so that you can use its data ( <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> == 0), then you won't be able to grow the memory file.  
  
##  \<a name="cmemfile__free">\</a>  CMemFile::Free  
 This function is called by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> member functions.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Pointer to the memory to be deallocated                                *.*  
  
### Remarks  
 Override this function to implement custom memory deallocation. If you override this function, you'll probably want to override [Alloc](#cmemfile__alloc) and [Realloc](#cmemfile__realloc) as well.  
  
##  \<a name="cmemfile__growfile">\</a>  CMemFile::GrowFile  
 This function is called by several of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> member functions.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 New size of the memory file.  
  
### Remarks  
 You can override it if you want to change how <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> grows its file. The default implementation calls [Realloc](#cmemfile__realloc) to grow an existing block (or [Alloc](#cmemfile__alloc) to create a memory block), allocating memory in multiples of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> value specified in the constructor or [Attach](#cmemfile__attach) call.  
  
##  \<a name="cmemfile__memcpy">\</a>  CMemFile::Memcpy  
 This function is called by the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> overrides of [CFile::Read](../vs140/cfile-class.md#cfile__read) and [CFile::Write](../vs140/cfile-class.md#cfile__write) to transfer data to and from the memory file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Pointer to the memory block into which the source memory will be copied.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Pointer to the source memory block.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Number of bytes to be copied.  
  
### Return Value  
 A copy of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function if you want to change the way that <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> does these memory copies.  
  
##  \<a name="cmemfile__realloc">\</a>  CMemFile::Realloc  
 This function is called by <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> member functions.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to the memory block to be reallocated.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 New size for the memory block.  
  
### Return Value  
 A pointer to the memory block that was reallocated (and possibly moved), or **NULL** if the reallocation failed.  
  
### Remarks  
 Override this function to implement custom memory reallocation. If you override this function, you'll probably want to override [Alloc](#cmemfile__alloc) and [Free](#cmemfile__free) as well.  
  
## See Also  
 [Base Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)