---
title: "ConvertBSTRToString"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - ConvertBSTRToString
dev_langs: 
  - C++
helpviewer_keywords: 
  - ConvertBSTRToString function
ms.assetid: ab6ce555-3d75-4e9c-9cb8-ada6d8ce43b1
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ConvertBSTRToString
**Microsoft Specific**  
  
 Converts a `BSTR` value to a **char \***.  
  
## Syntax  
  
```  
  
      char* __stdcall ConvertBSTRToString(  
   BSTR pSrc  
);  
```  
  
#### Parameters  
 `pSrc`  
 A BSTR variable.  
  
## Remarks  
 `ConvertBSTRToString` allocates a string you must delete.  
  
## Example  
  
```  
// ConvertBSTRToString.cpp  
#include <comutil.h>  
#include <stdio.h>  
  
#pragma comment(lib, "comsuppw.lib")  
  
int main() {  
   BSTR bstrText = ::SysAllocString(L"Test");  
   wprintf_s(L"BSTR text: %s\n", bstrText);  
  
   char* lpszText2 = _com_util::ConvertBSTRToString(bstrText);  
   printf_s("char * text: %s\n", lpszText2);  
  
   SysFreeString(bstrText);  
   delete[] lpszText2;  
}  
```  
  
 **BSTR text: Test**  
**char \* text: Test**   
## END Microsoft Specific  
  
## Requirements  
 **Header:** comutil.h.  
  
 **Lib:** comsuppw.lib or comsuppwd.lib (see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) for more information)  
  
## See Also  
 [Compiler COM Global Functions](../vs140/compiler-com-global-functions.md)