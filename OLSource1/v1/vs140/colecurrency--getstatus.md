---
title: "COleCurrency::GetStatus"
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
  - "COleCurrency::GetStatus"
  - "COleCurrency.GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CurrencyStatus method"
  - "GetStatus method"
ms.assetid: 3c0c8750-a598-4c4b-9e8b-28cf72dcb1ff
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::GetStatus
Call this member function to get the status (validity) of a given **COleCurrency** object.  
  
## Syntax  
  
```  
  
CurrencyStatus GetStatus( ) const;  
  
```  
  
## Return Value  
 Returns the status of this **COleCurrency** value.  
  
## Remarks  
 The return value is defined by the `CurrencyStatus` enumerated type that is defined within the **COleCurrency** class.  
  
 `enum CurrencyStatus{`  
  
 `valid = 0,`  
  
 `invalid = 1,`  
  
 `null = 2,`  
  
 `};`  
  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid** Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid** Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null** Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a **COleCurrency** object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or `COleVariant` value that could not be converted to a currency value.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, for example `+=` or **\*=**.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using [SetStatus](../vs140/colecurrency--setstatus.md).  
  
 For more information on operations that may set the status to invalid, see the following member functions:  
  
-   [COleCurrency](../vs140/colecurrency--colecurrency.md)  
  
-   [operator =](../vs140/colecurrency--operator-=.md)  
  
-   [operator +, -](../vs140/colecurrency--operator-----.md)  
  
-   [operator +=, -=](../vs140/colecurrency--operator--=---=.md)  
  
-   [operator *, /](../vs140/colecurrency--operator-----.md)  
  
-   [operator *=, /=](../vs140/colecurrency--operator--=---=.md)  
  
## Example  
 [!code[NVC_MFCOleContainer#12](../vs140/codesnippet/CPP/colecurrency--getstatus_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::SetStatus](../vs140/colecurrency--setstatus.md)   
 [COleCurrency::m_status](../vs140/colecurrency--m_status.md)