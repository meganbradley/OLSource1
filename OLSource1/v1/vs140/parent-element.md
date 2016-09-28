---
title: "Parent Element"
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
  - "VSCT XML schema elements, Parent"
  - "Parent element (VSCT XML schema)"
ms.assetid: e4624ac8-1b9a-4940-910a-528a661cefad
caps.latest.revision: 12
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Parent Element
The parent of a button or combo box may only be a group. The parent of a menu or group may be any other menu or group. In a [CommandPlacement](../vs140/commandplacement-element.md), this element is required; in all other instances it is optional. If this element is omitted, the parent of `Group_Undefined:0` will be implied.  
  
## Syntax  
  
```  
<Parent guid="guidMyCommandSet" id="MyParentGroupOrMenu" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. GUID of GUID/ID command identifier.|  
|id|Required. ID of GUID/ID command identifier.|  
  
### Child Elements  
 None  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../vs140/commandtable-element.md)|Defines all the elements that represent commands that a VSPackage provides to the integrated development environment (IDE). For example, menu items, menus, toolbars, and combo boxes.|  
|[Buttons](../vs140/buttons-element.md)|Groups [Button](../vs140/button-element.md) elements.|  
|[Menus](../vs140/menus-element.md)|Defines all the menus that a VSPackage implements.|  
|[Groups](../vs140/groups-element.md)|Contains entries that define the command groups of a VSPackage.|  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)