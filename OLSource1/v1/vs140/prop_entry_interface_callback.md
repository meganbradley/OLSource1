---
title: "PROP_ENTRY_INTERFACE_CALLBACK"
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
  - "PROP_ENTRY_INTERFACE_CALLBACK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROP_ENTRY_INTERFACE_CALLBACK macro"
ms.assetid: 9a1f1e9c-d0a0-4f60-b9b2-72c28e7e80cd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROP_ENTRY_INTERFACE_CALLBACK
Lets you enter a property description and property DISPID, and provide a callback function to determine whether any CLSID should be added to the property map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The property description.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The DISPID of the property.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The CLSID of the associated property page. Use the special value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a property that does not have an associated property page.  
  
 [in]<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The callback function that controls data during the loading process.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the property.  
  
## Remarks  
 Include this macro to give an application more control over the [IPersistStreamInitImpl::Load](../vs140/ipersiststreaminitimpl--load.md) process. The callback function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is retrieving data from a non-trusted stream. The callback function filters the data and controls which objects are loaded.  
  
 This macro only applies if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a base class and the class is advertised as safe for initializing. Otherwise, you should not use this macro.  
  
 This macro is only valid if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Passing in a different value for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to this macro will cause a compilation error. For any other value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, use [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md).  
  
 The [BEGIN_PROP_MAP](../vs140/begin_prop_map.md) macro marks the beginning of the property map; the [END_PROP_MAP](../vs140/end_prop_map.md) macro marks the end.  
  
 If you are creating a web control that needs to be initialized, you should use the [IPersistPropertyBagImpl Class](../vs140/ipersistpropertybagimpl-class.md) instead of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to initialize properties. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> possess a greater risk in binary format than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [BEGIN_PROP_MAP](../vs140/begin_prop_map.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)   
 [PROP_ENTRY_INTERFACE](../vs140/prop_entry_interface.md)   
 [PROP_ENTRY_INTERFACE_EX](../vs140/prop_entry_interface_ex.md)   
 [PROP_ENTRY_INTERFACE_CALLBACK_EX](../vs140/prop_entry_interface_callback_ex.md)   
 [PROP_ENTRY_TYPE](../vs140/prop_entry_type.md)   
 [PROP_ENTRY_TYPE_EX](../vs140/prop_entry_type_ex.md)