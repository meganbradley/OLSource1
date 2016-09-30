---
title: "DISP_PROPERTY_NOTIFY"
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
  - "DISP_PROPERTY_NOTIFY"
  - "AFXDISP/DISP_PROPERTY_NOTIFY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_PROPERTY_NOTIFY macro"
ms.assetid: 2c22c48d-ab55-4b21-a545-a125546a6512
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_PROPERTY_NOTIFY
Defines an OLE automation property with notification in a dispatch map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 External name of the property.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Name of the member variable in which the property is stored.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of the notification function for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value specifying the property's type.  
  
## Remarks  
 Unlike properties defined with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, a property defined with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will automatically call the function specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> when the property is changed.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument is of type **VARTYPE**. Possible values for this argument are taken from the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> enumeration:  
  
|Symbol|**Property type**|  
|------------|-----------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|**DATE**|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|**VT_DISPATCH**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)