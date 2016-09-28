---
title: "CFtpConnection::GetFile"
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
  - "FTP_TRANSFER_TYPE_ASCII"
  - "CFtpConnection.GetFile"
  - "FTP_TRANSFER_TYPE_BINARY"
  - "CFtpConnection::GetFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FILE_ATTRIBUTE_DIRECTORY attribute"
  - "FILE_ATTRIBUTE_NORMAL attribute"
  - "GetFile method"
  - "FILE_ATTRIBUTE_TEMPORARY attribute"
  - "FILE_ATTRIBUTE_HIDDEN attribute"
  - "FTP_TRANSFER_TYPE_ASCII"
  - "CFtpConnection class, attributes"
  - "FILE_ATTRIBUTE_ARCHIVE attribute"
  - "FILE_ATTRIBUTE_READONLY attribute"
  - "FILE_ATTRIBUTE_COMPRESSED attribute"
  - "FTP_TRANSFER_TYPE_BINARY"
  - "FILE_ATTRIBUTE_SYSTEM attribute"
ms.assetid: bdd7d5a2-c653-441d-9313-3544a388d15b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection::GetFile
Call this member function to get a file from an FTP server and store it on the local machine.  
  
## Syntax  
  
```  
  
      BOOL GetFile(  
   LPCTSTR pstrRemoteFile,  
   LPCTSTR pstrLocalFile,  
   BOOL bFailIfExists = TRUE,  
   DWORD dwAttributes = FILE_ATTRIBUTE_NORMAL,  
   DWORD dwFlags = FTP_TRANSFER_TYPE_BINARY,  
   DWORD_PTR dwContext = 1   
);  
```  
  
#### Parameters  
 `pstrRemoteFile`  
 A pointer to a null-terminated string containing the name of a file to retrieve from the FTP server.  
  
 `pstrLocalFile`  
 A pointer to a null-terminated string containing the name of the file to create on the local system.  
  
 *bFailIfExists*  
 Indicates whether the file name may already be used by an existing file. If the local file name already exists, and this parameter is **TRUE**, `GetFile` fails. Otherwise, `GetFile` will erase the existing copy of the file.  
  
 `dwAttributes`  
 Indicates the attributes of the file. This can be any combination of the following FILE_ATTRIBUTE_* flags.  
  
-   FILE_ATTRIBUTE_ARCHIVE   The file is an archive file. Applications use this attribute to mark files for backup or removal.  
  
-   FILE_ATTRIBUTE_COMPRESSED   The file or directory is compressed. For a file, compression means that all of the data in the file is compressed. For a directory, compression is the default for newly created files and subdirectories.  
  
-   FILE_ATTRIBUTE_DIRECTORY   The file is a directory.  
  
-   FILE_ATTRIBUTE_NORMAL   The file has no other attributes set. This attribute is valid only if used alone. All other file attributes override FILE_ATTRIBUTE_NORMAL:  
  
-   FILE_ATTRIBUTE_HIDDEN   The file is hidden. It is not to be included in an ordinary directory listing.  
  
-   FILE_ATTRIBUTE_READONLY   The file is read only. Applications can read the file but cannot write to it or delete it.  
  
-   FILE_ATTRIBUTE_SYSTEM   The file is part of or is used exclusively by the operating system.  
  
-   FILE_ATTRIBUTE_TEMPORARY   The file is being used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
 `dwFlags`  
 Specifies the conditions under which the transfer occurs. This parameter can be any of the `dwFlags` values described in [FtpGetFile](http://msdn.microsoft.com/library/windows/desktop/aa384157) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwContext`  
 The context identifier for the file retrieval. See **Remarks** for more information about `dwContext`.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 `GetFile` is a high-level routine that handles all of the overhead associated with reading a file from an FTP server and storing it locally. Applications that only retrieve file data, or that require close control over the file transfer, should use `OpenFile` and [CInternetFile::Read](../vs140/cinternetfile--read.md) instead.  
  
 If `dwFlags` is FILE_TRANSFER_TYPE_ASCII, translation of file data also converts control and formatting characters to Windows equivalents. The default transfer is binary mode, where the file is downloaded in the same format as it is stored on the server.  
  
 Both `pstrRemoteFile` and `pstrLocalFile` can be either partially qualified filenames relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. `GetFile` translates the directory name separators to the appropriate characters before they are used.  
  
 Override the `dwContext` default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the `CFtpConnection` object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)