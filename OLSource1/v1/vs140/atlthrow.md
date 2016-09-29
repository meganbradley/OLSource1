---
title: "AtlThrow"
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
  - "ATL.AtlThrow"
  - "AtlThrow"
  - "ATL::AtlThrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlThrow function"
ms.assetid: 2bd111da-8170-488d-914a-c9bf6b6765f7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlThrow
Call this function to signal an error based on a `HRESULT` status code.  
  
## Syntax  
  
```  
__declspec(noreturn) inline void AtlThrow(  
   HRESULT hr  
);  
```  
  
#### Parameters  
 `hr`  
 Standard HRESULT value.  
  
## Remarks  
 This function is used by ATL and MFC code in the event of an error condition. It can also be called from your own code. The default implementation of this function depends on the definition of the symbol **_ATL_NO_EXCEPTIONS** and on the type of project, MFC or ATL.  
  
 In all cases, this function traces the HRESULT to the debugger.  
  
 In Visual Studio 2015 Update 3 and later, this function is attributed __declspec(noreturn) to avoid spurious SAL warnings.  
  
 If **_ATL_NO_EXCEPTIONS** is not defined in an MFC project, this function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or a [COleException](../vs140/coleexception-class.md) based on the value of the HRESULT.  
  
 If **_ATL_NO_EXCEPTIONS** is not defined in an ATL project, the function throws a [CAtlException](../vs140/catlexception-class.md).  
  
 If **_ATL_NO_EXCEPTIONS** is defined, the function causes an assertion failure instead of throwing an exception.  
  
 For ATL projects, it is possible to provide your own implementation of this function to be used by ATL in the event of a failure. To do this, define your own function with the same signature as `AtlThrow` and #define `AtlThrow` to be the name of your function. This must be done before including atlexcept.h (which means that it must be done prior to including any ATL headers since atlbase.h includes atlexcept.h). Attribute your function `__declspec(noreturn)` to avoid spurious SAL warnings.  
  
## Example  
 [!code[NVC_ATL_Windowing#95](../vs140/codesnippet/CPP/atlthrow_1.h)]  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [CAtlException Class](../vs140/catlexception-class.md)   
 [ATLTRACE2](../vs140/atltrace2.md)   
 [CMemoryException Class](../vs140/cmemoryexception-class.md)   
 [COleException Class](../vs140/coleexception-class.md)   
 [AtlThrowLastWin32](../vs140/atlthrowlastwin32.md)