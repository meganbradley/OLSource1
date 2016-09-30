---
title: "Extern Element"
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
  - "Extern"
helpviewer_keywords: 
  - "VSCT XML schema elements, Extern"
  - "Extern element (VSCT XML schema)"
ms.assetid: db6c3ddd-a1ba-450a-897a-bb568a5377fc
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extern Element
The Extern element references any external header (.h) files to merge with the .vsct file at compile time. The files to be merged must be on the Include path given to the VSCT compiler or referenced by an [Include element](../vs140/include-element.md). The files may be other .vsct files or C++ header files.  
  
 Definitions in header files must be of the form "#define [Symbol] [Value]"  The value may be another symbol if it is previously defined. Definitions may be used in conditional statements of command items. Any symbol not actually used will be discarded.  
  
 CommandTable Element  
Extern Element  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|href|Required. The path to the header file:\<br />\<br /> href="stdidcmd.h"|  
|Condition|Optional. See [Conditional Attributes](../vs140/vsct-xml-schema-conditional-attributes.md).|  
|language|Optional. The default language of all [\<Strings>](../vs140/strings-element.md) elements in the command table:\<br />\<br /> language="en-us"|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None.|None.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../vs140/commandtable-element.md)|Defines all of the elements that represent commands — that is, menu items, menus, toolbars, and combo boxes — that a VSPackage provides to the IDE.|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)   
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)