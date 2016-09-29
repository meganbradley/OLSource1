---
title: "_ATL_FUNC_INFO Structure"
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
  - "_ATL_FUNC_INFO"
  - "ATL::_ATL_FUNC_INFO"
  - "ATL._ATL_FUNC_INFO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATL_FUNC_INFO structure"
  - "ATL_FUNC_INFO structure"
ms.assetid: 441ebe2c-f971-47de-9f52-a258e8d6f88e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_FUNC_INFO Structure
Contains type information used to describe a method or property on a dispinterface.  
  
## Syntax  
  
```  
  
      struct _ATL_FUNC_INFO{  
   CALLCONV cc;  
   VARTYPE vtReturn;  
   SHORT nParams;  
   VARTYPE pVarTypes[_ATL_MAX_VARTYPES];  
};  
```  
  
## Members  
 **cc**  
 The calling convention. When using this structure with the [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) class, this member must be **CC_STDCALL**. `CC_CDECL` is the only option supported in Windows CE for the `CALLCONV` field of the `_ATL_FUNC_INFO` structure. Any other value is unsupported thus its behavior undefined.  
  
 **vtReturn**  
 The variant type of the function return value.  
  
 **nParams**  
 The number of function parameters.  
  
 **pVarTypes**  
 An array of variant types of the function parameters.  
  
## Remarks  
 Internally, ATL uses this structure to hold information obtained from a type library. You may need to manipulate this structure directly if you provide type information for an event handler used with the [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) class and [SINK_ENTRY_INFO](../vs140/sink_entry_info.md) macro.  
  
## Example  
 Given a dispinterface method defined in IDL:  
  
 [!code[NVC_ATL_Windowing#139](../vs140/codesnippet/CPP/_atl_func_info-structure_1.idl)]  
  
 you would define an `_ATL_FUNC_INFO` structure:  
  
 [!code[NVC_ATL_Windowing#140](../vs140/codesnippet/CPP/_atl_func_info-structure_2.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Structures](../vs140/atl-structures.md)   
 [IDispEventSimpleImpl Class](../vs140/idispeventsimpleimpl-class.md)   
 [SINK_ENTRY_INFO](../vs140/sink_entry_info.md)