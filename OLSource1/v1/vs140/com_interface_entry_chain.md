---
title: "COM_INTERFACE_ENTRY_CHAIN"
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
  - "COM_INTERFACE_ENTRY_CHAIN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_CHAIN macro"
ms.assetid: 0eb40174-d703-4ce4-a424-d65c3aa7e7c5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_CHAIN
Processes the COM map of the base class when the processing reaches this entry in the COM map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *classname*  
 [in] A base class of the current object.  
  
## Remarks  
 For example, in the following code:  
  
 [!code[NVC_ATL_Windowing#116](../vs140/codesnippet/CPP/com_interface_entry_chain_1.h)]  
  
 Note that the first entry in the COM map must be an interface on the object containing the COM map. Thus, you cannot start your COM map entries with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, which causes the COM map of a different object to be searched at the point where **COM_INTERFACE_ENTRY_CHAIN(**<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>**)** appears in your object's COM map. If you want to search the COM map of another object first, add an interface entry for **IUnknown** to your COM map, then chain the other object's COM map. For example:  
  
 [!code[NVC_ATL_Windowing#111](../vs140/codesnippet/CPP/com_interface_entry_chain_2.h)]  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)