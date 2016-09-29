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
  
```  
  
class CAtlTemporaryFile  
  
```  
  
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
|[CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md)|Call this method to disassociate the file from the `CAtlTemporaryFile` object.|  
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
 `CAtlTemporaryFile` makes it easy to create and use a temporary file. The file is automatically named, opened, closed, and deleted. If the file contents are required after the file is closed, they can be saved to a new file with a specified name.  
  
## Requirements  
 **Header:** atlfile.h  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__catltemporaryfile"></a>  CAtlTemporaryFile::CAtlTemporaryFile  
 The constructor.  
  
```  
  
CAtlTemporaryFile( ) throw( );  
  
```  
  
### Remarks  
 A file is not actually opened until a call is made to [CAtlTemporaryFile::Create](../vs140/catltemporaryfile--create.md).  
  
### Example  
 [!code[NVC_ATL_Utilities#73](../vs140/codesnippet/CPP/catltemporaryfile-class_1.cpp)]  
  
##  <a name="catltemporaryfile___dtorcatltemporaryfile"></a>  CAtlTemporaryFile::~CAtlTemporaryFile  
 The destructor.  
  
```  
  
~CAtlTemporaryFile( ) throw( );  
  
```  
  
### Remarks  
 The destructor calls [CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md).  
  
##  <a name="catltemporaryfile__close"></a>  CAtlTemporaryFile::Close  
 Call this method to close a temporary file and either delete its contents or store them under the specified file name.  
  
```  
  
HRESULT Close(  
      LPCTSTR  szNewName  
    = NULL   
   ) throw( );  
  
```  
  
### Parameters  
 *szNewName*  
 The name for the new file to store the contents of the temporary file in. If this argument is NULL, the contents of the temporary file are deleted.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__create"></a>  CAtlTemporaryFile::Create  
 Call this method to create a temporary file.  
  
```  
  
HRESULT Create(  
      LPCTSTR  pszDir  
    = NULL,  
      DWORD  dwDesiredAccess  
    = GENERIC_WRITE  
   ) throw( );  
  
```  
  
### Parameters  
 `pszDir`  
 The path for the temporary file. If this is NULL, [GetTempPath](http://msdn.microsoft.com/library/windows/desktop/aa364992) will be called to assign a path.  
  
 `dwDesiredAccess`  
 The desired access. See `dwDesiredAccess` in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__flush"></a>  CAtlTemporaryFile::Flush  
 Call this method to force any data remaining in the file buffer to be written to the temporary file.  
  
```  
  
HRESULT Flush( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Similar to [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md), except that the file is not closed.  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__getposition"></a>  CAtlTemporaryFile::GetPosition  
 Call this method to get the current file pointer position.  
  
```  
  
HRESULT GetPosition(  
      ULONGLONG&  nPos  
   ) const throw( );  
  
```  
  
### Parameters  
 `nPos`  
 The position in bytes.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 To change the file pointer position, use [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
##  <a name="catltemporaryfile__getsize"></a>  CAtlTemporaryFile::GetSize  
 Call this method to get the size in bytes of the temporary file.  
  
```  
  
HRESULT GetSize(  
      ULONGLONG&  nLen  
   ) const throw( );  
  
```  
  
### Parameters  
 `nLen`  
 The number of bytes in the file.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
##  <a name="catltemporaryfile__handsoff"></a>  CAtlTemporaryFile::HandsOff  
 Call this method to disassociate the file from the `CAtlTemporaryFile` object.  
  
```  
  
HRESULT HandsOff( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 `HandsOff` and [CAtlTemporaryFile::HandsOn](../vs140/catltemporaryfile--handson.md) are used to disassociate the file from the object, and reattach it if needed. `HandsOff` will force any data remaining in the file buffer to be written to the temporary file, and then close the file. If you want to close and delete the file permanently, or if you want to close and retain the contents of the file with a given name, use [CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md).  
  
##  <a name="catltemporaryfile__handson"></a>  CAtlTemporaryFile::HandsOn  
 Call this method to open an existing temporary file and position the pointer at the end of the file.  
  
```  
  
HRESULT HandsOn( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md) and `HandsOn` are used to disassociate the file from the object, and reattach it if needed.  
  
##  <a name="catltemporaryfile__lockrange"></a>  CAtlTemporaryFile::LockRange  
 Call this method to lock a region in the temporary file to prevent other processes from accessing it.  
  
```  
  
HRESULT LockRange(  
      ULONGLONG  nPos,  
      ULONGLONG  nCount  
   ) throw( );  
  
```  
  
### Parameters  
 `nPos`  
 The position in the file where the lock should begin.  
  
 `nCount`  
 The length of the byte range to be locked.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed. To successfully unlock a region, use [CAtlTemporaryFile::UnlockRange](../vs140/catltemporaryfile--unlockrange.md), ensuring the byte range corresponds exactly to the region that was previously locked. `LockRange` does not merge adjacent regions; if two locked regions are adjacent, you must unlock each separately.  
  
##  <a name="catltemporaryfile__operator_handle"></a>  CAtlTemporaryFile::operator HANDLE  
 Returns a handle to the temporary file.  
  
```  
  
operator HANDLE( ) throw( );  
  
```  
  
##  <a name="catltemporaryfile__read"></a>  CAtlTemporaryFile::Read  
 Call this method to read data from the temporary file starting at the position indicated by the file pointer.  
  
```  
  
HRESULT Read(  
      LPVOID  pBuffer,  
      DWORD  nBufSize,  
      DWORD&  nBytesRead  
   ) throw( );  
  
```  
  
### Parameters  
 `pBuffer`  
 Pointer to the buffer that will receive the data read from the file.  
  
 `nBufSize`  
 The buffer size in bytes.  
  
 `nBytesRead`  
 The number of bytes read.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CAtlFile::Read](../vs140/catlfile--read.md). To change the position of the file pointer, call [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__seek"></a>  CAtlTemporaryFile::Seek  
 Call this method to move the file pointer of the temporary file.  
  
```  
  
HRESULT Seek(  
      LONGLONG  nOffset,  
      DWORD  dwFrom  
    = FILE_CURRENT   
   ) throw( );  
  
```  
  
### Parameters  
 `nOffset`  
 The offset, in bytes, from the starting point given by *dwFrom.*  
  
 `dwFrom`  
 The starting point (FILE_BEGIN, FILE_CURRENT, or FILE_END).  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CAtlFile::Seek](../vs140/catlfile--seek.md). To obtain the current file pointer position, call [CAtlTemporaryFile::GetPosition](../vs140/catltemporaryfile--getposition.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
##  <a name="catltemporaryfile__setsize"></a>  CAtlTemporaryFile::SetSize  
 Call this method to set the size of the temporary file.  
  
```  
  
HRESULT SetSize(  
      ULONGLONG  nNewLen  
   ) throw( );  
  
```  
  
### Parameters  
 `nNewLen`  
 The new length of the file in bytes.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CAtlFile::SetSize](../vs140/catlfile--setsize.md). On return, the file pointer is positioned at the end of the file.  
  
##  <a name="catltemporaryfile__tempfilename"></a>  CAtlTemporaryFile::TempFileName  
 Call this method to return the name of temporary file.  
  
```  
  
LPCTSTR TempFileName( ) throw( );  
  
```  
  
### Return Value  
 Returns the `LPCTSTR` pointing to the file name.  
  
### Remarks  
 The file name is generated in [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md) with a call to the [GetTempFile](http://msdn.microsoft.com/library/windows/desktop/aa364991)[!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] function. The file extension will always be "TFR" for the temporary file.  
  
##  <a name="catltemporaryfile__unlockrange"></a>  CAtlTemporaryFile::UnlockRange  
 Call this method to unlock a region of the temporary file.  
  
```  
  
HRESULT UnlockRange(  
      ULONGLONG  nPos,  
      ULONGLONG  nCount  
   ) throw( );  
  
```  
  
### Parameters  
 `nPos`  
 The position in the file where the unlock should begin.  
  
 `nCount`  
 The length of the byte range to be unlocked.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md).  
  
##  <a name="catltemporaryfile__write"></a>  CAtlTemporaryFile::Write  
 Call this method to write data to the temporary file starting at the position indicated by the file pointer.  
  
```  
  
HRESULT Write(  
      LPCVOID  pBuffer,  
      DWORD  nBufSize,  
      DWORD*  pnBytesWritten  
    = NULL   
   ) throw( );  
  
```  
  
### Parameters  
 `pBuffer`  
 The buffer containing the data to be written to the file.  
  
 `nBufSize`  
 The number of bytes to be transferred from the buffer.  
  
 `pnBytesWritten`  
 The number of bytes written.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CAtlFile::Write](../vs140/catlfile--write.md).  
  
### Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [CAtlFile Class](../vs140/catlfile-class.md)