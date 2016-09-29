---
title: "PX_UShort"
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
  - "AFXCTL/PX_UShort"
  - "PX_UShort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_UShort function"
ms.assetid: c34cfb78-36a6-4fbe-b0ff-1f6120c5abc1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_UShort
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type `unsigned` **short**.  
  
## Syntax  
  
```  
  
      BOOL PX_UShort(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   USHORT& usValue   
);  
BOOL PX_UShort(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   USHORT& usValue,  
   USHORT usDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 Name of the property being exchanged.  
  
 *usValue*  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 *usDefault*  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by *usValue*, as appropriate. If *usDefault* is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)