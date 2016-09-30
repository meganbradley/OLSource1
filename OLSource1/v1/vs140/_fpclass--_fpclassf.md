---
title: "_fpclass, _fpclassf"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_fpclass"
  - "_fpclassf"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fpclass"
  - "_fpclass"
  - "_fpclassf"
  - "math/_fpclass"
  - "float/_fpclass"
  - "math/_fpclassf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fpclass function"
  - "floating-point numbers, IEEE representation"
  - "_fpclass function"
  - "_fpclassf function"
ms.assetid: 2774872d-3543-446f-bc72-db85f8b95a6b
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _fpclass, _fpclassf
Returns a value indicating the floating-point classification of the argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The floating-point value to test.  
  
## Return Value  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return an integer value that indicates the floating-point classification of the argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The classification may have one of the following values, defined in \<float.h>.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Signaling NaN|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Quiet NaN|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Negative infinity ( –INF)|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Negative normalized non-zero|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Negative denormalized|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Negative zero ( – 0)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Positive 0 (+0)|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Positive denormalized|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Positive normalized non-zero|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Positive infinity (+INF)|  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions are Microsoft specific. They are similar to [fpclassify](../vs140/fpclassify.md), but return more detailed information about the argument. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function is only available when compiled for the x64 platform.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<float.h>|  
  
 For more compatibility and conformance information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [isnan, _isnan, _isnanf](../vs140/isnan--_isnan--_isnanf.md)   
 [fpclassify](../vs140/fpclassify.md)