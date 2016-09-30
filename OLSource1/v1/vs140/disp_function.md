---
title: "DISP_FUNCTION"
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
  - "DISP_FUNCTION"
  - "AFXDISP/DISP_FUNCTION"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_FUNCTION macro"
ms.assetid: 8a1c666b-304b-4641-ab20-4f1a6d3c2d2e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_FUNCTION
Defines an OLE automation function in a dispatch map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 External name of the function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Name of the member function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value specifying the function's return type.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A space-separated list of one or more constants specifying the function's parameter list.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument is of type **VARTYPE**. The following possible values for this argument are taken from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> enumeration:  
  
|Symbol|Return type|  
|------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|**DATE**|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|**VT_DISPATCH**|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example,  
  
 [!code[NVC_MFCAutomation#14](../vs140/codesnippet/CPP/disp_function_1.cpp)]  
  
 specifies a list containing a short integer followed by a pointer to a short integer.  
  
 The **VTS_** constants and their meanings are as follows:  
  
|Symbol|Parameter type|  
|------------|--------------------|  
|**VTS_I2**|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|**VTS_I4**|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|**VTS_R4**|**Float**|  
|**VTS_R8**|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|**VTS_CY**|**const CY** or **CY\***|  
|**VTS_DATE**|**DATE**|  
|**VTS_BSTR**|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|**VTS_DISPATCH**|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|**VTS_SCODE**|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|**VTS_BOOL**|**BOOL**|  
|**VTS_VARIANT**|**const VARIANT\*** or **VARIANT&**|  
|**VTS_UNKNOWN**|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|**VTS_PI2**|**short\***|  
|**VTS_PI4**|**long\***|  
|**VTS_PR4**|**float\***|  
|**VTS_PR8**|**double\***|  
|**VTS_PCY**|**CY\***|  
|**VTS_PDATE**|**DATE\***|  
|**VTS_PBSTR**|**BSTR\***|  
|**VTS_PDISPATCH**|**LPDISPATCH\***|  
|**VTS_PSCODE**|**SCODE\***|  
|**VTS_PBOOL**|**BOOL\***|  
|**VTS_PVARIANT**|**VARIANT\***|  
|**VTS_PUNKNOWN**|**LPUNKNOWN\***|  
|**VTS_NONE**|No parameters|  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_PROPERTY_EX](../vs140/disp_property_ex.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)