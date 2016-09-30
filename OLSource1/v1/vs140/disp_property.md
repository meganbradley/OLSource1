---
title: "DISP_PROPERTY"
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
  - "AFXDISP/DISP_PROPERTY"
  - "DISP_PROPERTY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_PROPERTY macro"
ms.assetid: c002a77d-3a55-42c0-91a2-003f5557c0c7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_PROPERTY
Defines an OLE automation property in a dispatch map.  
  
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
 A value specifying the property's type.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument is of type **VARTYPE**. Possible values for this argument are taken from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> enumeration:  
  
|Symbol|**Property type**|  
|------------|-----------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|**DATE**|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|**VT_DISPATCH**|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
 When an external client changes the property, the value of the member variable specified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> changes; there is no notification of the change.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY_EX](../vs140/disp_property_ex.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)