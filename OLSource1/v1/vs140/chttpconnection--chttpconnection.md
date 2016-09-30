---
title: "CHttpConnection::CHttpConnection"
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
  - "CHttpConnection.CHttpConnection"
  - "CHttpConnection::CHttpConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHttpConnection class, constructor"
ms.assetid: b4479392-9707-42b7-8581-5b18be90cc76
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpConnection::CHttpConnection
This member function is called to construct a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CInternetSession](../vs140/cinternetsession-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A handle to an Internet connection.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a string containing the server name.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The context identifier for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. See **Remarks** for more information about <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The number that identifies the Internet port for this connection.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that specifies the name of the user to log in. If **NULL**, the default is anonymous.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that specifies the password to use to log in. If both <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are **NULL**, the default anonymous password is the user's email name. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is **NULL** (or an empty string) but <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not **NULL**, a blank password is used. The following table describes the behavior for the four possible settings of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>:  
  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Username sent to FTP server|Password sent to FTP server|  
|--------------------|--------------------|---------------------------------|---------------------------------|  
|**NULL** or " "|**NULL** or " "|"anonymous"|User's email name|  
|Non-**NULL** String|**NULL** or " "|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|" "|  
|**NULL** Non-**NULL** String|**ERROR**|**ERROR**||  
|Non-**NULL** String|Non-**NULL** String|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Any combination of the **INTERNET_ FLAG_\*** flags. See the table in the **Remarks** section of [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md) for a description of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> values.  
  
## Remarks  
 You never create a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> directly. Rather, you create an object by calling [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)