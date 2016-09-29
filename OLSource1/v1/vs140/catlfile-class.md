---
title: "CAtlFile Class"
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
  - "CAtlFile"
  - "ATL::CAtlFile"
  - "ATL.CAtlFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlFile class"
ms.assetid: 93ed160b-af2a-448c-9cbe-e5fa46c199bb
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile Class
This class provides a thin wrapper around the Windows file-handling API.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CAtlFile :  
   public CHandle  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFile::CAtlFile](../vs140/catlfile--catlfile.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFile::Create](../vs140/catlfile--create.md)|Call this method to create or open a file.|  
|[CAtlFile::Flush](../vs140/catlfile--flush.md)|Call this method to clear the buffers for the file and cause all buffered data to be written to the file.|  
|[CAtlFile::GetOverlappedResult](../vs140/catlfile--getoverlappedresult.md)|Call this method to get the results of an overlapped operation on the file.|  
|[CAtlFile::GetPosition](../vs140/catlfile--getposition.md)|Call this method to get the current file pointer position from the file.|  
|[CAtlFile::GetSize](../vs140/catlfile--getsize.md)|Call this method to get the size in bytes of the file.|  
|[CAtlFile::LockRange](../vs140/catlfile--lockrange.md)|Call this method to lock a region in the file to prevent other processes from accessing it.|  
|[CAtlFile::Read](../vs140/catlfile--read.md)|Call this method to read data from a file starting at the position indicated by the file pointer.|  
|[CAtlFile::Seek](../vs140/catlfile--seek.md)|Call this method to move the file pointer of the file.|  
|[CAtlFile::SetSize](../vs140/catlfile--setsize.md)|Call this method to set the size of the file.|  
|[CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md)|Call this method to unlock a region of the file.|  
|[CAtlFile::Write](../vs140/catlfile--write.md)|Call this method to write data to the file starting at the position indicated by the file pointer.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFile::m_pTM](../vs140/catlfile--m_ptm.md)|Pointer to `CAtlTransactionManager` object|  
  
## Remarks  
 Use this class when file-handling needs are relatively simple, but more abstraction than the Windows API provides is required, without including MFC dependencies.  
  
## Inheritance Hierarchy  
 [CHandle](../vs140/chandle-class.md)  
  
 `CAtlFile`  
  
## Requirements  
 **Header:** atlfile.h  
  
##  <a name="catlfile__catlfile"></a>  CAtlFile::CAtlFile  
 The constructor.  
  
```  
  
CAtlFile( ) throw( );   
   CAtlFile(  
   CAtlTransactionManager* pTM  
   = NULL  
   ) throw( );  
   CAtlFile(  
      CAtlFile&  file  
   ) throw( );  
   explicit CAtlFile(  
      HANDLE  hFile  
   ) throw( );  
  
```  
  
### Parameters  
 `file`  
 The file object.  
  
 `hFile`  
 The file handle.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 The copy constructor transfers ownership of the file handle from the original `CAtlFile` object to the newly constructed object.  
  
##  <a name="catlfile__create"></a>  CAtlFile::Create  
 Call this method to create or open a file.  
  
```  
  
HRESULT Create(  
      LPCTSTR  szFilename,  
      DWORD  dwDesiredAccess,  
      DWORD  dwShareMode,  
      DWORD  dwCreationDisposition,  
      DWORD  dwFlagsAndAttributes  
    = FILE_ATTRIBUTE_NORMAL,  
      LPSECURITY_ATTRIBUTES  lpsa  
    = NULL,  
      HANDLE  hTemplateFile  
    = NULL   
   ) throw( );  
  
```  
  
### Parameters  
 *szFilename*  
 The file name.  
  
 `dwDesiredAccess`  
 The desired access. See `dwDesiredAccess` in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwShareMode`  
 The share mode. See `dwShareMode` in **CreateFile**.  
  
 `dwCreationDisposition`  
 The creation disposition. See `dwCreationDisposition` in **CreateFile**.  
  
 `dwFlagsAndAttributes`  
 The flags and attributes. See `dwFlagsAndAttributes` in **CreateFile**.  
  
 `lpsa`  
 The security attributes. See *lpSecurityAttributes* in **CreateFile**.  
  
 `hTemplateFile`  
 The template file. See `hTemplateFile` in **CreateFile**.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) to create or open the file.  
  
##  <a name="catlfile__flush"></a>  CAtlFile::Flush  
 Call this method to clear the buffers for the file and cause all buffered data to be written to the file.  
  
```  
  
HRESULT Flush( ) throw( );  
  
```  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [FlushFileBuffers](http://msdn.microsoft.com/library/windows/desktop/aa364439) to flush buffered data to the file.  
  
##  <a name="catlfile__getoverlappedresult"></a>  CAtlFile::GetOverlappedResult  
 Call this method to get the results of an overlapped operation on the file.  
  
```  
  
HRESULT GetOverlappedResult(  
      LPOVERLAPPED  pOverlapped,  
      DWORD&  dwBytesTransferred,  
      BOOL  bWait  
   ) throw( );  
  
```  
  
### Parameters  
 `pOverlapped`  
 The overlapped structure. See `lpOverlapped` in [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *dwBytesTransferred*  
 The bytes transferred. See *lpNumberOfBytesTransferred* in `GetOverlappedResult`.  
  
 `bWait`  
 The wait option. See `bWait` in `GetOverlappedResult`.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) to get the results of an overlapped operation on the file.  
  
##  <a name="catlfile__getposition"></a>  CAtlFile::GetPosition  
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
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) to get the current file pointer position.  
  
##  <a name="catlfile__getsize"></a>  CAtlFile::GetSize  
 Call this method to get the size in bytes of the file.  
  
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
  
### Remarks  
 Calls [GetFileSize](http://msdn.microsoft.com/library/windows/desktop/aa364955) to get the size in bytes of the file.  
  
##  <a name="catlfile__lockrange"></a>  CAtlFile::LockRange  
 Call this method to lock a region in the file to prevent other processes from accessing it.  
  
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
 Calls [LockFile](http://msdn.microsoft.com/library/windows/desktop/aa365202) to lock a region in the file. Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed. When you unlock a region, using [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md), the byte range must correspond exactly to the region that was previously locked. `LockRange` does not merge adjacent regions; if two locked regions are adjacent, you must unlock each separately.  
  
##  <a name="catlfile__m_ptm"></a>  CAtlFile::m_pTM  
 Pointer to a `CAtlTransactionManager` object.  
  
```  
CAtlTransactionManager* m_pTM;  
```  
  
### Remarks  
  
##  <a name="catlfile__read"></a>  CAtlFile::Read  
 Call this method to read data from a file starting at the position indicated by the file pointer.  
  
```  
  
HRESULT Read(  
      LPVOID  pBuffer,  
      DWORD  nBufSize  
   ) throw( );  
   HRESULT Read(  
      LPVOID  pBuffer,  
      DWORD  nBufSize,  
      DWORD&  nBytesRead  
   ) throw( );  
   HRESULT Read(  
      LPVOID  pBuffer,  
      DWORD  nBufSize,  
      LPOVERLAPPED  pOverlapped  
   ) throw( );  
   HRESULT Read(  
      LPVOID  pBuffer,  
      DWORD  nBufSize,  
      LPOVERLAPPED  pOverlapped,  
      LPOVERLAPPED_COMPLETION_ROUTINE  pfnCompletionRoutine  
   ) throw( );  
  
```  
  
### Parameters  
 `pBuffer`  
 Pointer to the buffer that will receive the data read from the file.  
  
 `nBufSize`  
 The buffer size in bytes.  
  
 `nBytesRead`  
 The number of bytes read.  
  
 `pOverlapped`  
 The overlapped structure. See `lpOverlapped` in [ReadFile](http://msdn.microsoft.com/library/windows/desktop/aa365467) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pfnCompletionRoutine`  
 The completion routine. See *lpCompletionRoutine* in [ReadFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365468) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 The first three forms call [ReadFile](http://msdn.microsoft.com/library/windows/desktop/aa365467), the last [ReadFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365468) to read data from the file. Use [CAtlFile::Seek](../vs140/catlfile--seek.md) to move the file pointer.  
  
##  <a name="catlfile__seek"></a>  CAtlFile::Seek  
 Call this method to move the file pointer of the file.  
  
```  
  
HRESULT Seek(  
      LONGLONG  nOffset,  
      DWORD  dwFrom  
    = FILE_CURRENT  
   ) throw( );  
  
```  
  
### Parameters  
 `nOffset`  
 The offset from the starting point given by `dwFrom`.  
  
 `dwFrom`  
 The starting point (FILE_BEGIN, FILE_CURRENT, or FILE_END).  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) to move the file pointer.  
  
##  <a name="catlfile__setsize"></a>  CAtlFile::SetSize  
 Call this method to set the size of the file.  
  
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
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) and [SetEndOfFile](http://msdn.microsoft.com/library/windows/desktop/aa365531) to set the size of the file. On return, the file pointer is positioned at the end of the file.  
  
##  <a name="catlfile__unlockrange"></a>  CAtlFile::UnlockRange  
 Call this method to unlock a region of the file.  
  
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
 Calls [UnlockFile](http://msdn.microsoft.com/library/windows/desktop/aa365715) to unlock a region of the file.  
  
##  <a name="catlfile__write"></a>  CAtlFile::Write  
 Call this method to write data to the file starting at the position indicated by the file pointer.  
  
```  
  
HRESULT Write(  
      LPCVOID  pBuffer,  
      DWORD  nBufSize,  
      LPOVERLAPPED  pOverlapped,  
      LPOVERLAPPED_COMPLETION_ROUTINE  pfnCompletionRoutine  
   ) throw( );  
   HRESULT Write(  
      LPCVOID  pBuffer,  
      DWORD  nBufSize,  
      DWORD*  pnBytesWritten  
    = NULL   
   ) throw( );  
   HRESULT Write(  
      LPCVOID  pBuffer,  
      DWORD  nBufSize,  
      LPOVERLAPPED  pOverlapped  
   ) throw( );  
  
```  
  
### Parameters  
 `pBuffer`  
 The buffer containing the data to be written to the file.  
  
 `nBufSize`  
 The number of bytes to be transferred from the buffer.  
  
 `pOverlapped`  
 The overlapped structure. See `lpOverlapped` in [WriteFile](http://msdn.microsoft.com/library/windows/desktop/aa365747) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pfnCompletionRoutine`  
 The completion routine. See *lpCompletionRoutine* in [WriteFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365748) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pnBytesWritten`  
 The bytes written.  
  
### Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
### Remarks  
 The first three forms call [WriteFile](http://msdn.microsoft.com/library/windows/desktop/aa365747), the last calls [WriteFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365748) to write data to the file. Use [CAtlFile::Seek](../vs140/catlfile--seek.md) to move the file pointer.  
  
## See Also  
 [Marquee Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CHandle Class](../vs140/chandle-class.md)