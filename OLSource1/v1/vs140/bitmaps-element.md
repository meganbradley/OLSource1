---
title: "Bitmaps Element"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSCT XML schema elements, Bitmaps"
  - "Bitmaps element (VSCT XML schema)"
ms.assetid: 74652e1b-fcfa-421b-aa9f-fbc081d3b476
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Bitmaps Element
Groups [Bitmap](../vs140/bitmap-element.md) elements.  
  
## Syntax  
  
```  
<Bitmaps>  
  <Bitmap>... </Bitmap>  
  <Bitmap>... </Bitmap>  
</Bitmaps>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Optional. See [Conditional Attributes](../vs140/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Bitmaps Element](../vs140/bitmaps-element.md)|Groups Bitmap elements.|  
|[Bitmap Element](../vs140/bitmap-element.md)|Defines a bitmap.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Commands](../vs140/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|  
  
## Example  
  
```  
<Bitmaps>  
  <Bitmap guid="guidWidgetIcons" href="WidgetToolbarIcons_32.bmp" />  
  <Bitmap guid="guidWidgetIcons2" resID="IDBMP_WIDGETICONS"  
    usedList="1, 2, 3, 4"/>  
</Bitmaps>  
```  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)