---
title: "COM_INTERFACE_ENTRY_NOINTERFACE"
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
  - "COM_INTERFACE_ENTRY_NOINTERFACE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY_NOINTERFACE macro"
ms.assetid: 14a9e65f-bb02-4d48-9eba-c32b8a71b0e0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY_NOINTERFACE
Returns **E_NOINTERFACE** and terminates COM map processing when the specified interface is queried for.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 [in] Text used to construct the interface identifier.  
  
## Remarks  
 You can use this macro to prevent an interface from being used in a particular case. For example, you can insert this macro into your COM map right before <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to prevent a query for the interface from being forwarded to the aggregate's inner unknown.  
  
 The interface IID will be constructed by appending *x* to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For example, if *x* is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the IID will be <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)