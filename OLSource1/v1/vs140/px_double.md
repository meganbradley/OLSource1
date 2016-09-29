---
title: "PX_Double"
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
  - "PX_Double"
  - "AFXCTL/PX_Double"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_Double function"
ms.assetid: 58697394-d7b0-4eb6-95d7-34c1bd1c88b2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_Double
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property of type **double**.  
  
## Syntax  
  
```  
  
      BOOL PX_Double(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   double& doubleValue   
);  
BOOL PX_Double(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   double& doubleValue,  
   double doubleDefault   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `doubleValue`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `doubleDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by `doubleValue`, as appropriate. If `doubleDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [PX_Float](../vs140/px_float.md)   
 [PX_Short](../vs140/px_short.md)