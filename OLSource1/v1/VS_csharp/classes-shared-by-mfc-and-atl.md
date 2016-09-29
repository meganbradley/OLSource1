---
title: "Classes Shared by MFC and ATL"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared classes, classes"
ms.assetid: ca8b4b6b-744d-430b-b31f-d5b2f17bf210
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes Shared by MFC and ATL
The following table lists the classes shared between MFC and ATL.  
  
|Class|Description|Header file|  
|-----------|-----------------|-----------------|  
|[CFileTime](../VS_csharp/cfiletime-class.md)|Provides methods for managing the date and time values associated with a file.|atltime.h|  
|[CFileTimeSpan](../VS_csharp/cfiletimespan-class.md)|Provides methods for managing relative date and time values associated with a file.|atltime.h|  
|[CFixedStringT](../VS_csharp/cfixedstringt-class.md)|Represents a string object with a fixed character buffer.|cstringt.h|  
|[CImage](../VS_csharp/cimage-class.md)|Provides enhanced bitmap support, including the ability to load and save images in JPEG, GIF, BMP, and Portable Network Graphics (PNG) formats.|atlimage.h|  
|[COleDateTime](../VS_csharp/coledatetime-class.md)|Encapsulates the **DATE** data type used in OLE automation.|atlcomtime.h|  
|[COleDateTimeSpan](../VS_csharp/coledatetimespan-class.md)|Represents a relative time, a time span.|atlcomtime.h|  
|[CPoint](../VS_csharp/cpoint-class.md)|A class similar to the Windows [POINT](../VS_csharp/point-structure.md) structure that also includes member functions to manipulate `CPoint` and **POINT** structures.|atltypes.h|  
|[CRect](../VS_csharp/crect-class.md)|A class similar to a Windows [RECT](../VS_csharp/rect-structure.md) structure that also includes member functions to manipulate `CRect` objects and Windows `RECT` structures.|atltypes.h|  
|[CSimpleStringT](../VS_csharp/csimplestringt-class.md)|Represents a `CSimpleStringT` object.|atlsimpstr.h|  
|[CSize](../VS_csharp/csize-class.md)|A class similar to the Windows SIZE structure, which implements a relative coordinate or position.|atltypes.h|  
|[CStrBufT](../VS_csharp/cstrbuft-class.md)|Provides automatic resource cleanup for `GetBuffer` and `ReleaseBuffer` calls on a existing `CStringT` object.|atlsimpstr.h|  
|[CStringData](../VS_csharp/cstringdata-class.md)|Represents the data of a string object.|atlsimpstr.h|  
|[CStringT](../VS_csharp/cstringt-class.md)|Represents a `CStringT` object.|cstringt.h (MFC dependent) atlstr.h (MFC independent)|  
|[CTime](../VS_csharp/ctime-class.md)|Represents an absolute time and date.|atltime.h|  
|[CTimeSpan](../VS_csharp/ctimespan-class.md)|An amount of time, which is internally stored as the number of seconds in the time span.|atltime.h|  
|[IAtlStringMgr](../VS_csharp/iatlstringmgr-class.md)|Represents the interface to a `CStringT` memory manager.|atlsimpstr.h|  
  
## See Also  
 [ATL/MFC Shared Classes](../VS_csharp/atl-mfc-shared-classes.md)