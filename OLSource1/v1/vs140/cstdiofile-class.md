---
title: "CStdioFile Class"
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
  - "CStdioFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStdioFile class"
  - "I/O [MFC], stream"
  - "stream I/O"
ms.assetid: 88c2274c-4f0e-4327-882a-557ba4b3ae15
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStdioFile Class
Represents a C run-time stream file as opened by the run-time function [fopen](../vs140/fopen--_wfopen.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CStdioFile::CStdioFile](#cstdiofile__cstdiofile)|Constructs a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object from a path or file pointer.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CStdioFile::Open](#cstdiofile__open)|Overloaded. Open is designed for use with the default <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> constructor (Overrides [CFile::Open](../vs140/cfile-class.md#cfile__open)).|  
|[CStdioFile::ReadString](#cstdiofile__readstring)|Reads a single line of text.|  
|[CStdioFile::Seek](#cstdiofile__seek)|Positions the current file pointer.|  
|[CStdioFile::WriteString](#cstdiofile__writestring)|Writes a single line of text.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CStdioFile::m_pStream](#cstdiofile__m_pstream)|Contains a pointer to an open file.|  
  
## Remarks  
 Stream files are buffered and can be opened in either text mode (the default) or binary mode.  
  
 Text mode provides special processing for carriage return–linefeed pairs. When you write a newline character (0x0A) to a text-mode <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, the byte pair (0x0D, 0x0A) is sent to the file. When you read, the byte pair (0x0D, 0x0A) is translated to a single 0x0A byte.  
  
 The [CFile](../vs140/cfile-class.md) functions [Duplicate](../vs140/cfile-class.md#cfile__duplicate), [LockRange](../vs140/cfile-class.md#cfile__lockrange), and [UnlockRange](../vs140/cfile-class.md#cfile__unlockrange) are not supported for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 If you call these functions on a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, you will get a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 For more information on using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, see the articles [Files in MFC](../vs140/files-in-mfc.md) and [File Handling](../vs140/file-handling.md) in the                 *Run-Time Library Reference*.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cstdiofile__cstdiofile">\</a>  CStdioFile::CStdioFile  
 Constructs and initializes a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies the file pointer returned by a call to the C run-time function [fopen](../vs140/fopen--_wfopen.md).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies a string that is the path to the desired file. The path can be relative or absolute.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies options for file creation, file sharing, and file access modes. You can specify multiple options by using the bitwise OR ( <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) operator.  
  
 One file access mode option is required; other modes are optional. See [CFile::CFile](../vs140/cfile-class.md#cfile__cfile) for a list of mode options and other flags. In MFC version 3.0 and later, share flags are allowed.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object.  
  
### Remarks  
 The default constructor does not attach a file to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. When using this constructor, you must use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method to open a file and attach it to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
 The single-parameter constructor attaches an open file stream to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object. Allowed pointer values include the predefined input/output file pointers <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The two-parameter constructor creates a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object and opens the corresponding file with the given path.  
  
 If you pass <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> for either <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the constructor throws a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 If the file cannot be opened or created, the constructor throws a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#37](../vs140/codesnippet/CPP/cstdiofile-class_1.cpp)]  
  
##  \<a name="cstdiofile__m_pstream">\</a>  CStdioFile::m_pStream  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> data member is the pointer to an open file as returned by the C run-time function <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 It is **NULL** if the file has never been opened or has been closed.  
  
##  \<a name="cstdiofile__open">\</a>  CStdioFile::Open  
 Overloaded. Open is designed for use with the default <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path can be relative or absolute.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Sharing and access mode. Specifies the action to take when opening the file. You can combine options by using the bitwise-OR (&#124;) operator. One access permission and one share option are required; the modeCreate and modeNoInherit modes are optional.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to an existing file-exception object that will receive the status of a failed operation.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cstdiofile__readstring">\</a>  CStdioFile::ReadString  
 Reads text data into a buffer, up to a limit of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>–1 characters, from the file associated with the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies a pointer to a user-supplied buffer that will receive a null-terminated text string.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the maximum number of characters to read, not counting the terminating null character.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object that will contain the string when the function returns.  
  
### Return Value  
 A pointer to the buffer containing the text data. **NULL** if end-of-file was reached without reading any data; or if boolean, **FALSE** if end-of-file was reached without reading any data.  
  
### Remarks  
 Reading is stopped by the first newline character. If, in that case, fewer than <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>–1 characters have been read, a newline character is stored in the buffer. A null character ('\0') is appended in either case.  
  
 [CFile::Read](../vs140/cfile-class.md#cfile__read) is also available for text-mode input, but it does not terminate on a carriage return–linefeed pair.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> version of this function removes the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if present; the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> version does not.  
  
### Example  
 [!code[NVC_MFCFiles#38](../vs140/codesnippet/CPP/cstdiofile-class_2.cpp)]  
  
##  \<a name="cstdiofile__seek">\</a>  CStdioFile::Seek  
 Repositions the pointer in a previously opened file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Number of bytes to move the pointer.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Pointer movement mode. Must be one of the following values:  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> bytes forward from the beginning of the file.  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> bytes from the current position in the file.  
  
-   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>: Move the file pointer <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> bytes from the end of the file. Note that <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> must be negative to seek into the existing file; positive values will seek past the end of the file.  
  
### Return Value  
 If the requested position is legal, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns the new byte offset from the beginning of the file. Otherwise, the return value is undefined and a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object is thrown.  
  
### Remarks  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> function permits random access to a file's contents by moving the pointer a specified amount, absolutely or relatively. No data is actually read during the seek. If the requested position is larger than the size of the file, the file length will be extended to that position, and no exception will be thrown.  
  
 When a file is opened, the file pointer is positioned at offset 0, the beginning of the file.  
  
 This implementation of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is based on the Run-Time Library (CRT) function <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. There are several limits on the usage of <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> on streams opened in text mode. For more information, see [fseek](../vs140/fseek--_fseeki64.md).  
  
### Example  
 The following example shows how to use <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> to move the pointer 1000 bytes from the beginning of the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> file. Note that <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> does not read data, so you must subsequently call [CStdioFile::ReadString](#cstdiofile__readstring) to read data.  
  
 [!code[NVC_MFCFiles#39](../vs140/codesnippet/CPP/cstdiofile-class_3.cpp)]  
  
##  \<a name="cstdiofile__writestring">\</a>  CStdioFile::WriteString  
 Writes data from a buffer to the file associated with the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies a pointer to a buffer that contains a null-terminated string.  
  
### Remarks  
 The terminating null character ( <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>) is not written to the file. This method writes newline characters in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to the file as a carriage return/linefeed pair.  
  
 If you want to write data that is not null-terminated to a file, use <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> or [CFile::Write](../vs140/cfile-class.md#cfile__write).  
  
 This method throws a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if you specify <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> parameter.  
  
 This method throws a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> in response to file system errors.  
  
### Example  
 [!code[NVC_MFCFiles#40](../vs140/codesnippet/CPP/cstdiofile-class_4.cpp)]  
  
## See Also  
 [Base Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile](../vs140/cfile-class.md)   
 [CFile::Duplicate](../vs140/cfile-class.md#cfile__duplicate)   
 [CFile::LockRange](../vs140/cfile-class.md#cfile__lockrange)   
 [CFile::UnlockRange](../vs140/cfile-class.md#cfile__unlockrange)   
 [CNotSupportedException](../vs140/cnotsupportedexception-class.md)   
 [How Do I: Use the CFile Class?](http://go.microsoft.com/fwlink/?LinkId=128046)