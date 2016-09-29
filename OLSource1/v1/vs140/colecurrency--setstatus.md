---
title: "COleCurrency::SetStatus"
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
  - "COleCurrency.SetStatus"
  - "COleCurrency::SetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStatus method"
  - "CurrencyStatus method"
ms.assetid: 630bef17-53c6-4aad-9147-1a1f478bdf20
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::SetStatus
Call this member function to set the status (validity) of this **COleCurrency** object.  
  
## Syntax  
  
```  
  
      void SetStatus(   
   CurrencyStatus status    
);  
```  
  
#### Parameters  
 *status*  
 The new status for this **COleCurrency** object.  
  
## Remarks  
 The *status* parameter value is defined by the `CurrencyStatus` enumerated type, which is defined within the **COleCurrency** class.  
  
 `enum CurrencyStatus{`  
  
 `valid = 0,`  
  
 `invalid = 1,`  
  
 `null = 2,`  
  
 `};`  
  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid** Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid** Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null** Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
    > [!CAUTION]
    >  This function is for advanced programming situations. This function does not alter the data in this object. It will most often be used to set the status to null or invalid. Note that the assignment operator ([operator =](../vs140/colecurrency--operator-=.md)) and [SetCurrency](../vs140/colecurrency--setcurrency.md) do set the status to of the object based on the source value(s).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)   
 [COleCurrency::operator =](../vs140/colecurrency--operator-=.md)   
 [COleCurrency::SetCurrency](../vs140/colecurrency--setcurrency.md)   
 [COleCurrency::m_status](../vs140/colecurrency--m_status.md)