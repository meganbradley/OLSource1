---
title: "COM_INTERFACE_ENTRY2"
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
  - "COM_INTERFACE_ENTRY2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM_INTERFACE_ENTRY2 macro"
ms.assetid: 3d48c53b-827b-42cc-9e22-594f7ea2bf0b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM_INTERFACE_ENTRY2
Use this macro to disambiguate two branches of inheritance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 [in] The name of an interface you want to expose from your object.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The name of the inheritance branch from which *x* is exposed.  
  
## Remarks  
 For example, if you derive your class object from two dual interfaces, you expose <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> since <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be obtained from either one of the interfaces.  
  
 See [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md) for remarks about COM map entries.  
  
## Example  
 [!code[NVC_ATL_Windowing#118](../vs140/codesnippet/CPP/com_interface_entry2_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../vs140/com-map-macros.md)   
 [Macros](../vs140/atl-macros.md)