---
title: "KeyBinding Element"
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
  - "VSCT XML schema elements, KeyBindings"
  - "KeyBinding element (VSCT XML schema)"
ms.assetid: e55a1098-15df-42a9-9f87-e3a99cf437dd
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# KeyBinding Element
The KeyBinding element specifies keyboard shortcuts for the commands.  
  
 Commands can have both single and dual key bindings associated with them. An example of a single key binding is CTRL+S for the **Save** command. Dual key bindings require two successive key combinations to trigger a command. An example of a dual key binding is CTRL+K,CTRL+K to set a bookmark.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required.|  
|id|Required.|  
|editor|Required. The editor GUID indicates the editing context for which this keyboard shortcut will be active. The global binding scope value is "guidVSStd97".|  
|key1|Required. Valid values include all typable alphanumerics, and also two-digit hexadecimal values preceded by 0x and VK_constants.|  
|mod1|Optional. Any combination of CTRL, ALT, and SHIFT separated by space.|  
|key2|Optional. Valid values include all typable alphanumerics, and also two-digit hexadecimal values preceded by 0x and VK_constants.|  
|mod2|Optional. Any combination of CTRL, ALT, and SHIFT separated by space.|  
|emulator|Optional.|  
|Condition|Optional. See [Conditional Attributes](../vs140/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|Parent||  
|Annotation||  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[KeyBindings](../vs140/keybindings-element.md)|Groups KeyBinding elements and other KeyBindings groupings.|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [KeyBindings](../vs140/keybindings-element.md)   
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)