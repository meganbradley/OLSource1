---
title: "PX_DataPath"
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
  - "PX_DataPath"
  - "AFXCTL/PX_DataPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asynchronous controls"
  - "PX_DataPath function"
ms.assetid: 4f92bc38-908a-45e8-bbcf-39ae080faf2e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_DataPath
Call this function within your control's `DoPropExchange` member function to serialize or initialize a data path property of type [CDataPathProperty](../vs140/cdatapathproperty-class.md).  
  
## Syntax  
  
```  
  
      BOOL PX_DataPath(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   CDataPathProperty& dataPathProperty   
);  
BOOL PX_DataPath(  
   CPropExchange* pPX,  
   CDataPathProperty& dataPathProperty   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `dataPathProperty`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 Data path properties implement asynchronous control properties. The property's value will be read from or written to the variable referenced by `dataPathProperty`, as appropriate.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)