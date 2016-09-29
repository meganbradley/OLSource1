---
title: "UsedCommands Element"
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
  - "UsedCommands"
helpviewer_keywords: 
  - "UsedCommands element (VSCT XML schema)"
  - "VSCT XML schema elements, UsedCommands"
ms.assetid: 5e000ee0-a919-46e9-9277-2a0659f1eb78
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# UsedCommands Element
The UsedCommands element groups UsedCommand elements and other UsedCommands groupings.  
  
 The UsedCommands element is optional. If you do not call commands defined outside your package, you do not have to include this section in your .vsct file.  
  
## Syntax  
  
```  
<UsedCommands condition="Defined(DEBUG)">  
  <UsedCommand ... />  
</UsedCommands>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|Condition|Optional. See [Conditional Attributes](../VS_csharp/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[UsedCommand](../VS_csharp/usedcommand-element.md)|The command that is implemented by other code.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[CommandTable Element](../VS_csharp/commandtable-element.md)|Defines all the elements that represent commands (for example, menu items, menus, toolbars, and combo boxes) that a VSPackage provides to the integrated development environment (IDE).|  
  
## Example  
  
```  
<UsedCommands>  
  <UsedCommand guid="guidVSStd97" id="cmdidCut"/>  
  <UsedCommand guid="guidVSStd97" id="cmdidCopy"/>  
  <UsedCommand guid="guidVSStd97" id="cmdidPaste"/>  
</UsedCommands>  
```  
  
## See Also  
 [UsedCommand](../VS_csharp/usedcommand-element.md)   
 [XML-Based Command Table Configuration (.vsct) Files](../VS_csharp/visual-studio-command-table--.vsct--files.md)