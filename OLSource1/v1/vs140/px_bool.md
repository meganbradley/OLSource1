---
title: "PX_Bool"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - PX_Bool
  - AFXCTL/PX_Bool
dev_langs: 
  - C++
helpviewer_keywords: 
  - PX_Bool function
ms.assetid: 1a59453b-9f23-47f8-9eb9-062b6ff34604
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PX_Bool
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type **BOOL**.  
  
## Syntax  
  
```  
  
      BOOL PX_Bool(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   BOOL& bValue   
);  
BOOL PX_Bool(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   BOOL& bValue,  
   BOOL bDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `bValue`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `bDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value will be read from or written to the variable referenced by `bValue`, as appropriate. If `bDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)