---
title: "AtlReportError"
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
  - "ATL.AtlReportError"
  - "ATL::AtlReportError"
  - "AtlReportError"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlReportError function"
ms.assetid: 86b046a5-ea18-4ecf-9aab-40fc1eab847c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlReportError
Sets up the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface to provide error information to clients of the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The CLSID of the object reporting the error.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The string describing the error. The Unicode versions specify that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is of type **LPCOLESTR**; the ANSI version specifies a type of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The IID of the interface defining the error or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the error is defined by the operating system.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> you want returned to the caller.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an **ASSERT** will result if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] The help context identifier for the error.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] The path and name of the help file describing the error.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] The handle to the resource. By default, this parameter is **__AtlBaseModuleModule::GetResourceInstance**, where **__AtlBaseModuleModule** is the global instance of [CAtlBaseModule](../vs140/catlbasemodule-class.md) or a class derived from it.  
  
## Return Value  
 If the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter is nonzero, returns the value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is zero, then the first four versions of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The last two versions return the result of the macro **MAKE_HRESULT( 1, FACILITY_ITF,** <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> **)**.  
  
## Remarks  
 The string *lpszDesc* is used as the text description of the error. When the client receives the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> you return from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the client can access the **IErrorInfo** structure for details about the error.  
  
## Example  
 [!code[NVC_ATL_COM#52](../vs140/codesnippet/CPP/atlreporterror_1.cpp)]  
  
> [!CAUTION]
>  Do not use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in C++ catch handlers. Some overrides of these functions use the ATL string conversion macros internally, which in turn use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function internally. Using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in a C++ catch handler can cause exceptions in C++ catch handlers.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Debugging and Error Reporting Global Functions](../vs140/debugging-and-error-reporting-global-functions.md)   
 [MAKE_HRESULT](http://msdn.microsoft.com/library/windows/desktop/ms694497)