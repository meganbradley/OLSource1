---
title: "CFile Class"
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
  - "CFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class"
  - "CArchive class, using with CFile"
  - "files [C++], classes for"
ms.assetid: b2eb5757-d499-4e67-b044-dd7d1abaa0f8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile Class
The base class for Microsoft Foundation Class file classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFile::CFile](#cfile__cfile)|Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object from a path or file handle.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFile::Abort](#cfile__abort)|Closes a file ignoring all warnings and errors.|  
|[CFile::Close](#cfile__close)|Closes a file and deletes the object.|  
|[CFile::Duplicate](#cfile__duplicate)|Constructs a duplicate object based on this file.|  
|[CFile::Flush](#cfile__flush)|Flushes any data yet to be written.|  
|[CFile::GetFileName](#cfile__getfilename)|Retrieves the filename of the selected file.|  
|[CFile::GetFilePath](#cfile__getfilepath)|Retrieves the full file path of the selected file.|  
|[CFile::GetFileTitle](#cfile__getfiletitle)|Retrieves the title of the selected file.|  
|[CFile::GetLength](#cfile__getlength)|Retrieves the length of the file.|  
|[CFile::GetPosition](#cfile__getposition)|Retrieves the current file pointer.|  
|[CFile::GetStatus](#cfile__getstatus)|Retrieves the status of the open file, or in the static version, retrieves the status of the specified file (static, virtual function).|  
|[CFile::LockRange](#cfile__lockrange)|Locks a range of bytes in a file.|  
|[CFile::Open](#cfile__open)|Safely opens a file with an error-testing option.|  
|[CFile::Read](#cfile__read)|Reads (unbuffered) data from a file at the current file position.|  
|[CFile::Remove](#cfile__remove)|Deletes the specified file (static function).|  
|[CFile::Rename](#cfile__rename)|Renames the specified file (static function).|  
|[CFile::Seek](#cfile__seek)|Positions the current file pointer.|  
|[CFile::SeekToBegin](#cfile__seektobegin)|Positions the current file pointer at the beginning of the file.|  
|[CFile::SeekToEnd](#cfile__seektoend)|Positions the current file pointer at the end of the file.|  
|[CFile::SetFilePath](#cfile__setfilepath)|Sets the full file path of the selected file.|  
|[CFile::SetLength](#cfile__setlength)|Changes the length of the file.|  
|[CFile::SetStatus](#cfile__setstatus)|Sets the status of the specified file (static, virtual function).|  
|[CFile::UnlockRange](#cfile__unlockrange)|Unlocks a range of bytes in a file.|  
|[CFile::Write](#cfile__write)|Writes (unbuffered) data in a file to the current file position.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CFile::operator HANDLE](#cfile__operator_handle)|A handle to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFile::hFileNull](#cfile__hfilenull)|Determines if the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object has a valid handle.|  
|[CFile::m_hFile](#cfile__m_hfile)|Usually contains the operating-system file handle.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFile::m_pTM](#cfile__m_ptm)|Pointer to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 It directly provides unbuffered, binary disk input/output services, and it indirectly supports text files and memory files through its derived classes. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> works in conjunction with the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class to support serialization of Microsoft Foundation Class objects.  
  
 The hierarchical relationship between this class and its derived classes allows your program to operate on all file objects through the polymorphic <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> interface. A memory file, for example, behaves like a disk file.  
  
 Use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and its derived classes for general-purpose disk I/O. Use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or other Microsoft iostream classes for formatted text sent to a disk file.  
  
 Normally, a disk file is opened automatically on <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> construction and closed on destruction. Static member functions permit you to interrogate a file's status without opening the file.  
  
 For more information on using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, see the articles [Files in MFC](../vs140/files-in-mfc.md) and [File Handling](../vs140/file-handling.md) in the                 *Run-Time Library Reference*.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cfile__abort">\</a>  CFile::Abort  
 Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 When handling exceptions, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> in two important ways. First, the **Abort** function will not throw an exception on failures because failures are ignored by **Abort**. Second, **Abort** will not **ASSERT** if the file has not been opened or was closed previously.  
  
 If you used **new** to allocate the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object on the heap, then you must delete it after closing the file. **Abort** sets <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#5](../vs140/codesnippet/CPP/cfile-class_1.cpp)]  
  
##  \<a name="cfile__cfile">\</a>  CFile::CFile  
 Constructs and initializes a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Handle of a file to attach to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Relative or full path of a file to attach to the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Bitwise combination (OR) of file access options for the specified file. See the Remarks section for possible options.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 The following five tables list the possible options for the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> parameter.  
  
 Choose only one of the following file access mode options. The default file access mode is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, which is read only.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Requests read access only.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Requests write access only.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Requests read and write access.|  
  
 Choose one of the following character mode options.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Sets binary mode (used in derived classes only).|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Sets text mode with special processing for carriage return–linefeed pairs (used in derived classes only).|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Sets Unicode mode (used in derived classes only). Text is written to the file in Unicode format when the application is built in a Unicode configuration. No BOM is written to the file.|  
  
 Choose only one of the following file share mode options. The default file share mode is <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, which is exclusive.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|No sharing restrictions.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Denies read access to all others.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Denies write access to all others.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Denies read and write access to all others.|  
  
 Choose the first, or both, of the following file creation mode options. The default creation mode is <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, which is open existing.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Creates a new file if no file exists.; If the file already exists, [CFileException](../vs140/cfileexception-class.md) is raised.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Creates a new file if no file exists; otherwise, if the file already exists, it is attached to the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.|  
  
 Choose the following file caching options as described. By default, the system uses a general purpose caching scheme that is not available as an option.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|The system does not use an intermediate cache for the file. This option cancels the following 2 options.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|The file cache is optimized for random access. Do not use this option and the sequential scan option.|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|The file cache is optimized for sequential access. Do not use this option and the random access option.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Write operations are performed without delay.|  
  
 Choose the following security option to prevent the file handle from being inherited. By default, any new child processes can use the file handle.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Prevents any child processes from using the file handle.|  
  
 The default constructor initializes members but does not attach a file to the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object. After using this constructor, use the [Open](#cfile__open) method to open a file and attach it to the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object.  
  
 The constructor with one parameter initializes members and attaches an existing file to the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object.  
  
 The constructor with two parameters initializes members and tries to open the specified file. If this constructor successfully opens the specified file, the file is attached to the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object; otherwise, this constructor throws a pointer to a <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object. For more information about how to handle exceptions, see [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
 If a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object successfully opens a specified file, it will close this file automatically when the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object is destroyed; otherwise, you must explicitly close the file after it is no longer attached to the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
### Example  
 The following code shows how to use a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCFiles#4](../vs140/codesnippet/CPP/cfile-class_2.cpp)]  
  
##  \<a name="cfile__close">\</a>  CFile::Close  
 Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 If you used **new** to allocate the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object on the heap, then you must delete it after closing the file. **Close** sets <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Example  
 See the example for [CFile::CFile](#cfile__cfile).  
  
##  \<a name="cfile__duplicate">\</a>  CFile::Duplicate  
 Constructs a duplicate <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object for a given file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a duplicate <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This is equivalent to the C run-time function <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
##  \<a name="cfile__flush">\</a>  CFile::Flush  
 Forces any data remaining in the file buffer to be written to the file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The use of <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> does not guarantee flushing of <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> buffers. If you are using an archive, call [CArchive::Flush](../vs140/carchive-class.md#carchive__flush) first.  
  
### Example  
 See the example for [CFile::SetFilePath](#cfile__setfilepath).  
  
##  \<a name="cfile__getfilename">\</a>  CFile::GetFileName  
 Call this member function to retrieve the name of a specified file.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The name of the file.  
  
### Remarks  
 For example, when you call <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to generate a message to the user about the file <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, the filename, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, is returned.  
  
 To return the entire path of the file, including the name, call [GetFilePath](#cfile__getfilepath). To return the title of the file ( <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>), call [GetFileTitle](#cfile__getfiletitle).  
  
### Example  
 This code fragment opens the SYSTEM.INI file in your WINDOWS directory. If found, the example will print out the name and path and title, as shown under Output:  
  
 [!code[NVC_MFCFiles#6](../vs140/codesnippet/CPP/cfile-class_3.cpp)]  
  
##  \<a name="cfile__getfilepath">\</a>  CFile::GetFilePath  
 Call this member function to retrieve the full path of a specified file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The full path of the specified file.  
  
### Remarks  
 For example, when you call <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> to generate a message to the user about the file <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, the file path, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, is returned.  
  
 To return just the name of the file ( <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>), call [GetFileName](#cfile__getfilename). To return the title of the file ( <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>), call [GetFileTitle](#cfile__getfiletitle).  
  
### Example  
 See the example for [GetFileName](#cfile__getfilename).  
  
##  \<a name="cfile__getfiletitle">\</a>  CFile::GetFileTitle  
 Call this member function to retrieve the file title (the display name) for the file.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The title of the underlying file.  
  
### Remarks  
 This method calls                         [GetFileTitle](http://msdn.microsoft.com/library/windows/desktop/ms646924) to retrieve the title of the file. If successful, the method returns the string that the system would use to display the file name to the user. Otherwise, the method calls                         [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589) to retrieve the file name (including the file extension) of the underlying file. Therefore, the file extension will not always be included in the returned file title string. For more information, see                         [GetFileTitle](http://msdn.microsoft.com/library/windows/desktop/ms646924) and                         [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To return the entire path of the file, including the name, call [GetFilePath](#cfile__getfilepath). To return just the name of the file, call [GetFileName](#cfile__getfilename).  
  
### Example  
 See the example for [GetFileName](#cfile__getfilename).  
  
##  \<a name="cfile__getlength">\</a>  CFile::GetLength  
 Obtains the current logical length of the file in bytes.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The length of the file.  
  
### Example  
 [!code[NVC_MFCFiles#7](../vs140/codesnippet/CPP/cfile-class_4.cpp)]  
  
##  \<a name="cfile__getposition">\</a>  CFile::GetPosition  
 Obtains the current value of the file pointer, which can be used in subsequent calls to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The file pointer.  
  
### Example  
 [!code[NVC_MFCFiles#8](../vs140/codesnippet/CPP/cfile-class_5.cpp)]  
  
##  \<a name="cfile__getstatus">\</a>  CFile::GetStatus  
 This method retrieves status information related to a given <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object instance or a given file path.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A reference to a user-supplied **CFileStatus** structure that will receive the status information. The **CFileStatus** structure has the following fields:  
  
-   **CTime m_ctime** The date and time the file was created.  
  
-   **CTime m_mtime** The date and time the file was last modified.  
  
-   **CTime m_atime** The date and time the file was last accessed for reading.  
  
-   **ULONGLONG m_size** The logical size of the file in bytes, as reported by the DIR command.  
  
-   **BYTE m_attribute** The attribute byte of the file.  
  
-   **char m_szFullName[_MAX_PATH]** The absolute filename in the Windows character set.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A string in the Windows character set that is the path to the desired file. The path can be relative or absolute, or it can contain a network path name.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Return Value  
 **TRUE** if the status information for the specified file is successfully obtained; otherwise, **FALSE**.  
  
### Remarks  
 The non-static version of **GetStatus** retrieves status information of the open file associated with the given <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object.  The static version of **GetStatus** obtains the file status from a given file path without actually opening the file. This is useful for testing the existence and access rights of a file.  
  
 The **m_attribute** member of the **CFileStatus** structure refers to the file attribute set. The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> class provides the **Attribute** enumeration type so file attributes can be specified symbolically:  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
  
### Example  
 [!code[NVC_MFCFiles#10](../vs140/codesnippet/CPP/cfile-class_6.cpp)]  
  
##  \<a name="cfile__hfilenull">\</a>  CFile::hFileNull  
 Determines the presence of a valid file handle for the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 This constant is used to determine if the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object has a valid file handle.  
  
 The following example demonstrates this operation:  
  
 [!code[NVC_MFCFiles#22](../vs140/codesnippet/CPP/cfile-class_7.cpp)]  
  
##  \<a name="cfile__lockrange">\</a>  CFile::LockRange  
 Locks a range of bytes in an open file, throwing an exception if the file is already locked.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The byte offset of the start of the byte range to lock.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The number of bytes in the range to lock.  
  
### Remarks  
 Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed.  
  
 When you unlock the region, using the <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> member function, the byte range must correspond exactly to the region that was previously locked. The <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> function does not merge adjacent regions; if two locked regions are adjacent, you must unlock each region separately.  
  
> [!NOTE]
>  This function is not available for the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>-derived class.  
  
### Example  
 [!code[NVC_MFCFiles#12](../vs140/codesnippet/CPP/cfile-class_8.cpp)]  
  
##  \<a name="cfile__m_hfile">\</a>  CFile::m_hFile  
 Contains the operating-system file handle for an open file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> is a public variable of type **UINT**. It contains <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> (an operating-system-independent empty file indicator) if the handle has not been assigned.  
  
 Use of <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is not recommended because the member's meaning depends on the derived class. <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is made a public member for convenience in supporting nonpolymorphic use of the class.  
  
##  \<a name="cfile__m_ptm">\</a>  CFile::m_pTM  
 Pointer to a <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cfile__open">\</a>  CFile::Open  
 Overloaded. **Open** is designed for use with the default <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> constructor.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path can be relative, absolute, or a network name (UNC).  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A **UINT** that defines the file's sharing and access mode. It specifies the action to take when opening the file. You can combine options by using the bitwise-OR ( **&#124;** ) operator. One access permission and one share option are required; the **modeCreate** and **modeNoInherit** modes are optional. See the [CFile](#cfile__cfile) constructor for a list of mode options.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A pointer to an existing file-exception object that will receive the status of a failed operation.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Return Value  
 Nonzero if the open was successful; otherwise 0. The <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> parameter is meaningful only if 0 is returned.  
  
### Remarks  
 The two functions form a "safe" method for opening a file where a failure is a normal, expected condition.  
  
 While the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> constructor will throw an exception in an error condition, **Open** will return **FALSE** for error conditions. **Open** can still initialize a [CFileException](../vs140/cfileexception-class.md) object to describe the error, however. If you don't supply the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> parameter, or if you pass **NULL** for <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, **Open** will return **FALSE** and not throw a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>. If you pass a pointer to an existing <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, and **Open** encounters an error, the function will fill it with information describing that error. In neither case will **Open** throw an exception.  
  
 The following table describes the possible results of **Open**.  
  
|<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|Error encountered?|Return value|CFileException content|  
|--------------|------------------------|------------------|----------------------------|  
|**NULL**|No|**TRUE**|n/a|  
|ptr to <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>|No|**TRUE**|unchanged|  
|**NULL**|Yes|**FALSE**|n/a|  
|ptr to <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>|Yes|**FALSE**|initialized to describe error|  
  
### Example  
 [!code[NVC_MFCFiles#13](../vs140/codesnippet/CPP/cfile-class_9.cpp)]  
  
 [!code[NVC_MFCFiles#14](../vs140/codesnippet/CPP/cfile-class_10.cpp)]  
  
##  \<a name="cfile__operator_handle">\</a>  CFile::operator HANDLE  
 Use this operator to pass a handle to a <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object to functions such as                 [ReadFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365468) and                 [GetFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724320) that expect a <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="cfile__read">\</a>  CFile::Read  
 Reads data into a buffer from the file associated with the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Pointer to the user-supplied buffer that is to receive the data read from the file.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The maximum number of bytes to be read from the file. For text-mode files, carriage return–linefeed pairs are counted as single characters.  
  
### Return Value  
 The number of bytes transferred to the buffer. Note that for all <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> classes, the return value may be less than <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if the end of file was reached.  
  
### Example  
 [!code[NVC_MFCFiles#15](../vs140/codesnippet/CPP/cfile-class_11.cpp)]  
  
 For another example see [CFile::Open](#cfile__open).  
  
##  \<a name="cfile__remove">\</a>  CFile::Remove  
 This static function deletes the file specified by the path.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path can be relative or absolute, and can contain a network name.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 It will not remove a directory.  
  
 The **Remove** member function throws an exception if the connected file is open or if the file cannot be removed. This is equivalent to the DEL command.  
  
### Example  
 [!code[NVC_MFCFiles#17](../vs140/codesnippet/CPP/cfile-class_12.cpp)]  
  
##  \<a name="cfile__rename">\</a>  CFile::Rename  
 This static function renames the specified file.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The old path.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The new path.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 Directories cannot be renamed. This is equivalent to the REN command.  
  
### Example  
 [!code[NVC_MFCFiles#18](../vs140/codesnippet/CPP/cfile-class_13.cpp)]  
  
##  \<a name="cfile__seek">\</a>  CFile::Seek  
 Repositions the file pointer in an open file.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Number of bytes to move the file pointer. Positive values move the file pointer towards the end of the file; negative values move the file pointer towards the start of the file.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Position to seek from. See the Remarks section for possible values.  
  
### Return Value  
 The position of the file pointer if the method was successful; otherwise, the return value is undefined and a pointer to a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> exception is thrown.  
  
### Remarks  
 The following table lists possible values for the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>|Seek from the start of the file.|  
|<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>|Seek from the current location of the file pointer.|  
|<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>|Seek from the end of the file.|  
  
 When a file is opened, the file pointer is positioned at 0, the start of the file.  
  
 You can set the file pointer to a position beyond the end of a file. If you do this, the size of the file does not increase until you write to the file.  
  
 The exception handler for this method must delete the exception object after the exception is processed.  
  
### Example  
 [!code[NVC_MFCFiles#9](../vs140/codesnippet/CPP/cfile-class_14.cpp)]  
  
##  \<a name="cfile__seektobegin">\</a>  CFile::SeekToBegin  
 Sets the value of the file pointer to the beginning of the file.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#19](../vs140/codesnippet/CPP/cfile-class_15.cpp)]  
  
##  \<a name="cfile__seektoend">\</a>  CFile::SeekToEnd  
 Sets the value of the file pointer to the logical end of the file.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 The length of the file in bytes.  
  
### Remarks  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#19](../vs140/codesnippet/CPP/cfile-class_15.cpp)]  
  
##  \<a name="cfile__setfilepath">\</a>  CFile::SetFilePath  
 Call this function to specify the path of the file; for example, if the path of a file is not available when a [CFile](../vs140/cfile-class.md) object is constructed, call <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> to provide it.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 Pointer to a string specifying the new path.  
  
### Remarks  
  
> [!NOTE]
>  <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> does not open the file or create the file; it simply associates the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object with a path name, which can then be used.  
  
### Example  
 [!code[NVC_MFCFiles#20](../vs140/codesnippet/CPP/cfile-class_16.cpp)]  
  
##  \<a name="cfile__setlength">\</a>  CFile::SetLength  
 Call this function to change the length of the file.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 Desired length of the file in bytes. This value can be larger or smaller than the current length of the file. The file will be extended or truncated as appropriate.  
  
### Remarks  
  
> [!NOTE]
>  With <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, this function could throw a <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCFiles#11](../vs140/codesnippet/CPP/cfile-class_17.cpp)]  
  
##  \<a name="cfile__setstatus">\</a>  CFile::SetStatus  
 Sets the status of the file associated with this file location.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path can be relative or absolute, and can contain a network name.  
  
 *status*  
 The buffer containing the new status information. Call the **GetStatus** member function to prefill the **CFileStatus** structure with current values, then make changes as required. If a value is 0, then the corresponding status item is not updated. See the [GetStatus](#cfile__getstatus) member function for a description of the **CFileStatus** structure.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Remarks  
 To set the time, modify the **m_mtime** field of                         *status*.  
  
 Please note that when you make a call to <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> in an attempt to change only the attributes of the file, and the **m_mtime** member of the file status structure is nonzero, the attributes may also be affected (changing the time stamp may have side effects on the attributes). If you want to only change the attributes of the file, first set the **m_mtime** member of the file status structure to zero and then make a call to <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#21](../vs140/codesnippet/CPP/cfile-class_18.cpp)]  
  
##  \<a name="cfile__unlockrange">\</a>  CFile::UnlockRange  
 Unlocks a range of bytes in an open file.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The byte offset of the start of the byte range to unlock.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The number of bytes in the range to unlock.  
  
### Remarks  
 See the description of the [LockRange](#cfile__lockrange) member function for details.  
  
> [!NOTE]
>  This function is not available for the <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>-derived class.  
  
### Example  
 [!code[NVC_MFCFiles#12](../vs140/codesnippet/CPP/cfile-class_8.cpp)]  
  
##  \<a name="cfile__write">\</a>  CFile::Write  
 Writes data from a buffer to the file associated with the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 A pointer to the user-supplied buffer that contains the data to be written to the file.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The number of bytes to be transferred from the buffer. For text-mode files, carriage return–linefeed pairs are counted as single characters.  
  
### Remarks  
 **Write** throws an exception in response to several conditions, including the disk-full condition.  
  
### Example  
 [!code[NVC_MFCFiles#16](../vs140/codesnippet/CPP/cfile-class_19.cpp)]  
  
 In addition, see the examples for [CFile::CFile](#cfile__cfile) and [CFile::Open](#cfile__open).  
  
## See Also  
 [MFC Sample DRAWCLI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStdioFile](../vs140/cstdiofile-class.md)   
 [CMemFile](../vs140/cmemfile-class.md)   
 [How Do I: Use the CFile Class?](http://go.microsoft.com/fwlink/?LinkId=128046)