---
title: "AtlThrowLastWin32"
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
  - "ATL.AtlThrowLastWin32"
  - "ATL::AtlThrowLastWin32"
  - "AtlThrowLastWin32"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlThrowLastWin32 function"
ms.assetid: 8bce8e56-c7cd-4ebb-8c62-80ebc63a3d07
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlThrowLastWin32
Call this function to signal an error based on the result of the Windows function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This function traces the result of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the debugger.  
  
 If **_ATL_NO_EXCEPTIONS** is not defined in an MFC project, this function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or a [COleException](../vs140/coleexception-class.md) based on the value returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If **_ATL_NO_EXCEPTIONS** is not defined in an ATL project, the function throws a [CAtlException](../vs140/catlexception-class.md).  
  
 If **_ATL_NO_EXCEPTIONS** is defined, the function causes an assertion failure instead of throwing an exception.  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [ATLTRACE2](../vs140/atltrace2.md)   
 [AtlThrow](../vs140/atlthrow.md)   
 [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360)