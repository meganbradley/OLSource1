---
title: "CGopherFile Class"
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
  - "CGopherFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "gopher protocol files"
  - "Internet, gopher"
  - "CGopherFile class"
ms.assetid: 3ca9898f-8cdb-4495-bbde-46d40100feda
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFile Class
Provides the functionality to find and read files on a gopher server.  
  
> [!NOTE]
>  The classes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and their members have been deprecated because they do not work on the Windows XP platform, but they will continue to work on earlier platforms.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CGopherFile::CGopherFile](#cgopherfile__cgopherfile)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The gopher service does not allow users to write data to a gopher file because this service functions mainly as a menu-driven interface for finding information. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member functions **Write**, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are not implemented for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Calling these functions on a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, returns a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 To learn more about how <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> works with the other MFC Internet classes, see the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [CStdioFile](../vs140/cstdiofile-class.md)  
  
 [CInternetFile](../vs140/cinternetfile-class.md)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxinet.h  
  
##  \<a name="cgopherfile__cgopherfile">\</a>  CGopherFile::CGopherFile  
 This member function is called to construct a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A handle to an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> file.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to a [CGopherConnection](../vs140/cgopherconnection-class.md) object.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A handle to the current Internet session.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A pointer to a string used to locate the gopher server. See [Gopher Sessions](https://msdn.microsoft.com/en-US/library/24wz8xze.aspx) for more information about gopher locators.  
  
 *dwLocLen*  
 A DWORD containing the number of bytes in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to the context identifier of the file being opened.  
  
### Remarks  
 You need a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object to read from a file during a gopher Internet session.  
  
 You never create a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object directly. Instead, call [CGopherConnection::OpenFile](../vs140/cgopherconnection-class.md#cgopherconnection__openfile) to open a file on a gopher server.  
  
## See Also  
 [Base Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile](../vs140/cinternetfile-class.md)   
 [CGopherLocator](../vs140/cgopherlocator-class.md)   
 [CGopherFileFind](../vs140/cgopherfilefind-class.md)   
 [CGopherConnection](../vs140/cgopherconnection-class.md)