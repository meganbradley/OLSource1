---
title: "DisplayKind"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "DisplayKind enumeration"
ms.assetid: 940968c5-6065-4bda-8ee6-c31597db4d71
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DisplayKind
Enumerates the valid values that represent the kinds of information to take from an [IDebugField](../vs140/idebugfield.md) object and display to the user.  
  
## Syntax  
  
```cpp#  
enum enum_DisplayKind  
{  
   DisplayKind_Value = 0x1,  
   DisplayKind_Name = 0x2,  
   DisplayKind_Type = 0x3,  
};  
typedef DWORD DisplayKind;  
```  
  
```c#  
public enum enum_DisplayKind  
{  
   DisplayKind_Value = 0x1,  
   DisplayKind_Name = 0x2,  
   DisplayKind_Type = 0x3,  
};  
```  
  
#### Parameters  
 DisplayKind_Value  
 Value of the field.  
  
 DisplayKind_Name  
 Name of the field.  
  
 DisplayKind_Type  
 Type of field.  
  
## Requirements  
 Header: Ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IEEVisualizerService::GetValueDisplayStringCount](../vs140/ieevisualizerservice--getvaluedisplaystringcount.md)