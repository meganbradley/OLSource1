---
title: "COleVariant::operator ="
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
  - "COleVariant::operator="
  - "COleVariant.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleVariant class, operators"
  - "operator=, variant"
  - "= operator, with specific MFC objects"
  - "operator =, variant"
ms.assetid: 025926e8-f15c-4d2e-86cc-292ac86a06d2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::operator =
These overloaded assignment operators copy the source value into this `COleVariant` object.  
  
## Syntax  
  
```  
  
      const COleVariant& operator =(  
   const VARIANT& varSrc   
);  
const COleVariant& operator =(  
   LPCVARIANT pSrc   
);  
const COleVariant& operator =(  
   const COleVariant& varSrc   
);  
const COleVariant& operator =(  
   const LPCTSTR lpszSrc   
);  
const COleVariant& operator =(  
   const CString& strSrc   
);  
const COleVariant& operator =(  
   BYTE nSrc   
);  
const COleVariant& operator =(  
   short nSrc   
);  
const COleVariant& operator =(  
   long lSrc   
);  
const COleVariant& operator =(  
   const COleCurrency& curSrc   
);  
const COleVariant& operator =(  
   float fltSrc   
);  
const COleVariant& operator =(  
   double dblSrc   
);  
const COleVariant& operator =(  
   const COleDateTime& dateSrc   
);  
const COleVariant& operator =(  
   const CByteArray& arrSrc   
);  
const COleVariant& operator =(  
   const CLongBinary& lbSrc   
);  
```  
  
## Remarks  
 A brief description of each operator follows:  
  
-   **operator =(** *varSrc* **)** Copies an existing **VARIANT** or `COleVariant` object into this object.  
  
-   **operator =(** `pSrc` **)** Copies the **VARIANT** object accessed by `pSrc` into this object.  
  
-   **operator =(** `lpszSrc` **)** Copies a null-terminated string into this object and sets the **VARTYPE** to `VT_BSTR`.  
  
-   **operator =(** `strSrc` **)** Copies a [CString](../vs140/cstringt-class.md) object into this object and sets the **VARTYPE** to `VT_BSTR`.  
  
-   **operator =(** `nSrc` **)** Copies an 8- or 16-bit integer value into this object. If `nSrc` is an 8-bit value, the **VARTYPE** of this is set to `VT_UI1`. If `nSrc` is a 16-bit value and the **VARTYPE** of this is `VT_BOOL`, it is kept; otherwise, it is set to `VT_I2`.  
  
-   **operator =(** `lSrc` **)** Copies a 32-bit integer value into this object. If the **VARTYPE** of this is `VT_ERROR`, it is kept; otherwise, it is set to `VT_I4`.  
  
-   **operator =(** `curSrc` **)** Copies a [COleCurrency](../vs140/colecurrency-class.md) object into this object and sets the **VARTYPE** to `VT_CY`.  
  
-   **operator =(** `fltSrc` **)** Copies a 32-bit floating-point value into this object and sets the **VARTYPE** to `VT_R4`.  
  
-   **operator =(** `dblSrc` **)** Copies a 64-bit floating-point value into this object and sets the **VARTYPE** to `VT_R8`.  
  
-   **operator =(** `dateSrc` **)** Copies a [COleDateTime](../vs140/coledatetime-class.md) object into this object and sets the **VARTYPE** to `VT_DATE`.  
  
-   **operator =(** `arrSrc` **)** Copies a [CByteArray](../vs140/cbytearray-class.md) object into this `COleVariant` object.  
  
-   **operator =(** `lbSrc` **)** Copies a [CLongBinary](../vs140/clongbinary-class.md) object into this `COleVariant` object.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) and [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)   
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [COleDateTime Class](../vs140/coledatetime-class.md)