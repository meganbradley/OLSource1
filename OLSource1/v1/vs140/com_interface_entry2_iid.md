---
title: "COM_INTERFACE_ENTRY2_IID"
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
  - "COM_INTERFACE_ENTRY2_IID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY2_IID macro"
ms.assetid: cd14fad1-d55b-4088-bb87-55b9d896e598
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY2_IID
Same as [COM_INTERFACE_ENTRY2](../vs140/com_interface_entry2.md), except you can specify a different IID.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY2_IID(   
iid  
,   
x  
,   
x2  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID you are specifying for the interface.  
  
 *x*  
 [in] The name of an interface that your class object derives from directly.  
  
 `x2`  
 [in] The name of a second interface that your class object derives from directly.  
  
## Remarks  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)