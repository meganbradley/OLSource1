---
title: "Simple Data Type Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.classes.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scalar classes [C++]"
  - "data classes [C++]"
  - "simple data type classes"
ms.assetid: 0d591d68-0a33-49e9-8a6d-90c90de5c16a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Simple Data Type Classes
The following classes encapsulate drawing coordinates, character strings, and time and date information, allowing convenient use of C++ syntax. These objects are used widely as parameters to the member functions of Windows classes in the class library. Because `CPoint`, `CSize`, and `CRect` correspond to the **POINT**, **SIZE**, and `RECT` structures, respectively, in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)], you can use objects of these C++ classes wherever you can use these C-language structures. The classes provide useful interfaces through their member functions. `CStringT` provides very flexible dynamic character strings. `CTime`, `COleDateTime`, `CTimeSpan`, and **COleTimeSpan** represent time and date values. For more information about these classes, see the article [Date and Time](../VS_csharp/date-and-time.md).  
  
 The classes that begin with "**COle**" are encapsulations of data types provided by OLE. These data types can be used in Windows programs regardless of whether other OLE features are used.  
  
 [CStringT Class](../VS_csharp/cstringt-class.md)  
 Holds character strings.  
  
 [CTime](../VS_csharp/ctime-class.md)  
 Holds absolute time and date values.  
  
 [COleDateTime](../VS_csharp/coledatetime-class.md)  
 Wrapper for the OLE automation type **DATE**. Represents date and time values.  
  
 [CTimeSpan](../VS_csharp/ctimespan-class.md)  
 Holds relative time and date values.  
  
 [COleDateTimeSpan](../VS_csharp/coledatetimespan-class.md)  
 Holds relative `COleDateTime` values, such as the difference between two `COleDateTime` values.  
  
 [CPoint](../VS_csharp/cpoint-class.md)  
 Holds coordinate (x, y) pairs.  
  
 [CSize](../VS_csharp/csize-class.md)  
 Holds distance, relative positions, or paired values.  
  
 [CRect](../VS_csharp/crect-class.md)  
 Holds coordinates of rectangular areas.  
  
 [CImageList](../VS_csharp/cimagelist-class.md)  
 Provides the functionality of the Windows image list. Image lists are used with list controls and tree controls. They can also be used to store and archive a set of same-sized bitmaps.  
  
 [COleVariant](../VS_csharp/colevariant-class.md)  
 Wrapper for the OLE automation type **VARIANT**. Data in **VARIANT**s can be stored in many formats.  
  
 [COleCurrency](../VS_csharp/colecurrency-class.md)  
 Wrapper for the OLE automation type **CURRENCY**, a fixed-point arithmetic type, with 15 digits before the decimal point and 4 digits after.  
  
> [!NOTE]
>  Beginning with Visual C++ .NET, `CRect`, `CSize`, and `CPoint` have been modified to be usable in either ATL or MFC applications. In addition, `CStringT` has been added to provide an MFC-independent `CString`-like class. For more information on shared utility classes, see [Shared Classes](../VS_csharp/atl-mfc-shared-classes.md).  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)