---
title: "COM_INTERFACE_ENTRY_BREAK"
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
  - "COM_INTERFACE_ENTRY_BREAK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_BREAK macro"
ms.assetid: 90ed8f05-2044-44b3-804d-0beba92495f7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_BREAK
Causes your program to call [DebugBreak](http://msdn.microsoft.com/library/windows/desktop/ms679297) when the specified interface is queried for.  
  
## Syntax  
  
```  
  
COM_INTERFACE_ENTRY_BREAK(   
x  
 )  
  
```  
  
#### Parameters  
 *x*  
 [in] Text used to construct the interface identifier.  
  
## Remarks  
 The interface IID will be constructed by appending *x* to `IID_`. For example, if *x* is `IPersistStorage`, the IID will be `IID_IPersistStorage`.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)