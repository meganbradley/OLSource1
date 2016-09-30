---
title: "CInternetSession::GetFtpConnection"
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
  - "GetFtpConnection"
  - "CInternetSession::GetFtpConnection"
  - "CInternetSession.GetFtpConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "establishing FTP connections"
  - "Internet protocols, FTP"
  - "GetFtpConnection method"
  - "CInternetSession class, attributes"
  - "FTP (File Transfer Protocol), establishing connections"
ms.assetid: 18565e06-ab74-4c19-a836-6a924ad17003
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::GetFtpConnection
Call this member function to establish an FTP connection and get a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the FTP server name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non-**NULL** String|**NULL** or " "|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|" "|  
|**NULL** Non-**NULL** String|**ERROR**|**ERROR**||  
|Non-**NULL** String|Non-**NULL** String|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies passive or active mode for this FTP session. If set to **TRUE**, it sets the Win32 API <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to **INTERNET_FLAG_PASSIVE**.  
  
## Return Value  
 A pointer to a [CFtpConnection](../vs140/cftpconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> connects to an FTP server, and creates and returns a pointer to a **CFTPConnection** object. It does not perform any specific operation on the server. If you intend to read or write to files, for example, you must perform those operations as separate steps. See the classes [CFtpConnection](../vs140/cftpconnection-class.md) and [CFtpFileFind](../vs140/cftpfilefind-class.md) for information about searching for files, opening files, and reading or writing to files. See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common FTP connection tasks.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CFtpFileFind](../vs140/cftpfilefind-class.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md)   
 [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md)   
 [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md)