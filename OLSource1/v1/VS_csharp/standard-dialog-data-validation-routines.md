---
title: "Standard Dialog Data Validation Routines"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "standard dialog, data validation routines"
ms.assetid: 44dbc222-a897-4949-925e-7660e8964ccd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Standard Dialog Data Validation Routines
This topic lists the standard dialog data validation (DDV) routines used for common MFC dialog controls.  
  
> [!NOTE]
>  The standard dialog data exchange routines are defined in the header file afxdd_.h. However, applications should include afxwin.h.  
  
### DDV Functions  
  
|||  
|-|-|  
|[DDV_MaxChars](../VS_csharp/ddv_maxchars.md)|Verifies the number of characters in a given control value does not exceed a given maximum.|  
|[DDV_MinMaxByte](../VS_csharp/ddv_minmaxbyte.md)|Verifies a given control value does not exceed a given **BYTE** range.|  
|[DDV_MinMaxDateTime](../VS_csharp/ddv_minmaxdatetime.md)|Verifies a given control value does not exceed a given time range.|  
|[DDV_MinMaxDouble](../VS_csharp/ddv_minmaxdouble.md)|Verifies a given control value does not exceed a given **double** range.|  
|[DDV_MinMaxDWord](../VS_csharp/ddv_minmaxdword.md)|Verifies a given control value does not exceed a given **DWORD** range.|  
|[DDV_MinMaxFloat](../VS_csharp/ddv_minmaxfloat.md)|Verifies a given control value does not exceed a given **float** range.|  
|[DDV_MinMaxInt](../VS_csharp/ddv_minmaxint.md)|Verifies a given control value does not exceed a given **int** range.|  
|[DDV_MinMaxLong](../VS_csharp/ddv_minmaxlong.md)|Verifies a given control value does not exceed a given **long** range.|  
|[DDV_MinMaxLongLong](../VS_csharp/ddv_minmaxlonglong.md)|Verifies a given control value does not exceed a given **LONGLONG** range.|  
|[DDV_MinMaxMonth](../VS_csharp/ddv_minmaxmonth.md)|Verifies a given control value does not exceed a given date range.|  
|[DDV_MinMaxShort](../VS_csharp/ddv_minmaxshort.md)|Verifies a given control value does not exceed a given **short** range.|  
|[DDV_MinMaxSlider](../VS_csharp/ddv_minmaxslider.md)|Verifies a given slider control value falls within the given range.|  
|[DDV_MinMaxUInt](../VS_csharp/ddv_minmaxuint.md)|Verifies a given control value does not exceed a given **UINT** range.|  
|[DDV_MinMaxULongLong](../VS_csharp/ddv_minmaxulonglong.md)|Verifies a given control value does not exceed a given **ULONGLONG** range.|  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../VS_csharp/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)