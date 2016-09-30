---
title: "CAtlTemporaryFile Class"
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
  - "CAtlTemporaryFile"
  - "ATL.CAtlTemporaryFile"
  - "ATL::CAtlTemporaryFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlTemporaryFile class"
ms.assetid: 05f0f2a5-94f6-4594-8dae-b114292ff5f9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile Class
This class provides methods for the creation and use of a temporary file.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md)|The constructor.|  
|[CAtlTemporaryFile::~CAtlTemporaryFile](../vs140/catltemporaryfile--~catltemporaryfile.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md)|Call this method to close a temporary file and either delete its contents or store them under the specified file name.|  
|[CAtlTemporaryFile::Create](../vs140/catltemporaryfile--create.md)|Call this method to create a temporary file.|  
|[CAtlTemporaryFile::Flush](../vs140/catltemporaryfile--flush.md)|Call this method to force any data remaining in the file buffer to be written to the temporary file.|  
|[CAtlTemporaryFile::GetPosition](../vs140/catltemporaryfile--getposition.md)|Call this method to get the current file pointer position.|  
|[CAtlTemporaryFile::GetSize](../vs140/catltemporaryfile--getsize.md)|Call this method to get the size in bytes of the temporary file.|  
|[CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md)|Call this method to disassociate the file from the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CAtlTemporaryFile::HandsOn](../vs140/catltemporaryfile--handson.md)|Call this method to open an existing temporary file and position the pointer at the end of the file.|  
|[CAtlTemporaryFile::LockRange](../vs140/catltemporaryfile--lockrange.md)|Call this method to lock a region in the file to prevent other processes from accessing it.|  
|[CAtlTemporaryFile::Read](../vs140/catltemporaryfile--read.md)|Call this method to read data from the temporary file starting at the position indicated by the file pointer.|  
|[CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md)|Call this method to move the file pointer of the temporary file.|  
|[CAtlTemporaryFile::SetSize](../vs140/catltemporaryfile--setsize.md)|Call this method to set the size of the temporary file.|  
|[CAtlTemporaryFile::TempFileName](../vs140/catltemporaryfile--tempfilename.md)|Call this method to return the name of the temporary file.|  
|[CAtlTemporaryFile::UnlockRange](../vs140/catltemporaryfile--unlockrange.md)|Call this method to unlock a region of the temporary file.|  
|[CAtlTemporaryFile::Write](../vs140/catltemporaryfile--write.md)|Call this method to write data to the temporary file starting at the position indicated by the file pointer.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlTemporaryFile::operator HANDLE](../vs140/catltemporaryfile--operator-handle.md)|Returns a handle to the temporary file.|  
  
## Remarks  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> makes it easy to create and use a temporary file. The file is automatically named, opened, closed, and deleted. If the file contents are required after the file is closed, they can be saved to a new file with a specified name.  
  
## Requirements  
 **Header:** atlfile.h  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__catltemporaryfile">\</a>  CAtlTemporaryFile::CAtlTemporaryFile  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 A file is not actually opened until a call is made to [CAtlTemporaryFile::Create](../vs140/catltemporaryfile--create.md).  
  
### Example  
 [!code[NVC_ATL_Utilities#73](../vs140/codesnippet/CPP/catltemporaryfile-class_1.cpp)]  
  
##  \<a name="catltemporaryfile___dtorcatltemporaryfile">\</a>  CAtlTemporaryFile::~CAtlTemporaryFile  
 The destructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The destructor calls [CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md).  
  
##  \<a name="catltemporaryfile__close">\</a>  CAtlTemporaryFile::Close  
 Call this method to close a temporary file and either delete its contents or store them under the specified file name.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *szNewName*  
 The name for the new file to store the contents of the temporary file in. If this argument is NULL, the contents of the temporary file are deleted.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> on failure.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__create">\</a>  CAtlTemporaryFile::Create  
 Call this method to create a temporary file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The path for the temporary file. If this is NULL, [GetTempPath](http://msdn.microsoft.com/library/windows/desktop/aa364992) will be called to assign a path.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The desired access. See <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> on failure.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__flush">\</a>  CAtlTemporaryFile::Flush  
 Call this method to force any data remaining in the file buffer to be written to the temporary file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Similar to [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md), except that the file is not closed.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__getposition">\</a>  CAtlTemporaryFile::GetPosition  
 Call this method to get the current file pointer position.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The position in bytes.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 To change the file pointer position, use [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
##  \<a name="catltemporaryfile__getsize">\</a>  CAtlTemporaryFile::GetSize  
 Call this method to get the size in bytes of the temporary file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The number of bytes in the file.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on failure.  
  
##  \<a name="catltemporaryfile__handsoff">\</a>  CAtlTemporaryFile::HandsOff  
 Call this method to disassociate the file from the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and [CAtlTemporaryFile::HandsOn](../vs140/catltemporaryfile--handson.md) are used to disassociate the file from the object, and reattach it if needed. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> will force any data remaining in the file buffer to be written to the temporary file, and then close the file. If you want to close and delete the file permanently, or if you want to close and retain the contents of the file with a given name, use [CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md).  
  
##  \<a name="catltemporaryfile__handson">\</a>  CAtlTemporaryFile::HandsOn  
 Call this method to open an existing temporary file and position the pointer at the end of the file.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md) and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> are used to disassociate the file from the object, and reattach it if needed.  
  
##  \<a name="catltemporaryfile__lockrange">\</a>  CAtlTemporaryFile::LockRange  
 Call this method to lock a region in the temporary file to prevent other processes from accessing it.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The position in the file where the lock should begin.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The length of the byte range to be locked.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed. To successfully unlock a region, use [CAtlTemporaryFile::UnlockRange](../vs140/catltemporaryfile--unlockrange.md), ensuring the byte range corresponds exactly to the region that was previously locked. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> does not merge adjacent regions; if two locked regions are adjacent, you must unlock each separately.  
  
##  \<a name="catltemporaryfile__operator_handle">\</a>  CAtlTemporaryFile::operator HANDLE  
 Returns a handle to the temporary file.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="catltemporaryfile__read">\</a>  CAtlTemporaryFile::Read  
 Call this method to read data from the temporary file starting at the position indicated by the file pointer.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Pointer to the buffer that will receive the data read from the file.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The buffer size in bytes.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The number of bytes read.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls [CAtlFile::Read](../vs140/catlfile--read.md). To change the position of the file pointer, call [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__seek">\</a>  CAtlTemporaryFile::Seek  
 Call this method to move the file pointer of the temporary file.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The offset, in bytes, from the starting point given by *dwFrom.*  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The starting point (FILE_BEGIN, FILE_CURRENT, or FILE_END).  
  
### Return Value  
 Returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls [CAtlFile::Seek](../vs140/catlfile--seek.md). To obtain the current file pointer position, call [CAtlTemporaryFile::GetPosition](../vs140/catltemporaryfile--getposition.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  \<a name="catltemporaryfile__setsize">\</a>  CAtlTemporaryFile::SetSize  
 Call this method to set the size of the temporary file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The new length of the file in bytes.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls [CAtlFile::SetSize](../vs140/catlfile--setsize.md). On return, the file pointer is positioned at the end of the file.  
  
##  \<a name="catltemporaryfile__tempfilename">\</a>  CAtlTemporaryFile::TempFileName  
 Call this method to return the name of temporary file.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> pointing to the file name.  
  
### Remarks  
 The file name is generated in [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md) with a call to the [GetTempFile](http://msdn.microsoft.com/library/windows/desktop/aa364991)[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] function. The file extension will always be "TFR" for the temporary file.  
  
##  \<a name="catltemporaryfile__unlockrange">\</a>  CAtlTemporaryFile::UnlockRange  
 Call this method to unlock a region of the temporary file.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The position in the file where the unlock should begin.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The length of the byte range to be unlocked.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md).  
  
##  \<a name="catltemporaryfile__write">\</a>  CAtlTemporaryFile::Write  
 Call this method to write data to the temporary file starting at the position indicated by the file pointer.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The buffer containing the data to be written to the file.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The number of bytes to be transferred from the buffer.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The number of bytes written.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 Calls [CAtlFile::Write](../vs140/catlfile--write.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [CAtlFile Class](../vs140/catlfile-class.md)