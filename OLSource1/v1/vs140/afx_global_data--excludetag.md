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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A buffer of text.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a pair of opening and closing XML tags.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When this method returns, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter contains the text that is between the opening and closing XML tags that are named by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter. Any leading or trailing whitespace is trimmed from the result.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to convert symbols for escape characters in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter into actual escape characters; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> not to perform the conversion.The default value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see Remarks.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 An XML tag pair consists of named opening and closing tags that indicate the start and end of a run of text in the specified buffer. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter specifies the buffer, and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter specifies the name of the XML tags.  
  
 Use the symbols in the following table to encode a set of escape characters in the specified buffer. Specify <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter to convert the symbols in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter into actual escape characters. The following table uses the [_T()](../vs140/data-type-mappings.md) macro to specify the symbol and escape character strings.  
  
|Symbol|Escape character|  
|------------|----------------------|  
|_T("\\\t")|_T("\t")|  
|_T("\\\n")|_T("\n")|  
|_T("\\\r")|_T("\r")|  
|_T("\\\b")|_T("\b")|  
|_T("LT")|_T("\<")|  
|_T("GT")|_T(">")|  
|_T("AMP")|_T("&")|  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Data Type Mappings](../vs140/data-type-mappings.md)