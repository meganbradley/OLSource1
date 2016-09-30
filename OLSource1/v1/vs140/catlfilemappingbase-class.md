---
title: "CAtlFileMappingBase Class"
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
  - "ATL.CAtlFileMappingBase"
  - "ATL::CAtlFileMappingBase"
  - "CAtlFileMappingBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlFileMappingBase class"
ms.assetid: be555723-2790-4f57-a8fb-be4d68460775
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMappingBase Class
This class represents a memory-mapped file.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFileMappingBase::CAtlFileMappingBase](../vs140/catlfilemappingbase--catlfilemappingbase.md)|The constructor.|  
|[CAtlFileMappingBase::~CAtlFileMappingBase](../vs140/catlfilemappingbase--~catlfilemappingbase.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFileMappingBase::CopyFrom](../vs140/catlfilemappingbase--copyfrom.md)|Call this method to copy from a file-mapping object.|  
|[CAtlFileMappingBase::GetData](../vs140/catlfilemappingbase--getdata.md)|Call this method to get the data from a file-mapping object.|  
|[CAtlFileMappingBase::GetHandle](../vs140/catlfilemappingbase--gethandle.md)|Call this method to return the file handle.|  
|[CAtlFileMappingBase::GetMappingSize](../vs140/catlfilemappingbase--getmappingsize.md)|Call this method to get the mapping size from a file-mapping object.|  
|[CAtlFileMappingBase::MapFile](../vs140/catlfilemappingbase--mapfile.md)|Call this method to create a file-mapping object.|  
|[CAtlFileMappingBase::MapSharedMem](../vs140/catlfilemappingbase--mapsharedmem.md)|Call this method to create a file-mapping object that permits full access to all processes.|  
|[CAtlFileMappingBase::OpenMapping](../vs140/catlfilemappingbase--openmapping.md)|Call this method to return a handle to the file-mapping object.|  
|[CAtlFileMappingBase::Unmap](../vs140/catlfilemappingbase--unmap.md)|Call this method to unmap a file-mapping object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFileMappingBase::operator =](../vs140/catlfilemappingbase--operator-=.md)|Sets the current file-mapping object to another file-mapping object.|  
  
## Remarks  
 File mapping is the association of a file's contents with a portion of the virtual address space of a process. This class provides methods for creating file-mapping objects that permit programs to easily access and share data.  
  
 For more information, see [File Mapping](http://msdn.microsoft.com/library/windows/desktop/aa366556) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlfile.h  
  
##  \<a name="catlfilemappingbase__catlfilemappingbase">\</a>  CAtlFileMappingBase::CAtlFileMappingBase  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The original file-mapping object to copy to create the new object.  
  
### Remarks  
 Creates a new file-mapping object, optionally using an existing object. It is still necessary to call [CAtlFileMappingBase::MapFile](../vs140/catlfilemappingbase--mapfile.md) to open or create the file-mapping object for a particular file.  
  
### Example  
 [!code[NVC_ATL_Utilities#71](../vs140/codesnippet/CPP/catlfilemappingbase-class_1.cpp)]  
  
##  \<a name="catlfilemappingbase___dtorcatlfilemappingbase">\</a>  CAtlFileMappingBase::~CAtlFileMappingBase  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Frees any resources allocated by the class and calls the [CAtlFileMappingBase::Unmap](../vs140/catlfilemappingbase--unmap.md) method.  
  
##  \<a name="catlfilemappingbase__copyfrom">\</a>  CAtlFileMappingBase::CopyFrom  
 Call this method to copy from a file-mapping object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The original file-mapping object to copy from.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on failure.  
  
##  \<a name="catlfilemappingbase__getdata">\</a>  CAtlFileMappingBase::GetData  
 Call this method to get the data from a file-mapping object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the data.  
  
##  \<a name="catlfilemappingbase__gethandle">\</a>  CAtlFileMappingBase::GetHandle  
 Call this method to return a handle to the file-mapping object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns a handle to the file-mapping object.  
  
##  \<a name="catlfilemappingbase__getmappingsize">\</a>  CAtlFileMappingBase::GetMappingSize  
 Call this method to get the mapping size from a file-mapping object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the mapping size.  
  
### Example  
 See the example for [CAtlFileMappingBase::CAtlFileMappingBase](../vs140/catlfilemappingbase--catlfilemappingbase.md).  
  
##  \<a name="catlfilemappingbase__mapfile">\</a>  CAtlFileMappingBase::MapFile  
 Call this method to open or create a file-mapping object for the specified file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Handle to the file from which to create a mapping object. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be valid and cannot be set to INVALID_HANDLE_VALUE.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file identified by *hFile.*  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The file offset where mapping is to begin. The offset value must be a multiple of the system's memory allocation granularity.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The protection desired for the file view when the file is mapped. See <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 After a file-mapping object has been created, the size of the file must not exceed the size of the file-mapping object; if it does, not all of the file's contents will be available for sharing. For more details, see [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) and [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 See the example for [CAtlFileMappingBase::CAtlFileMappingBase](../vs140/catlfilemappingbase--catlfilemappingbase.md).  
  
##  \<a name="catlfilemappingbase__mapsharedmem">\</a>  CAtlFileMappingBase::MapSharedMem  
 Call this method to create a file-mapping object that permits full access to all processes.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file-mapping object identified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The name of the mapping object.  
  
 *pbAlreadyExisted*  
 Points to a BOOL value that is set to TRUE if the mapping object already existed.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The pointer to a **SECURITY_ATTRIBUTES** structure that determines whether the returned handle can be inherited by child processes. See *lpAttributes* in [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The protection desired for the file view, when the file is mapped. See <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in **CreateFileMapping** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 **MapShareMem** allows an existing file-mapping object, created by [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537), to be shared between processes.  
  
##  \<a name="catlfilemappingbase__openmapping">\</a>  CAtlFileMappingBase::OpenMapping  
 Call this method to open a named file-mapping object for the specified file.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The name of the mapping object. If there is an open handle to a file-mapping object by this name and the security descriptor on the mapping object does not conflict with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter, the open operation succeeds.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file-mapping object identified by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The file offset where mapping is to begin. The offset value must be a multiple of the system's memory allocation granularity.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if the input parameters are invalid.  
  
##  \<a name="catlfilemappingbase__operator__eq">\</a>  CAtlFileMappingBase::operator =  
 Sets the current file-mapping object to another file-mapping object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The current file-mapping object.  
  
### Return Value  
 Returns a reference to the current object.  
  
##  \<a name="catlfilemappingbase__unmap">\</a>  CAtlFileMappingBase::Unmap  
 Call this method to unmap a file-mapping object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 See [UnmapViewOfFile](http://msdn.microsoft.com/library/windows/desktop/aa366882) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more details.  
  
## See Also  
 [CAtlFileMapping Class](../vs140/catlfilemapping-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)