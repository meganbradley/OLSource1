---
title: "COleCurrency::COleCurrency"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleCurrency.COleCurrency
  - COleCurrency::COleCurrency
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleCurrency class, constructor
ms.assetid: c3ad2bf0-54bd-4d05-927f-4fa47e026ae9
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleCurrency::COleCurrency
Constructs a **COleCurrency** object.  
  
## Syntax  
  
```  
  
      COleCurrency( );  
COleCurrency(  
   CURRENCY cySrc   
);  
COleCurrency(  
   const COleCurrency& curSrc   
);  
COleCurrency(  
   const VARIANT& varSrc   
);  
COleCurrency(  
   long nUnits,  
   long nFractionalUnits   
);  
```  
  
#### Parameters  
 `cySrc`  
 A **CURRENCY** value to be copied into the new **COleCurrency** object.  
  
 `curSrc`  
 An existing **COleCurrency** object to be copied into the new **COleCurrency** object.  
  
 *varSrc*  
 An existing **VARIANT** data structure (possibly a `COleVariant` object) to be converted to a currency value (`VT_CY`) and copied into the new **COleCurrency** object.  
  
 `nUnits`, `nFractionalUnits`  
 Indicate the units and fractional part (in 1/10,000's) of the value to be copied into the new **COleCurrency** object.  
  
## Remarks  
 All of these constructors create new **COleCurrency** objects initialized to the specified value. A brief description of each of these constructors follows. Unless otherwise noted, the status of the new **COleCurrency** item is set to valid.  
  
-   `COleCurrency(` **)** Constructs a **COleCurrency** object initialized to 0 (zero).  
  
-   `COleCurrency(` `cySrc` **)** Constructs a **COleCurrency** object from a [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) value.  
  
-   `COleCurrency(` `curSrc` **)** Constructs a **COleCurrency** object from an existing **COleCurrency** object. The new object has the same status as the source object.  
  
-   `COleCurrency(` *varSrc* **)** Constructs a **COleCurrency** object. Attempts to convert a [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) structure or `COleVariant` object to a currency (`VT_CY`) value. If this conversion is successful, the converted value is copied into the new **COleCurrency** object. If it is not, the value of the **COleCurrency** object is set to zero (0) and its status to invalid.  
  
-   `COleCurrency(` `nUnits`**,** `nFractionalUnits` **)** Constructs a **COleCurrency** object from the specified numerical components. If the absolute value of the fractional part is greater than 10,000, the appropriate adjustment is made to the units. Note that the units and fractional part are specified by signed long values.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) and [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following examples show the effects of the zero-parameter and two-parameter constructors:  
  
 [!code[NVC_MFCOleContainer#10](../vs140/codesnippet/CPP/colecurrency--colecurrency_1.cpp)]
  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::SetCurrency](../vs140/colecurrency--setcurrency.md)   
 [COleCurrency::operator =](../vs140/colecurrency--operator-=.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)   
 [COleCurrency::m_cur](../vs140/colecurrency--m_cur.md)   
 [COleCurrency::m_status](../vs140/colecurrency--m_status.md)