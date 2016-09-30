---
title: "CInternetFile Class"
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
  - "CInternetFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetFile class"
  - "Internet files"
  - "Internet files, CInternetFile class"
ms.assetid: 96935681-ee71-4a8d-9783-5abc7b3e6f10
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile Class
Allows access to files on remote systems that use Internet protocols.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetFile::CInternetFile](#cinternetfile__cinternetfile)|Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetFile::Abort](#cinternetfile__abort)|Closes the file, ignoring all warnings and errors.|  
|[CInternetFile::Close](#cinternetfile__close)|Closes a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and frees its resources.|  
|[CInternetFile::Flush](#cinternetfile__flush)|Flushes the contents of the write buffer and makes sure the data in memory is written to the target machine.|  
|[CInternetFile::GetLength](#cinternetfile__getlength)|Returns the size of the file.|  
|[CInternetFile::Read](#cinternetfile__read)|Reads the number of specified bytes.|  
|[CInternetFile::ReadString](#cinternetfile__readstring)|Reads a stream of characters.|  
|[CInternetFile::Seek](#cinternetfile__seek)|Repositions the pointer in an open file.|  
|[CInternetFile::SetReadBufferSize](#cinternetfile__setreadbuffersize)|Sets the size of the buffer where data will be read.|  
|[CInternetFile::SetWriteBufferSize](#cinternetfile__setwritebuffersize)|Sets the size of the buffer where data will be written.|  
|[CInternetFile::Write](#cinternetfile__write)|Writes the number of specified bytes.|  
|[CInternetFile::WriteString](#cinternetfile__writestring)|Writes a null-terminated string to a file.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetFile::operator HINTERNET](#cinternetfile__operator_hinternet)|A casting operator for an Internet handle.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CInternetFile::m_hFile](#cinternetfile__m_hfile)|A handle to a file.|  
  
## Remarks  
 Provides a base class for the [CHttpFile](../vs140/chttpfile-class.md) and [CGopherFile](../vs140/cgopherfile-class.md) file classes. You never create a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object directly. Instead, create an object of one of its derived classes by calling [CGopherConnection::OpenFile](../vs140/cgopherconnection-class.md#cgopherconnection__openfile) or [CHttpConnection::OpenRequest](../vs140/chttpconnection-class.md#chttpconnection__openrequest). You also can create a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object by calling [CFtpConnection::OpenFile](../vs140/cftpconnection-class.md#cftpconnection__openfile).  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member functions **Open**, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are not implemented for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If you call these functions on a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object, you will get a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 To learn more about how <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [CStdioFile](../vs140/cstdiofile-class.md)  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cinternetfile__abort">\</a>  CInternetFile::Abort  
 Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 When handling exceptions, **Abort** differs from [Close](#cinternetfile__close) in two important ways. First, the **Abort** function does not throw an exception on failures because it ignores failures. Second, **Abort** does not **ASSERT** if the file has not been opened or was closed previously.  
  
##  \<a name="cinternetfile__cinternetfile">\</a>  CInternetFile::CInternetFile  
 This member function is called when a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is created.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A handle to an Internet file.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to a string containing the file name.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to a [CInternetConnection](../vs140/cinternetconnection-class.md) object.  
  
 *bReadMode*  
 Indicates whether the file is read-only.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A handle to an Internet session.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the server.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object. See [WinInet Basics](../vs140/wininet-basics.md) for more information about the context identifier.  
  
### Remarks  
 You never create a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object directly. Instead, create an object of one of its derived classes by calling [CGopherConnection::OpenFile](../vs140/cgopherconnection-class.md#cgopherconnection__openfile) or [CHttpConnection::OpenRequest](../vs140/chttpconnection-class.md#chttpconnection__openrequest). You also can create a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object by calling [CFtpConnection::OpenFile](../vs140/cftpconnection-class.md#cftpconnection__openfile).  
  
##  \<a name="cinternetfile__close">\</a>  CInternetFile::Close  
 Closes a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and frees any of its resources.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the file was opened for writing, there is an implicit call to [Flush](#cinternetfile__flush) to assure that all buffered data is written to the host. You should call **Close** when you are finished using a file.  
  
##  \<a name="cinternetfile__flush">\</a>  CInternetFile::Flush  
 Call this member function to flush the contents of the write buffer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to assure that all data in memory has actually been written to the target machine and to assure your transaction with the host machine has been completed. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is only effective on <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> objects opened for writing.  
  
##  \<a name="cinternetfile__getlength">\</a>  CInternetFile::GetLength  
 Returns the size of the file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cinternetfile__m_hfile">\</a>  CInternetFile::m_hFile  
 A handle to the file associated with this object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cinternetfile__operator_hinternet">\</a>  CInternetFile::operator HINTERNET  
 Use this operator to get the Windows handle for the current Internet session.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="cinternetfile__read">\</a>  CInternetFile::Read  
 Call this member function to read into the given memory, starting at <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the specified number of bytes, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to a memory address to which file data is read.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The number of bytes to be written.  
  
### Return Value  
 The number of bytes transferred to the buffer. The return value may be less than <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the end of file was reached.  
  
### Remarks  
 The function returns the number of bytes actually read — a number that may be less than <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the file ends. If an error occurs while reading the file, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object that describes the error. Note that reading past the end of the file is not considered an error and no exception will be thrown.  
  
 To ensure all data is retrieved, an application must continue to call the **CInternetFile::Read** method until the method returns zero.  
  
##  \<a name="cinternetfile__readstring">\</a>  CInternetFile::ReadString  
 Call this member function to read a stream of characters until it finds a newline character.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to a string which will receive the line being read.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The maximum number of characters to be read.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A reference to the [CString](../vs140/cstringt-class.md) object that receives the read line.  
  
### Return Value  
 A pointer to the buffer containing plain data retrieved from the [CInternetFile](../vs140/cinternetfile-class.md) object. Regardless of the data type of the buffer passed to this method, it does not perform any manipulations on the data (for example, conversion to Unicode), so you must map the returned data to the structure you expect, as if the **void\*** type were returned.  
  
 **NULL** if end-of-file was reached without reading any data; or, if boolean, **FALSE** if end-of-file was reached without reading any data.  
  
### Remarks  
 The function places the resulting line into the memory referenced by the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> parameter. It stops reading characters when it reaches the maximum number of characters, specified by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. The buffer always receives a terminating null character.  
  
 If you call <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> without first calling [SetReadBufferSize](#cinternetfile__setreadbuffersize), you will get a buffer of 4096 bytes.  
  
##  \<a name="cinternetfile__seek">\</a>  CInternetFile::Seek  
 Call this member function to reposition the pointer in a previously opened file.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Offset in bytes to move the read/write pointer in the file.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Relative reference for the offset. Must be one of the following values:  
  
-   **CFile::begin** Move the file pointer <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> bytes forward from the beginning of the file.  
  
-   **CFile::current** Move the file pointer <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> bytes from the current position in the file.  
  
-   **CFile::end** Move the file pointer <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> bytes from the end of the file. <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> must be negative to seek into the existing file; positive values will seek past the end of the file.  
  
### Return Value  
 The new byte offset from the beginning of the file if the requested position is legal; otherwise, the value is undefined and a [CInternetException](../vs140/cinternetexception-class.md) object is thrown.  
  
### Remarks  
 The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> function permits random access to a file's contents by moving the pointer a specified amount, absolutely or relatively. No data is actually read during the seek.  
  
 At this time, a call to this member function is only supported for data associated with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects. It is not supported for FTP or gopher requests. If you call <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> for one of these unsupported services, it will pass back you to the Win32 error code **ERROR_INTERNET_INVALID_OPERATION**.  
  
 When a file is opened, the file pointer is at offset 0, the beginning of the file.  
  
> [!NOTE]
>  Using <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> may cause an implicit call to [Flush](#cinternetfile__flush).  
  
### Example  
  See the example for the base class implementation ( [CFile::Seek](../vs140/cfile-class.md#cfile__seek)).  
  
##  \<a name="cinternetfile__setreadbuffersize">\</a>  CInternetFile::SetReadBufferSize  
 Call this member function to set the size of the temporary read buffer used by a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>-derived object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *nReadSize*  
 The desired buffer size in bytes.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 The underlying WinInet APIs do not perform buffering, so choose a buffer size that allows your application to read data efficiently, regardless of the amount of data to be read. If each call to [Read](#cinternetfile__read) normally involves a large aount of data (for example, four or more kilobytes), you should not need a buffer. However, if you call **Read** to get small chunks of data, or if you use [ReadString](#cinternetfile__readstring) to read individual lines at a time, then a read buffer improves application performance.  
  
 By default, a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object does not provide any buffering for reading. If you call this member function, you must be sure that the file has been opened for read access.  
  
 You can increase the buffer size at any time, but shrinking the buffer will have no effect. If you call [ReadString](#cinternetfile__readstring) without first calling <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, you will get a buffer of 4096 bytes.  
  
##  \<a name="cinternetfile__setwritebuffersize">\</a>  CInternetFile::SetWriteBufferSize  
 Call this member function to set the size of the temporary write buffer used by a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>-derived object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *nWriteSize*  
 The size of the buffer in bytes.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 The underlying WinInet APIs don't perform buffering, so choose a buffer size that allows your application to write data efficiently regardless of the amount of data to be written. If each call to [Write](#cinternetfile__write) normally involves a large amount of data (for example, four or more kilobytes at a time), you should not need a buffer. However, if you call [Write](#cinternetfile__write) to write small chunks of data, a write buffer improves your application's performance.  
  
 By default, a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object does not provide any buffering for writing. If you call this member function, you must be sure that the file has been opened for write access. You can change the size of the write buffer at any time, but doing so causes an implicit call to [Flush](#cinternetfile__flush).  
  
##  \<a name="cinternetfile__write">\</a>  CInternetFile::Write  
 Call this member function to write into the given memory, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, the specified number of bytes, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A pointer to the first byte to be written.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the number of bytes to be written.  
  
### Remarks  
 If any error occurs while writing the data, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object describing the error.  
  
##  \<a name="cinternetfile__writestring">\</a>  CInternetFile::WriteString  
 This function writes a null-terminated string to the associated file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A pointer to a string containing the contents to be written.  
  
### Remarks  
 If any error occurs while writing the data, the function throws a [CInternetException](../vs140/cinternetexception-class.md) object describing the error.  
  
## See Also  
 [Base Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection](../vs140/cinternetconnection-class.md)