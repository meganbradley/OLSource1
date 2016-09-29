---
title: "COM_INTERFACE_ENTRY_IID"
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
  - "COM_INTERFACE_ENTRY_IID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_IID macro"
ms.assetid: 1bb69549-2099-4e20-ad5e-4c5a32f44e4b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_IID
Use this macro to enter the interface into the COM map and specify its IID.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_IID(   
iid  
,   
x  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the interface exposed.  
  
 *x*  
 [in] The name of the class whose vtable will be exposed as the interface identified by `iid`.  
  
## Remarks  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#117](../vs140/codesnippet/CPP/com_interface_entry_iid_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)