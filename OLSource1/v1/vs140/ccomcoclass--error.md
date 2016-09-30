---
title: "CComCoClass::Error"
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
  - "CComCoClass.Error"
  - "ATL::CComCoClass::Error"
  - "ATL.CComCoClass.Error"
  - "Error"
  - "CComCoClass::Error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Error method"
ms.assetid: 4de82384-550c-43fc-81ea-c5f19e65739d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCoClass::Error
This static function sets up the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface to provide error information to the client.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The string describing the error. The Unicode version of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is of type **LPCOLESTR**; the ANSI version specifies a type of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The IID of the interface defining the error or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (the default value) if the error is defined by the operating system.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> you want returned to the caller. The default value is 0. For more details about <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, see Remarks.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an **ASSERT** will result if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] The help context identifier for the error.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] The path and name of the help file describing the error.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] The handle to the resource. By default, this parameter is **_AtlModule::GetResourceInstance**, where **_AtlModule** is the global instance of [CAtlModule](../vs140/catlmodule-class.md).  
  
## Return Value  
 A standard <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value. For details, see Remarks.  
  
## Remarks  
 To call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, your object must implement the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface.  
  
 If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter is nonzero, then <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns the value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is zero, then the first four versions of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The last two versions return the result of the macro **MAKE_HRESULT( 1, FACILITY_ITF,** <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> **)**.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCoClass Class](../vs140/ccomcoclass-class.md)   
 [ISupportErrorInfoImpl Class](../vs140/isupporterrorinfoimpl-class.md)   
 [MAKE_HRESULT](http://msdn.microsoft.com/library/windows/desktop/ms694497)