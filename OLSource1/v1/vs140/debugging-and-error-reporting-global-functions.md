---
title: "Debugging and Error Reporting Global Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "functions [ATL], error reporting"
ms.assetid: 11339c02-98cd-428d-b3b9-7deeb155a6a3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging and Error Reporting Global Functions
These functions provide useful debugging and trace facilities.  
  
|||  
|-|-|  
|[AtlHresultFromLastError](../vs140/atlhresultfromlasterror.md)|Returns a                             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> error code in the form of an HRESULT.|  
|[AtlHresultFromWin32](../vs140/atlhresultfromwin32.md)|Converts a Win32 error code into an HRESULT.|  
|[AtlReportError](../vs140/atlreporterror.md)|Sets up                             **IErrorInfo** to provide error details to a client.|  
|[AtlThrow](../vs140/atlthrow.md)|Throws a                             <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[AtlThrowLastWin32](../vs140/atlthrowlastwin32.md)|Call this function to signal an error based on the result of the Windows function                             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[AtlTraceLoadSettings](../vs140/atltraceloadsettings.md)|Call this function to load trace settings from a file.|  
|[AtlTraceSaveSettings](../vs140/atltracesavesettings.md)|Call this function to save the current trace settings to a file.|  
  
##  \<a name="atlhresultfromlasterror">\</a>  AtlHresultFromLastError  
 Returns the calling thread's last-error code value in the form of an HRESULT.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> calls                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to obtain the last error and returns the error after converting it to an HRESULT using the                         **HRESULT_FROM_WIN32** macro.  
  
##  \<a name="atlhresultfromwin32">\</a>  AtlHresultFromWin32  
 Converts a Win32 error code into an HRESULT.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *error*  
 The error value to convert.  
  
### Remarks  
 Converts a Win32 error code into an HRESULT, using the macro                         **HRESULT_FROM_WIN32**.  
  
> [!NOTE]
>  Instead of using                             **HRESULT_FROM_WIN32(GetLastError())**, use the function                             [AtlHresultFromLastError](../vs140/atlhresultfromlasterror.md).  
  
##  \<a name="atlreporterror">\</a>  AtlReportError  
 Sets up the                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface to provide error information to clients of the object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The CLSID of the object reporting the error.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] The string describing the error. The Unicode versions specify that                                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is of type                                 **LPCOLESTR**; the ANSI version specifies a type of                                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] The IID of the interface defining the error or                                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if the error is defined by the operating system.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 [in] The                                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> you want returned to the caller.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an                                 **ASSERT** will result if                                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 [in] The help context identifier for the error.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 [in] The path and name of the help file describing the error.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 [in] The handle to the resource. By default, this parameter is                                 **__AtlBaseModuleModule::GetResourceInstance**, where                                 **__AtlBaseModuleModule** is the global instance of                                 [CAtlBaseModule](../vs140/catlbasemodule-class.md) or a class derived from it.  
  
### Return Value  
 If the                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter is nonzero, returns the value of                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is zero, then the first four versions of                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> return                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The last two versions return the result of the macro                         **MAKE_HRESULT( 1, FACILITY_ITF,** <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> **)**.  
  
### Remarks  
 The string                         *lpszDesc* is used as the text description of the error. When the client receives the                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> you return from                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the client can access the                         **IErrorInfo** structure for details about the error.  
  
### Example  
 [!code[NVC_ATL_COM#52](../vs140/codesnippet/CPP/debugging-and-error-reporting-global-functions_1.cpp)]  
  
> [!CAUTION]
>  Do not use                                     <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in C++ catch handlers. Some overrides of these functions use the ATL string conversion macros internally, which in turn use the                                     <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function internally. Using                                     <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in a C++ catch handler can cause exceptions in C++ catch handlers.  
  
##  \<a name="atlthrow">\</a>  AtlThrow  
 Call this function to signal an error based on a                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> status code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Standard HRESULT value.  
  
### Remarks  
 This function is used by ATL and MFC code in the event of an error condition. It can also be called from your own code. The default implementation of this function depends on the definition of the symbol                         **_ATL_NO_EXCEPTIONS** and on the type of project, MFC or ATL.  
  
 In all cases, this function traces the HRESULT to the debugger.  
  
 In Visual Studio 2015 Update 3 and later, this function is attributed __declspec(noreturn) to avoid spurious SAL warnings.  
  
 If                         **_ATL_NO_EXCEPTIONS** is not defined in an MFC project, this function throws a                         [CMemoryException](../vs140/cmemoryexception-class.md) or a                         [COleException](../vs140/coleexception-class.md) based on the value of the HRESULT.  
  
 If                         **_ATL_NO_EXCEPTIONS** is not defined in an ATL project, the function throws a                         [CAtlException](../vs140/catlexception-class.md).  
  
 If                         **_ATL_NO_EXCEPTIONS** is defined, the function causes an assertion failure instead of throwing an exception.  
  
 For ATL projects, it is possible to provide your own implementation of this function to be used by ATL in the event of a failure. To do this, define your own function with the same signature as                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and #define                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to be the name of your function. This must be done before including atlexcept.h (which means that it must be done prior to including any ATL headers since atlbase.h includes atlexcept.h). Attribute your function                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to avoid spurious SAL warnings.  
  
### Example  
 [!code[NVC_ATL_Windowing#95](../vs140/codesnippet/CPP/debugging-and-error-reporting-global-functions_2.h)]  
  
##  \<a name="atlthrowlastwin32">\</a>  AtlThrowLastWin32  
 Call this function to signal an error based on the result of the Windows function                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This function traces the result of                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to the debugger.  
  
 If                         **_ATL_NO_EXCEPTIONS** is not defined in an MFC project, this function throws a                         [CMemoryException](../vs140/cmemoryexception-class.md) or a                         [COleException](../vs140/coleexception-class.md) based on the value returned by                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 If                         **_ATL_NO_EXCEPTIONS** is not defined in an ATL project, the function throws a                         [CAtlException](../vs140/catlexception-class.md).  
  
 If                         **_ATL_NO_EXCEPTIONS** is defined, the function causes an assertion failure instead of throwing an exception.  
  
## See Also  
 [ATL Functions](../vs140/atl-functions.md)   
 [Debugging and Error Reporting Macros](../vs140/debugging-and-error-reporting-macros.md)