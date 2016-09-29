---
title: "PX_Currency"
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
  - "AFXCTL/PX_Currency"
  - "PX_Currency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_Currency function"
ms.assetid: edc7a469-7f3f-4c80-a15a-1a4a6d5c869b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_Currency
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type **currency**.  
  
## Syntax  
  
```  
  
      BOOL PX_Currency(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   CY& cyValue   
);  
BOOL PX_Currency(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   CY& cyValue,  
   CY cyDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `cyValue`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `cyDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value will be read from or written to the variable referenced by `cyValue`, as appropriate. If `cyDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)