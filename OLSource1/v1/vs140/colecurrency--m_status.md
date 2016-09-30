---
title: "COleCurrency::m_status"
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
  - "COleCurrency.m_status"
  - "CurrencyStatus"
  - "m_status"
  - "COleCurrency::m_status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CurrencyStatus method"
  - "COleCurrency class, data members"
  - "m_status"
ms.assetid: 5caf9bba-b628-4a35-b573-cfd05d48d043
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::m_status
The type of this data member is the enumerated type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, which is defined within the **COleCurrency** class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid** Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid** Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null** Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a **COleCurrency** object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value that could not be converted to a currency value.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, for example <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or **\*=**.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using [SetStatus](../vs140/colecurrency--setstatus.md).  
  
 For more information on operations that may set the status to invalid, see the following member functions:  
  
-   [COleCurrency](../vs140/colecurrency--colecurrency.md)  
  
-   [operator =](../vs140/colecurrency--operator-=.md)  
  
-   [operator +, -](../vs140/colecurrency--operator-----.md)  
  
-   [operator +=, -=](../vs140/colecurrency--operator--=---=.md)  
  
-   [operator *, /](../vs140/colecurrency--operator-----.md)  
  
-   [operator *=, /=](../vs140/colecurrency--operator--=---=.md)  
  
    > [!CAUTION]
    >  This data member is for advanced programming situations. You should use the inline member functions [GetStatus](../vs140/colecurrency--getstatus.md) and [SetStatus](../vs140/colecurrency--setstatus.md). See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for further cautions regarding explicitly setting this data member.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)   
 [COleCurrency::SetStatus](../vs140/colecurrency--setstatus.md)