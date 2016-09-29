---
title: "ATLENSURE"
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
  - "ATLENSURE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLENSURE"
ms.assetid: 41d47432-5e73-432e-8ab7-acaf8fde3ffb
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLENSURE
This macro is used to validate parameters passed to a function.  
  
## Syntax  
  
```  
  
      ATLENSURE(  
      booleanExpression  
      );  
ATLENSURE_THROW(booleanExpression, hr);  
```  
  
#### Parameters  
 `booleanExpression`  
 Specifies a boolean expression to be tested.  
  
 `hr`  
 Specifies an error code to return.  
  
## Remarks  
 These macros provide a mechanism to detect and notify the user of incorrect parameter usage.  
  
 The macro calls `ATLASSERT` and if the condition fails calls `AtlThrow`.  
  
 In the **ATLENSURE** case, `AtlThrow` is called with E_FAIL.  
  
 In the **ATLENSURE_THROW** case, `AtlThrow` is called with the specified HRESULT.  
  
 The difference between **ATLENSURE** and `ATLASSERT` is that **ATLENSURE** throws an exception in Release builds as well as in Debug builds.  
  
## Example  
 [!code[NVC_ATL_Utilities#108](../VS_csharp/codesnippet/CPP/atlensure_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Debugging and Error Reporting Macros](../VS_csharp/debugging-and-error-reporting-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [ATLASSERT](../VS_csharp/atlassert.md)   
 [ENSURE (MFC)](../VS_csharp/ensure--mfc-.md)