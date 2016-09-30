---
title: "CommandPlacement Element"
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
  - "CommandPlacements element (VSCT XML schema)"
  - "VSCT XML schema elements, CommandPlacements"
ms.assetid: 2cbd7ac8-c55a-43d8-a26d-713b3d790016
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CommandPlacement Element
The CommandPlacement element enables buttons, groups, and menus to be included in more than one group or menu. By using the CommandPlacement element, you do not have to completely redefine these items in order to modify the look of a user interface.  
  
 For more information, see [How to: Create Reusable Groups of Buttons](../vs140/creating-reusable-groups-of-buttons.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The guid of the command set, as defined in the [Symbols Element](../vs140/symbols-element.md).|  
|id|Required. The id of the menu, group, or command to be placed, as defined in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
|priority|Required. Determines the visual position of the item in its parent element.|  
|Condition|Optional. See [Conditional Attributes](../vs140/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Parent|Required. The menu or group that hosts the item to be placed.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandPlacements](../vs140/commandplacements-element.md)|Specifies groups of CommandPlacements and CommandPlacement elements.|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [CommandPlacements Element](../vs140/commandplacements-element.md)   
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)