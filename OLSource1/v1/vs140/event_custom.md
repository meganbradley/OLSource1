---
title: "EVENT_CUSTOM"
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
  - "EVENT_CUSTOM"
  - "AFXCTL/EVENT_CUSTOM"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EVENT_CUSTOM macro"
ms.assetid: a8263bb6-0659-435c-878a-b5d069b6bd9a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EVENT_CUSTOM
Defines an event-map entry for a custom event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the event.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the event firing function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A space-separated list of one or more constants specifying the function's parameter list.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example:  
  
 [!code[NVC_MFCActiveXControl#13](../vs140/codesnippet/CPP/event_custom_1.cpp)]  
  
 specifies a list containing a 32-bit integer representing an RGB color value, followed by a pointer to the **IFontDisp** interface of an OLE font object.  
  
 The **VTS_** constants and their meanings are as follows:  
  
|Symbol|Parameter type|  
|------------|--------------------|  
|**VTS_I2**|**short**|  
|**VTS_I4**|**long**|  
|**VTS_R4**|**float**|  
|**VTS_R8**|**double**|  
|**VTS_COLOR**|**OLE_COLOR**|  
|**VTS_CY**|**CURRENCY**|  
|**VTS_DATE**|**DATE**|  
|**VTS_BSTR**|**const char\***|  
|**VTS_DISPATCH**|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|**VTS_FONT**|**IFontDispatch\***|  
|**VTS_HANDLE**|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|**VTS_SCODE**|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|**VTS_BOOL**|**BOOL**|  
|**VTS_VARIANT**|**const VARIANT\***|  
|**VTS_PVARIANT**|**VARIANT\***|  
|**VTS_UNKNOWN**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|**VTS_OPTEXCLUSIVE**|**OLE_OPTEXCLUSIVE**|  
|**VTS_PICTURE**|**IPictureDisp\***|  
|**VTS_TRISTATE**|**OLE_TRISTATE**|  
|**VTS_XPOS_PIXELS**|**OLE_XPOS_PIXELS**|  
|**VTS_YPOS_PIXELS**|**OLE_YPOS_PIXELS**|  
|**VTS_XSIZE_PIXELS**|**OLE_XSIZE_PIXELS**|  
|**VTS_YSIZE_PIXELS**|**OLE_YSIZE_PIXELS**|  
|**VTS_XPOS_HIMETRIC**|**OLE_XPOS_HIMETRIC**|  
|**VTS_YPOS_HIMETRIC**|**OLE_YPOS_HIMETRIC**|  
|**VTS_XSIZE_HIMETRIC**|**OLE_XSIZE_HIMETRIC**|  
|**VTS_YSIZE_HIMETRIC**|**OLE_YSIZE_HIMETRIC**|  
  
> [!NOTE]
>  Additional variant constants have been defined for all variant types, with the exception of **VTS_FONT** and **VTS_PICTURE**, that provide a pointer to the variant data constant. These constants are named using the **VTS_P**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> convention. For example, **VTS_PCOLOR** is a pointer to a **VTS_COLOR** constant.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [EVENT_CUSTOM_ID](../vs140/event_custom_id.md)   
 [DECLARE_EVENT_MAP](../vs140/declare_event_map.md)   
 [Variant Parameter Type Constants](../vs140/variant-parameter-type-constants.md)