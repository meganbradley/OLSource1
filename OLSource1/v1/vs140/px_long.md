---
title: "PX_Long"
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
  - AFXCTL/PX_Long
  - PX_Long
dev_langs: 
  - C++
helpviewer_keywords: 
  - PX_Long function
ms.assetid: f1ba2daf-187c-405d-a6de-6e62c843f8bf
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PX_Long
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type **long**.  
  
## Syntax  
  
```  
  
      BOOL PX_Long(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   long& lValue   
);  
BOOL PX_Long(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   long& lValue,  
   long lDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `lValue`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `lDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by `lValue`, as appropriate. If `lDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)