---
title: "AFX_GLOBAL_DATA::ExcludeTag"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ExcludeTag"
  - "AFX_GLOBAL_DATA.ExcludeTag"
  - "AFX_GLOBAL_DATA::ExcludeTag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExcludeTag method"
  - "AFX_GLOBAL_DATA::ExcludeTag"
ms.assetid: dc68cc0b-106e-4908-a0e0-92e6ab1d855e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::ExcludeTag
Removes the specified XML tag pair from a specified buffer.  
  
## Syntax  
  
```  
BOOL ExcludeTag(  
   CString& strBuffer,  
   LPCTSTR lpszTag,  
   CString& strTag,  
   BOOL bIsCharsList = FALSE  
);  
```  
  
#### Parameters  
 [in] `strBuffer`  
 A buffer of text.  
  
 [in] `lpszTag`  
 The name of a pair of opening and closing XML tags.  
  
 [out] `strTag`  
 When this method returns, the `strTag` parameter contains the text that is between the opening and closing XML tags that are named by the `lpszTag` parameter. Any leading or trailing whitespace is trimmed from the result.  
  
 [in] `bIsCharsList`  
 `TRUE` to convert symbols for escape characters in the `strTag` parameter into actual escape characters; `FALSE` not to perform the conversion.The default value is `FALSE`. For more information, see Remarks.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Remarks  
 An XML tag pair consists of named opening and closing tags that indicate the start and end of a run of text in the specified buffer. The `strBuffer` parameter specifies the buffer, and the `lpszTag` parameter specifies the name of the XML tags.  
  
 Use the symbols in the following table to encode a set of escape characters in the specified buffer. Specify `TRUE` for the `bIsCharsList` parameter to convert the symbols in the `strTag` parameter into actual escape characters. The following table uses the [_T()](../vs140/data-type-mappings.md) macro to specify the symbol and escape character strings.  
  
|Symbol|Escape character|  
|------------|----------------------|  
|_T("\\\t")|_T("\t")|  
|_T("\\\n")|_T("\n")|  
|_T("\\\r")|_T("\r")|  
|_T("\\\b")|_T("\b")|  
|_T("LT")|_T("<")|  
|_T("GT")|_T(">")|  
|_T("AMP")|_T("&")|  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Data Type Mappings](../vs140/data-type-mappings.md)