---
title: "MODULE_INFO_FLAGS"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - MODULE_INFO_FLAGS
helpviewer_keywords: 
  - MODULE_INFO_FLAGS enumeration
ms.assetid: e22d3723-b4d4-4524-8a2f-3adb55bbd273
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# MODULE_INFO_FLAGS
Specifies the state of symbols for a module.  
  
## Syntax  
  
```cpp#  
enum enum_MODULE_INFO_FLAGS {  
   MIF_SYMBOLS_LOADED = 0x0001  
};  
typedef DWORD MODULE_INFO_FLAGS;  
```  
  
```c#  
public enum enum_MODULE_INFO_FLAGS {  
   MIF_SYMBOLS_LOADED = 0x0001  
};  
```  
  
## Members  
 MIF_SYMBOLS_LOADED  
 At least one set of symbols was loaded by the module (otherwise no symbols were loaded).  
  
## Remarks  
 This value is returned by the [IDebugSymbolSearchEvent2::GetSymbolSearchInfo](../vs140/idebugsymbolsearchevent2--getsymbolsearchinfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugSymbolSearchEvent2::GetSymbolSearchInfo](../vs140/idebugsymbolsearchevent2--getsymbolsearchinfo.md)