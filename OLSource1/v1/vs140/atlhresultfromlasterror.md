---
title: "AtlHresultFromLastError"
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
  - "ATL.AtlHresultFromLastError"
  - "AtlHresultFromLastError"
  - "ATL::AtlHresultFromLastError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHresultFromLastError function"
ms.assetid: 74530d7d-3c91-484c-acf3-aff755715d66
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHresultFromLastError
Returns the calling thread's last-error code value in the form of an HRESULT.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to obtain the last error and returns the error after converting it to an HRESULT using the **HRESULT_FROM_WIN32** macro.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360)   
 [HRESULT_FROM_WIN32](http://msdn.microsoft.com/library/windows/desktop/ms680746)   
 [AtlHresultFromWin32](../vs140/atlhresultfromwin32.md)