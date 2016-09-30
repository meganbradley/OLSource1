---
title: "CGopherLocator::GetLocatorType"
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
  - "GOPHER_TYPE_DOS_ARCHIVE"
  - "GOPHER_TYPE_SOUND"
  - "GOPHER_TYPE_INDEX_SERVER"
  - "GOPHER_TYPE_INLINE"
  - "GOPHER_TYPE_GOPHER_PLUS"
  - "GOPHER_TYPE_BITMAP"
  - "GOPHER_TYPE_CALENDAR"
  - "GOPHER_TYPE_ERROR"
  - "GOPHER_TYPE_TEXT_FILE"
  - "GOPHER_TYPE_CSO"
  - "GetLocatorType"
  - "GOPHER_TYPE_UNIX_UUENCODED"
  - "GOPHER_TYPE_UNKNOWN"
  - "GOPHER_TYPE_ASK"
  - "GOPHER_TYPE_REDUNDANT"
  - "GOPHER_TYPE_PDF"
  - "GOPHER_TYPE_HTML"
  - "GOPHER_TYPE_MAC_BINHEX"
  - "GOPHER_TYPE_TELNET"
  - "GOPHER_TYPE_DIRECTORY"
  - "GOPHER_TYPE_BINARY"
  - "CGopherLocator.GetLocatorType"
  - "GOPHER_TYPE_MOVIE"
  - "GOPHER_TYPE_TN3270"
  - "GOPHER_TYPE_GIF"
  - "CGopherLocator::GetLocatorType"
  - "GOPHER_TYPE_IMAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GOPHER_TYPE_SOUND"
  - "GOPHER_TYPE_DOS_ARCHIVE"
  - "GetLocatorType method"
  - "GOPHER_TYPE_ERROR"
  - "GOPHER_TYPE_IMAGE"
  - "GOPHER_TYPE_MOVIE"
  - "GOPHER_TYPE_DIRECTORY"
  - "GOPHER_TYPE_MAC_BINHEX"
  - "GOPHER_TYPE_ASK"
  - "GOPHER_TYPE_INLINE"
  - "GOPHER_TYPE_TN3270"
  - "GOPHER_TYPE_CALENDAR"
  - "GOPHER_TYPE_CSO"
  - "GOPHER_TYPE_TEXT_FILE"
  - "GOPHER_TYPE_BINARY"
  - "GOPHER_TYPE_HTML"
  - "GOPHER_TYPE_TELNET"
  - "GOPHER_TYPE_PDF"
  - "GOPHER_TYPE_BITMAP"
  - "GOPHER_TYPE_GIF"
  - "GOPHER_TYPE_GOPHER_PLUS"
  - "GOPHER_TYPE_INDEX_SERVER"
  - "GOPHER_TYPE_UNKNOWN"
  - "GOPHER_TYPE_REDUNDANT"
  - "GOPHER_TYPE_UNIX_UUENCODED"
  - "CGopherLocator class, attributes"
ms.assetid: 51bf9225-0417-4d93-beb0-18185dd32144
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherLocator::GetLocatorType
Call this member function to get the locator type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwRef*  
 A reference to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that will receive the locator type. See **Remarks** for a table of locator types.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 The possible types are as follows:  
  
|Value|Meaning|  
|-----------|-------------|  
|GOPHER_TYPE_TEXT_FILE|An ASCII text file.|  
|GOPHER_TYPE_DIRECTORY|A directory of additional Gopher items.|  
|GOPHER_TYPE_CSO|A CSO phone book server.|  
|GOPHER_TYPE_ERROR|Indicates an error condition.|  
|GOPHER_TYPE_MAC_BINHEX|A Macintosh file in BINHEX format.|  
|GOPHER_TYPE_DOS_ARCHIVE|A DOS archive file.|  
|GOPHER_TYPE_UNIX_UUENCODED|A UUENCODED file.|  
|GOPHER_TYPE_INDEX_SERVER|An index server.|  
|GOPHER_TYPE_TELNET|A Telnet Server.|  
|GOPHER_TYPE_BINARY|A binary file.|  
|GOPHER_TYPE_REDUNDANT|A duplicated server. The information contained within is a duplicate of the primary server. The primary server is the last directory entry that did not have a GOPHER_TYPE_REDUNDANT type.|  
|GOPHER_TYPE_TN3270|A TN3270 server.|  
|GOPHER_TYPE_GIF|A GIF graphics file.|  
|GOPHER_TYPE_IMAGE|An image file.|  
|GOPHER_TYPE_BITMAP|A bitmap file.|  
|GOPHER_TYPE_MOVIE|A movie file.|  
|GOPHER_TYPE_SOUND|A sound file.|  
|GOPHER_TYPE_HTML|An HTML document.|  
|GOPHER_TYPE_PDF|A PDF file.|  
|GOPHER_TYPE_CALENDAR|A calendar file.|  
|GOPHER_TYPE_INLINE|An inline file.|  
|GOPHER_TYPE_UNKNOWN|The item type is unknown.|  
|GOPHER_TYPE_ASK|An Ask+ item.|  
|GOPHER_TYPE_GOPHER_PLUS|A Gopher+ item.|  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)