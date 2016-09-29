---
title: "PX_ULong"
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
  - "PX_ULong"
  - "AFXCTL/PX_ULong"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_ULong function"
ms.assetid: 0d9effeb-9313-48a3-99b5-f4eb7c5c8e12
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_ULong
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type **ULONG**.  
  
## Syntax  
  
```  
  
      BOOL PX_ULong(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   ULONG& ulValue   
);  
BOOL PX_ULong(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   ULONG& ulValue,  
   long ulDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 Name of the property being exchanged.  
  
 `ulValue`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `ulDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by `ulValue`, as appropriate. If `ulDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)