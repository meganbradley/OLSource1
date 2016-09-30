---
title: "CCachedDataPathProperty Class"
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
  - "CCachedDataPathProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], asynchronous"
  - "CCachedDataPathProperty class"
  - "OLE controls [C++], asynchronous"
  - "asynchronous controls [C++]"
  - "memory files [C++]"
ms.assetid: 0d81356b-4fe5-43f6-aed2-2eb5a5485706
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCachedDataPathProperty Class
Implements an OLE control property transferred asynchronously and cached in a memory file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCachedDataPathProperty::CCachedDataPathProperty](#ccacheddatapathproperty__ccacheddatapathproperty)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CCachedDataPathProperty::m_Cache](#ccacheddatapathproperty__m_cache)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object in which to cache data.|  
  
## Remarks  
 A memory file is stored in RAM rather than on disk and is useful for fast temporary transfers.  
  
 Along with **CAysncMonikerFile** and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provides functionality for the use of asynchronous monikers in OLE controls. With <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects, you are able to transfer data asynchronously from a URL or file source and store it in a memory file via the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> public variable. All the data is stored in the memory file, and there is no need to override [OnDataAvailable](../vs140/casyncmonikerfile-class.md#casyncmonikerfile__ondataavailable) unless you want to watch for notifications and respond. For example, if you are transferring a large .GIF file and want to notify your control that more data has arrived and it should redraw itself, override <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to make the notification.  
  
 The class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For more information about how to use asynchronous monikers and ActiveX controls in Internet applications, see the following topics:  
  
-   [Internet First Steps: ActiveX Controls](../vs140/activex-controls-on-the-internet.md)  
  
-   [Internet First Steps: Asynchronous Monikers](../vs140/asynchronous-monikers-on-the-internet.md)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [COleStreamFile](../vs140/colestreamfile-class.md)  
  
 [CMonikerFile](../vs140/cmonikerfile-class.md)  
  
 [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md)  
  
 [CDataPathProperty](../vs140/cdatapathproperty-class.md)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="ccacheddatapathproperty__ccacheddatapathproperty">\</a>  CCachedDataPathProperty::CCachedDataPathProperty  
 Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the ActiveX control object to be associated with this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object for a file, prepend file:// to the path.  
  
### Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used by [Open](../vs140/cdatapathproperty-class.md#cdatapathproperty__open) and retrieved by derived classes. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is **NULL**, the control used with **Open** should be set with [SetControl](../vs140/cdatapathproperty-class.md#cdatapathproperty__setcontrol). If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is **NULL**, you can pass in the path through **Open** or set it with [SetPath](../vs140/cdatapathproperty-class.md#cdatapathproperty__setpath).  
  
##  \<a name="ccacheddatapathproperty__m_cache">\</a>  CCachedDataPathProperty::m_Cache  
 Contains the class name of the memory file into which data is cached.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 A memory file is stored in RAM rather than on disk.  
  
## See Also  
 [Base Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty](../vs140/cdatapathproperty-class.md)