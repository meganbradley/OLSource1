---
title: "PX_IUnknown"
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
  - "PX_IUnknown"
  - "AFXCTL/PX_IUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_IUnknown function"
ms.assetid: 0e202f80-1fba-4a24-8649-c067e758c3b0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_IUnknown
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property represented by an object having an **IUnknown**-derived interface.  
  
## Syntax  
  
```  
  
      BOOL PX_IUnknown(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   LPUNKNOWN& pUnk,  
   REFIID iid,  
   LPUNKNOWN pUnkDefault = NULL   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 *pUnk*  
 Reference to a variable containing the interface of the object that represents the value of the property.  
  
 `iid`  
 An interface ID indicating which interface of the property object is used by the control.  
  
 `pUnkDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by *pUnk*, as appropriate. If `pUnkDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)