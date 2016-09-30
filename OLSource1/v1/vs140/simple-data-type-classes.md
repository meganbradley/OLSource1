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
The following classes encapsulate drawing coordinates, character strings, and time and date information, allowing convenient use of C++ syntax. These objects are used widely as parameters to the member functions of Windows classes in the class library. Because <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> correspond to the **POINT**, **SIZE**, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structures, respectively, in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], you can use objects of these C++ classes wherever you can use these C-language structures. The classes provide useful interfaces through their member functions. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> provides very flexible dynamic character strings. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and **COleTimeSpan** represent time and date values. For more information about these classes, see the article [Date and Time](../vs140/date-and-time.md).  
  
 The classes that begin with "**COle**" are encapsulations of data types provided by OLE. These data types can be used in Windows programs regardless of whether other OLE features are used.  
  
 [CStringT Class](../vs140/cstringt-class.md)  
 Holds character strings.  
  
 [CTime](../vs140/ctime-class.md)  
 Holds absolute time and date values.  
  
 [COleDateTime](../vs140/coledatetime-class.md)  
 Wrapper for the OLE automation type **DATE**. Represents date and time values.  
  
 [CTimeSpan](../vs140/ctimespan-class.md)  
 Holds relative time and date values.  
  
 [COleDateTimeSpan](../vs140/coledatetimespan-class.md)  
 Holds relative <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> values, such as the difference between two <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values.  
  
 [CPoint](../vs140/cpoint-class.md)  
 Holds coordinate (x, y) pairs.  
  
 [CSize](../vs140/csize-class.md)  
 Holds distance, relative positions, or paired values.  
  
 [CRect](../vs140/crect-class.md)  
 Holds coordinates of rectangular areas.  
  
 [CImageList](../vs140/cimagelist-class.md)  
 Provides the functionality of the Windows image list. Image lists are used with list controls and tree controls. They can also be used to store and archive a set of same-sized bitmaps.  
  
 [COleVariant](../vs140/colevariant-class.md)  
 Wrapper for the OLE automation type **VARIANT**. Data in **VARIANT**s can be stored in many formats.  
  
 [COleCurrency](../vs140/colecurrency-class.md)  
 Wrapper for the OLE automation type **CURRENCY**, a fixed-point arithmetic type, with 15 digits before the decimal point and 4 digits after.  
  
> [!NOTE]
>  Beginning with Visual C++ .NET, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> have been modified to be usable in either ATL or MFC applications. In addition, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has been added to provide an MFC-independent <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>-like class. For more information on shared utility classes, see [Shared Classes](../vs140/atl-mfc-shared-classes.md).  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)