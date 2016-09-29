---
title: "Commands Element"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "Commands"
helpviewer_keywords: 
  - "Commands element (VSCT XML schema)"
  - "VSCT XML schema elements, Commands"
ms.assetid: 47cf16a5-d78b-452e-86f6-b5893856dddf
caps.latest.revision: 21
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Commands Element
Represents the collection of commands on the VSPackage toolbar. The collection can have up to five subsections, as follows: menus, groups, buttons, combos, and bitmaps.  
  
 Each subsection child element, for example, <Menu\>, is identified by a unique command ID that is a GUID and numeric identifier pair. The GUID identifies the "command set" and is used to group logically related commands. The VSPackage should define its own command set to avoid collisions with command IDs that are defined by other VSPackages.  
  
## Syntax  
  
```  
<Commands package="GuidMyPackage" >  
  <Menus>... </Menus>  
  <Groups>... </Groups>  
  <Buttons>... </Buttons>  
  <Combos>... </Combos>  
  <Bitmaps>... </Bitmaps>  
</Commands>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|package|A GUID that identifies the VSPackage that provides the commands.<br /><br /> For example, package="guidVsPackage1Pkg".|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Menus Element](../vs140/menus-element.md)|Defines all the menus that a VSPackage implements.|  
|[Groups Element](../vs140/groups-element.md)|Contains entries that define the command groups in a VSPackage.|  
|[Buttons Element](../vs140/buttons-element.md)|Groups Button elements.|  
|[Bitmaps Element](../vs140/bitmaps-element.md)|Groups Bitmap elements.|  
|[Combos Element](../vs140/combos-element.md)|Groups Combo elements.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../vs140/commandtable-element.md)|Defines all the elements that represent the commands that a VSPackage provides to the IDE. Possible elements are menu items, menus, toolbars, and combo boxes.|  
  
## Example  
 The following example shows how to use a [Commands Element](../vs140/commands-element.md).  
  
```  
<Commands package="guidMyPackage">  
    <Menus>  
      <Menu Condition="'%(DEBUG)' != 'true'"   
        guid="cmdSetGuidMyProductCommands" id="menuIDMainMenu"   
        priority="0x0000" type="Menu">  
        <Annotation>  
          <Documentation>this is an annotation</Documentation>  
          <AppInfo>  
            <CustomData>  
              <CustomSubElement>Some data</CustomSubElement>  
            </CustomData>  
          </AppInfo>  
        </Annotation>  
        <CommandFlag>AlwaysCreate</CommandFlag>  
        <Strings>  
          <ButtonText>MainMenu</ButtonText>  
        </Strings>  
      </Menu>  
  </Menus>  
<Commands>  
```  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)