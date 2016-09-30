---
title: "COleControl::GetAmbientProperty"
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
  - "COleControl.GetAmbientProperty"
  - "COleControl::GetAmbientProperty"
  - "GetAmbientProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientProperty method"
ms.assetid: b6a8c3b2-6f4f-48b0-9074-a3c86c4af025
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetAmbientProperty
Gets the value of an ambient property of the container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwDispid*  
 The dispatch ID of the desired ambient property.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A variant type tag that specifies the type of the value to be returned in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the address of the variable that will receive the property value or return value. The actual type of this pointer must match the type specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|vtProp|Type of pvProp|  
|------------|--------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|**BOOL\***|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|**CString\***|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|**short\***|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**long\***|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**float\***|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**double\***|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|**CY\***|  
|**VT_COLOR**|**OLE_COLOR\***|  
|**VT_DISPATCH**|**LPDISPATCH\***|  
|**VT_FONT**|**LPFONTDISP\***|  
  
## Return Value  
 Nonzero if the ambient property is supported; otherwise 0.  
  
## Remarks  
 If you use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to retrieve the ambient DisplayName and ScaleUnits properties, set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to **CString\***. If you are retrieving the ambient Font property, set <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to **VT_FONT** and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to **LPFONTDISP\***.  
  
 Note that functions have already been provided for common ambient properties, such as [AmbientBackColor](../vs140/colecontrol--ambientbackcolor.md) and [AmbientFont](../vs140/colecontrol--ambientfont.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::AmbientForeColor](../vs140/colecontrol--ambientforecolor.md)   
 [COleControl::AmbientScaleUnits](../vs140/colecontrol--ambientscaleunits.md)   
 [COleControl::AmbientShowGrabHandles](../vs140/colecontrol--ambientshowgrabhandles.md)