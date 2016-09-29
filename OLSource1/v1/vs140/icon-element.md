---
title: "Icon Element"
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
  - "VSCT XML schema elements, Icon"
  - "Icon element (VSCT XML schema)"
ms.assetid: 73c58fe3-d53c-4f4e-b025-29567c6cbb7c
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Icon Element
The guid attribute of the Icon tag is the guid of a defined bitmap.  The id attribute selects the slot in the bitmap strip. This element is optional.  If this element is omitted the value of **guidOfficeIcon:msotcidNoIcon** will be implied.  
  
## Syntax  
  
```  
<Icon guid="guidImages" id="bmpPic1" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The guid of a defined bitmap.|  
|id|Required. Selects the slot in the bitmap strip.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None.|None.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Buttons](../vs140/buttons-element.md)||  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)