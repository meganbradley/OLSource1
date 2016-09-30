---
title: "CFtpConnection Class"
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
  - "CFtpConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFtpConnection class"
  - "FTP (File Transfer Protocol), establishing connections"
  - "Internet connections, FTP"
  - "Internet services, FTP"
ms.assetid: 5e3a0501-8893-49cf-a3d5-0628d8d6b936
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection Class
Manages your FTP connection to an Internet server and allows direct manipulation of directories and files on that server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFtpConnection::CFtpConnection](#cftpconnection__cftpconnection)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFtpConnection::Command](#cftpconnection__command)|Sends a command directly to an FTP server.|  
|[CFtpConnection::CreateDirectory](#cftpconnection__createdirectory)|Creates a directory on the server.|  
|[CFtpConnection::GetCurrentDirectory](#cftpconnection__getcurrentdirectory)|Gets the current directory for this connection.|  
|[CFtpConnection::GetCurrentDirectoryAsURL](#cftpconnection__getcurrentdirectoryasurl)|Gets the current directory for this connection as a URL.|  
|[CFtpConnection::GetFile](#cftpconnection__getfile)|Gets a file from the connected server|  
|[CFtpConnection::OpenFile](#cftpconnection__openfile)|Opens a file on the connected server.|  
|[CFtpConnection::PutFile](#cftpconnection__putfile)|Places a file on the server.|  
|[CFtpConnection::Remove](#cftpconnection__remove)|Removes a file from the server.|  
|[CFtpConnection::RemoveDirectory](#cftpconnection__removedirectory)|Removes the specified directory from the server.|  
|[CFtpConnection::Rename](#cftpconnection__rename)|Renames a file on the server.|  
|[CFtpConnection::SetCurrentDirectory](#cftpconnection__setcurrentdirectory)|Sets the current FTP directory.|  
  
## Remarks  
 FTP is one of the three Internet services recognized by the MFC WinInet classes.  
  
 To communicate with an FTP Internet server, you must first create an instance of [CInternetSession](../vs140/cinternetsession-class.md), and then create a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. You never create a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object directly; rather, call [CInternetSession::GetFtpConnection](../vs140/cinternetsession-class.md#cinternetsession__getftpconnection), which creates the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object and returns a pointer to it.  
  
 To learn more about how <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md). For more information about communicating with the other two supported services, HTTP and gopher, see the classes [CHttpConnection](../vs140/chttpconnection-class.md) and [CGopherConnection](../vs140/cgopherconnection-class.md).  
  
## Example  
  See the example in the [CFtpFileFind](../vs140/cftpfilefind-class.md) class overview.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CInternetConnection](../vs140/cinternetconnection-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cftpconnection__cftpconnection">\</a>  CFtpConnection::CFtpConnection  
 This member function is called to construct a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A pointer to the related [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The Windows handle of the current Internet session.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to a string containing the FTP server name.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The context identifier for the operation. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> identifies the operation's status information returned by [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback). The default is set to 1; however, you can explicitly assign a specific context ID for the operation. The object and any work it does will be associated with that context ID.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non- **NULL** String|**NULL** or " "|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|" "|  
|**NULL** Non- **NULL** String|**ERROR**|**ERROR**||  
|Non- **NULL** String|Non- **NULL** String|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Specifies passive or active mode for this FTP session. If set to **TRUE**, it sets the Win32 API <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to **INTERNET_FLAG_PASSIVE**.  
  
### Remarks  
 You never create a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object directly. Instead, call [CInternetSession::GetFtpConnection](../vs140/cinternetsession-class.md#cinternetsession__getftpconnection), which creates the **CFptConnection** object.  
  
##  \<a name="cftpconnection__command">\</a>  CFtpConnection::Command  
 Sends a command directly to an FTP server.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to a string containing the command to be sent.  
  
 *eResponse*  
 Determines whether a response is expected from the FTP server. Can be one of the following values:  
  
-   **CmdRespNone** No response is expected.  
  
-   **CmdRespRead** A response is expected.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A value containing the flags that control this function. For a complete list, see [FTPCommand](http://msdn.microsoft.com/library/windows/desktop/aa384133).  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A pointer to a value containing an application-defined value used to identify the application context in callbacks.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 This member function emulates the functionality of the [FTPCommand](http://msdn.microsoft.com/library/windows/desktop/aa384133) function, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If an error occurs, MFC throws an exception of type [CInternetException](../vs140/cinternetexception-class.md).  
  
##  \<a name="cftpconnection__createdirectory">\</a>  CFtpConnection::CreateDirectory  
 Call this member function to create a directory on the connected server.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the directory to create.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Windows function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 Use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to determine the current working directory for this connection to the server. Do not assume that the remote system has connected you to the root directory.  
  
 The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter can be either a partially or a fully qualified filename relative to the current directory. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__getcurrentdirectory">\</a>  CFtpConnection::GetCurrentDirectory  
 Call this member function to get the name of the current directory.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A reference to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A pointer to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to a DWORD that contains the following information:  
  
|||  
|-|-|  
|On entry|The size of the buffer referenced by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
|On return|The number of characters stored to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. If the member function fails and ERROR_INSUFFICIENT_BUFFER is returned, then <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> contains the number of bytes that the application must allocate in order to receive the string.|  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 To get the directory name as a URL instead, call [GetCurrentDirectoryAsURL](#cftpconnection__getcurrentdirectoryasurl).  
  
 The parameters <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> can be either partially qualified filenames relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__getcurrentdirectoryasurl">\</a>  CFtpConnection::GetCurrentDirectoryAsURL  
 Call this member function to get the current directory's name as a URL.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A reference to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A pointer to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a DWORD that contains the following information:  
  
|||  
|-|-|  
|On entry|The size of the buffer referenced by <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.|  
|On return|The number of characters stored to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. If the member function fails and ERROR_INSUFFICIENT_BUFFER is returned, then <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> contains the number of bytes that the application must allocate in order to receive the string.|  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> behaves the same as [GetCurrentDirectory](#cftpconnection__getcurrentdirectory)  
  
 The parameter <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> can be either partially qualified filenames relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__getfile">\</a>  CFtpConnection::GetFile  
 Call this member function to get a file from an FTP server and store it on the local machine.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string containing the name of a file to retrieve from the FTP server.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string containing the name of the file to create on the local system.  
  
 *bFailIfExists*  
 Indicates whether the file name may already be used by an existing file. If the local file name already exists, and this parameter is **TRUE**, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> fails. Otherwise, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> will erase the existing copy of the file.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Indicates the attributes of the file. This can be any combination of the following FILE_ATTRIBUTE_* flags.  
  
-   FILE_ATTRIBUTE_ARCHIVE   The file is an archive file. Applications use this attribute to mark files for backup or removal.  
  
-   FILE_ATTRIBUTE_COMPRESSED   The file or directory is compressed. For a file, compression means that all of the data in the file is compressed. For a directory, compression is the default for newly created files and subdirectories.  
  
-   FILE_ATTRIBUTE_DIRECTORY   The file is a directory.  
  
-   FILE_ATTRIBUTE_NORMAL   The file has no other attributes set. This attribute is valid only if used alone. All other file attributes override FILE_ATTRIBUTE_NORMAL:  
  
-   FILE_ATTRIBUTE_HIDDEN   The file is hidden. It is not to be included in an ordinary directory listing.  
  
-   FILE_ATTRIBUTE_READONLY   The file is read only. Applications can read the file but cannot write to it or delete it.  
  
-   FILE_ATTRIBUTE_SYSTEM   The file is part of or is used exclusively by the operating system.  
  
-   FILE_ATTRIBUTE_TEMPORARY   The file is being used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the conditions under which the transfer occurs. This parameter can be any of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> values described in [FtpGetFile](http://msdn.microsoft.com/library/windows/desktop/aa384157) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The context identifier for the file retrieval. See **Remarks** for more information about <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is a high-level routine that handles all of the overhead associated with reading a file from an FTP server and storing it locally. Applications that only retrieve file data, or that require close control over the file transfer, should use <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and [CInternetFile::Read](../vs140/cinternetfile-class.md#cinternetfile__read) instead.  
  
 If <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is FILE_TRANSFER_TYPE_ASCII, translation of file data also converts control and formatting characters to Windows equivalents. The default transfer is binary mode, where the file is downloaded in the same format as it is stored on the server.  
  
 Both <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> can be either partially qualified filenames relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
 Override the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  \<a name="cftpconnection__openfile">\</a>  CFtpConnection::OpenFile  
 Call this member function to open a file located on an FTP server for reading or writing.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the file to be opened.  
  
 *dwAccess*  
 Determines how the file will be accessed. Can be either GENERIC_READ or GENERIC_WRITE, but not both.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Specifies the conditions under which subsequent transfers occur. This can be any of the following FTP_TRANSFER_* constants:  
  
-   FTP_TRANSFER_TYPE_ASCII   The file transfers using FTP ASCII (Type A) transfer method. Converts control and formatting information to local equivalents.  
  
-   FTP_TRANSFER_TYPE_BINARY   The file transfers data using FTP's Image (Type I) transfer method. The file transfers data exactly as it exists, with no changes. This is the default transfer method.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The context identifier for opening the file. See **Remarks** for more information about <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to a [CInternetFile](../vs140/cinternetfile-class.md) object.  
  
### Remarks  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> should be used in the following situations:  
  
-   An application has data that needs to be sent and created as a file on the FTP server, but that data is not in a local file. Once <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> opens a file, the application uses [CInternetFile::Write](../vs140/cinternetfile-class.md#cinternetfile__write) to send the FTP file data to the server.  
  
-   An application must retrieve a file from the server and place it into application-controlled memory, instead of writing it to disk. The application uses [CInternetFile::Read](../vs140/cinternetfile-class.md#cinternetfile__read) after using <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to open the file.  
  
-   An application needs a fine level of control over a file transfer. For example, the application may want to display a progress control indicate the progress of the file transfer status while downloading a file.  
  
 After calling <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> and until calling **CInternetConnection::Close**, the application can only call [CInternetFile::Read](../vs140/cinternetfile-class.md#cinternetfile__read), [CInternetFile::Write](../vs140/cinternetfile-class.md#cinternetfile__write), **CInternetConnection::Close**, or [CFtpFileFind::FindFile](../vs140/cftpfilefind-class.md#cftpfilefind__findfile). Calls to other FTP functions for the same FTP session will fail and set the error code to FTP_ETRANSFER_IN_PROGRESS.  
  
 The <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> parameter can be either a partially qualified filename relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before using it.  
  
 Override the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  \<a name="cftpconnection__putfile">\</a>  CFtpConnection::PutFile  
 Call this member function to store a file on an FTP server.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the file to send from the local system.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the file to create on the FTP server.  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 Specifies the conditions under which the transfer of the file occurs. Can be any of the FTP_TRANSFER_* constants described in [OpenFile](#cftpconnection__openfile).  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The context identifier for placing the file. See **Remarks** for more information about <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> is a high-level routine that handles all of the operations associated with storing a file on an FTP server. Applications that only send data, or that require closer control over the file transfer, should use [OpenFile](#cftpconnection__openfile) and [CInternetFile::Write](../vs140/cinternetfile-class.md#cinternetfile__write).  
  
 Override the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession-class.md#cinternetsession__onstatuscallback) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
##  \<a name="cftpconnection__remove">\</a>  CFtpConnection::Remove  
 Call this member function to delete the specified file from the connected server.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A pointer to a string containing the file name to remove.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> parameter can be either a partially qualified filename relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. The **Remove** function translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__removedirectory">\</a>  CFtpConnection::RemoveDirectory  
 Call this member function to remove the specified directory from the connected server.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to a string containing the directory to be removed.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 Use [GetCurrentDirectory](#cftpconnection__getcurrentdirectory) to determine the server's current working directory. Do not assume that the remote system has connected you to the root directory.  
  
 The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> parameter can be either a partially or fully qualified filename relative to the current directory. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__rename">\</a>  CFtpConnection::Rename  
 Call this member function to rename the specified file on the connected server.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A pointer to a string containing the current name of the file to be renamed.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 A pointer to a string containing the file's new name.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 The <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> parameters can be either a partially qualified filename relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. **Rename** translates the directory name separators to the appropriate characters before they are used.  
  
##  \<a name="cftpconnection__setcurrentdirectory">\</a>  CFtpConnection::SetCurrentDirectory  
 Call this member function to change to a different directory on the FTP server.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the directory.  
  
### Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
### Remarks  
 The <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> parameter can be either a partially or fully qualified filename relative to the current directory. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
 Use [GetCurrentDirectory](#cftpconnection__getcurrentdirectory) to determine an FTP server's current working directory. Do not assume that the remote system has connected you to the root directory.  
  
## See Also  
 [Base Class](../vs140/cinternetconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection](../vs140/cinternetconnection-class.md)   
 [CInternetSession](../vs140/cinternetsession-class.md)