---
title: "COleControl::FireEvent"
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
  - "FireEvent"
  - "COleControl::FireEvent"
  - "COleControl.FireEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireEvent method, syntax"
  - "FireEvent method"
ms.assetid: 2dad053d-8e96-43cb-94df-531b554553cc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireEvent
Fires a user-defined event from your control with any number of optional arguments,.  
  
## Syntax  
  
```  
  
      void AFX_CDECL FireEvent(  
   DISPID dispid,  
   BYTE* pbParams,  
   ...   
);  
```  
  
#### Parameters  
 `dispid`  
 The dispatch ID of the event to be fired.  
  
 `pbParams`  
 A descriptor for the event's parameter types.  
  
## Remarks  
 Usually this function should not be called directly. Instead you will call the event-firing functions in the event map section of your control's class declaration.  
  
 The `pbParams` argument is a space-separated list of **VTS_**. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are as follows:  
  
|Symbol|Parameter type|  
|------------|--------------------|  
|**VTS_COLOR**|**OLE_COLOR**|  
|**VTS_FONT**|**IFontDisp\***|  
|**VTS_HANDLE**|`HWND`|  
|**VTS_PICTURE**|**IPictureDisp\***|  
|**VTS_OPTEXCLUSIVE**|**OLE_OPTEXCLUSIVE\***|  
|**VTS_TRISTATE**|**OLE_TRISTATE**|  
|**VTS_XPOS_HIMETRIC**|**OLE_XPOS_HIMETRIC**|  
|**VTS_YPOS_HIMETRIC**|**OLE_YPOS_HIMETRIC**|  
|**VTS_XPOS_PIXELS**|**OLE_XPOS_PIXELS**|  
|**VTS_YPOS_PIXELS**|**OLE_YPOS_PIXELS**|  
|**VTS_XSIZE_PIXELS**|**OLE_XSIZE_PIXELS**|  
|**VTS_YSIZE_PIXELS**|**OLE_XSIZE_PIXELS**|  
|**VTS_XSIZE_HIMETRIC**|**OLE_XSIZE_HIMETRIC**|  
|**VTS_YSIZE_HIMETRIC**|**OLE_XSIZE_HIMETRIC**|  
  
> [!NOTE]
>  Additional variant constants have been defined for all variant types, with the exception of **VTS_FONT** and **VTS_PICTURE**, that provide a pointer to the variant data constant. These constants are named using the **VTS_P**`constantname` convention. For example, **VTS_PCOLOR** is a pointer to a **VTS_COLOR** constant.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)