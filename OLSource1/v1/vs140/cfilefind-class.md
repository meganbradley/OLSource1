---
title: "CFileFind Class"
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
  - "CFileFind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "files [C++], finding"
  - "Internet files [C++], finding"
  - "CFileFind class"
  - "URLs [C++], searching for"
  - "local files"
  - "local files, searching for"
ms.assetid: 9990068c-b023-4114-9580-a50182d15240
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind Class
Performs local file searches and is the base class for [CGopherFileFind](../vs140/cgopherfilefind-class.md) and [CFtpFileFind](../vs140/cftpfilefind-class.md), which perform Internet file searches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFileFind::CFileFind](#cfilefind__cfilefind)|Constructs a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileFind::Close](#cfilefind__close)|Closes the search request.|  
|[CFileFind::FindFile](#cfilefind__findfile)|Searches a directory for a specified file name.|  
|[CFileFind::FindNextFile](#cfilefind__findnextfile)|Continues a file search from a previous call to [FindFile](#cfilefind__findfile).|  
|[CFileFind::GetCreationTime](#cfilefind__getcreationtime)|Gets the time the file was created.|  
|[CFileFind::GetFileName](#cfilefind__getfilename)|Gets the name, including the extension, of the found file|  
|[CFileFind::GetFilePath](#cfilefind__getfilepath)|Gets the whole path of the found file.|  
|[CFileFind::GetFileTitle](#cfilefind__getfiletitle)|Gets the title of the found file. The title does not include the extension.|  
|[CFileFind::GetFileURL](#cfilefind__getfileurl)|Gets the URL, including the file path, of the found file.|  
|[CFileFind::GetLastAccessTime](#cfilefind__getlastaccesstime)|Gets the time that the file was last accessed.|  
|[CFileFind::GetLastWriteTime](#cfilefind__getlastwritetime)|Gets the time the file was last changed and saved.|  
|[CFileFind::GetLength](#cfilefind__getlength)|Gets the length of the found file, in bytes.|  
|[CFileFind::GetRoot](#cfilefind__getroot)|Gets the root directory of the found file.|  
|[CFileFind::IsArchived](#cfilefind__isarchived)|Determines if the found file is archived.|  
|[CFileFind::IsCompressed](#cfilefind__iscompressed)|Determines if the found file is compressed.|  
|[CFileFind::IsDirectory](#cfilefind__isdirectory)|Determines if the found file is a directory.|  
|[CFileFind::IsDots](#cfilefind__isdots)|Determines if the name of the found file has the name "." or "..", indicating that is actually a directory.|  
|[CFileFind::IsHidden](#cfilefind__ishidden)|Determines if the found file is hidden.|  
|[CFileFind::IsNormal](#cfilefind__isnormal)|Determines if the found file is normal (in other words, has no other attributes).|  
|[CFileFind::IsReadOnly](#cfilefind__isreadonly)|Determines if the found file is read-only.|  
|[CFileFind::IsSystem](#cfilefind__issystem)|Determines if the found file is a system file.|  
|[CFileFind::IsTemporary](#cfilefind__istemporary)|Determines if the found file is temporary.|  
|[CFileFind::MatchesMask](#cfilefind__matchesmask)|Indicates the desired file attributes of the file to be found.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileFind::CloseContext](#cfilefind__closecontext)|Closes the file specified by the current search handle.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFileFind::m_pTM](#cfilefind__m_ptm)|Pointer to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> includes member functions that begin a search, locate a file, and return the title, name, or path of the file. For Internet searches, the member function [GetFileURL](#cfilefind__getfileurl) returns the file's URL.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is the base class for two other MFC classes designed to search particular server types: <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> works specifically with gopher servers, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> works specifically with FTP servers. Together, these three classes provide a seamless mechanism for the client to find files, regardless of the server protocol, the file type, or location, on either a local machine or a remote server.  
  
 The following code will enumerate all the files in the current directory, printing the name of each file:  
  
 [!code[NVC_MFCFiles#31](../vs140/codesnippet/CPP/cfilefind-class_1.cpp)]  
  
 To keep the example simple, this code uses the standard C++ library <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> line could be replaced with a call to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, for example, in a program with a graphical user interface.  
  
 For more information about how to use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and the other WinInet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cfilefind__cfilefind">\</a>  CFileFind::CFileFind  
 This member function is called when a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object is constructed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__close">\</a>  CFileFind::Close  
 Call this member function to end the search, reset the context, and release all resources.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 After calling **Close**, you do not have to create a new <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> instance before calling [FindFile](#cfilefind__findfile) to begin a new search.  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__closecontext">\</a>  CFileFind::CloseContext  
 Closes the file specified by the current search handle.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Closes the file specified by the current value of the search handle. Override this function to change the default behavior.  
  
 You must call the [FindFile](#cfilefind__findfile) or [FindNextFile](#cfilefind__findnextfile) functions at least once to retrieve a valid search handle. The **FindFile** and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> functions use the search handle to locate files with names that match a given name.  
  
##  \<a name="cfilefind__findfile">\</a>  CFileFind::FindFile  
 Call this member function to open a file search.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the file to find. If you pass **NULL** for <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, **FindFile** does a wildcard (*.\*) search.  
  
 *dwUnused*  
 Reserved to make **FindFile** polymorphic with derived classes. Must be 0.  
  
### Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 After calling **FindFile** to begin the file search, call [FindNextFile](#cfilefind__findnextfile) to retrieve subsequent files. You must call <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> at least once before calling any of the following attribute member functions:  
  
-   [GetCreationTime](#cfilefind__getcreationtime)  
  
-   [GetFileName](#cfilefind__getfilename)  
  
-   [GetFileTitle](#cfilefind__getfiletitle)  
  
-   [GetFilePath](#cfilefind__getfilepath)  
  
-   [GetFileURL](#cfilefind__getfileurl)  
  
-   [GetLastAccessTime](#cfilefind__getlastaccesstime)  
  
-   [GetLastWriteTime](#cfilefind__getlastwritetime)  
  
-   [GetLength](#cfilefind__getlength)  
  
-   [GetRoot](#cfilefind__getroot)  
  
-   [IsArchived](#cfilefind__isarchived)  
  
-   [IsCompressed](#cfilefind__iscompressed)  
  
-   [IsDirectory](#cfilefind__isdirectory)  
  
-   [IsDots](#cfilefind__isdots)  
  
-   [IsHidden](#cfilefind__ishidden)  
  
-   [IsNormal](#cfilefind__isnormal)  
  
-   [IsReadOnly](#cfilefind__isreadonly)  
  
-   [IsSystem](#cfilefind__issystem)  
  
-   [IsTemporary](#cfilefind__istemporary)  
  
-   [MatchesMask](#cfilefind__matchesmask)  
  
### Example  
  See the example for [CFileFind::IsDirectory](#cfilefind__isdirectory).  
  
##  \<a name="cfilefind__findnextfile">\</a>  CFileFind::FindNextFile  
 Call this member function to continue a file search from a previous call to [FindFile](#cfilefind__findfile).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if there are more files; zero if the file found is the last one in the directory or if an error occurred. To get extended error information, call the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). If the file found is the last file in the directory, or if no matching files can be found, the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function returns ERROR_NO_MORE_FILES.  
  
### Remarks  
 You must call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> at least once before calling any of the following attribute member functions:  
  
-   [GetCreationTime](#cfilefind__getcreationtime)  
  
-   [GetFileName](#cfilefind__getfilename)  
  
-   [GetFileTitle](#cfilefind__getfiletitle)  
  
-   [GetFilePath](#cfilefind__getfilepath)  
  
-   [GetFileURL](#cfilefind__getfileurl)  
  
-   [GetLastAccessTime](#cfilefind__getlastaccesstime)  
  
-   [GetLastWriteTime](#cfilefind__getlastwritetime)  
  
-   [GetLength](#cfilefind__getlength)  
  
-   [GetRoot](#cfilefind__getroot)  
  
-   [IsArchived](#cfilefind__isarchived)  
  
-   [IsCompressed](#cfilefind__iscompressed)  
  
-   [IsDirectory](#cfilefind__isdirectory)  
  
-   [IsDots](#cfilefind__isdots)  
  
-   [IsHidden](#cfilefind__ishidden)  
  
-   [IsNormal](#cfilefind__isnormal)  
  
-   [IsReadOnly](#cfilefind__isreadonly)  
  
-   [IsSystem](#cfilefind__issystem)  
  
-   [IsTemporary](#cfilefind__istemporary)  
  
-   [MatchesMask](#cfilefind__matchesmask)  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> wraps the Win32 function                         [FindNextFile](http://msdn.microsoft.com/library/windows/desktop/aa364428).  
  
### Example  
  See the example for [CFileFind::IsDirectory](#cfilefind__isdirectory).  
  
##  \<a name="cfilefind__getcreationtime">\</a>  CFileFind::GetCreationTime  
 Call this member function to get the time the specified file was created.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to a                                 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was created.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
### Return Value  
 Nonzero if successful; 0 if unsuccessful. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> returns 0 only if [FindNextFile](#cfilefind__findnextfile) has never been called on this <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the                             [Win32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operation systems, the returned time is in the time zone local to the machine were the file is located. See the Win32                             [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__getfilename">\</a>  CFileFind::GetFileName  
 Call this member function to get the name of the found file.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The name of the most-recently-found file.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling GetFileName.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is one of three <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> member functions that return some form of the file name. The following list describes the three and how they vary:  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> returns the file name, including the extension. For example, calling <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> returns the file name <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
-   [GetFilePath](#cfilefind__getfilepath) returns the entire path for the file. For example, calling <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> returns the file path <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
-   [GetFileTitle](#cfilefind__getfiletitle) returns the file name, excluding the file extension. For example, calling <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> returns the file title <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#32](../vs140/codesnippet/CPP/cfilefind-class_2.cpp)]  
  
##  \<a name="cfilefind__getfilepath">\</a>  CFileFind::GetFilePath  
 Call this member function to get the full path of the specified file.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The path of the specified file.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> is one of three <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> member functions that return some form of the file name. The following list describes the three and how they vary:  
  
-   [GetFileName](#cfilefind__getfilename) returns the file name, including the extension. For example, calling <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> returns the file name <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> returns the entire path for the file. For example, calling <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> returns the file path <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
-   [GetFileTitle](#cfilefind__getfiletitle) returns the file name, excluding the file extension. For example, calling <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> returns the file title <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__getfiletitle">\</a>  CFileFind::GetFileTitle  
 Call this member function to get the title of the found file.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The title of the file.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is one of three <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> member functions that return some form of the file name. The following list describes the three and how they vary:  
  
-   [GetFileName](#cfilefind__getfilename) returns the file name, including the extension. For example, calling <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> returns the file name <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
-   [GetFilePath](#cfilefind__getfilepath) returns the entire path for the file. For example, calling <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> returns the file path <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> returns the file name, excluding the file extension. For example, calling <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to generate a user message about the file <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> returns the file title <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__getfileurl">\</a>  CFileFind::GetFileURL  
 Call this member function to retrieve the specified URL.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The complete URL.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is similar to the member function [GetFilePath](#cfilefind__getfilepath), except that it returns the URL in the form <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. For example, calling <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> to get the complete URL for <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> returns the URL <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__getlastaccesstime">\</a>  CFileFind::GetLastAccessTime  
 Call this member function to get the time that the specified file was last accessed.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A pointer to a                                 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was last accessed.  
  
### Return Value  
 Nonzero if successful; 0 if unsuccessful. <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> returns 0 only if [FindNextFile](#cfilefind__findnextfile) has never been called on this <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the                             [Win32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operation systems, the returned time is in the time zone local to the machine were the file is located. See the Win32                             [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__getlastwritetime">\</a>  CFileFind::GetLastWriteTime  
 Call this member function to get the last time the file was changed.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to a                                 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structure containing the time the file was last written to.  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A reference to a [CTime](../vs140/ctime-class.md) object.  
  
### Return Value  
 Nonzero if successful; 0 if unsuccessful. <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> returns 0 only if [FindNextFile](#cfilefind__findnextfile) has never been called on this <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Not all file systems use the same semantics to implement the time stamp returned by this function. This function may return the same value returned by other time stamp functions if the underlying file system or server does not support keeping the time attribute. See the                             [Win32_Find_Data](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure for information about time formats. On some operation systems, the returned time is in the time zone local to the machine were the file is located. See the Win32                             [FileTimeToLocalFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724277) API for more information.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__getlength">\</a>  CFileFind::GetLength  
 Call this member function to get the length of the found file, in bytes.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The length of the found file, in bytes.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> uses the Win32 structure                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) to get and return the value of the file size, in bytes.  
  
> [!NOTE]
>  As of MFC 7.0, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> supports 64-bit integer types. Previously existing code built with this newer version of the library may result in truncation warnings.  
  
### Example  
 [!code[NVC_MFCFiles#33](../vs140/codesnippet/CPP/cfilefind-class_3.cpp)]  
  
##  \<a name="cfilefind__getroot">\</a>  CFileFind::GetRoot  
 Call this member function to get the root of the found file.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The root of the active search.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
 This member function returns the drive specifier and path name used to start a search. For example, calling [FindFile](#cfilefind__findfile) with <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> results in <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> returning an empty string. Passing a path, such as <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, to **FindFile** results <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> returning <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CFileFind::GetFileName](#cfilefind__getfilename).  
  
##  \<a name="cfilefind__isarchived">\</a>  CFileFind::IsArchived  
 Call this member function to determine if the found file is archived.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Applications mark an archive file, which is to be backed up or removed, with FILE_ATTRIBUTE_ARCHIVE, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__iscompressed">\</a>  CFileFind::IsCompressed  
 Call this member function to determine if the found file is compressed.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A compressed file is marked with FILE_ATTRIBUTE_COMPRESSED, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. For a file, this attribute indicates that all of the data in the file is compressed. For a directory, this attribute indicates that compression is the default for newly created files and subdirectories.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__isdirectory">\</a>  CFileFind::IsDirectory  
 Call this member function to determine if the found file is a directory.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A file that is a directory is marked with FILE_ATTRIBUTE_DIRECTORY a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
 This small program recurses every directory on the C:\ drive and prints the name of the directory.  
  
 [!code[NVC_MFCFiles#34](../vs140/codesnippet/CPP/cfilefind-class_4.cpp)]  
  
##  \<a name="cfilefind__isdots">\</a>  CFileFind::IsDots  
 Call this member function to test for the current directory and parent directory markers while iterating through files.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the found file has the name "." or "..", which indicates that the found file is actually a directory. Otherwise 0.  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CFileFind::IsDirectory](#cfilefind__isdirectory).  
  
##  \<a name="cfilefind__ishidden">\</a>  CFileFind::IsHidden  
 Call this member function to determine if the found file is hidden.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Hidden files, which are marked with FILE_ATTRIBUTE_HIDDEN, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A hidden file is not included in an ordinary directory listing.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__isnormal">\</a>  CFileFind::IsNormal  
 Call this member function to determine if the found file is a normal file.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Files marked with FILE_ATTRIBUTE_NORMAL, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A normal file has no other attributes set. All other file attributes override this attribute.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__isreadonly">\</a>  CFileFind::IsReadOnly  
 Call this member function to determine if the found file is read-only.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A read-only file is marked with FILE_ATTRIBUTE_READONLY, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. Applications can read such a file, but they cannot write to it or delete it.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__issystem">\</a>  CFileFind::IsSystem  
 Call this member function to determine if the found file is a system file.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A system file is marked with FILE_ATTRIBUTE_SYSTEM, , a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A system file is part of, or is used exclusively by, the operating system.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__istemporary">\</a>  CFileFind::IsTemporary  
 Call this member function to determine if the found file is a temporary file.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A temporary file is marked with FILE_ATTRIBUTE_TEMPORARY, a file attribute identified in the                         [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A temporary file is used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](#cfilefind__matchesmask) for a complete list of file attributes.  
  
### Example  
  See the example for [CFileFind::GetLength](#cfilefind__getlength).  
  
##  \<a name="cfilefind__m_ptm">\</a>  CFileFind::m_pTM  
 Pointer to a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cfilefind__matchesmask">\</a>  CFileFind::MatchesMask  
 Call this member function to test the file attributes on the found file.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Specifies one or more file attributes, identified in the                                 [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure, for the found file. To search for multiple attributes, use the bitwise OR (&#124;) operator. Any combination of the following attributes is acceptable:  
  
-   FILE_ATTRIBUTE_ARCHIVE   The file is an archive file. Applications use this attribute to mark files for backup or removal.  
  
-   FILE_ATTRIBUTE_COMPRESSED   The file or directory is compressed. For a file, this means that all of the data in the file is compressed. For a directory, this means that compression is the default for newly created files and subdirectories.  
  
-   FILE_ATTRIBUTE_DIRECTORY   The file is a directory.  
  
-   FILE_ATTRIBUTE_NORMAL   The file has no other attributes set. This attribute is valid only if used alone. All other file attributes override this attribute.  
  
-   FILE_ATTRIBUTE_HIDDEN   The file is hidden. It is not to be included in an ordinary directory listing.  
  
-   FILE_ATTRIBUTE_READONLY   The file is read only. Applications can read the file but cannot write to it or delete it.  
  
-   FILE_ATTRIBUTE_SYSTEM   The file is part of or is used exclusively by the operating system.  
  
-   FILE_ATTRIBUTE_TEMPORARY   The file is being used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
### Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 You must call [FindNextFile](#cfilefind__findnextfile) at least once before calling <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#35](../vs140/codesnippet/CPP/cfilefind-class_5.cpp)]  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpFileFind](../vs140/cftpfilefind-class.md)   
 [CGopherFileFind](../vs140/cgopherfilefind-class.md)   
 [CInternetFile](../vs140/cinternetfile-class.md)   
 [CGopherFile](../vs140/cgopherfile-class.md)   
 [CHttpFile](../vs140/chttpfile-class.md)