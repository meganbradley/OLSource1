---
title: "AtlHresultFromWin32"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::AtlHresultFromWin32
  - AtlHresultFromWin32
  - ATL.AtlHresultFromWin32
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlHresultFromWin32 function
ms.assetid: 63add2dd-274c-4e72-a98c-040b93413a2f
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlHresultFromWin32
Converts a Win32 error code into an HRESULT.  
  
## Syntax  
  
```  
  
      AtlHresultFromWin32{  
   DWORD error  
};  
```  
  
#### Parameters  
 *error*  
 The error value to convert.  
  
## Remarks  
 Converts a Win32 error code into an HRESULT, using the macro **HRESULT_FROM_WIN32**.  
  
> [!NOTE]
>  Instead of using **HRESULT_FROM_WIN32(GetLastError())**, use the function [AtlHresultFromLastError](../vs140/atlhresultfromlasterror.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [HRESULT_FROM_WIN32](http://msdn.microsoft.com/library/windows/desktop/ms680746)   
 [AtlHresultFromLastError](../vs140/atlhresultfromlasterror.md)