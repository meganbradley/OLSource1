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
author: ""
ms.author: ""
manager: ""
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
|[DDV_MaxChars](../vs140/ddv_maxchars.md)|Verifies the number of characters in a given control value does not exceed a given maximum.|  
|[DDV_MinMaxByte](../vs140/ddv_minmaxbyte.md)|Verifies a given control value does not exceed a given **BYTE** range.|  
|[DDV_MinMaxDateTime](../vs140/ddv_minmaxdatetime.md)|Verifies a given control value does not exceed a given time range.|  
|[DDV_MinMaxDouble](../vs140/ddv_minmaxdouble.md)|Verifies a given control value does not exceed a given **double** range.|  
|[DDV_MinMaxDWord](../vs140/ddv_minmaxdword.md)|Verifies a given control value does not exceed a given **DWORD** range.|  
|[DDV_MinMaxFloat](../vs140/ddv_minmaxfloat.md)|Verifies a given control value does not exceed a given **float** range.|  
|[DDV_MinMaxInt](../vs140/ddv_minmaxint.md)|Verifies a given control value does not exceed a given **int** range.|  
|[DDV_MinMaxLong](../vs140/ddv_minmaxlong.md)|Verifies a given control value does not exceed a given **long** range.|  
|[DDV_MinMaxLongLong](../vs140/ddv_minmaxlonglong.md)|Verifies a given control value does not exceed a given **LONGLONG** range.|  
|[DDV_MinMaxMonth](../vs140/ddv_minmaxmonth.md)|Verifies a given control value does not exceed a given date range.|  
|[DDV_MinMaxShort](../vs140/ddv_minmaxshort.md)|Verifies a given control value does not exceed a given **short** range.|  
|[DDV_MinMaxSlider](../vs140/ddv_minmaxslider.md)|Verifies a given slider control value falls within the given range.|  
|[DDV_MinMaxUInt](../vs140/ddv_minmaxuint.md)|Verifies a given control value does not exceed a given **UINT** range.|  
|[DDV_MinMaxULongLong](../vs140/ddv_minmaxulonglong.md)|Verifies a given control value does not exceed a given **ULONGLONG** range.|  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)