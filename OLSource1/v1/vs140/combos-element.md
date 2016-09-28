---
title: "Combos Element"
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
  - "Combos element (VSCT XML schema)"
  - "VSCT XML schema elements, Combos"
ms.assetid: ef48d2d2-0c47-4f93-8cfe-52026b6c463e
caps.latest.revision: 10
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Combos Element
Groups [Combo](../vs140/combo-element.md) elements.  
  
## Syntax  
  
```  
<Combos>  
  <Combo>... </Combo>  
  <Combo>... </Combo>  
</Combos>  
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
|[Combos Element](../vs140/combos-element.md)|Groups Combo elements.|  
|[Combo Elements](../vs140/combo-element.md)|Defines the commands that appear in a combo box.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Commands](../vs140/commands-element.md)|Represents the collection of commands on the VSPackage toolbar.|  
  
## Example  
  
```  
<Combos>  
  <Combo guid="guidWidgetPackage" id="cmdidInsertOptions"  
    defaultWidth="100" idCommandList="cmdidGetInsertOptionsList">  
    <CommandFlag>DynamicVisibility</CommandFlag>  
    <Strings>  
      <ButtonText>Select Insert Options</ButtonText>  
    </Strings>  
  </Combo>  
  
  <Combo guid="guidWidgetPackage" id="cmdidInsertOptions"  
    priority="0x0500" type="DropDownCombo" defaultWidth="100"  
    idCommandList="cmdidGetInsertOptionsList">  
    <Parent guid="cmdSetGuidWidgetCommands" id="groupIDFileEdit">  
    <CommandFlag>DynamicVisibility</CommandFlag>  
    <Strings>  
      <ButtonText>Select Insert Options</ButtonText>  
    </Strings>  
  </Combo>  
</Combos>  
```  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)